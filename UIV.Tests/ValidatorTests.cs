using Microsoft.VisualStudio.TestTools.UnitTesting;
using UIV.BL;

namespace UIV.Tests
{
    [TestClass]
    public class ValidatorTests
    {
        [TestMethod]
        [TestCategory("Sad")]
        public void IsValid_WithEmpty_ReturnsFalse()
        {
            AssertAreEqual("", false);
        }

        [TestMethod]
        [TestCategory("Sad")]
        public void IsValid_LessThanLengthOfFive_ReturnsFalse()
        {
            AssertAreEqual("1234", false);
        }

        [TestMethod]
        [TestCategory("Sad")]
        public void IsValid_MoreThanLengthOfTwelve_ReturnsFalse()
        {
            AssertAreEqual("1234567890123", false);
        }

        [TestMethod]
        [TestCategory("Sad")]
        public void IsValid_WithNonAlphaNumeric_ReturnsFalse()
        {
            AssertAreEqual("_abc1", false);
            
            AssertAreEqual("123@a", false);
        }

        [TestMethod]
        [TestCategory("Sad")]
        public void IsValid_WithAllLetters_ReturnsFalse()
        {
            AssertAreEqual("abcde", false);
        }

        [TestMethod]
        [TestCategory("Sad")]
        public void IsValid_WithAllNumbers_ReturnsFalse()
        {
            AssertAreEqual("12345", false);
        }

        [TestMethod]
        [TestCategory("Happy")]
        public void IsValid_WithOneLetterAndNumbers_ReturnsTrue()
        {
            AssertAreEqual("a1234", true);
        }

        [TestMethod]
        [TestCategory("Happy")]
        public void IsValid_WithOneCapLetterAndNumbers_ReturnsTrue()
        {
            AssertAreEqual("A1234", true);
        }

        [TestMethod]
        [TestCategory("Happy")]
        public void IsValid_WithOneNumberAndLetters_ReturnsTrue()
        {
            AssertAreEqual("1abcd", true);
        }

        [TestMethod]
        [TestCategory("Happy")]
        public void IsValid_WithOneNumberAndCapLetters_ReturnsTrue()
        {
            AssertAreEqual("1ABCD", true);
        }

        [TestMethod]
        [TestCategory("Sad")]
        public void IsValid_WithTwoRepeatedBeginningLettersAndNumber_ReturnsFalse()
        {
            AssertAreEqual("aabc1", false);
        }

        [TestMethod]
        [TestCategory("Sad")]
        public void IsValid_WithTwoRepeatedBeginningCapLettersAndNumber_ReturnsFalse()
        {
            AssertAreEqual("AAbc1", false);
        }

        [TestMethod]
        [TestCategory("Sad")]
        public void IsValid_WithTwoRepeatedMiddleLetersAndNumber_ReturnsFalse()
        {
            AssertAreEqual("abbc1", false);
        }

        [TestMethod]
        [TestCategory("Sad")]
        public void IsValid_WithTwoRepeatedCapMiddleLetterAndNumber_ReturnsFalse()
        {
            AssertAreEqual("aBBc1", false);
        }

        [TestMethod]
        [TestCategory("Sad")]
        public void IsValid_WithTwoRepeatedLastLettersAndNumber_ReturnsFalse()
        {
            AssertAreEqual("ab1cc", false);
        }

        [TestMethod]
        [TestCategory("Sad")]
        public void IsValid_WithTwoRepeatedCapLastLettersandNumber_ReturnsFalse()
        {
            AssertAreEqual("ab1CC", false);
        }

        [TestMethod]
        [TestCategory("Sad")]
        public void IsValid_WithTwoRepeatedBeginninNumbersAndLetters_ReturnsFalse()
        {
            AssertAreEqual("11abc", false);
        }

        [TestMethod]
        [TestCategory("Sad")]
        public void IsValid_WithTwoRepeatedMiddleNumbersAndLetters_ReturnsFalse()
        {
            AssertAreEqual("a11bc", false);
        }

