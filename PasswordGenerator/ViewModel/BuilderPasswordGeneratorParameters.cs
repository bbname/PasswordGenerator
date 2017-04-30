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

            ControlsLogic.CheckBoxLogic checkBoxLogic = new ControlsLogic.CheckBoxLogic();
            signTypes = checkBoxLogic.GetSignTypesFromCheckBoxes(this._formMain.groupBoxSignTypes.Controls, ref signTypes);

            return signTypes;
        }
    }
}
