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
        public void Should_Return_m_When_Given_m()
        {
            //Arrange
            var expected = "m";
            
            //Act
            var actual = MommifyString.Mommify("m");
            
            //Assert
            Assert.AreEqual(expected, actual);
        }


    }
}