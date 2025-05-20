using CondoBox.App.Utils.PicturePath;
using CondoBox.Applications.Persist.Interface;
using CondoBox.Applications.Validator.EmployeeValid.Interface;

namespace CondoBox.App.UsersControl;

public partial class AddEmployeeUserControl : UserControl
{
    private readonly IEmployeePersist persist;
    private readonly IEmployeeValid employeeValid;
    string imagePath = string.Empty;

    public AddEmployeeUserControl(IEmployeePersist persist, IEmployeeValid employeeValid)
    {
        InitializeComponent();
        this.persist = persist;
        this.employeeValid = employeeValid;
    }
    private void buttonEmployeeImage_Click(object sender, EventArgs e)
    {
        imagePath = SelectImage.Now();
        if (!string.IsNullOrEmpty(imagePath))
        {
            pictureBoxEmployee.Image = Image.FromFile(imagePath);
            pictureBoxEmployee.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }

    private void buttonSend_Click(object sender, EventArgs e)
    {
        try
        {
            string fullName = textBoxName.Text;
            string cpf = maskedTextBoxCPF.Text;
            string role = comboBoxRole.Text;
            string cellphone = maskedTextBoxCellPhone.Text;
            if(string.IsNullOrEmpty(imagePath)) imagePath = "default";
            string password = textBoxPassword.Text;
            string confirmPassword = textBoxConfirmPassword.Text;

            var employee = employeeValid.Valid(fullName, cpf, role, cellphone, password, confirmPassword, imagePath);
            if (employee != null)
            {
                try
                {
                    persist.AddEmployeeAsync(employee);
                    MessageBox.Show("Colaborador cadastrado com Sucesso!", "SUCESSO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Parent.Controls.Remove(this);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("Erro ao cadastras o colaborador! Tente novamente!", "ERROR!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearFields();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }

    private void ClearFields()
    {
        textBoxName.Clear();
        maskedTextBoxCPF.Clear();
        comboBoxRole.Items.Clear();
        maskedTextBoxCPF.Clear();
        textBoxPassword.Clear();
        textBoxConfirmPassword.Clear();
    }
}
