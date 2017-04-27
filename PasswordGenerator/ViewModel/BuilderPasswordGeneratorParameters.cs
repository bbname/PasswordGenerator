using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinesLogic.Interfaces;
using System.Windows.Forms;
using BussinesLogic;
using DataServices.Data;

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
            bool[] signTypes = new bool [this._formMain.groupBoxSignTypes.Controls.Count];

            foreach (var checkBox in this._formMain.groupBoxSignTypes.Controls)
            {
                if (checkBox is CheckBox)
                {
                    CheckBox checkBoxSignType = checkBox as CheckBox;
                    BuilderPasswordGeneratorSignTypes pgSignTypes = new BuilderPasswordGeneratorSignTypes();

                    signTypes = pgSignTypes.GetSignTypes(this._formMain.groupBoxSignTypes.Controls.Count,
                        checkBoxSignType.Name, checkBoxSignType.Checked);


                    //for (int i = 0; i < signsTypes.Length; i++)
                    //{
                    //    BuilderPasswordGeneratorSignTypes pgSignTypes = new BuilderPasswordGeneratorSignTypes();
                    //    signsTypes[i] = pgSignTypes.GetSignTypeFromCheckBox(i, checkBoxSignType.Name, checkBoxSignType.Checked);
                    //    //string signTypeName = pgSignTypes.GetSignTypeNameByNumber(i);

                    //    //if (pgSignTypes.CompareSignTypeNameWithCheckBox(checkBoxSignType.Name, signTypeName))
                    //    //{
                    //    //    signsTypes[i] = checkBoxSignType.Checked;
                    //    //    break;
                    //    //}
                    //}
                }
            }
            return signTypes;
        }
    }
}
