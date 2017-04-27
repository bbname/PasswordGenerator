using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLogic.Interfaces
{
    interface IBuilderPasswordGeneratorSignTypes
    {
        bool CompareSignTypeNameWithCheckBox(string checkBoxName, string signTypeName);
        string GetSignTypeNameByNumber(int number);
        //bool GetSignTypeFromCheckBox(int signTypeNumber, string checkBoxSignTypeName, bool checkBoxSignTypeValue);
    }
}
