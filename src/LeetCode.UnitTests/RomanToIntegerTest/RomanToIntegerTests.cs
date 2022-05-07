using NUnit.Framework;

namespace LeetCode.UnitTests
{
    public class RomanToIntegerTests
    {
        [Test]
        public void Test1()
        {
            //SETUP

            
            //TEST
            var result = new RomanToIntegerProblem().RomanToInt("III");

            //VALIDATE
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void Test2()
        {
            //SETUP

            
            //TEST
            var result = new RomanToIntegerProblem().RomanToInt("LVIII");

            //VALIDATE
            Assert.That(result, Is.EqualTo(58));
        }

        [Test]
        public void Test3()
        {
            //SETUP

            
            //TEST
            var result = new RomanToIntegerProblem().RomanToInt("MCMXCIV");

            //VALIDATE
            Assert.That(result, Is.EqualTo(1994));
        }

        [Test]
        public void Test4()
        {
            //SETUP

            
            //TEST
            var result = new RomanToIntegerProblem().RomanToInt("XLIX");

            //VALIDATE
            Assert.That(result, Is.EqualTo(49));
        }
    }
}