using GitHookTestConsole;
using System;
using Xunit;

namespace GitHookTest.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            string expectedResult = "HopScotch";

            Text txt = new Text();
            string result = txt.Concat("Hop", "Scotch");

            Assert.Equal(expectedResult, result);
        }
    }
}