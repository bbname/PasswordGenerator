using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLogic.Interfaces
{
    public interface IBuilderPasswordGeneratorParameters
    {
        int GetPasswordLength();
        bool[] GetSignsTypes();
    }
}
