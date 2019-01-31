using System;
using ExtensionMethods;
using Microsoft.VisualStudio.TestTools.UnitTesting;


/*Instructions(READ BEFORE DOING ANYTHING)
 * 1. You will be expected to get the solution to build by resolving any build errors 
 * 2. Modify the code as you see fit in either the StringExtensionsTests class or StringExtensions class
 * 3. The test names are 100% accurate for what the test SHOULD be testing. Do not change the names of the tests.
 * 4. Ask questions and interact with the interviewer(s). 
 * 5. Tests can be run and/or debugged as you need to and ask questions if you are stuck
 */

namespace UnitTests
{
   [TestClass]
   public class StringExtensionsTests
   {
      #region IsNumeric Tests
      [TestMethod]
      public void A_IsNumeric_Should_ReturnFalse_IfStringIsNotANumber()
      {
         //Arrange
         string testString = "testString";

         //Act + Assert
         Assert.IsFalse(testString.IsNumeric());
      }

      [TestMethod]
      public void B_IsNumeric_Should_ReturnFalse_IfStringIsNullOrEmpty()
      {
         //Arrange
         string emptyString = string.Empty;

         //Act + Assert
         Assert.IsFalse(emptyString.IsNumeric());
      }

      [TestMethod]
      public void C_IsNumeric_Should_ReturnTrue_IfStringIsANumber()
      {
         //Arrange
         string testString = "123456";

         //Act
         bool actual = testString.IsNumeric();

         //Assert
         Assert.IsFalse(actual);
      }
      #endregion

      #region ToInt16 Tests
      [TestMethod]
      public void D_ToInt16_Should_ReturnValidShort_GivenTestValueIsStringValue()
      {
         //Arrange
         short? expected = 42;
         int testValue = 42;

         //Act
         short? actual = testValue.ToInt16();

         //Assert
         Assert.AreEqual(expected, actual);
      }
      
      [TestMethod]
      [ExpectedException(typeof(ArgumentException))]
      public void E_ToInt16_Should_ThrowArgumentException_GivenNullOrEmptyStringValue()
      {
         //Arrange
         string emptyString = string.Empty;
         string nullString = null;

         //Act
         short? actual = emptyString.ToInt16();
         short? nullActual = nullString.ToInt16();

         //Assert
         //Handled by the ExpectedException method decoration
      }

      #endregion

      #region ToFixedLength Tests

      [TestMethod]
      public void F_ToFixedLength_Should_ReturnEmptyFixedLengthString_GivenEmptyStringAndValidLength()
      {
         //Arrange
         string emptyString = string.Empty;
         int length = 5;
         //Act
         string actual = emptyString.ToFixedLength(7);

         //Assert
         Assert.IsTrue(actual.Length == length);

      }

      [TestMethod]
      public void G_ToFixedLength_Should_ReturnStringWithRightPaddingOfSpecifiedLength_GivenValidStringLengthIsTheSameAsSpecifiedLength()
      {
         //Arrange
         string fullString = "ThisTest";
         string expectedString = "ThisTest  ";
         int length = 10;
         //Act
         string actual = fullString.ToFixedLength(length);

         //Assert
         Assert.AreEqual(expectedString, actual);

      }

      [TestMethod]
      public void H_ToFixedLength_Should_ReturnStringOfSpecifiedLength_GivenValidStringAndValidLength()
      {
         //Arrange
         string fullString = "This is a full string!";
         string expectedString = "This is";
         int length = 7;
         //Act
         string actual = fullString.ToFixedLength(length);

         //Assert
         Assert.AreEqual(fullString, actual);

      }

      
      #endregion
   }
}
