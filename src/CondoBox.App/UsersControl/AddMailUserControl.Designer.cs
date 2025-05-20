namespace CondoBox.App.UsersControl
{
    partial class AddMailUserControl
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
            groupBoxAddMail = new GroupBox();
            labelAmountDescription = new Label();
            labelDescription = new Label();
            buttonSelect = new Button();
            comboBoxAmount = new ComboBox();
            labelAmount = new Label();
            labelUnit = new Label();
            buttonRegister = new Button();
            comboBoxListUnits = new ComboBox();
            groupBoxAddMail.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxAddMail
            // 
            groupBoxAddMail.Controls.Add(labelAmountDescription);
            groupBoxAddMail.Controls.Add(labelDescription);
            groupBoxAddMail.Controls.Add(buttonSelect);
            groupBoxAddMail.Controls.Add(comboBoxAmount);
            groupBoxAddMail.Controls.Add(labelAmount);
            groupBoxAddMail.Controls.Add(labelUnit);
            groupBoxAddMail.Controls.Add(buttonRegister);
            groupBoxAddMail.Controls.Add(comboBoxListUnits);
            groupBoxAddMail.Dock = DockStyle.Fill;
            groupBoxAddMail.Location = new Point(0, 0);
            groupBoxAddMail.Name = "groupBoxAddMail";
            groupBoxAddMail.Size = new Size(550, 550);
            groupBoxAddMail.TabIndex = 0;
            groupBoxAddMail.TabStop = false;
            groupBoxAddMail.Text = "Adicionar Encomenda";
            // 
            // labelAmountDescription
            // 
            labelAmountDescription.AutoSize = true;
            labelAmountDescription.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelAmountDescription.Location = new Point(305, 170);
            labelAmountDescription.Name = "labelAmountDescription";
            labelAmountDescription.Size = new Size(22, 21);
            labelAmountDescription.TabIndex = 8;
            labelAmountDescription.Text = "...";
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDescription.Location = new Point(17, 170);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(22, 21);
            labelDescription.TabIndex = 7;
            labelDescription.Text = "...";
            // 
            // buttonSelect
            // 
            buttonSelect.Enabled = false;
            buttonSelect.Location = new Point(469, 83);
            buttonSelect.Name = "buttonSelect";
            buttonSelect.Size = new Size(75, 23);
            buttonSelect.TabIndex = 6;
            buttonSelect.Text = "Selecionar";
            buttonSelect.UseVisualStyleBackColor = true;
            buttonSelect.Click += buttonSelect_Click;
            // 
            // comboBoxAmount
            // 
            comboBoxAmount.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxAmount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxAmount.FormattingEnabled = true;
            comboBoxAmount.Items.AddRange(new object[] { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15" });
            comboBoxAmount.Location = new Point(258, 79);
            comboBoxAmount.Name = "comboBoxAmount";
            comboBoxAmount.Size = new Size(184, 29);
            comboBoxAmount.TabIndex = 5;
            // 
            // labelAmount
            // 
            labelAmount.AutoSize = true;
            labelAmount.Location = new Point(305, 48);
            labelAmount.Name = "labelAmount";
            labelAmount.Size = new Size(72, 15);
            labelAmount.TabIndex = 4;
            labelAmount.Text = "Quantidade:";
            // 
            // labelUnit
            // 
            labelUnit.AutoSize = true;
            labelUnit.Location = new Point(17, 48);
            labelUnit.Name = "labelUnit";
            labelUnit.Size = new Size(54, 15);
            labelUnit.TabIndex = 3;
            labelUnit.Text = "Unidade:";
            // 
            // buttonRegister
            // 
            buttonRegister.Enabled = false;
            buttonRegister.Location = new Point(190, 358);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(184, 49);
            buttonRegister.TabIndex = 2;
            buttonRegister.Text = "Cadastrar";
            buttonRegister.UseVisualStyleBackColor = true;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // comboBoxListUnits
            // 
            comboBoxListUnits.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxListUnits.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxListUnits.FormattingEnabled = true;
            comboBoxListUnits.Location = new Point(17, 79);
            comboBoxListUnits.Name = "comboBoxListUnits";
            comboBoxListUnits.Size = new Size(184, 29);
            comboBoxListUnits.TabIndex = 1;
            // 
            // AddMailUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBoxAddMail);
            Name = "AddMailUserControl";
            Size = new Size(550, 550);
            groupBoxAddMail.ResumeLayout(false);
            groupBoxAddMail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxAddMail;
        private ComboBox comboBoxListUnits;
        private ComboBox comboBoxAmount;
        private Label labelAmount;
        private Label labelUnit;
        private Button buttonRegister;
        private Button buttonSelect;
        private Label labelAmountDescription;
        private Label labelDescription;
    }
}
