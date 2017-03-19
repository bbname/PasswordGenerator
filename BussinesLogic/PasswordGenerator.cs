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
        private int _length;
        private bool[] _signsTypes;

        public PasswordGenerator(int length, bool [] signsTypes)
        {
            this._length = length;
            this._signsTypes = signsTypes;
        }
        public string GetPassword()
        {
            throw new NotImplementedException();
        }
    }
}
