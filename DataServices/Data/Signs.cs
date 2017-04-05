using System;

namespace DataServices.Data
{
    public static class Signs
    {
        private static readonly char[] _letters =
        {
            'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l',
            'm', 'n', 'o', 'u', 'p', 'r', 's', 't', 'w', 'x', 'y', 'z'
        };

        private static readonly char[] _polishLetters = {'ą', 'ć', 'ę', 'ł', 'ń', 'ó', 'ś', 'ź', 'ż'};

        private static readonly char[] _specialSigns =
        {
            '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '_',
            '=', '+', ',', '<', '.', '>', '/', '?', ';', ':', '"', '\'',
            '[', '{', ']', '}', '\\', '|'
        };

        private static readonly char[] _digits = {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9'};

        /// <summary>
        ///     Transforming letters into smalls/capitals.
        /// </summary>
        /// <param name="letterType"></param>
        /// <param name="toLower"></param>
        /// <param name="toUpper"></param>
        /// <returns></returns>
        private static char[] GenerateLettersSize(char[] letterType, bool toLower, bool toUpper)
        {
            var letters = new char[letterType.Length];

            for (var i = 0; i < letterType.Length; i++)
                if (toLower)
                    letters[i] = char.ToLower(letterType[i]);
                else if (toUpper)
                    letters[i] = char.ToUpper(letterType[i]);
                else
                    throw new DataMisalignedException("Something went wrong with letters.");

            return letters;
        }

        public static char[] SmallLetters()
        {
            return GenerateLettersSize(_letters, true, false);
        }

        public static char[] CapitalLetters()
        {
            return GenerateLettersSize(_letters, false, true);
        }

        public static char[] SmallPolishLetters()
        {
            return GenerateLettersSize(_polishLetters, true, false);
        }

        public static char[] CapitalPolishLetters()
        {
            return GenerateLettersSize(_polishLetters, false, true);
        }

        public static char[] SpecialSigns()
        {
            return _specialSigns;
        }

        public static char[] Digits()
        {
            return _digits;
        }
    }
}