using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinesLogic.Interfaces;
using System.Windows.Forms;

namespace PasswordGenerator.ViewModel
{
    public class BuilderPasswordGeneratorParameters : IBuilderPasswordGeneratorParameters
    {
        private FormMain _formMain;

        public BuilderPasswordGeneratorParameters(FormMain formMain)
        {
            _formMain = formMain;
        }
        public int GetPasswordLength()
        {
            int passwordLength = Convert.ToInt32(_formMain.numericUpDownPasswordLength.Value);
            return passwordLength;
        }

        public bool[] GetSignTypes()
        {
            bool[] signsTypes = new bool [this._formMain.groupBoxSignTypes.Controls.Count];
            int checkBoxCounter = 0;

            foreach (var checkBox in this._formMain.groupBoxSignTypes.Controls)
            {
                if (checkBox is CheckBox)
                {
                    CheckBox checkBoxSignType = checkBox as CheckBox;

                    if (checkBoxSignType.Checked)
                    {
                        signsTypes[checkBoxCounter] = true;
                    }
                    else
                    {
                        signsTypes[checkBoxCounter] = false;
                    }

                    checkBoxCounter++;
                }
            }    
            return signsTypes;
        }
    }
}
