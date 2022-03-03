using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanNumbers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RomanNumbers.Tests
{
    [TestClass()]
    public class RomanNumberTests
    {
        [TestMethod()]
        public void Add()
        {
            //arrange
            var romanNumber = new RomanNumber(8);
            var romanNumber1 = new RomanNumber(1);
            var romanNumber2 = new RomanNumber(120);
            var expected1 = new RomanNumber(9);
            var expected2 = new RomanNumber(128);
            //act
            RomanNumber actual1 = romanNumber + romanNumber1;
            RomanNumber actual2 = romanNumber + romanNumber2;
            //assert
            Assert.AreEqual(expected1.ToString(), actual1.ToString());
            Assert.AreEqual(expected2.ToString(), actual2.ToString());

        }
        [TestMethod()]
        public void Sub()
        {
            //arrange
            var romanNumber = new RomanNumber(10);
            var romanNumber1 = new RomanNumber(1);
            var romanNumber2 = new RomanNumber(120);
            var expected = new RomanNumber(9);

            //act

            RomanNumber actual = romanNumber - romanNumber1;

            //assert
            Assert.AreEqual(expected.ToString(), actual.ToString());
            Assert.ThrowsException<RomanNumberException>(() => (romanNumber - romanNumber2));

        }
        [TestMethod()]
        public void Div()
        {
            var romanNumber = new RomanNumber(10);
            var romanNumber1 = new RomanNumber(2);
            var romanNumber2 = new RomanNumber(120);
            var expected = new RomanNumber(5);

            //act

            RomanNumber actual = romanNumber / romanNumber1;

            //assert
            Assert.AreEqual(expected.ToString(), actual.ToString());
            Assert.ThrowsException<RomanNumberException>(() => (romanNumber / romanNumber2));
        }
        [TestMethod()]
        public void Mul()
        {
            //arrange
            var romanNumber = new RomanNumber(8);
            var romanNumber1 = new RomanNumber(6);
            var romanNumber2 = new RomanNumber(12);
            var expected1 = new RomanNumber(48);
            var expected2 = new RomanNumber(96);
            //act
            RomanNumber actual1 = romanNumber * romanNumber1;
            RomanNumber actual2 = romanNumber * romanNumber2;
            //assert
            Assert.AreEqual(expected1.ToString(), actual1.ToString());
            Assert.AreEqual(expected2.ToString(), actual2.ToString());
        }

        [TestMethod()]
        public void ToStringTest()
        {
            //arrange
            RomanNumber romanNumber = new RomanNumber(1002);
            string expected = "MII";
            //act
            string actual = romanNumber.ToString();
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CloneTest()
        {
            //arrange
            RomanNumber romanNumber = new RomanNumber(5);
            RomanNumber expected = new RomanNumber(5);
            //act
            RomanNumber clone = (RomanNumber)romanNumber.Clone();
            //assert
            Assert.AreEqual(expected.ToString(), clone.ToString());
            Assert.AreNotSame(expected, clone);
        }


        [TestMethod()]
        public void CompareToTest()
        {
            //arrange
            RomanNumber romanNumber = new RomanNumber(10);
            RomanNumber romanNumber1 = new RomanNumber(10);
            const int expected = 0;
            //act
            int actual = romanNumber.CompareTo(romanNumber1);
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}