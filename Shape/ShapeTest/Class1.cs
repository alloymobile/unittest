using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Shape;
namespace ShapeTest
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void Rectangle_Area_Valid() 
        {
            double expected = 200;
            Rectangle r1 = new Rectangle(20,10);
            double actual = r1.Area();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Rectangle_Perimeter_Valid()
        {
            double expected = 60;
            Rectangle r1 = new Rectangle(20, 10);
            double actual = r1.Perimeter();
            Assert.AreEqual(expected, actual);
        }
    }
}
