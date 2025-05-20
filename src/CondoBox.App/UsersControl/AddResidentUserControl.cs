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
using CondoBox.Applications.Validator.ResidentValid.Interface;

namespace CondoBox.App.UsersControl;

public partial class AddResidentUserControl : UserControl
{
    private readonly IUnitPersist unitPersist;
    private readonly IResidentValid valid;
    private readonly IResidentPersist residentPersist;
    private int id;

    public AddResidentUserControl(IUnitPersist unitPersist, IResidentValid valid, IResidentPersist residentPersist)
    {
        InitializeComponent();
        this.unitPersist = unitPersist;
        this.valid = valid;
        this.residentPersist = residentPersist;
        ChangerUnits();

        textBoxFullName.TextChanged += (s, e) => CheckedFields();
        textBoxCPF.TextChanged += (s, e) => CheckedFields();
        textBoxCellPhone.TextChanged += (s, e) => CheckedFields();
        textBoxEmail.TextChanged += (s, e) => CheckedFields();
    }

    private void buttonSelectUnit_Click(object sender, EventArgs e)
    {
        Unit selectedUnit = (Unit)comboBoxListUnits.SelectedItem;
        labelResultBuilding.Text = selectedUnit.Building;
        labelResultApt.Text = selectedUnit.Apt;
        id = selectedUnit.Id;
    }
    private void buttonRegister_Click(object sender, EventArgs e)
    {
        try
        {
            var resident = valid.IsValid(
                                    textBoxFullName.Text,
                                    textBoxCPF.Text,
                                    textBoxEmail.Text,
                                    textBoxCellPhone.Text,
                                    id);
            residentPersist.AddResisdentAsync(resident);
            MessageBox.Show("Morador cadastrado com Sucesso!", "SUCESSO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Parent.Controls.Remove(this);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    private void ChangerUnits()
    {
        comboBoxListUnits.DataSource = unitPersist.GetAllUnityAsync().Result.ToArray();
        comboBoxListUnits.DisplayMember = "Description";
        comboBoxListUnits.ValueMember = "Id";
    }
    private void CheckedFields()
    {
        bool fieldsCheck = !string.IsNullOrWhiteSpace(textBoxFullName.Text) &&
                           !string.IsNullOrWhiteSpace(textBoxCPF.Text) &&
                           !string.IsNullOrWhiteSpace(textBoxCellPhone.Text) &&
                           !string.IsNullOrWhiteSpace(textBoxEmail.Text) &&
                           (id != 0);

        buttonRegister.Enabled = fieldsCheck;
    }

    
}