        [TestMethod]
        [TestCategory("Sad")]
        public void IsValid_WithTwoRepeatedLastNumbersAndLetters_ReturnsFalse()
        {
            AssertAreEqual("abc11", false);
        }

        [TestMethod]
        [TestCategory("Sad")]
        public void IsValid_WithThreeBeginningRepeatedLettersAndNumber_ReturnsFalse()
        {
            AssertAreEqual("aaab1", false);
        }

        [TestMethod]
        [TestCategory("Sad")]
        public void IsValid_WithThreeCapBeginningRepeatedLettersAndNumber_ReturnFalse()
        {
            AssertAreEqual("AAAb1", false);
        }

        [TestMethod]
        [TestCategory("Sad")]
        public void IsValid_WithThreeMiddleRepeatedLettersAndNumber_ReturnsFalse()
        {
            AssertAreEqual("abbb1", false);
        }

        [TestMethod]
        [TestCategory("Sad")]
        public void IsValid_WithThreeRepeatedLastLettersAndNumber_ReturnsFalse()
        {
            AssertAreEqual("a1BBB", false);
        }

        [TestMethod]
        [TestCategory("Sad")]
        public void IsValid_WithThreeRepeatedBeginningNumbersAndLetter_ReturnsFalse()
        {
            AssertAreEqual("1112a", false);
        }

        [TestMethod]
        [TestCategory("Sad")]
        public void IsValid_WithThreeRepeatedMiddleNumbersAndLetter_ReturnsFalse()
        {
            AssertAreEqual("a1112", false);
        }

        [TestMethod]
        [TestCategory("Sad")]
        public void IsValid_WithThreeRepeatedLastNumbersAndLetter_ReturnsFalse()
        {
            AssertAreEqual("ab111", false);
        }

        [TestMethod]
        [TestCategory("Sad")]
        public void IsValid_WithLongRepeatedLettersAndNumbers_ReturnsFalse()
        {
            AssertAreEqual("zabcdabcd123", false);
        }

        [TestMethod]
        [TestCategory("Sad")]
        public void IsValid_WithLongRepeatedNumbersAndLetters_ReturnFalse()
        {
            AssertAreEqual("z1234512345a", false);
        }

        [TestMethod]
        [TestCategory("Happy")]
        public void IsValid_WithNonSequentialRepeatedLettersAndNumber_ReturnsTrue()
        {
            AssertAreEqual("abcbacdedfe1", true);
        }

        [TestMethod]
        [TestCategory("Happy")]
        public void IsValid_WithLongSequentialNonAdjacentLettersAndNumbers_ReturnsTrue()
        {
            AssertAreEqual("zabcdyabcd12", true);
        }

        [TestMethod]
        [TestCategory("Happy")]
        public void IsValid_WithLongSequentialNonAdjecentNumbersAndLetters_ReturnsTrue()
        {
            AssertAreEqual("0123491234ab", true);
        }

        [TestMethod]
        [TestCategory("Happy")]
        public void IsValid_WithStartNumberAndLettersLengthOfTwelve_ReturnsTrue()
        {
            AssertAreEqual("1a2b3c4d5e6f", true);
        }

        [TestMethod]
        [TestCategory("Happy")]
        public void IsValid_WithStartLetterAndNumbersLengthOfTwelve_ReturnsTrue()
        {
            AssertAreEqual("a1b2c3d4e5f6", true);
        }

        [TestMethod]
        [TestCategory("Happy")]
        public void IsValid_WithMixedCaseLettersAndNumberLengthOfTwelve_ReturnsTrue()
        {
            AssertAreEqual("WeRtYuOpAsD1", true);
        }


        private static void AssertAreEqual(string inputString, bool expected)
        {
            var actual = Validator.IsValid(inputString);

            Assert.AreEqual(expected, actual);
        }
    }
}
