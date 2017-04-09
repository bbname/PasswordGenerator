using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BussinesLogic;
using System.Collections.Generic;

namespace BussinesLogicTests
{
    [TestClass]
    public class BuilderPasswordGeneratorRandomIndexesTests
    {
        [TestMethod]
        public void GenerateRandomNumber_ValidSignsRange()
        {
            // Arrange
            int passwordLength = 20;
            int lastIndexNumber = 80;
            IEnumerable<int> randomIndexesExpect;
            BuilderPasswordGeneratorRandomIndexes randomIndexes = new BuilderPasswordGeneratorRandomIndexes(passwordLength, lastIndexNumber);

            // Act
            randomIndexesExpect = randomIndexes.GetRandomIndexes();
        }
    }
}
