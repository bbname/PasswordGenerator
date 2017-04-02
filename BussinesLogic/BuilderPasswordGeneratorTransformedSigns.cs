using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLogic
{
    public abstract class BuilderPasswordGeneratorTransformedSigns
    {

        /// <summary>
        /// Transforming indexes for sign types collections.
        /// </summary>
        /// <returns></returns>
        protected int[,] TransformSignIndexes(int[] signTypesCollectionsLength)
        {
            // Set local variables.
            int smallLetters = signTypesCollectionsLength[0];
            int capitalLetters = signTypesCollectionsLength[1];
            int smallPolishLetters = signTypesCollectionsLength[2];
            int capitalPolishLetters = signTypesCollectionsLength[3];
            int specialSigns = signTypesCollectionsLength[4];

            // Count whole number of signs.
            int totalSignsNumber = smallLetters + capitalLetters + smallPolishLetters + capitalPolishLetters + specialSigns;

            // Create a array where types of signs have own signs on specified amount.
            int[,] lettersIndexes = new int[signTypesCollectionsLength.Length, totalSignsNumber];

            // Set counter for loops to verify and change collection of signs in loop.
            int signTypesCounter = 0;

            // While amount of collections isn't larger, then we've created before, go on.
            // From the begining to the number of all possibly elements - signs 
            // mark one as loop iterator sign and set to special collection.
            // Check if actual iterator in loop isn't the last sign of individual collection,
            // if it is, change to next collection, to the end of collections.
            while (signTypesCounter < signTypesCollectionsLength.Length)
            {
                for (int i = 0; i < totalSignsNumber; i++)
                {
                    lettersIndexes[signTypesCounter, i] = i;

                    if ((signTypesCounter == signTypesCollectionsLength[0] && i == (smallLetters - 1))
                     || (signTypesCounter == signTypesCollectionsLength[1] && i == (capitalLetters - 1))
                     || (signTypesCounter == signTypesCollectionsLength[2] && i == (smallPolishLetters - 1))
                     || (signTypesCounter == signTypesCollectionsLength[3] && i == (capitalPolishLetters - 1))
                     || (signTypesCounter == signTypesCollectionsLength[4] && i == (specialSigns - 1)))
                    {
                        signTypesCounter += 1;
                    }
                }
            }

            return lettersIndexes;
        }
    }
}
