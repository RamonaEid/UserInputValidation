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
            const string inputString = "";
            const bool expected = false;

            var actual = Validator.IsValid(inputString);

            Assert.AreEqual(expected, actual);
            Assert.IsNotNull(expected);
        }

        [TestMethod]
        [TestCategory("Sad")]
        public void IsValid_LessThanLengthOfFive_ReturnsFalse()
        {
            const string inputString = "1234";
            const bool expected = false;

            var actual = Validator.IsValid(inputString);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("Sad")]
        public void IsValid_MoreThanLengthOfTwelve_ReturnsFalse()
        {
            const string inputString = "1234567890123";
            const bool expected = false;

            var actual = Validator.IsValid(inputString);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("Sad")]
        public void IsValid_WithNonAlphaNumeric_ReturnsFalse()
        {
            var inputString = "_abc1";
            const bool expected = false;

            var actual = Validator.IsValid(inputString);

            Assert.AreEqual(expected, actual);
            
            inputString = "123@a";
            actual = Validator.IsValid(inputString);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("Sad")]
        public void IsValid_WithAllLetters_ReturnsFalse()
        {
            const string inputString = "abcde";
            const bool expected = false;

            var actual = Validator.IsValid(inputString);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("Sad")]
        public void IsValid_WithAllNumbers_ReturnsFalse()
        {
            const string inputString = "12345";
            const bool expected = false;

            var actual = Validator.IsValid(inputString);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("Happy")]
        public void IsValid_WithOneLetterAndNumbers_ReturnsTrue()
        {
            const string inputString = "a1234";
            const bool expected = true;

            var actual = Validator.IsValid(inputString);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("Happy")]
        public void IsValid_WithOneCapLetterAndNumbers_ReturnsTrue()
        {
            const string inputString = "A1234";
            const bool expected = true;

            var actual = Validator.IsValid(inputString);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("Happy")]
        public void IsValid_WithOneNumberAndLetters_ReturnsTrue()
        {
            const string inputString = "1abcd";
            const bool expected = true;

            var actual = Validator.IsValid(inputString);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("Happy")]
        public void IsValid_WithOneNumberAndCapLetters_ReturnsTrue()
        {
            const string inputString = "1ABCD";
            const bool expected = true;

            var actual = Validator.IsValid(inputString);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("Sad")]
        public void IsValid_WithTwoRepeatedBeginningLettersAndNumber_ReturnsFalse()
        {
            const string inputString = "aabc1";
            const bool expected = false;

            var actual = Validator.IsValid(inputString);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("Sad")]
        public void IsValid_WithTwoRepeatedBeginningCapLettersAndNumber_ReturnsFalse()
        {
            const string inputString = "AAbc1";
            const bool expected = false;

            var actual = Validator.IsValid(inputString);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("Sad")]
        public void IsValid_WithTwoRepeatedMiddleLetersAndNumber_ReturnsFalse()
        {
            const string inputString = "abbc1";
            const bool expected = false;

            var actual = Validator.IsValid(inputString);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("Sad")]
        public void IsValid_WithTwoRepeatedCapMiddleLetterAndNumber_ReturnsFalse()
        {
            const string inputString = "aBBc1";
            const bool expected = false;

            var actual = Validator.IsValid(inputString);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("Sad")]
        public void IsValid_WithTwoRepeatedLastLettersAndNumber_ReturnsFalse()
        {
            const string inputString = "ab1cc";
            const bool expected = false;

            var actual = Validator.IsValid(inputString);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("Sad")]
        public void IsValid_WithTwoRepeatedCapLastLettersandNumber_ReturnsFalse()
        {
            const string inputString = "ab1CC";
            const bool expected = false;

            var actual = Validator.IsValid(inputString);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("Sad")]
        public void IsValid_WithTwoRepeatedBeginninNumbersAndLetters_ReturnsFalse()
        {
            const string inputString = "11abc";
            const bool expected = false;

            var actual = Validator.IsValid(inputString);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("Sad")]
        public void IsValid_WithTwoRepeatedMiddleNumbersAndLetters_ReturnsFalse()
        {
            const string inputString = "a11bc";
            const bool expected = false;

            var actual = Validator.IsValid(inputString);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("Sad")]
        public void IsValid_WithTwoRepeatedLastNumbersAndLetters_ReturnsFalse()
        {
            const string inputString = "abc11";
            const bool expected = false;

            var actual = Validator.IsValid(inputString);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("Sad")]
        public void IsValid_WithThreeBeginningRepeatedLettersAndNumber_ReturnsFalse()
        {
            const string inputString = "aaab1";
            const bool expected = false;

            var actual = Validator.IsValid(inputString);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("Sad")]
        public void IsValid_WithThreeCapBeginningRepeatedLettersAndNumber_ReturnFalse()
        {
            const string inputString = "AAAb1";
            const bool expected = false;

            var actual = Validator.IsValid(inputString);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("Sad")]
        public void IsValid_WithThreeMiddleRepeatedLettersAndNumber_ReturnsFalse()
        {
            const string inputString = "abbb1";
            const bool expected = false;

            var actual = Validator.IsValid(inputString);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("Sad")]
        public void IsValid_WithThreeRepeatedLastLettersAndNumber_ReturnsFalse()
        {
            const string inputString = "a1BBB";
            const bool expected = false;

            var actual = Validator.IsValid(inputString);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("Sad")]
        public void IsValid_WithThreeRepeatedBeginningNumbersAndLetter_ReturnsFalse()
        {
            const string inputString = "1112a";
            const bool expected = false;

            var actual = Validator.IsValid(inputString);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("Sad")]
        public void IsValid_WithThreeRepeatedMiddleNumbersAndLetter_ReturnsFalse()
        {
            const string inputString = "a1112";
            const bool expected = false;

            var actual = Validator.IsValid(inputString);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("Sad")]
        public void IsValid_WithThreeRepeatedLastNumbersAndLetter_ReturnsFalse()
        {
            const string inputString = "ab111";
            const bool expected = false;

            var actual = Validator.IsValid(inputString);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("Sad")]
        public void IsValid_WithLongRepeatedLettersAndNumbers_ReturnsFalse()
        {
            const string inputString = "zabcdabcd123";
            const bool expected = false;

            var actual = Validator.IsValid(inputString);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("Sad")]
        public void IsValid_WithLongRepeatedNumbersAndLetters_ReturnFalse()
        {
            const string inputString = "z1234512345a";
            const bool expected = false;

            var actual = Validator.IsValid(inputString);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("Happy")]
        public void IsValid_WithNonSequentialRepeatedLettersAndNumber_ReturnsTrue()
        {
            const string inputString = "abcbacdedfe1";
            const bool expected = true;

            var actual = Validator.IsValid(inputString);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("Happy")]
        public void IsValid_WithLongSequentialNonAdjacentLettersAndNumbers_ReturnsTrue()
        {
            const string inputString = "zabcdyabcd12";
            const bool expected = true;

            var actual = Validator.IsValid(inputString);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("Happy")]
        public void IsValid_WithLongSequentialNonAdjecentNumbersAndLetters_ReturnsTrue()
        {
            const string inputString = "0123491234ab";
            const bool expected = true;

            var actual = Validator.IsValid(inputString);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("Happy")]
        public void IsValid_WithStartNumberAndLettersLengthOfTwelve_ReturnsTrue()
        {
            const string inputString = "1a2b3c4d5e6f";
            const bool expected = true;

            var actural = Validator.IsValid(inputString);

            Assert.AreEqual(expected, actural);
        }

        [TestMethod]
        [TestCategory("Happy")]
        public void IsValid_WithStartLetterAndNumbersLengthOfTwelve_ReturnsTrue()
        {
            const string inputString = "a1b2c3d4e5f6";
            const bool expected = true;

            var actual = Validator.IsValid(inputString);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("Happy")]
        public void IsValid_WithMixedCaseLettersAndNumberLengthOfTwelve_ReturnsTrue()
        {
            const string inputString = "WeRtYuOpAsD1";
            const bool expected = true;

            var actual = Validator.IsValid(inputString);

            Assert.AreEqual(expected, actual);
        }

    }
}
