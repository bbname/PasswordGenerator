using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinesLogic.Interfaces;

namespace BussinesLogic
{
    public class BuilderPasswordGeneratorTransformSigns : IBuilderPasswordGeneratorTransformSigns
    {
        private bool[] _signTypes;
        private int[] _signsLength;
        public BuilderPasswordGeneratorTransformSigns(bool[] signTypes, int[] signsLength)
        {
            this._signTypes = signTypes;
            this._signsLength = signsLength;
        }

        public int[,] GetSignIndexes()
        {
            // Set local variables.
            int smallLetters = this._signsLength[0];
            int capitalLetters = this._signsLength[1];
            int smallPolishLetters = this._signsLength[2];
            int capitalPolishLetters = this._signsLength[3];
            int specialSigns = this._signsLength[4];
            int[] signTypesCollection = new int[this._signTypes.Length];

            // Count whole number of signs.
            int totalSignsNumber = smallLetters + capitalLetters + smallPolishLetters + capitalPolishLetters + specialSigns;

            // Check if collection of signs exists.
            // Then assign individual number in collection of collections. :D
            for (int i = 0; i < _signsLength.Length; i++)
            {
                if (this._signTypes[i])
                {
                    signTypesCollection[i] = i;
                }
            }

            // Create a array where special collection of signs have own signs on specified amount.
            int[,] lettersIndexes = new int[this._signTypes.Length, totalSignsNumber];

            // Set counter for loops to verify and change collection of signs in loop.
            int signTypesCollectionCounter = 0;

            // While amount of collections isn't larger, then we've created before, go on.
            // From the begining to the number of all possibly elements - signs 
            // mark one as loop iterator sign and set to special collection.
            // Check if actual iterator in loop isn't the last sign of individual collection,
            // if it is, change to next collection, to the end of collections.
            while (signTypesCollectionCounter < this._signTypes.Length)
            {
                for (int i = 0; i < totalSignsNumber; i++)
                {
                    lettersIndexes[signTypesCollectionCounter, i] = i;

                    if ((signTypesCollectionCounter == Convert.ToInt32(signTypesCollection[0]) && i == (smallLetters - 1))
                     || (signTypesCollectionCounter == Convert.ToInt32(signTypesCollection[1]) && i == (capitalLetters - 1))
                     || (signTypesCollectionCounter == Convert.ToInt32(signTypesCollection[2]) && i == (smallPolishLetters - 1))
                     || (signTypesCollectionCounter == Convert.ToInt32(signTypesCollection[3]) && i == (capitalPolishLetters - 1))
                     || (signTypesCollectionCounter == Convert.ToInt32(signTypesCollection[4]) && i == (specialSigns - 1)))
                    {
                        signTypesCollectionCounter += 1;
                    }
                }
            }

            return lettersIndexes;
        }
    }
}
