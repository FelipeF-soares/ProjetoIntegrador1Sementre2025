namespace CondoBox.App.UsersControl
{
    partial class SettingEmailUserControl
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
            groupBoxSettingEmail = new GroupBox();
            maskedTextBoxEmailPort = new MaskedTextBox();
            labelInfo = new Label();
            buttonRegister = new Button();
            richTextBoxEmailBody = new RichTextBox();
            labelEmailBody = new Label();
            textBoxSubject = new TextBox();
            labelSubjact = new Label();
            textBoxEmailCC = new TextBox();
            labelEmailCC = new Label();
            labelSmtpPort = new Label();
            textBoxSmtpClient = new TextBox();
            labelSmtpClient = new Label();
            textBoxPassword = new TextBox();
            labelPassword = new Label();
            textBoxEmailSender = new TextBox();
            labelEmailSender = new Label();
            groupBoxSettingEmail.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxSettingEmail
            // 
            groupBoxSettingEmail.Controls.Add(maskedTextBoxEmailPort);
            groupBoxSettingEmail.Controls.Add(labelInfo);
            groupBoxSettingEmail.Controls.Add(buttonRegister);
            groupBoxSettingEmail.Controls.Add(richTextBoxEmailBody);
            groupBoxSettingEmail.Controls.Add(labelEmailBody);
            groupBoxSettingEmail.Controls.Add(textBoxSubject);
            groupBoxSettingEmail.Controls.Add(labelSubjact);
            groupBoxSettingEmail.Controls.Add(textBoxEmailCC);
            groupBoxSettingEmail.Controls.Add(labelEmailCC);
            groupBoxSettingEmail.Controls.Add(labelSmtpPort);
            groupBoxSettingEmail.Controls.Add(textBoxSmtpClient);
            groupBoxSettingEmail.Controls.Add(labelSmtpClient);
            groupBoxSettingEmail.Controls.Add(textBoxPassword);
            groupBoxSettingEmail.Controls.Add(labelPassword);
            groupBoxSettingEmail.Controls.Add(textBoxEmailSender);
            groupBoxSettingEmail.Controls.Add(labelEmailSender);
            groupBoxSettingEmail.Dock = DockStyle.Fill;
            groupBoxSettingEmail.Location = new Point(0, 0);
            groupBoxSettingEmail.Name = "groupBoxSettingEmail";
            groupBoxSettingEmail.Size = new Size(550, 550);
            groupBoxSettingEmail.TabIndex = 0;
            groupBoxSettingEmail.TabStop = false;
            groupBoxSettingEmail.Text = "Configurações E-mail";
            // 
            // maskedTextBoxEmailPort
            // 
            maskedTextBoxEmailPort.Location = new Point(251, 117);
            maskedTextBoxEmailPort.Mask = "00000";
            maskedTextBoxEmailPort.Name = "maskedTextBoxEmailPort";
            maskedTextBoxEmailPort.Size = new Size(100, 23);
            maskedTextBoxEmailPort.TabIndex = 12;
            maskedTextBoxEmailPort.ValidatingType = typeof(int);
            // 
            // labelInfo
            // 
            labelInfo.AutoSize = true;
            labelInfo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelInfo.ForeColor = SystemColors.ControlText;
            labelInfo.Location = new Point(154, 363);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new Size(317, 85);
            labelInfo.TabIndex = 11;
            labelInfo.Text = "Gmail: smtp.gmail.com, porta 587\r\n\r\nOutlook (Hotmail): smtp.office365.com, porta 587\r\n\r\nYahoo: smtp.mail.yahoo.com, porta 587";
            // 
            // buttonRegister
            // 
            buttonRegister.Location = new Point(198, 477);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(165, 47);
            buttonRegister.TabIndex = 8;
            buttonRegister.Text = "Registrar";
            buttonRegister.UseVisualStyleBackColor = true;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // richTextBoxEmailBody
            // 
            richTextBoxEmailBody.Location = new Point(6, 237);
            richTextBoxEmailBody.Name = "richTextBoxEmailBody";
            richTextBoxEmailBody.Size = new Size(537, 96);
            richTextBoxEmailBody.TabIndex = 7;
            richTextBoxEmailBody.Text = "";
            // 
            // labelEmailBody
            // 
            labelEmailBody.AutoSize = true;
            labelEmailBody.Location = new Point(6, 219);
            labelEmailBody.Name = "labelEmailBody";
            labelEmailBody.Size = new Size(63, 15);
            labelEmailBody.TabIndex = 10;
            labelEmailBody.Text = "Conteúdo:";
            // 
            // textBoxSubject
            // 
            textBoxSubject.Location = new Point(354, 175);
            textBoxSubject.Name = "textBoxSubject";
            textBoxSubject.Size = new Size(189, 23);
            textBoxSubject.TabIndex = 6;
            // 
            // labelSubjact
            // 
            labelSubjact.AutoSize = true;
            labelSubjact.Location = new Point(354, 157);
            labelSubjact.Name = "labelSubjact";
            labelSubjact.Size = new Size(40, 15);
            labelSubjact.TabIndex = 8;
            labelSubjact.Text = "Título:";
            // 
            // textBoxEmailCC
            // 
            textBoxEmailCC.Location = new Point(6, 175);
            textBoxEmailCC.Name = "textBoxEmailCC";
            textBoxEmailCC.Size = new Size(342, 23);
            textBoxEmailCC.TabIndex = 5;
            // 
            // labelEmailCC
            // 
            labelEmailCC.AutoSize = true;
            labelEmailCC.Location = new Point(6, 157);
            labelEmailCC.Name = "labelEmailCC";
            labelEmailCC.Size = new Size(63, 15);
            labelEmailCC.TabIndex = 7;
            labelEmailCC.Text = "E-mail CC:";
            // 
            // labelSmtpPort
            // 
            labelSmtpPort.AutoSize = true;
            labelSmtpPort.Location = new Point(251, 99);
            labelSmtpPort.Name = "labelSmtpPort";
            labelSmtpPort.Size = new Size(38, 15);
            labelSmtpPort.TabIndex = 5;
            labelSmtpPort.Text = "Porta:";
            // 
            // textBoxSmtpClient
            // 
            textBoxSmtpClient.Location = new Point(6, 117);
            textBoxSmtpClient.Name = "textBoxSmtpClient";
            textBoxSmtpClient.Size = new Size(224, 23);
            textBoxSmtpClient.TabIndex = 3;
            // 
            // labelSmtpClient
            // 
            labelSmtpClient.AutoSize = true;
            labelSmtpClient.Location = new Point(6, 99);
            labelSmtpClient.Name = "labelSmtpClient";
            labelSmtpClient.Size = new Size(92, 15);
            labelSmtpClient.TabIndex = 3;
            labelSmtpClient.Text = "Endereço SMTP:";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(354, 58);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(189, 23);
            textBoxPassword.TabIndex = 2;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(354, 40);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(42, 15);
            labelPassword.TabIndex = 0;
            labelPassword.Text = "Senha:";
            // 
            // textBoxEmailSender
            // 
            textBoxEmailSender.Location = new Point(6, 58);
            textBoxEmailSender.Name = "textBoxEmailSender";
            textBoxEmailSender.Size = new Size(342, 23);
            textBoxEmailSender.TabIndex = 1;
            // 
            // labelEmailSender
            // 
            labelEmailSender.AutoSize = true;
            labelEmailSender.Location = new Point(6, 40);
            labelEmailSender.Name = "labelEmailSender";
            labelEmailSender.Size = new Size(112, 15);
            labelEmailSender.TabIndex = 0;
            labelEmailSender.Text = "Endereço de e-mail:";
            // 
            // SettingEmailUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBoxSettingEmail);
            Name = "SettingEmailUserControl";
            Size = new Size(550, 550);
            groupBoxSettingEmail.ResumeLayout(false);
            groupBoxSettingEmail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxSettingEmail;
        private TextBox textBoxPassword;
        private Label labelPassword;
        private TextBox textBoxEmailSender;
        private Label labelEmailSender;
        private TextBox textBoxSmtpClient;
        private Label labelSmtpClient;
        private Label labelSmtpPort;
        private TextBox textBoxEmailCC;
        private Label labelEmailCC;
        private Label labelSubjact;
        private Button buttonRegister;
        private RichTextBox richTextBoxEmailBody;
        private Label labelEmailBody;
        private TextBox textBoxSubject;
        private Label labelInfo;
        private MaskedTextBox maskedTextBoxEmailPort;
    }
}
