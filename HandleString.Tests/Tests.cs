﻿using System;
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
            var actual = MommifyString.mommify("h");
            
            //Assert
            Assert.AreEqual(expected, actual);
            
        }


    }
}