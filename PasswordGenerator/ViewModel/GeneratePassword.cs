using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinesLogic;

namespace PasswordGenerator.ViewModel
{
    public class GeneratePassword
    {
        private BuilderPasswordGeneratorParameters _pgParameters;
        public GeneratePassword(BuilderPasswordGeneratorParameters pgParameters)
        {
            this._pgParameters = pgParameters;
        }
        public string GetPassword()
        {
            BussinesLogic.PasswordGenerator pg = new BussinesLogic.PasswordGenerator(this._pgParameters.GetPasswordLength(), 
                this._pgParameters.GetSignTypes());

            string password = pg.GeneratePassword();

            return password;
        }
    }
}
