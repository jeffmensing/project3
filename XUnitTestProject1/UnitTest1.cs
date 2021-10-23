using System;
using Xunit;
using System.Collections;
using FizzBuzzLib;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void check15Case()
        {
            Hashtable ht = new Hashtable();
            ht.Add(3, "Fizz");
            ht.Add(5, "Buzz");
            int z = 15;
            Class1 cl = new Class1();

            string result = cl.checkNumWordPair(z, ht);

            Assert.Contains("Fizz", result);
            Assert.Contains("Buzz", result);
        }
    }
}
