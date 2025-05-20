using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CondoBox.Applications.Persist.Interface;
using CondoBox.Domain;
using CondoBox.Infrastructure.EmailService;

namespace CondoBox.App.UsersControl;

public partial class AddMailUserControl : UserControl
{
    private readonly IUnitPersist unitPersist;
    private readonly Employee globalEmployee;
    private readonly IMailPersist mailPersist;
    private readonly ISettingEmailPersist settingEmailPersist;
    private Unit selectedUnit;

    public AddMailUserControl(IUnitPersist unitPersist, Employee globalEmployee, IMailPersist mailPersist, ISettingEmailPersist settingEmailPersist)
    {
        InitializeComponent();
        this.unitPersist = unitPersist;
        this.globalEmployee = globalEmployee;
        this.mailPersist = mailPersist;
        this.settingEmailPersist = settingEmailPersist;
        ChangerUnits();

        comboBoxAmount.SelectedValueChanged += (s, e) => ChangedComboBox();
        comboBoxListUnits.SelectedValueChanged += (s, e) => ChangedComboBox();

    }
    private void buttonSelect_Click(object sender, EventArgs e)
    {
        selectedUnit = (Unit)comboBoxListUnits.SelectedItem;
        labelDescription.Text = selectedUnit.Description;
        labelAmountDescription.Text = comboBoxAmount.Text;
    }
    private void buttonRegister_Click(object sender, EventArgs e)
    {
        try
        {
            EmailService emailService = new EmailService();
            Mail mail = new Mail();
            mail.UnitId = selectedUnit.Id;
            mail.DateTimeRegister = DateTime.Now;
            mail.Amount = int.Parse(comboBoxAmount.Text);
            mail.CpfEmployee = globalEmployee.Cpf;
            mail.NameEmployee = globalEmployee.Name;

            var unit = unitPersist.GetUnityById(selectedUnit.Id).Result;
            var setting = settingEmailPersist.GetEmail();
            var emailWasSend = emailService.SendEmail(unit.Residents.ToList(), setting);
            if (emailWasSend)
            {
                mailPersist.AddMailAsync(mail);
                MessageBox.Show("Unidade foi notificada por email", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                mailPersist.AddMailAsync(mail);
                MessageBox.Show("Não foi possível notificar a unidade entre em contato para avisar a chegada da encomenda!!!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            

        }
        catch(Exception ex)
        {
            MessageBox.Show(ex.Message, "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    private void ChangedComboBox()
    {
        var buttonEnable = !string.IsNullOrWhiteSpace(comboBoxAmount.Text) &&
                           !string.IsNullOrWhiteSpace(comboBoxListUnits.Text);

        buttonRegister.Enabled = buttonEnable;
        buttonSelect.Enabled = buttonEnable;
    }
    private void ChangerUnits()
    {
        comboBoxListUnits.DataSource = unitPersist.GetAllUnityAsync().Result.ToArray();
        comboBoxListUnits.DisplayMember = "Description";
        comboBoxListUnits.ValueMember = "Id";
    }
}
