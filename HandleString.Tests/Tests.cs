using System;
using NUnit.Framework;
using HandleString;

namespace HandleString.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Should_Return_h_When_Given_h()
        {
            //Arrange
            var expected = "h";
            
            //Act
            var actual = MommifyString.Mommify("h");
            
            //Assert
            Assert.AreEqual(expected, actual);        
        }

        [Test]
        public void Should_Return_mommy_When_Given_a()
        {
            //Arrange
            var expected = "mommy";
            
            //Act
            var actual = MommifyString.Mommify("a");
            
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}