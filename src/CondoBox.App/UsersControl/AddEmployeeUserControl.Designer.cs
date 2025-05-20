namespace CondoBox.App.UsersControl
{
    partial class AddEmployeeUserControl
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox = new GroupBox();
            maskedTextBoxCellPhone = new MaskedTextBox();
            maskedTextBoxCPF = new MaskedTextBox();
            labelInformationPassword = new Label();
            buttonSend = new Button();
            textBoxConfirmPassword = new TextBox();
            labelValidPassword = new Label();
            textBoxPassword = new TextBox();
            labelPassWord = new Label();
            groupBoxImage = new GroupBox();
            pictureBoxEmployee = new PictureBox();
            buttonEmployeeImage = new Button();
            labelCellPhone = new Label();
            comboBoxRole = new ComboBox();
            labelRole = new Label();
            labelCpf = new Label();
            textBoxName = new TextBox();
            labelName = new Label();
            groupBox.SuspendLayout();
            groupBoxImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEmployee).BeginInit();
            SuspendLayout();
            // 
            // groupBox
            // 
            groupBox.Controls.Add(maskedTextBoxCellPhone);
            groupBox.Controls.Add(maskedTextBoxCPF);
            groupBox.Controls.Add(labelInformationPassword);
            groupBox.Controls.Add(buttonSend);
            groupBox.Controls.Add(textBoxConfirmPassword);
            groupBox.Controls.Add(labelValidPassword);
            groupBox.Controls.Add(textBoxPassword);
            groupBox.Controls.Add(labelPassWord);
            groupBox.Controls.Add(groupBoxImage);
            groupBox.Controls.Add(buttonEmployeeImage);
            groupBox.Controls.Add(labelCellPhone);
            groupBox.Controls.Add(comboBoxRole);
            groupBox.Controls.Add(labelRole);
            groupBox.Controls.Add(labelCpf);
            groupBox.Controls.Add(textBoxName);
            groupBox.Controls.Add(labelName);
            groupBox.Dock = DockStyle.Fill;
            groupBox.Location = new Point(0, 0);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(550, 550);
            groupBox.TabIndex = 0;
            groupBox.TabStop = false;
            groupBox.Text = "Cadastrar Colaborador";
            // 
            // maskedTextBoxCellPhone
            // 
            maskedTextBoxCellPhone.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            maskedTextBoxCellPhone.Location = new Point(420, 292);
            maskedTextBoxCellPhone.Mask = "(99) 90000-0000";
            maskedTextBoxCellPhone.Name = "maskedTextBoxCellPhone";
            maskedTextBoxCellPhone.Size = new Size(113, 27);
            maskedTextBoxCellPhone.TabIndex = 17;
            // 
            // maskedTextBoxCPF
            // 
            maskedTextBoxCPF.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            maskedTextBoxCPF.Location = new Point(55, 290);
            maskedTextBoxCPF.Mask = "000,000,000-00";
            maskedTextBoxCPF.Name = "maskedTextBoxCPF";
            maskedTextBoxCPF.Size = new Size(109, 27);
            maskedTextBoxCPF.TabIndex = 16;
            // 
            // labelInformationPassword
            // 
            labelInformationPassword.AutoSize = true;
            labelInformationPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelInformationPassword.ForeColor = Color.Black;
            labelInformationPassword.Location = new Point(110, 344);
            labelInformationPassword.Name = "labelInformationPassword";
            labelInformationPassword.Size = new Size(354, 75);
            labelInformationPassword.TabIndex = 15;
            labelInformationPassword.Text = "A senha deve ter no mínimo 6 caracteres e conter pelo menos:\r\n1 letra maiúscula,\r\n1 letra minúscula,\r\n1 número e \r\n1 caractere especial.";
            // 
            // buttonSend
            // 
            buttonSend.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSend.Location = new Point(219, 466);
            buttonSend.Name = "buttonSend";
            buttonSend.Size = new Size(147, 45);
            buttonSend.TabIndex = 14;
            buttonSend.Text = "Registrar";
            buttonSend.UseVisualStyleBackColor = true;
            buttonSend.Click += buttonSend_Click;
            // 
            // textBoxConfirmPassword
            // 
            textBoxConfirmPassword.Location = new Point(355, 430);
            textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            textBoxConfirmPassword.Size = new Size(121, 23);
            textBoxConfirmPassword.TabIndex = 13;
            textBoxConfirmPassword.UseSystemPasswordChar = true;
            // 
            // labelValidPassword
            // 
            labelValidPassword.AutoSize = true;
            labelValidPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelValidPassword.Location = new Point(247, 433);
            labelValidPassword.Name = "labelValidPassword";
            labelValidPassword.Size = new Size(106, 15);
            labelValidPassword.TabIndex = 12;
            labelValidPassword.Text = "Confirmar Senha: ";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(103, 430);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(121, 23);
            textBoxPassword.TabIndex = 11;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // labelPassWord
            // 
            labelPassWord.AutoSize = true;
            labelPassWord.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPassWord.Location = new Point(41, 433);
            labelPassWord.Name = "labelPassWord";
            labelPassWord.Size = new Size(47, 15);
            labelPassWord.TabIndex = 10;
            labelPassWord.Text = "Senha: ";
            // 
            // groupBoxImage
            // 
            groupBoxImage.Controls.Add(pictureBoxEmployee);
            groupBoxImage.Location = new Point(189, 22);
            groupBoxImage.Name = "groupBoxImage";
            groupBoxImage.Size = new Size(203, 157);
            groupBoxImage.TabIndex = 9;
            groupBoxImage.TabStop = false;
            // 
            // pictureBoxEmployee
            // 
            pictureBoxEmployee.Location = new Point(33, 15);
            pictureBoxEmployee.Name = "pictureBoxEmployee";
            pictureBoxEmployee.Size = new Size(144, 136);
            pictureBoxEmployee.TabIndex = 0;
            pictureBoxEmployee.TabStop = false;
            // 
            // buttonEmployeeImage
            // 
            buttonEmployeeImage.Location = new Point(219, 198);
            buttonEmployeeImage.Name = "buttonEmployeeImage";
            buttonEmployeeImage.Size = new Size(147, 23);
            buttonEmployeeImage.TabIndex = 8;
            buttonEmployeeImage.Text = "Selecione uma imagem";
            buttonEmployeeImage.UseVisualStyleBackColor = true;
            buttonEmployeeImage.Click += buttonEmployeeImage_Click;
            // 
            // labelCellPhone
            // 
            labelCellPhone.AutoSize = true;
            labelCellPhone.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelCellPhone.Location = new Point(420, 269);
            labelCellPhone.Name = "labelCellPhone";
            labelCellPhone.Size = new Size(57, 15);
            labelCellPhone.TabIndex = 6;
            labelCellPhone.Text = "Contato: ";
            // 
            // comboBoxRole
            // 
            comboBoxRole.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRole.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.Items.AddRange(new object[] { "Admin", "Porteiro" });
            comboBoxRole.Location = new Point(210, 292);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(121, 25);
            comboBoxRole.TabIndex = 5;
            // 
            // labelRole
            // 
            labelRole.AutoSize = true;
            labelRole.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelRole.Location = new Point(210, 269);
            labelRole.Name = "labelRole";
            labelRole.Size = new Size(52, 15);
            labelRole.TabIndex = 4;
            labelRole.Text = "Função: ";
            // 
            // labelCpf
            // 
            labelCpf.AutoSize = true;
            labelCpf.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelCpf.Location = new Point(55, 269);
            labelCpf.Name = "labelCpf";
            labelCpf.Size = new Size(33, 15);
            labelCpf.TabIndex = 2;
            labelCpf.Text = "CPF: ";
            // 
            // textBoxName
            // 
            textBoxName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxName.Location = new Point(6, 239);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(527, 27);
            textBoxName.TabIndex = 1;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelName.Location = new Point(6, 221);
            labelName.Name = "labelName";
            labelName.Size = new Size(104, 15);
            labelName.TabIndex = 0;
            labelName.Text = "Nome Completo: ";
            // 
            // AddEmployeeUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox);
            Name = "AddEmployeeUserControl";
            Size = new Size(550, 550);
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            groupBoxImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxEmployee).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox;
        private Label labelName;
        private TextBox textBoxName;
        private Label labelCpf;
        private ComboBox comboBoxRole;
        private Label labelRole;
        private Label labelCellPhone;
        private Button buttonEmployeeImage;
        private GroupBox groupBoxImage;
        private TextBox textBoxConfirmPassword;
        private Label labelValidPassword;
        private TextBox textBoxPassword;
        private Label labelPassWord;
        private Button buttonSend;
        private Label labelInformationPassword;
        private PictureBox pictureBoxEmployee;
        private MaskedTextBox maskedTextBoxCPF;
        private MaskedTextBox maskedTextBoxCellPhone;
    }
}
