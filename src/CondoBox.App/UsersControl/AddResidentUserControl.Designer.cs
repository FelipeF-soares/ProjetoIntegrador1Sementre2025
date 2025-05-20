namespace CondoBox.App.UsersControl
{
    partial class AddResidentUserControl
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
            groupBoxDateResident = new GroupBox();
            buttonRegister = new Button();
            textBoxCellPhone = new TextBox();
            labelCellPhone = new Label();
            textBoxEmail = new TextBox();
            labelEmail = new Label();
            textBoxCPF = new TextBox();
            labelCPF = new Label();
            textBoxFullName = new TextBox();
            labelFullName = new Label();
            labelResultApt = new Label();
            labelResultBuilding = new Label();
            labelApt = new Label();
            buttonSelectUnit = new Button();
            comboBoxListUnits = new ComboBox();
            groupBox.SuspendLayout();
            groupBoxDateResident.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox
            // 
            groupBox.Controls.Add(groupBoxDateResident);
            groupBox.Controls.Add(labelResultApt);
            groupBox.Controls.Add(labelResultBuilding);
            groupBox.Controls.Add(labelApt);
            groupBox.Controls.Add(buttonSelectUnit);
            groupBox.Controls.Add(comboBoxListUnits);
            groupBox.Dock = DockStyle.Fill;
            groupBox.Location = new Point(0, 0);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(550, 550);
            groupBox.TabIndex = 0;
            groupBox.TabStop = false;
            groupBox.Text = "Cadastro de Morador";
            // 
            // groupBoxDateResident
            // 
            groupBoxDateResident.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            groupBoxDateResident.Controls.Add(buttonRegister);
            groupBoxDateResident.Controls.Add(textBoxCellPhone);
            groupBoxDateResident.Controls.Add(labelCellPhone);
            groupBoxDateResident.Controls.Add(textBoxEmail);
            groupBoxDateResident.Controls.Add(labelEmail);
            groupBoxDateResident.Controls.Add(textBoxCPF);
            groupBoxDateResident.Controls.Add(labelCPF);
            groupBoxDateResident.Controls.Add(textBoxFullName);
            groupBoxDateResident.Controls.Add(labelFullName);
            groupBoxDateResident.Location = new Point(6, 175);
            groupBoxDateResident.Name = "groupBoxDateResident";
            groupBoxDateResident.Size = new Size(532, 363);
            groupBoxDateResident.TabIndex = 6;
            groupBoxDateResident.TabStop = false;
            groupBoxDateResident.Text = "Dados do Morador";
            // 
            // buttonRegister
            // 
            buttonRegister.Enabled = false;
            buttonRegister.Location = new Point(181, 272);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(173, 23);
            buttonRegister.TabIndex = 8;
            buttonRegister.Text = "Registrar";
            buttonRegister.UseVisualStyleBackColor = true;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // textBoxCellPhone
            // 
            textBoxCellPhone.Location = new Point(342, 128);
            textBoxCellPhone.Name = "textBoxCellPhone";
            textBoxCellPhone.Size = new Size(184, 23);
            textBoxCellPhone.TabIndex = 7;
            // 
            // labelCellPhone
            // 
            labelCellPhone.AutoSize = true;
            labelCellPhone.Location = new Point(290, 132);
            labelCellPhone.Name = "labelCellPhone";
            labelCellPhone.Size = new Size(47, 15);
            labelCellPhone.TabIndex = 6;
            labelCellPhone.Text = "Celular:";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(59, 191);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(295, 23);
            textBoxEmail.TabIndex = 5;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(7, 195);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(44, 15);
            labelEmail.TabIndex = 4;
            labelEmail.Text = "E-mail:";
            // 
            // textBoxCPF
            // 
            textBoxCPF.Location = new Point(46, 131);
            textBoxCPF.Name = "textBoxCPF";
            textBoxCPF.Size = new Size(197, 23);
            textBoxCPF.TabIndex = 3;
            // 
            // labelCPF
            // 
            labelCPF.AutoSize = true;
            labelCPF.Location = new Point(6, 136);
            labelCPF.Name = "labelCPF";
            labelCPF.Size = new Size(34, 15);
            labelCPF.TabIndex = 2;
            labelCPF.Text = "CPF: ";
            // 
            // textBoxFullName
            // 
            textBoxFullName.Location = new Point(111, 74);
            textBoxFullName.Name = "textBoxFullName";
            textBoxFullName.Size = new Size(415, 23);
            textBoxFullName.TabIndex = 1;
            // 
            // labelFullName
            // 
            labelFullName.AutoSize = true;
            labelFullName.Location = new Point(6, 77);
            labelFullName.Name = "labelFullName";
            labelFullName.Size = new Size(99, 15);
            labelFullName.TabIndex = 0;
            labelFullName.Text = "Nome Completo:";
            // 
            // labelResultApt
            // 
            labelResultApt.AutoSize = true;
            labelResultApt.Location = new Point(312, 133);
            labelResultApt.Name = "labelResultApt";
            labelResultApt.Size = new Size(16, 15);
            labelResultApt.TabIndex = 5;
            labelResultApt.Text = "...";
            // 
            // labelResultBuilding
            // 
            labelResultBuilding.AutoSize = true;
            labelResultBuilding.Location = new Point(244, 103);
            labelResultBuilding.Name = "labelResultBuilding";
            labelResultBuilding.Size = new Size(16, 15);
            labelResultBuilding.TabIndex = 4;
            labelResultBuilding.Text = "...";
            // 
            // labelApt
            // 
            labelApt.AutoSize = true;
            labelApt.Location = new Point(223, 133);
            labelApt.Name = "labelApt";
            labelApt.Size = new Size(83, 15);
            labelApt.TabIndex = 3;
            labelApt.Text = "Apartamento: ";
            // 
            // buttonSelectUnit
            // 
            buttonSelectUnit.Location = new Point(244, 62);
            buttonSelectUnit.Name = "buttonSelectUnit";
            buttonSelectUnit.Size = new Size(75, 23);
            buttonSelectUnit.TabIndex = 1;
            buttonSelectUnit.Text = "Adicionar";
            buttonSelectUnit.UseVisualStyleBackColor = true;
            buttonSelectUnit.Click += buttonSelectUnit_Click;
            // 
            // comboBoxListUnits
            // 
            comboBoxListUnits.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxListUnits.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxListUnits.FormattingEnabled = true;
            comboBoxListUnits.Location = new Point(187, 22);
            comboBoxListUnits.Name = "comboBoxListUnits";
            comboBoxListUnits.Size = new Size(184, 29);
            comboBoxListUnits.TabIndex = 0;
            // 
            // AddResidentUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox);
            Name = "AddResidentUserControl";
            Size = new Size(550, 550);
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            groupBoxDateResident.ResumeLayout(false);
            groupBoxDateResident.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox;
        private ComboBox comboBoxListUnits;
        private Label labelApt;
        private Button buttonSelectUnit;
        private Label labelResultApt;
        private Label labelResultBuilding;
        private GroupBox groupBoxDateResident;
        private TextBox textBoxFullName;
        private Label labelFullName;
        private TextBox textBoxCellPhone;
        private Label labelCellPhone;
        private TextBox textBoxEmail;
        private Label labelEmail;
        private TextBox textBoxCPF;
        private Label labelCPF;
        private Button buttonRegister;
    }
}
