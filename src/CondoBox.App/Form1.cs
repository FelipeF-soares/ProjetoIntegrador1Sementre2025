using CondoBox.App.TabPages;
using CondoBox.App.UsersControl;
using CondoBox.Applications.Persist.Interface;
using CondoBox.Applications.Validator.EmployeeValid.Interface;
using CondoBox.Applications.Validator.Placeholder;
using CondoBox.Applications.Validator.ResidentValid;
using CondoBox.Applications.Validator.ResidentValid.Interface;
using CondoBox.Applications.Validator.SettingEmailValid.Interface;
using CondoBox.Domain;
using CondoBox.Infrastructure.EmailService;
using CondoBox.Infrastructure.Repository.Interfaces;

namespace CondoBox.App;

public partial class Form1 : Form
{
    private readonly IEmployeePersist persist;
    private readonly IEmployeeValid valid;
    private readonly IUnitPersist unitPersist;
    private readonly IResidentPersist residentPersist;
    private readonly IResidentValid residentValid;
    private readonly IMailPersist mailPersist;
    private readonly ISettingEmailPersist emailPersist;
    private readonly ISettingEmailValid settingEmailValid;
    private Employee globalEmployee;

    public Form1
    (
        IEmployeePersist persist,
        IEmployeeValid valid,
        IUnitPersist unitPersist,
        IResidentPersist residentPersist,
        IResidentValid residentValid,
        IMailPersist mailPersist,
        ISettingEmailPersist emailPersist,
        ISettingEmailValid settingEmailValid
    )
    {

        InitializeComponent();
        string filePath = Application.StartupPath;
        string v = AppDomain.CurrentDomain.BaseDirectory;
        this.persist = persist;
        this.valid = valid;
        this.unitPersist = unitPersist;
        this.residentPersist = residentPersist;
        this.residentValid = residentValid;
        this.mailPersist = mailPersist;
        this.emailPersist = emailPersist;
        this.settingEmailValid = settingEmailValid;
        checkedEmployee();
        GenerateKey.GeneratorAndSaveKeys();
        
    }

    private void ButtonAddMail_EnabledChanged(object? sender, EventArgs e)
    {
        throw new NotImplementedException();
    }

    private void loginToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var login = new LoginUserControl(persist);
        var dynamicTabPage = new DynamicTabPage();
        dynamicTabPage.Add("Login", login, tabControl);
        login.UserEmployee += OnEmployeeSelected;
    }
    private void cadastroNovoToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var userControlEmployee = new AddEmployeeUserControl(persist, valid);
        var dynamicTabPage = new DynamicTabPage();
        dynamicTabPage.Add("AddEmployee", userControlEmployee, tabControl);
    }
    private void cadastrarMoradorToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var userControlResident = new AddResidentUserControl(unitPersist, residentValid, residentPersist);
        var dynamicTabPage = new DynamicTabPage();
        dynamicTabPage.Add("AddResident", userControlResident, tabControl);
    }
    private void buttonAddMail_Click(object sender, EventArgs e)
    {
        var userControlAddMail = new AddMailUserControl(unitPersist, globalEmployee, mailPersist, emailPersist);
        var dynamicTabPage = new DynamicTabPage();
        dynamicTabPage.Add("AddMail", userControlAddMail, tabControl);
    }
    private void emailToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var userControlSettingEmail = new SettingEmailUserControl(settingEmailValid,emailPersist);
        var dynamicTabPage = new DynamicTabPage();
        dynamicTabPage.Add("SettingEmail", userControlSettingEmail, tabControl);
    }

    private async Task checkedEmployee()
    {
        try
        {
            var employee = await persist.GetAllEmployeeAsync();
            if (!employee.Any())
            {
                cadastroNovoToolStripMenuItem.Enabled = true;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    private void OnEmployeeSelected(object sender, Employee employee)
    {
        globalEmployee = employee;
        labelCPFNumber.Text = CPFMask.Add(employee.Cpf);
        labelRole.Text = employee.Role;
        labelCellphone.Text = CellPhoneMask.Add(employee.CellPhone);
        string path = employee.ImagePath;
        if (path.Equals("default"))
        {

           string pathDefault = Path.Combine(Application.StartupPath, "Pictures\\Employee\\LogoAltos.jpg");
           pictureBoxImage.Image = Image.FromFile(pathDefault);
           pictureBoxImage.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        else
        {
            pictureBoxImage.Image = Image.FromFile(employee.ImagePath);
            pictureBoxImage.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        if (employee.Role == "ADMIN")
        {
            cadastroNovoToolStripMenuItem.Enabled = true;
            cadastrarMoradorToolStripMenuItem.Enabled = true;
            buttonAddMail.Enabled = true;
            configuraçõesToolStripMenuItem.Enabled = true;
        }
    }

    
}
