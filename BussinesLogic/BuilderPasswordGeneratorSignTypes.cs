using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinesLogic.Interfaces;
using DataServices.Data;

namespace BussinesLogic
{
    public class BuilderPasswordGeneratorSignTypes : IBuilderPasswordGeneratorSignTypes
    {
        public bool CompareSignTypeNameWithCheckBox(string checkBoxName, string signTypeName)
        {
            bool result = checkBoxName.ToLower().Contains(signTypeName.ToLower()) ? true : false;
            return result;
        }

        public string GetSignTypeNameByNumber(int number)
        {
            SignTypes signType = (SignTypes)number;
            string signTypeName = signType.ToString();

            return signTypeName;
        }

        //public bool GetSignTypeFromCheckBox(int signTypeNumber, string checkBoxSignTypeName, bool checkBoxSignTypeValue)
        //{
        //    bool signType = false;
        //    string signTypeName = this.GetSignTypeNameByNumber(signTypeNumber);

        //    if (this.CompareSignTypeNameWithCheckBox(checkBoxSignTypeName, signTypeName))
        //    {
        //        signType = checkBoxSignTypeValue;
        //    }

        //    return signType;
        //}

        public bool [] GetSignTypes(int signTypesCount, string checkBoxSignTypeName, bool checkBoxSignTypeValue)
        {
            bool [] signTypes = new bool[signTypesCount];

            for (int i = 0; i < signTypesCount; i++)
            {
                string signTypeName = this.GetSignTypeNameByNumber(i);
                if (this.CompareSignTypeNameWithCheckBox(checkBoxSignTypeName, signTypeName))
                {
                    signTypes[i] = checkBoxSignTypeValue;
                }
            }

            return signTypes;
        }

    }
}
