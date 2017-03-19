using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGenerator.ViewModel
{
    public static class ControllsDefaultSettings
    {
        public static void ActivateCheckBox(CheckBox checkBox)
        {
            checkBox.Checked = true;
        }

        /// <summary>
        /// Did it for FormMain numericUpDown.
        /// </summary>
        /// <param name="numericUpDown"></param>
        public static void SetNumberNumericUpDown(NumericUpDown numericUpDown)
        {
            numericUpDown.Value = 20m;
        }
    }
}
