using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinesLogic.Interfaces;

namespace BussinesLogic
{
    public class BuilderPasswordGeneratorTransformSigns : BuilderPasswordGeneratorTransformedSigns, IBuilderPasswordGeneratorTransformSigns
    {
        private bool[] _signTypesSelected;
        private int[] _signTypesCollectionsLength;
        public BuilderPasswordGeneratorTransformSigns(bool[] signTypesSelected, int[] signTypesCollectionsLength)
        {
            this._signTypesSelected = signTypesSelected;
            this._signTypesCollectionsLength = signTypesCollectionsLength;
        }

        public int[,] GetSignIndexes()
        {
            int[,] lettersIndexes = this.TransformSignIndexes(this._signTypesCollectionsLength);

            for (int i = 0; i < this._signTypesCollectionsLength.Length; i++)
            {
                if (!this._signTypesSelected[i])
                {
                    // Dopisać kod na usuwanie niepotrzebnych kolekcji.
                }
            }
        }
    }
}
