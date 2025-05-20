namespace CondoBox.App
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            iníciarToolStripMenuItem = new ToolStripMenuItem();
            loginToolStripMenuItem = new ToolStripMenuItem();
            cadastroNovoToolStripMenuItem = new ToolStripMenuItem();
            cadastrarMoradorToolStripMenuItem = new ToolStripMenuItem();
            configuraçõesToolStripMenuItem = new ToolStripMenuItem();
            emailToolStripMenuItem = new ToolStripMenuItem();
            panelSideMenu = new Panel();
            labelCell = new Label();
            labelCellphone = new Label();
            labelRoleFuction = new Label();
            labelRole = new Label();
            labelUsuario = new Label();
            buttonAddMail = new Button();
            labelCPFNumber = new Label();
            pictureBoxImage = new PictureBox();
            tabControl = new TabControl();
            menuStrip1.SuspendLayout();
            panelSideMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImage).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { iníciarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(784, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // iníciarToolStripMenuItem
            // 
            iníciarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { loginToolStripMenuItem, cadastroNovoToolStripMenuItem, cadastrarMoradorToolStripMenuItem, configuraçõesToolStripMenuItem });
            iníciarToolStripMenuItem.Name = "iníciarToolStripMenuItem";
            iníciarToolStripMenuItem.Size = new Size(51, 20);
            iníciarToolStripMenuItem.Text = "Iniciar";
            // 
            // loginToolStripMenuItem
            // 
            loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            loginToolStripMenuItem.Size = new Size(193, 22);
            loginToolStripMenuItem.Text = "Login";
            loginToolStripMenuItem.Click += loginToolStripMenuItem_Click;
            // 
            // cadastroNovoToolStripMenuItem
            // 
            cadastroNovoToolStripMenuItem.Enabled = false;
            cadastroNovoToolStripMenuItem.Name = "cadastroNovoToolStripMenuItem";
            cadastroNovoToolStripMenuItem.Size = new Size(193, 22);
            cadastroNovoToolStripMenuItem.Text = "Cadastrar Colaborador";
            cadastroNovoToolStripMenuItem.Click += cadastroNovoToolStripMenuItem_Click;
            // 
            // cadastrarMoradorToolStripMenuItem
            // 
            cadastrarMoradorToolStripMenuItem.Enabled = false;
            cadastrarMoradorToolStripMenuItem.Name = "cadastrarMoradorToolStripMenuItem";
            cadastrarMoradorToolStripMenuItem.Size = new Size(193, 22);
            cadastrarMoradorToolStripMenuItem.Text = "Cadastrar Morador";
            cadastrarMoradorToolStripMenuItem.Click += cadastrarMoradorToolStripMenuItem_Click;
            // 
            // configuraçõesToolStripMenuItem
            // 
            configuraçõesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { emailToolStripMenuItem });
            configuraçõesToolStripMenuItem.Enabled = false;
            configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            configuraçõesToolStripMenuItem.Size = new Size(193, 22);
            configuraçõesToolStripMenuItem.Text = "Configurações";
            // 
            // emailToolStripMenuItem
            // 
            emailToolStripMenuItem.Name = "emailToolStripMenuItem";
            emailToolStripMenuItem.Size = new Size(108, 22);
            emailToolStripMenuItem.Text = "E-mail";
            emailToolStripMenuItem.Click += emailToolStripMenuItem_Click;
            // 
            // panelSideMenu
            // 
            panelSideMenu.BackColor = Color.LightGray;
            panelSideMenu.Controls.Add(labelCell);
            panelSideMenu.Controls.Add(labelCellphone);
            panelSideMenu.Controls.Add(labelRoleFuction);
            panelSideMenu.Controls.Add(labelRole);
            panelSideMenu.Controls.Add(labelUsuario);
            panelSideMenu.Controls.Add(buttonAddMail);
            panelSideMenu.Controls.Add(labelCPFNumber);
            panelSideMenu.Controls.Add(pictureBoxImage);
            panelSideMenu.Dock = DockStyle.Left;
            panelSideMenu.Location = new Point(0, 24);
            panelSideMenu.Name = "panelSideMenu";
            panelSideMenu.Size = new Size(183, 537);
            panelSideMenu.TabIndex = 1;
            // 
            // labelCell
            // 
            labelCell.AutoSize = true;
            labelCell.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCell.Location = new Point(5, 252);
            labelCell.Name = "labelCell";
            labelCell.Size = new Size(61, 17);
            labelCell.TabIndex = 7;
            labelCell.Text = "Contato:";
            // 
            // labelCellphone
            // 
            labelCellphone.AutoSize = true;
            labelCellphone.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCellphone.Location = new Point(70, 252);
            labelCellphone.Name = "labelCellphone";
            labelCellphone.Size = new Size(20, 17);
            labelCellphone.TabIndex = 6;
            labelCellphone.Text = "...";
            // 
            // labelRoleFuction
            // 
            labelRoleFuction.AutoSize = true;
            labelRoleFuction.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelRoleFuction.Location = new Point(5, 218);
            labelRoleFuction.Name = "labelRoleFuction";
            labelRoleFuction.Size = new Size(48, 17);
            labelRoleFuction.TabIndex = 5;
            labelRoleFuction.Text = "Cargo:";
            // 
            // labelRole
            // 
            labelRole.AutoSize = true;
            labelRole.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelRole.Location = new Point(59, 218);
            labelRole.Name = "labelRole";
            labelRole.Size = new Size(20, 17);
            labelRole.TabIndex = 4;
            labelRole.Text = "...";
            // 
            // labelUsuario
            // 
            labelUsuario.AutoSize = true;
            labelUsuario.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUsuario.Location = new Point(5, 187);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(59, 17);
            labelUsuario.TabIndex = 3;
            labelUsuario.Text = "Usuário:";
            // 
            // buttonAddMail
            // 
            buttonAddMail.Enabled = false;
            buttonAddMail.FlatAppearance.BorderColor = Color.LightGray;
            buttonAddMail.FlatAppearance.BorderSize = 0;
            buttonAddMail.FlatStyle = FlatStyle.Flat;
            buttonAddMail.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAddMail.ForeColor = Color.Black;
            buttonAddMail.Location = new Point(3, 272);
            buttonAddMail.Name = "buttonAddMail";
            buttonAddMail.Size = new Size(177, 50);
            buttonAddMail.TabIndex = 2;
            buttonAddMail.Text = "Cadastrar";
            buttonAddMail.UseVisualStyleBackColor = true;
            buttonAddMail.Click += buttonAddMail_Click;
            // 
            // labelCPFNumber
            // 
            labelCPFNumber.AutoSize = true;
            labelCPFNumber.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCPFNumber.Location = new Point(70, 187);
            labelCPFNumber.Name = "labelCPFNumber";
            labelCPFNumber.Size = new Size(20, 17);
            labelCPFNumber.TabIndex = 1;
            labelCPFNumber.Text = "...";
            // 
            // pictureBoxImage
            // 
            pictureBoxImage.Location = new Point(3, 3);
            pictureBoxImage.Name = "pictureBoxImage";
            pictureBoxImage.Size = new Size(177, 177);
            pictureBoxImage.TabIndex = 0;
            pictureBoxImage.TabStop = false;
            // 
            // tabControl
            // 
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(183, 24);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(601, 537);
            tabControl.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(tabControl);
            Controls.Add(panelSideMenu);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MaximumSize = new Size(800, 600);
            MinimumSize = new Size(800, 600);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CondoBox - Sistema de Controle de Encomendas";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panelSideMenu.ResumeLayout(false);
            panelSideMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem iníciarToolStripMenuItem;
        private ToolStripMenuItem cadastroNovoToolStripMenuItem;
        private ToolStripMenuItem loginToolStripMenuItem;
        private Panel panelSideMenu;
        private TabControl tabControl;
        private Label labelCPFNumber;
        private PictureBox pictureBoxImage;
        private ToolStripMenuItem cadastrarMoradorToolStripMenuItem;
        private Button buttonAddMail;
        private ToolStripMenuItem configuraçõesToolStripMenuItem;
        private ToolStripMenuItem emailToolStripMenuItem;
        private Label labelUsuario;
        private Label labelRoleFuction;
        private Label labelRole;
        private Label labelCell;
        private Label labelCellphone;
    }
}
