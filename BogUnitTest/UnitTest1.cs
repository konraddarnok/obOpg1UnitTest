using System;
using System.Security.Cryptography;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OPKonradKirkebjerg;


namespace BogUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void TestAuthorLength()
        {
            //Arrange
            Bog b1 = new Bog();

            //Act

            b1.Author = "A";
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestPageLength()
        {
            //Arrange
            Bog b2 = new Bog();
            //Act
            b2.Page = 200;
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestIsbn13()
        {
        //Arrage
        Bog b3 = new Bog();
        //Act
        b3.Isbn13 = "111111111111111";
        }




    }
}
