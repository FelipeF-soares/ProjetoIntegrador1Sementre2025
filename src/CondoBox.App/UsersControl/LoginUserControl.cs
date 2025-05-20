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
using CondoBox.Applications.Validator.EmployeeValid.Interface;
using CondoBox.Applications.Login;
using CondoBox.Domain;

namespace CondoBox.App;

public partial class LoginUserControl : UserControl
{
    public event EventHandler<Employee> UserEmployee;

    private readonly IEmployeePersist persist;
    

    public LoginUserControl(IEmployeePersist persist)
    {
        InitializeComponent();
        this.persist = persist;
    }

    private void buttonLogin_Click(object sender, EventArgs e)
    {
        try
        {
            string cpf = textBoxCPF.Text;
            string password = textBoxPassword.Text;

            LoginValid.CheckValided(cpf, password);
            var validLogin = new LoginService();
            var employee = validLogin.EmployeeResult(cpf, persist);
            if (validLogin.Authenticate(cpf, password, employee))
            {
                MessageBox.Show("Usuário Atenticado com Sucesso", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UserEmployee?.Invoke(this, employee);
                this.Parent.Controls.Remove(this);
            }
            else
            {
               MessageBox.Show("Falha no login Tente novamente", "FALHA", MessageBoxButtons.OK, MessageBoxIcon.Error);
               ClearFields();
            }
        }
        catch(Exception ex)
        {
            MessageBox.Show(ex.Message, "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private void ClearFields()
    {
        textBoxCPF.Clear();
        textBoxPassword.Clear();
    }
    
}
