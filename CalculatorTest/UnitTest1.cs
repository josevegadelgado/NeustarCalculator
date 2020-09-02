using CalculatorCore.Model;
using CalculatorCore.Operation;
using NUnit.Framework;

namespace CalculatorTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }


        [Test]
        public void Test_1()
        {
            var _operation = new Calculator();            
            _operation.Number1 = 3200; 
            _operation.Number2 = 800;
            Assert.AreEqual(_operation.Calculate(new Add()), 4000);
        }


        [Test]
        public void Test_2()
        {
            var _operation = new Calculator();
            _operation.Number1 = 50;
            _operation.Number2 = 50;
            Assert.AreEqual(_operation.Calculate(new Add()), 100);
        }

        [Test]
        public void Test_3()
        {
            var _operation = new Calculator();
            _operation.Number1 = -10;
            _operation.Number2 = 25;
            Assert.AreEqual(_operation.Calculate(new Add()), 15);
        }

        [Test]
        public void Test_4()
        {
            var _operation = new Calculator();
            _operation.Number1 = 10;
            _operation.Number2 = 1500;
            Assert.AreNotEqual(_operation.Calculate(new Add()), 0);
        }



    }
}