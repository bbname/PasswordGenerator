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
        public void GetSignTypeNameByNumber_OtherNumberAsParam_DifferentSignTypeNames()
        {
            // Arrange
            int smallLetters = 0;
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
        public void GetSignTypeNameByNumber_NegativeNumberAsParam_WrongSignTypeName()
        {
            // Arrange
            int smallLetters = 0;
            int negativeNumber = -1;
            SignTypes expectedSignType = SignTypes.SmallLetters;
            string expectedSignTypeName = expectedSignType.ToString();
            var signTypes = new BuilderPasswordGeneratorSignTypes();

            // Act
            string actualSignTypeName = signTypes.GetSignTypeNameByNumber(negativeNumber);

            // Assert
            Assert.AreNotEqual(expectedSignTypeName, actualSignTypeName);
        }


    }
}
