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
            const string expected = "h";
            
            //Act
            var actual = ModifyString.Modify("h");
            
            //Assert
            Assert.AreEqual(expected, actual);        
        }

        [Test]
        public void Should_Return_mommy_When_Given_a()
        {
            //Arrange
            const string expected = "mommy";
            
            //Act
            var actual = ModifyString.Modify("a");
            
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Should_Return_mommy_When_Given_vowel()
        {
            //Arrange
            const string expected = "mommy";

            foreach (var vowel in "aeiou")
            {
                //Act
                var actual = ModifyString.Modify(vowel.ToString());
                
                //Assert
                Assert.AreEqual(expected,actual);
            }
        }

        [Test]
        public void Should_Modify_When_Vowels_Greater_Than_30_Percentage()
        {
            //Arrange
            const string expected = "shmommy";
            
            //Act
            var actual = ModifyString.Modify("she");
            
            //Assert
            Assert.AreEqual(expected,actual);
        }
    }
}