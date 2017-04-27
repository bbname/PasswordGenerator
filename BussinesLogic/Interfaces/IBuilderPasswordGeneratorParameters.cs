using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataServices.Data;

namespace BussinesLogic.Interfaces
{
    public interface IBuilderPasswordGeneratorParameters
    {
        int GetPasswordLength();
        bool[] GetSignTypes();
    }
}
