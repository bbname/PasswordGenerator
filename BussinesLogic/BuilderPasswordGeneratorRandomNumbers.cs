using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinesLogic.Interfaces;

namespace BussinesLogic
{
    public class BuilderPasswordGeneratorRandomNumbers : IBuilderPasswordGeneratorRandomNumbers
    {
        private int _passwordLength;
        private int _signsNumber;
        private Random _random;

        public BuilderPasswordGeneratorRandomNumbers(int passwordLength, int signsNumber)
        {
            this._passwordLength = passwordLength;
            this._signsNumber = signsNumber;
            _random = new Random();
        }
        private int GenerateRandomNumber()
        {
            int randomNumber;

            randomNumber = _random.Next(_signsNumber);

            return randomNumber;
        }

        public int[] GetRandomNumbers()
        {
            int[] randomNumbers = new int[_passwordLength];

            for (int i = 0; i < _passwordLength; i++)
            {
                randomNumbers[i] = this.GenerateRandomNumber();
            }

            return randomNumbers;
        }
    }
}
