using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinesLogic.Interfaces;

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
            //_formMain.Dispose();
            return passwordLength;
        }

        public bool[] GetSignsTypes()
        {
            bool[] signsTypes = new bool[6];
            
            return signsTypes;
        }
    }
}
