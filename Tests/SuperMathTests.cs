using NUnit.Framework;
using System;
using Lib;

namespace Tests
{
    public class SuperMathTests
    {
        [Test]
        public static void SuperTest()
        {
            var result = SuperDuperMath.MultiplyByTwo(2);
            Assert.AreEqual(4, result, "Failed to multiply by two");
        }
    }
}