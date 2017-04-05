using System;
using System.Collections.Generic;
using System.Linq;
using BussinesLogic.Interfaces;
using DataServices.Data;

namespace BussinesLogic
{
    public class BuilderPasswordGeneratorTransformSigns : IBuilderPasswordGeneratorTransformSigns
    {
        private readonly Dictionary<char, int> _signsIndexes;
        private readonly bool[] _signTypesSelected;

        public BuilderPasswordGeneratorTransformSigns(bool[] signTypesSelected)
        {
            _signTypesSelected = signTypesSelected;
            _signsIndexes = new Dictionary<char, int>();
            TransformSigns();
        }

        public char GetSignByIndex(int index)
        {
            var sign = _signsIndexes.FirstOrDefault(x => x.Value == index).Key;
            return sign;
        }

        public int GetIndexBySign(char sign)
        {
            var index = _signsIndexes.FirstOrDefault(x => x.Key == sign).Value;
            return index;
        }

        public IEnumerable<int> GetIndexes()
        {
            return _signsIndexes.Values;
        }

        public IEnumerable<char> GetSigns()
        {
            return _signsIndexes.Keys;
        }

        public char[] GetSignsOfType(SignTypes signTypes)
        {
            switch (signTypes)
            {
                case SignTypes.SmallLetters:
                    return Signs.SmallLetters();
                case SignTypes.CapitalLetters:
                    return Signs.CapitalLetters();
                case SignTypes.SmallPolishLetters:
                    return Signs.SmallPolishLetters();
                case SignTypes.CapitalPolishLetters:
                    return Signs.CapitalPolishLetters();
                case SignTypes.SpecialSigns:
                    return Signs.SpecialSigns();
                case SignTypes.Digits:
                    return Signs.Digits();
                default:
                    return null;
            }
        }

        private void TransformSigns()
        {
            var indexCounter = 0;

            // For signs type check if it was selected.
            // Then, get a array of selected type.
            // Check if the array isn't empty, if it is throw exception.
            // If the array isn't empty, add the sign of selected type and assign index for it.
            for (var i = 0; i < _signTypesSelected.Length; i++)
                if (_signTypesSelected[i])
                {
                    var signTypes = (SignTypes) i;
                    var signs = GetSignsOfType(signTypes);

                    if (signs != null)
                        for (var j = 0; j < signs.Length; j++)
                        {
                            _signsIndexes.Add(signs[j], indexCounter);
                            indexCounter++;
                        }
                    else
                        throw new NullReferenceException("Something went wrong with signs loading.");
                }
        }
    }
}