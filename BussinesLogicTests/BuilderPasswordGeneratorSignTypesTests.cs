using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinesLogic;
using DataServices.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BussinesLogicTests
{
    [TestClass]
    public class BuilderPasswordGeneratorSignTypesTests
    {
        [TestMethod]
        public void CompareSignTypeNameWithCheckBox_NamesAreEqual_CorrectCompare()
        {
            // Arrange
            string checkBoxName = "checkBoxSmallLetters";
            string signTypeName = "SmallLetters";
            var signTypes = new BuilderPasswordGeneratorSignTypes();
            bool expected = true;

            // Act
            bool actual = signTypes.CompareSignTypeNameWithCheckBox(checkBoxName, signTypeName);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CompareSignTypeNameWithCheckBox_SignTypeNameIsWrong_DifferentNames()
        {
            // Arrange
            string checkBoxName = "checkBoxSmallLetters";
            string signTypeName = "randomWrongName";
            var signTypes = new BuilderPasswordGeneratorSignTypes();
            bool expected = false;

            // Act
            bool actual = signTypes.CompareSignTypeNameWithCheckBox(checkBoxName, signTypeName);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CompareSignTypeNameWithCheckBox_CheckBoxNameIsWrong_DifferentNames()
        {
            // Arrange
            string checkBoxName = "checkBoxRandomWrongName";
            string signTypeName = "SmallLetters";
            var signTypes = new BuilderPasswordGeneratorSignTypes();
            bool expected = false;

            // Act
            bool actual = signTypes.CompareSignTypeNameWithCheckBox(checkBoxName, signTypeName);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void CompareSignTypeNameWithCheckBox_SignTypeNameIsNull_ExceptionThrown()
        {
            // Arrange
            string checkBoxName = "checkBoxSmallLetters";
            string signTypeName = null;
            var signTypes = new BuilderPasswordGeneratorSignTypes();

            // Act
            bool actual = signTypes.CompareSignTypeNameWithCheckBox(checkBoxName, signTypeName);

            // Assert
            // is handled by ExpectedException
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void CompareSignTypeNameWithCheckBox_CheckBoxNameIsNull_ExceptionThrown()
        {
            // Arrange
            string checkBoxName = null;
            string signTypeName = "SmallLetters";
            var signTypes = new BuilderPasswordGeneratorSignTypes();

            // Act
            bool actual = signTypes.CompareSignTypeNameWithCheckBox(checkBoxName, signTypeName);

            // Assert
            // is handled by ExpectedException
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void CompareSignTypeNameWithCheckBox_CheckBoxNameAndSignTypeNameAreNull_ExceptionThrown()
        {
            // Arrange
            string checkBoxName = null;
            string signTypeName = null;
            var signTypes = new BuilderPasswordGeneratorSignTypes();

            // Act
            bool actual = signTypes.CompareSignTypeNameWithCheckBox(checkBoxName, signTypeName);

            // Assert
            // is handled by the ExpectedException 
        }

        [TestMethod]
        public void GetSignTypeNameByNumber_NumberFromSignTypesRange_CorrectSignTypeName()
        {
            // Arrange
            int smallLetters = 0;
            SignTypes expectedSignType = SignTypes.SmallLetters;
            string expectedSignTypeName = expectedSignType.ToString();
            var signTypes = new BuilderPasswordGeneratorSignTypes();

            // Act
            string actualSignTypeName = signTypes.GetSignTypeNameByNumber(smallLetters);

            // Assert
            Assert.AreEqual(expectedSignTypeName, actualSignTypeName);
        }

        [TestMethod]
        public void GetSignTypeNameByNumber_OthersNumbersInSignTypeRange_DifferentSignTypeNames()
        {
            // Arrange
            int capitalLetters = 1;
            SignTypes expectedSignType = SignTypes.SmallLetters;
            string expectedSignTypeName = expectedSignType.ToString();
            var signTypes = new BuilderPasswordGeneratorSignTypes();

            // Act
            string actualSignTypeName = signTypes.GetSignTypeNameByNumber(capitalLetters);

            // Assert
            Assert.AreNotEqual(expectedSignType, actualSignTypeName);
        }

        [TestMethod]
        public void GetSignTypeNameByNumber_NegativeNumberOutOfSignTypeRange_WrongSignTypeName()
        {
            // Arrange
            int negativeNumber = -1;
            SignTypes expectedSignType = SignTypes.SmallLetters;
            string expectedSignTypeName = expectedSignType.ToString();
            var signTypes = new BuilderPasswordGeneratorSignTypes();

            // Act
            string actualSignTypeName = signTypes.GetSignTypeNameByNumber(negativeNumber);

            // Assert
            Assert.AreNotEqual(expectedSignTypeName, actualSignTypeName);
        }

        [TestMethod]
        public void GetSignTypeNameByNumber_PositiveNumberOutOfSignTypeRange_WrongSignTypeName()
        {
            // Arrange
            int numberOutOfRange = 50;
            SignTypes expectedSignType = SignTypes.SmallLetters;
            string expectedSignTypeName = expectedSignType.ToString();
            var signTypes = new BuilderPasswordGeneratorSignTypes();

            // Act
            string actualSignTypeName = signTypes.GetSignTypeNameByNumber(numberOutOfRange);

            // Assert
            Assert.AreNotEqual(expectedSignTypeName, actualSignTypeName);
        }

        [TestMethod]
        public void GetSortedSignTypes_6SignTypesAndCheckBoxSmallLettersWithTrueValue_CorrectSort()
        {
            // Arrange
            int signTypeToSortCount = 6;
            bool[] signTypesToSort = new bool[signTypeToSortCount];
            string checkBoxSignTypeName = "checkBoxSmallLetters";
            bool checkBoxSignTypeValue = true;
            var signTypes = new BuilderPasswordGeneratorSignTypes();
            bool[] expectedSignTypesToSort = new bool[] {true, false, false, false, false, false};

            // Act
            signTypesToSort = signTypes.GetSortedSignTypes(ref signTypesToSort, signTypeToSortCount,
                checkBoxSignTypeName, checkBoxSignTypeValue);

            // Assert
            CollectionAssert.AreEqual(expectedSignTypesToSort, signTypesToSort);
        }

        [TestMethod]
        public void GetSortedSignTypes_6SignTypesAndCheckBoxSpecialSignsWithTrueValue_CorrectSort()
        {
            // Arrange
            int signTypeToSortCount = 6;
            bool[] signTypesToSort = new bool[signTypeToSortCount];
            string checkBoxSignTypeName = "checkBoxSpecialSigns";
            bool checkBoxSignTypeValue = true;
            var signTypes = new BuilderPasswordGeneratorSignTypes();
            bool[] expectedSignTypesToSort = new bool[] { false, false, false, false, true, false };

            // Act
            signTypesToSort = signTypes.GetSortedSignTypes(ref signTypesToSort, signTypeToSortCount,
                checkBoxSignTypeName, checkBoxSignTypeValue);

            // Assert
            CollectionAssert.AreEqual(expectedSignTypesToSort, signTypesToSort);
        }

        [TestMethod]
        public void GetSortedSignTypes_6SignTypesWithTrueValuesAndWrongCheckBoxNameWithFalseValue_CorrectSort()
        {
            // Arrange
            int signTypeToSortCount = 6;
            bool[] signTypesToSort = new bool[] { true, true, true, true, true, true };
            string checkBoxSignTypeName = "checkBoxWrongName";
            bool checkBoxSignTypeValue = false;
            var signTypes = new BuilderPasswordGeneratorSignTypes();
            bool[] expectedSignTypesToSort = new bool[] { true, true, true, true, true, true };

            // Act
            signTypesToSort = signTypes.GetSortedSignTypes(ref signTypesToSort, signTypeToSortCount,
                checkBoxSignTypeName, checkBoxSignTypeValue);

            // Assert
            CollectionAssert.AreEqual(expectedSignTypesToSort, signTypesToSort);
        }

        [TestMethod]
        public void GetSortedSignTypes_2SignTypesWithTrueValuesAndCheckBoxDigitsWithFalseValue_CorrectSort()
        {
            // Arrange
            int signTypeToSortCount = 2;
            bool[] signTypesToSort = new bool[] { true, true };
            string checkBoxSignTypeName = "checkBoxDigits";
            bool checkBoxSignTypeValue = false;
            var signTypes = new BuilderPasswordGeneratorSignTypes();
            bool[] expectedSignTypesToSort = new bool[] { true, true };

            // Act
            signTypesToSort = signTypes.GetSortedSignTypes(ref signTypesToSort, signTypeToSortCount,
                checkBoxSignTypeName, checkBoxSignTypeValue);

            // Assert
            CollectionAssert.AreEqual(expectedSignTypesToSort, signTypesToSort);
        }


    }
}
