using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinesLogic.Interfaces;

namespace BussinesLogic
{
    public class BuilderPasswordGeneratorRandomIndexes : IBuilderPasswordGeneratorRandomIndexes
    {
        private int _passwordLength;
        private int _lastIndexNumber;
        private Random _random;

        public BuilderPasswordGeneratorRandomIndexes(int passwordLength, int lastIndexNumber)
        {
            this._passwordLength = passwordLength;
            this._lastIndexNumber = lastIndexNumber;
            _random = new Random();
        }
        public int GenerateRandomIndex()
        {
            int randomIndex = _random.Next(_lastIndexNumber);

            return randomIndex;
        }

        public IEnumerable<int> GetRandomIndexes()
        {
            int[] randomIndexes = new int[_passwordLength];

            for (int i = 0; i < _passwordLength; i++)
            {
                randomIndexes[i] = this.GenerateRandomIndex();
            }

            return randomIndexes;
        }
    }
}
