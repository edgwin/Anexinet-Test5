using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test5.Test
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void GetExpectedString()
        {
            //Arrange
            var input = "abbbccaa";
            var expected = "1a3b2c2a";
            //Act
            var result = Program.process(input);
            //Assert
            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void GetNoneExpectedString()
        {
            //Arrange
            var input = "abbbccaa";
            var expected = "2a3b2c2a";
            //Act
            var result = Program.process(input);
            //Assert
            Assert.AreNotEqual(expected, result);

        }

        [TestMethod]
        public void InvalidInput()
        {
            //Arrange
            var input = "";
            //Act
            var result = Program.process(input);
            //Assert
            Assert.IsTrue(result == "Invalid input");

        }
    }
}
