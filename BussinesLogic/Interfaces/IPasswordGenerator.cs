using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLogic.Interfaces
{
    interface IPasswordGenerator : IBuilderPasswordGeneratorParameters, IBuilderPasswordGeneratorRounds
    {
        string GetPassword();
        //string GetParams(int signsNumber, params bool[] sign);
    }
}
