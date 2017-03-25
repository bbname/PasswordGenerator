﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PasswordGenerator.ViewModel;

namespace PasswordGenerator
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            SetControllsDefaultSettings();
        }

        /// <summary>
        /// Setting default values for choosen controlls in formMain.
        /// </summary>
        private void SetControllsDefaultSettings()
        {
            ControllsDefaultSettings.ActivateCheckBox(checkBoxSmallLetters);
            ControllsDefaultSettings.ActivateCheckBox(checkBoxCapitalLetters);
            ControllsDefaultSettings.ActivateCheckBox(checkBoxSpecialSigns);
            ControllsDefaultSettings.SetNumberNumericUpDown(numericUpDownPasswordLength);
        }

    }
}
