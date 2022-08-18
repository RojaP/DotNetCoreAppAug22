using DET_Batch1_MS_Aug22;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DET_Test_Project
{
    [TestClass]
    public class CircleTest
    {
        Circle myCircle;

        [TestMethod]
        public void TestArea()
        {
           var area= myCircle.Area();
            Assert.AreEqual( 60, area);

        }

        [TestMethod]
        public void TestDiameter()
        {
            var diameter = myCircle.Diameter();
            Assert.AreEqual(20, diameter);

        }
        [TestInitialize]
       public void Initialize()
        {
             myCircle = new Circle(10);
        }
    }
}