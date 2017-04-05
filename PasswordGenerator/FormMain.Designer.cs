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
            this.textBoxPlaceName = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonClearAll = new System.Windows.Forms.Button();
            this.checkBoxSmallLetters = new System.Windows.Forms.CheckBox();
            this.checkBoxCapitalLetters = new System.Windows.Forms.CheckBox();
            this.checkBoxSmallPolishLetters = new System.Windows.Forms.CheckBox();
            this.checkBoxCapitalPolishLetters = new System.Windows.Forms.CheckBox();
            this.checkBoxSpecialSigns = new System.Windows.Forms.CheckBox();
            this.checkBoxAdditionalLogin = new System.Windows.Forms.CheckBox();
            this.checkBoxAdditionalEmail = new System.Windows.Forms.CheckBox();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.checkBoxDigits = new System.Windows.Forms.CheckBox();
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
            this.labelSignsTypes.Location = new System.Drawing.Point(359, 10);
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
            this.labelAdditionalOptions.Location = new System.Drawing.Point(359, 161);
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
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(362, 256);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(126, 24);
            this.buttonSave.TabIndex = 15;
            this.buttonSave.Text = "Zapisz";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonClearAll
            // 
            this.buttonClearAll.Location = new System.Drawing.Point(362, 229);
            this.buttonClearAll.Name = "buttonClearAll";
            this.buttonClearAll.Size = new System.Drawing.Size(126, 26);
            this.buttonClearAll.TabIndex = 16;
            this.buttonClearAll.Text = "Wyczyść wszystko";
            this.buttonClearAll.UseVisualStyleBackColor = true;
            // 
            // checkBoxSmallLetters
            // 
            this.checkBoxSmallLetters.AutoSize = true;
            this.checkBoxSmallLetters.Location = new System.Drawing.Point(362, 26);
            this.checkBoxSmallLetters.Name = "checkBoxSmallLetters";
            this.checkBoxSmallLetters.Size = new System.Drawing.Size(75, 17);
            this.checkBoxSmallLetters.TabIndex = 17;
            this.checkBoxSmallLetters.Text = "Małe litery";
            this.checkBoxSmallLetters.UseVisualStyleBackColor = true;
            // 
            // checkBoxCapitalLetters
            // 
            this.checkBoxCapitalLetters.AutoSize = true;
            this.checkBoxCapitalLetters.Location = new System.Drawing.Point(362, 49);
            this.checkBoxCapitalLetters.Name = "checkBoxCapitalLetters";
            this.checkBoxCapitalLetters.Size = new System.Drawing.Size(85, 17);
            this.checkBoxCapitalLetters.TabIndex = 18;
            this.checkBoxCapitalLetters.Text = "Wielkie litery";
            this.checkBoxCapitalLetters.UseVisualStyleBackColor = true;
            // 
            // checkBoxSmallPolishLetters
            // 
            this.checkBoxSmallPolishLetters.AutoSize = true;
            this.checkBoxSmallPolishLetters.Location = new System.Drawing.Point(362, 72);
            this.checkBoxSmallPolishLetters.Name = "checkBoxSmallPolishLetters";
            this.checkBoxSmallPolishLetters.Size = new System.Drawing.Size(111, 17);
            this.checkBoxSmallPolishLetters.TabIndex = 19;
            this.checkBoxSmallPolishLetters.Text = "Małe polskie litery";
            this.checkBoxSmallPolishLetters.UseVisualStyleBackColor = true;
            // 
            // checkBoxCapitalPolishLetters
            // 
            this.checkBoxCapitalPolishLetters.AutoSize = true;
            this.checkBoxCapitalPolishLetters.Location = new System.Drawing.Point(362, 95);
            this.checkBoxCapitalPolishLetters.Name = "checkBoxCapitalPolishLetters";
            this.checkBoxCapitalPolishLetters.Size = new System.Drawing.Size(121, 17);
            this.checkBoxCapitalPolishLetters.TabIndex = 20;
            this.checkBoxCapitalPolishLetters.Text = "Wielkie polskie litery";
            this.checkBoxCapitalPolishLetters.UseVisualStyleBackColor = true;
            // 
            // checkBoxSpecialSigns
            // 
            this.checkBoxSpecialSigns.AutoSize = true;
            this.checkBoxSpecialSigns.Location = new System.Drawing.Point(362, 118);
            this.checkBoxSpecialSigns.Name = "checkBoxSpecialSigns";
            this.checkBoxSpecialSigns.Size = new System.Drawing.Size(101, 17);
            this.checkBoxSpecialSigns.TabIndex = 21;
            this.checkBoxSpecialSigns.Text = "Znaki specjalne";
            this.checkBoxSpecialSigns.UseVisualStyleBackColor = true;
            // 
            // checkBoxAdditionalLogin
            // 
            this.checkBoxAdditionalLogin.AutoSize = true;
            this.checkBoxAdditionalLogin.Location = new System.Drawing.Point(362, 177);
            this.checkBoxAdditionalLogin.Name = "checkBoxAdditionalLogin";
            this.checkBoxAdditionalLogin.Size = new System.Drawing.Size(52, 17);
            this.checkBoxAdditionalLogin.TabIndex = 22;
            this.checkBoxAdditionalLogin.Text = "Login";
            this.checkBoxAdditionalLogin.UseVisualStyleBackColor = true;
            // 
            // checkBoxAdditionalEmail
            // 
            this.checkBoxAdditionalEmail.AutoSize = true;
            this.checkBoxAdditionalEmail.Location = new System.Drawing.Point(362, 200);
            this.checkBoxAdditionalEmail.Name = "checkBoxAdditionalEmail";
            this.checkBoxAdditionalEmail.Size = new System.Drawing.Size(51, 17);
            this.checkBoxAdditionalEmail.TabIndex = 23;
            this.checkBoxAdditionalEmail.Text = "Email";
            this.checkBoxAdditionalEmail.UseVisualStyleBackColor = true;
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(15, 51);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(78, 38);
            this.buttonGenerate.TabIndex = 24;
            this.buttonGenerate.Text = "Generuj";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            // 
            // checkBoxDigits
            // 
            this.checkBoxDigits.AutoSize = true;
            this.checkBoxDigits.Location = new System.Drawing.Point(362, 141);
            this.checkBoxDigits.Name = "checkBoxDigits";
            this.checkBoxDigits.Size = new System.Drawing.Size(49, 17);
            this.checkBoxDigits.TabIndex = 25;
            this.checkBoxDigits.Text = "Cyfry";
            this.checkBoxDigits.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 306);
            this.Controls.Add(this.checkBoxDigits);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.checkBoxAdditionalEmail);
            this.Controls.Add(this.checkBoxAdditionalLogin);
            this.Controls.Add(this.checkBoxSpecialSigns);
            this.Controls.Add(this.checkBoxCapitalPolishLetters);
            this.Controls.Add(this.checkBoxSmallPolishLetters);
            this.Controls.Add(this.checkBoxCapitalLetters);
            this.Controls.Add(this.checkBoxSmallLetters);
            this.Controls.Add(this.buttonClearAll);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.textBoxPlaceName);
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
        public System.Windows.Forms.Button buttonSave;
        public System.Windows.Forms.Button buttonClearAll;
        public System.Windows.Forms.Label labelPasswordLength;
        public System.Windows.Forms.Label labelSignsTypes;
        public System.Windows.Forms.Label labelGeneratedPassword;
        public System.Windows.Forms.Label labelPlaceName;
        public System.Windows.Forms.Label labelAdditionalOptions;
        public System.Windows.Forms.TextBox textBoxGeneratedPassword;
        public System.Windows.Forms.CheckBox checkBoxSmallLetters;
        public System.Windows.Forms.CheckBox checkBoxCapitalLetters;
        public System.Windows.Forms.CheckBox checkBoxSmallPolishLetters;
        public System.Windows.Forms.CheckBox checkBoxCapitalPolishLetters;
        public System.Windows.Forms.CheckBox checkBoxSpecialSigns;
        public System.Windows.Forms.CheckBox checkBoxAdditionalLogin;
        public System.Windows.Forms.CheckBox checkBoxAdditionalEmail;
        public System.Windows.Forms.Button buttonGenerate;
        public System.Windows.Forms.CheckBox checkBoxDigits;
    }
}