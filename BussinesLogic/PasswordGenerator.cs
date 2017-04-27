using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinesLogic.Interfaces;

namespace BussinesLogic
{
    public class PasswordGenerator : IPasswordGenerator
    {
        private int _passwordLength;
        private bool[] _signTypes;
        private BuilderPasswordGeneratorTransformSigns _pgTransformSigns;
        private BuilderPasswordGeneratorRandomIndexes _pgRandomIndexes;

        public PasswordGenerator(int passwordLength, bool [] signTypes)
        {
            this._passwordLength = passwordLength;
            this._signTypes = signTypes;
            _pgTransformSigns = new BuilderPasswordGeneratorTransformSigns(this._signTypes);
        }

        public string GeneratePassword()
        {
            _pgRandomIndexes = new BuilderPasswordGeneratorRandomIndexes(this._passwordLength, this._pgTransformSigns.GetLastIndex());
            IEnumerable<int> generatedIndexes = _pgRandomIndexes.GetRandomIndexes();
            ICollection<char> generatedCharsPassword = _pgTransformSigns.GetSignsByIndexes(generatedIndexes);

            StringBuilder generatedPassword = new StringBuilder();
            generatedPassword.Append(generatedCharsPassword.ToArray());

            return generatedPassword.ToString();
        }
    }
}
