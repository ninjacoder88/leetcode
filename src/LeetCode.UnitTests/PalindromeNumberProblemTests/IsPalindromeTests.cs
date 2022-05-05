using NUnit.Framework;

namespace LeetCode.UnitTests
{
    public class IsPalindromeTests
    {
        [Test]
        public void Test1()
        {
            //SETUP
            var x = 121;

            //TEST
            var result = new PalindromeNumberProblem().IsPalindrome(x);

            //VALIDATE
            Assert.That(result, Is.True);
        }

        [Test]
        public void Test2()
        {
            //SETUP
            var x = -121;

            //TEST
            var result = new PalindromeNumberProblem().IsPalindrome(x);

            //VALIDATE
            Assert.That(result, Is.False);
        }

        [Test]
        public void Test3()
        {
            //SETUP
            var x = 10;

            //TEST
            var result = new PalindromeNumberProblem().IsPalindrome(x);

            //VALIDATE
            Assert.That(result, Is.False);
        }

        [Test]
        public void Test4()
        {
            //SETUP
            var x = 10201;

            //TEST
            var result = new PalindromeNumberProblem().IsPalindrome(x);

            //VALIDATE
            Assert.That(result, Is.True);
        }

        [Test]
        public void Test5()
        {
            //SETUP
            var x = 102201;

            //TEST
            var result = new PalindromeNumberProblem().IsPalindrome(x);

            //VALIDATE
            Assert.That(result, Is.True);
        }

        [Test]
        public void Test6()
        {
            //SETUP
            var x = 10234201;

            //TEST
            var result = new PalindromeNumberProblem().IsPalindrome(x);

            //VALIDATE
            Assert.That(result, Is.False);
        }
    }
}