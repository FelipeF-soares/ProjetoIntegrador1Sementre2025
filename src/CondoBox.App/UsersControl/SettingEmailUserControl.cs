using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CondoBox.Applications.Validator.SettingEmailValid.Interface;
using CondoBox.Applications.Persist.Interface;

namespace CondoBox.App.UsersControl;

public partial class SettingEmailUserControl : UserControl
{
    private readonly ISettingEmailValid emailValid;
    private readonly ISettingEmailPersist emailPersist;

    public SettingEmailUserControl(ISettingEmailValid emailValid, ISettingEmailPersist emailPersist)
    {
        InitializeComponent();
        this.emailValid = emailValid;
        this.emailPersist = emailPersist;
    }

    private void buttonRegister_Click(object sender, EventArgs e)
    {
        try
        {
            var settingEmailValid = emailValid.IsValid
                                               (
                                                   textBoxEmailSender.Text,
                                                   textBoxPassword.Text,
                                                   textBoxSmtpClient.Text,
                                                   maskedTextBoxEmailPort.Text,
                                                   textBoxEmailCC.Text,
                                                   textBoxSubject.Text,
                                                   richTextBoxEmailBody.Text
                                                );
            emailPersist.SalveSettingEmail(settingEmailValid);
            MessageBox.Show("Cadastrado Realizado com Sucesso!", "SUCESSO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Parent.Controls.Remove(this);
        }
        catch(Exception ex)
        {
            MessageBox.Show(ex.Message, "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
