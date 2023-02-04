using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using MyBank;

namespace MyBankTest
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void MyBank_Register_Valid()
        {
            Customer c1 = new Customer(1,"David","david@gmail.com","1234");
            String expected = "David";
            String actual = c1.name;
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void MyBank_Register_InValid()
        {
            Customer c1 = new Customer(1, "David", "david@gmail.com", "1234");
            String expected = "Sam";
            String actual = c1.name;
            Assert.AreNotEqual(expected, actual);
        }
        [Test]
        public void MyBank_Login_Valid()
        {
            Customer c1 = new Customer(1, "David", "david@gmail.com", "1234");
            String expected = c1.name;
            Customer c2 = c1.login("david@gmail.com", "1234");
            String actual = c2.name; 
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void MyBank_Login_InValid()
        {
            Customer c1 = new Customer(1, "David", "david@gmail.com", "1234");
            String expected = c1.name;
            Customer c2 = c1.login("david@gmail.com", "abcd");
            String actual = c2.name;
            Assert.AreNotEqual(expected, actual);
        }

    }
}
