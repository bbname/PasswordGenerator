using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BussinesLogic;
using System.Collections.Generic;
using System.Linq;

namespace BussinesLogicTests
{
    [TestClass]
    public class BuilderPasswordGeneratorRandomIndexesTests
    {
        [TestMethod]
        public void GenerateRandomIndex_IndexIsPositiveNumber_IndexIsInRange()
        {
            // Arrange
            int passwordLength = 20;
            int lastIndexNumber = 80;
            var randomIndexes = new BuilderPasswordGeneratorRandomIndexes(passwordLength, lastIndexNumber);
            int expected = lastIndexNumber;

            // Act
            int randomIndex = randomIndexes.GenerateRandomIndex();

            // Assert
            Assert.IsTrue(randomIndex < expected);
        }

        [TestMethod]
        public void GenerateRandomIndex_RandomIndexIsGreaterThanOrEqaulTo0_CorrectIndex()
        {
            // Arrange
            int passwordLength = 20;
            int lastIndexNumber = 80;
            var randomIndexes = new BuilderPasswordGeneratorRandomIndexes(passwordLength, lastIndexNumber);
            int expected = 0;

            // Act
            int randomIndex = randomIndexes.GenerateRandomIndex();

            // Assert
            Assert.IsTrue(randomIndex >= expected);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GenerateRandomIndex_LastIndexIsNegative_ExceptionThrown()
        {
            // Arrange
            int passwordLength = 20;
            int lastIndexNumber = -80;
            var randomIndexes = new BuilderPasswordGeneratorRandomIndexes(passwordLength, lastIndexNumber);
            int expected = 0;

            // Act
            int randomIndex = randomIndexes.GenerateRandomIndex();

            // Assert
            // is handled by ExpectedException
        }

        [TestMethod]
        public void GetRandomIndexes_AmmountOfIndexes()
        {
            // Arrange
            int passwordLength = 20;
            int lastIndexNumber = 80;
            var randomIndexes = new BuilderPasswordGeneratorRandomIndexes(passwordLength, lastIndexNumber);
            int expected = passwordLength;

            // Act
            IList<int> generatedRandomIndexes = randomIndexes.GetRandomIndexes().ToList();

            // Assert
            Assert.AreEqual(expected, generatedRandomIndexes.Count);
        }

        [TestMethod]
        public void GetRandomIndexes_AreAllIndexesInRange()
        {
            // Arrange
            int passwordLength = 20;
            int lastIndexNumber = 80;
            var randomIndexes = new BuilderPasswordGeneratorRandomIndexes(passwordLength, lastIndexNumber);
            int expected = lastIndexNumber;

            // Act
            IEnumerable<int> generatedRandomIndexes = randomIndexes.GetRandomIndexes();

            // Assert
            foreach (var generatedRandomIndex in generatedRandomIndexes)
            {
                Assert.IsTrue(generatedRandomIndex < expected);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void GetRandomIndexes_IsAmmountOfIndexesNegative_Throws()
        {
            // Arrange
            int passwordLength = -20;
            int lastIndexNumber = 80;
            var randomIndexes = new BuilderPasswordGeneratorRandomIndexes(passwordLength, lastIndexNumber);
            int expected = 0;

            // Act
            IList<int> generatedRandomIndexes = randomIndexes.GetRandomIndexes().ToList();

            // Assert
            // is handled by ExpectedException
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GetRandomIndexes_AreAllIndexesNegative_Throws()
        {
            // Arrange
            int passwordLength = 20;
            int lastIndexNumber = -80;
            var randomIndexes = new BuilderPasswordGeneratorRandomIndexes(passwordLength, lastIndexNumber);
            int expected = 0;

            // Act
            IEnumerable<int> generatedRandomIndexes = randomIndexes.GetRandomIndexes();

            // Assert
            // is handled by ExpectedException
        }
    }
}
