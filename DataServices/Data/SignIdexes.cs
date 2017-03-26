using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataServices.Data
{
    public static class SignIdexes
    {
        public static int [] SmallLetters { get { return null; } }

        public static int [] SetLettersIndexes()
        {
            int smallLetters = Signs.Letters.Length;
            int capitalLetters = Signs.Letters.Length;
            int smallPolishLetters = Signs.PolishLetters.Length;
            int capitalPolishLetters = Signs.PolishLetters.Length;
            int specialSigns = Signs.SpecialSigns.Length;
            int totalSignsNumber = smallLetters + capitalLetters + smallPolishLetters + capitalPolishLetters + specialSigns;

            bool[] signTypes = { smallLetters > 0, capitalLetters > 0,
                                 smallPolishLetters > 0, capitalPolishLetters > 0, specialSigns > 0  };
            int[,] lettersIndexes = new int[totalSignsNumber, signTypes.Length];

            int lettersNumber = smallLetters;
            while ()
            {
                for (int i = 0; i < totalSignsNumber; i++)
                {
                    lettersIndexes[i, ] = i;
                }
            }

            return lettersIndexes;
        }
    }
}
