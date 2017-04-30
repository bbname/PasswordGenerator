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
        bool[] GetSignTypes(ref bool[] signTypes, int signTypesCount, string checkBoxSignTypeName, bool checkBoxSignTypeValue);
    }
}
