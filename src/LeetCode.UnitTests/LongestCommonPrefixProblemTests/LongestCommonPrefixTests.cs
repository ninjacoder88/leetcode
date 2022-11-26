using NUnit.Framework;

namespace LeetCode.UnitTests
{
    public class LongestCommonPrefixTests
    {
        public void Test1()
        {
            //TEST
            var result = new LongestCommonPrefixProblem().LongestCommonPrefix(new string[]{"flower", "flow", "flight"});

            //VALIDATE
            Assert.That(result, Is.EqualTo("fl"));
        }

        public void Test2()
        {
            //TEST
            var result = new LongestCommonPrefixProblem().LongestCommonPrefix(new string[]{"dog", "racecar", "car"});

            //VALIDATE
            Assert.That(result, Is.EqualTo(""));
        }

        public void Test3()
        {
            //TEST
            var result = new LongestCommonPrefixProblem().LongestCommonPrefix(new string[]{"abcde", "abcd", "abc"});

            //VALIDATE
            Assert.That(result, Is.EqualTo("abc"));
        }

        public void Test4()
        {
            //TEST
            var result = new LongestCommonPrefixProblem().LongestCommonPrefix(new string[]{"abcd", "abcde", "abc"});

            //VALIDATE
            Assert.That(result, Is.EqualTo("abc"));
        }

        public void Test5()
        {
            //TEST
            var result = new LongestCommonPrefixProblem().LongestCommonPrefix(new string[]{"abc", "abcde", "abcd"});

            //VALIDATE
            Assert.That(result, Is.EqualTo("abc"));
        }

        public void Test6()
        {
            //TEST
            var result = new LongestCommonPrefixProblem().LongestCommonPrefix(new string[]{"def", "abcd", "abcdef", "abcde"});

            //VALIDATE
            Assert.That(result, Is.EqualTo(""));
        }

        public void Test7()
        {
            //TEST
            var result = new LongestCommonPrefixProblem().LongestCommonPrefix(new string[]{"def", "de", "abcd", "abcdef", "abcde"});

            //VALIDATE
            Assert.That(result, Is.EqualTo(""));
        }
    }
}