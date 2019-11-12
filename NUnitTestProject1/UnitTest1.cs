using NUnit.Framework;
using ConsoleApp1;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void Test_Calculator_Add()
        {

            Calculator calc = new Calculator();
            int answer = calc.Add(4, 5);
            Assert.AreEqual(9, answer);
        }

        [Test]
        public void Test_Calculator_Add_DeliberateFail()
        {
            // Designed to fail
            Calculator calc = new Calculator();
            int answer = calc.Add(8, 5);
            Assert.AreEqual(9, answer);
        }
    }
}