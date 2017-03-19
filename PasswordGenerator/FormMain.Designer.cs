namespace PasswordGenerator
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelPasswordLength = new System.Windows.Forms.Label();
            this.labelSignsTypes = new System.Windows.Forms.Label();
            this.labelGeneratedPassword = new System.Windows.Forms.Label();
            this.labelPlaceName = new System.Windows.Forms.Label();
            this.labelAdditionalOptions = new System.Windows.Forms.Label();
            this.numericUpDownPasswordLength = new System.Windows.Forms.NumericUpDown();
            this.textBoxGeneratedPassword = new System.Windows.Forms.TextBox();
            this.checkedListBoxSignsTypes = new System.Windows.Forms.CheckedListBox();
            this.textBoxPlaceName = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.checkedListBoxAdditionalOptions = new System.Windows.Forms.CheckedListBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonClearAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPasswordLength)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPasswordLength
            // 
            this.labelPasswordLength.AutoSize = true;
            this.labelPasswordLength.Location = new System.Drawing.Point(12, 9);
            this.labelPasswordLength.Name = "labelPasswordLength";
            this.labelPasswordLength.Size = new System.Drawing.Size(81, 13);
            this.labelPasswordLength.TabIndex = 0;
            this.labelPasswordLength.Text = "Długość hasła:";
            // 
            // labelSignsTypes
            // 
            this.labelSignsTypes.AutoSize = true;
            this.labelSignsTypes.Location = new System.Drawing.Point(390, 8);
            this.labelSignsTypes.Name = "labelSignsTypes";
            this.labelSignsTypes.Size = new System.Drawing.Size(76, 13);
            this.labelSignsTypes.TabIndex = 1;
            this.labelSignsTypes.Text = "Znaki w haśle:";
            // 
            // labelGeneratedPassword
            // 
            this.labelGeneratedPassword.AutoSize = true;
            this.labelGeneratedPassword.Location = new System.Drawing.Point(112, 8);
            this.labelGeneratedPassword.Name = "labelGeneratedPassword";
            this.labelGeneratedPassword.Size = new System.Drawing.Size(115, 13);
            this.labelGeneratedPassword.TabIndex = 2;
            this.labelGeneratedPassword.Text = "Wygenerowane hasło:";
            // 
            // labelPlaceName
            // 
            this.labelPlaceName.AutoSize = true;
            this.labelPlaceName.Location = new System.Drawing.Point(12, 128);
            this.labelPlaceName.Name = "labelPlaceName";
            this.labelPlaceName.Size = new System.Drawing.Size(81, 13);
            this.labelPlaceName.TabIndex = 4;
            this.labelPlaceName.Text = "Nazwa miejsca:";
            // 
            // labelAdditionalOptions
            // 
            this.labelAdditionalOptions.AutoSize = true;
            this.labelAdditionalOptions.Location = new System.Drawing.Point(417, 121);
            this.labelAdditionalOptions.Name = "labelAdditionalOptions";
            this.labelAdditionalOptions.Size = new System.Drawing.Size(49, 13);
            this.labelAdditionalOptions.TabIndex = 5;
            this.labelAdditionalOptions.Text = "Zapisz z:";
            // 
            // numericUpDownPasswordLength
            // 
            this.numericUpDownPasswordLength.Location = new System.Drawing.Point(15, 25);
            this.numericUpDownPasswordLength.Name = "numericUpDownPasswordLength";
            this.numericUpDownPasswordLength.Size = new System.Drawing.Size(78, 20);
            this.numericUpDownPasswordLength.TabIndex = 6;
            // 
            // textBoxGeneratedPassword
            // 
            this.textBoxGeneratedPassword.Location = new System.Drawing.Point(115, 24);
            this.textBoxGeneratedPassword.Multiline = true;
            this.textBoxGeneratedPassword.Name = "textBoxGeneratedPassword";
            this.textBoxGeneratedPassword.Size = new System.Drawing.Size(211, 95);
            this.textBoxGeneratedPassword.TabIndex = 7;
            // 
            // checkedListBoxSignsTypes
            // 
            this.checkedListBoxSignsTypes.FormattingEnabled = true;
            this.checkedListBoxSignsTypes.Items.AddRange(new object[] {
            "Małe litery",
            "Wielkie litery",
            "Male polskie litery",
            "Wielkie polskie litery",
            "Znaki specjalnie"});
            this.checkedListBoxSignsTypes.Location = new System.Drawing.Point(332, 24);
            this.checkedListBoxSignsTypes.Name = "checkedListBoxSignsTypes";
            this.checkedListBoxSignsTypes.Size = new System.Drawing.Size(134, 94);
            this.checkedListBoxSignsTypes.TabIndex = 8;
            // 
            // textBoxPlaceName
            // 
            this.textBoxPlaceName.Location = new System.Drawing.Point(115, 125);
            this.textBoxPlaceName.Multiline = true;
            this.textBoxPlaceName.Name = "textBoxPlaceName";
            this.textBoxPlaceName.Size = new System.Drawing.Size(211, 48);
            this.textBoxPlaceName.TabIndex = 9;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(115, 179);
            this.textBoxLogin.Multiline = true;
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(211, 48);
            this.textBoxLogin.TabIndex = 11;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(12, 182);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(97, 13);
            this.labelLogin.TabIndex = 10;
            this.labelLogin.Text = "Login (opcjonalne):";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(115, 233);
            this.textBoxEmail.Multiline = true;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(211, 48);
            this.textBoxEmail.TabIndex = 13;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(12, 236);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(96, 13);
            this.labelEmail.TabIndex = 12;
            this.labelEmail.Text = "Email (opcjonalne):";
            // 
            // checkedListBoxAdditionalOptions
            // 
            this.checkedListBoxAdditionalOptions.FormattingEnabled = true;
            this.checkedListBoxAdditionalOptions.Items.AddRange(new object[] {
            "Login",
            "Email"});
            this.checkedListBoxAdditionalOptions.Location = new System.Drawing.Point(332, 137);
            this.checkedListBoxAdditionalOptions.Name = "checkedListBoxAdditionalOptions";
            this.checkedListBoxAdditionalOptions.Size = new System.Drawing.Size(134, 34);
            this.checkedListBoxAdditionalOptions.TabIndex = 14;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(332, 233);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(134, 48);
            this.buttonSave.TabIndex = 15;
            this.buttonSave.Text = "Zapisz";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonClearAll
            // 
            this.buttonClearAll.Location = new System.Drawing.Point(332, 179);
            this.buttonClearAll.Name = "buttonClearAll";
            this.buttonClearAll.Size = new System.Drawing.Size(134, 48);
            this.buttonClearAll.TabIndex = 16;
            this.buttonClearAll.Text = "Wyczyść wszystko";
            this.buttonClearAll.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 306);
            this.Controls.Add(this.buttonClearAll);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.checkedListBoxAdditionalOptions);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.textBoxPlaceName);
            this.Controls.Add(this.checkedListBoxSignsTypes);
            this.Controls.Add(this.textBoxGeneratedPassword);
            this.Controls.Add(this.numericUpDownPasswordLength);
            this.Controls.Add(this.labelAdditionalOptions);
            this.Controls.Add(this.labelPlaceName);
            this.Controls.Add(this.labelGeneratedPassword);
            this.Controls.Add(this.labelSignsTypes);
            this.Controls.Add(this.labelPasswordLength);
            this.Name = "FormMain";
            this.Text = "FormMain";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPasswordLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.NumericUpDown numericUpDownPasswordLength;
        public System.Windows.Forms.TextBox textBoxPlaceName;
        public System.Windows.Forms.TextBox textBoxLogin;
        public System.Windows.Forms.Label labelLogin;
        public System.Windows.Forms.TextBox textBoxEmail;
        public System.Windows.Forms.Label labelEmail;
        public System.Windows.Forms.CheckedListBox checkedListBoxAdditionalOptions;
        public System.Windows.Forms.Button buttonSave;
        public System.Windows.Forms.Button buttonClearAll;
        public System.Windows.Forms.Label labelPasswordLength;
        public System.Windows.Forms.Label labelSignsTypes;
        public System.Windows.Forms.Label labelGeneratedPassword;
        public System.Windows.Forms.Label labelPlaceName;
        public System.Windows.Forms.Label labelAdditionalOptions;
        public System.Windows.Forms.TextBox textBoxGeneratedPassword;
        public System.Windows.Forms.CheckedListBox checkedListBoxSignsTypes;
    }
}