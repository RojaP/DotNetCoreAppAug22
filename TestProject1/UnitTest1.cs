using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication8;
namespace TestProject1
{
    [TestClass]
    public class UnitTestArithmeticOperations
    {
        [TestMethod]
        public void TestAdd()
        {
            ArithmeticOperations arithmeticOperations = new ArithmeticOperations();
            arithmeticOperations.Operand1 = 1;
            arithmeticOperations.Operand2 = 2;
            var result = arithmeticOperations.Add();
            Assert.AreEqual(3, result);

        }
        [TestMethod]
        public void TestSub()
        {
            ArithmeticOperations arithmeticOperations = new ArithmeticOperations();
            arithmeticOperations.Operand1 = 10;
            arithmeticOperations.Operand2 = 2;
            var result = arithmeticOperations.Sub();
            Assert.AreEqual(8, result);
        }
    }
}