namespace CondoBox.App
{
    partial class LoginUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginUserControl));
            labelCpf = new Label();
            textBoxCPF = new TextBox();
            textBoxPassword = new TextBox();
            labelPassword = new Label();
            buttonLogin = new Button();
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelCpf
            // 
            labelCpf.AutoSize = true;
            labelCpf.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            labelCpf.Location = new Point(211, 288);
            labelCpf.Name = "labelCpf";
            labelCpf.Size = new Size(35, 17);
            labelCpf.TabIndex = 0;
            labelCpf.Text = "CPF:";
            // 
            // textBoxCPF
            // 
            textBoxCPF.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxCPF.Location = new Point(211, 306);
            textBoxCPF.Name = "textBoxCPF";
            textBoxCPF.Size = new Size(200, 29);
            textBoxCPF.TabIndex = 1;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPassword.Location = new Point(211, 358);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(200, 29);
            textBoxPassword.TabIndex = 3;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            labelPassword.Location = new Point(211, 340);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(49, 17);
            labelPassword.TabIndex = 2;
            labelPassword.Text = "Senha:";
            // 
            // buttonLogin
            // 
            buttonLogin.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLogin.Location = new Point(211, 429);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(200, 35);
            buttonLogin.TabIndex = 4;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(labelCpf);
            groupBox1.Controls.Add(buttonLogin);
            groupBox1.Controls.Add(textBoxCPF);
            groupBox1.Controls.Add(textBoxPassword);
            groupBox1.Controls.Add(labelPassword);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(644, 544);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(200, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(232, 232);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // LoginUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Name = "LoginUserControl";
            Size = new Size(650, 550);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label labelCpf;
        private TextBox textBoxCPF;
        private TextBox textBoxPassword;
        private Label labelPassword;
        private Button buttonLogin;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
    }
}
