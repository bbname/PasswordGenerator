using BussinesLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGenerator.ControlsLogic
{
    public class CheckBoxLogic
    {
        public bool IsCheckBox(object checkBox)
        {
            bool isCheckBox = false;

            if (checkBox is CheckBox)
            {
                isCheckBox = true;
            }

            return isCheckBox;
        }

        public CheckBox GetSignTypeCheckBox(object checkBox)
        {
            CheckBox checkBoxSignType = null;

            if (this.IsCheckBox(checkBox))
            {
                checkBoxSignType = checkBox as CheckBox;
            }

            return checkBoxSignType;
        }

        public bool[] GetSignTypesFromCheckBoxes(Control.ControlCollection groupCheckBoxes, ref bool[] signTypes)
        {
            foreach (var checkBox in groupCheckBoxes)
            {
                CheckBox checkBoxSignType = this.GetSignTypeCheckBox(checkBox);
                BuilderPasswordGeneratorSignTypes pgSignTypes = new BuilderPasswordGeneratorSignTypes();

                signTypes = pgSignTypes.GetSortedSignTypes(ref signTypes, groupCheckBoxes.Count,
                        checkBoxSignType.Name, checkBoxSignType.Checked);
            }

            return signTypes;
        }
    }
}
