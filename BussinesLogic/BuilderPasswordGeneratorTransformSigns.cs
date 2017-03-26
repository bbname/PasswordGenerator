using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinesLogic.Interfaces;
using

namespace BussinesLogic
{
    public class BuilderPasswordGeneratorTransformSigns : IBuilderPasswordGeneratorTransformSigns
    {
        private bool[] _signTypes;
        public BuilderPasswordGeneratorTransformSigns(bool[] singTypes)
        {
            this._signTypes = _signTypes;
        }


        public int[] GetSignsIndexes()
        {
            
        }
    }
}
