using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.UnitTests
{
    public class TwoSumTests
    {
        [Test]
        public void Test1()
        {
            //SETUP
            var nums = new int[4]{2,7,11,15};
            var target = 9;

            //TEST
            var result = new TwoSumProblem().TwoSum(nums, target);

            //VALIDATE
            Assert.That(result.ToList().SequenceEqual(new List<int>{0,1}));
        }

        [Test]
        public void Test2()
        {
            //SETUP
            var nums = new int[3]{3,2,4};
            var target = 6;

            //TEST
            var result = new TwoSumProblem().TwoSum(nums, target);

            //VALIDATE
            result.Dump();
            Assert.That(result.ToList().SequenceEqual(new List<int>{1,2}));
        }

        [Test]
        public void Test3()
        {
            //SETUP
            var nums = new int[2]{3,3};
            var target = 6;

            //TEST
            var result = new TwoSumProblem().TwoSum(nums, target);

            //VALIDATE
            Assert.That(result.ToList().SequenceEqual(new List<int>{0,1}));
        }
    }
}