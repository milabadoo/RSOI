using System;
using Xunit;
using RSOIlab1.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("1")]
        [InlineData("2")]
        public void Test1(string str)
        {
            ValuesController vs = new ValuesController();
            var actionResult = vs.Get(str);
            String result = actionResult.Value;
            Assert.Equal(str, result);
           
        }

        [Theory]
        [InlineData(1,2)]
        [InlineData(10,555)]
        public void Test2(int a, int b)
        {
            ValuesController vs = new ValuesController();
            var actionResult = vs.Get(a,b);
            var result = actionResult.Value;
            Assert.Equal("[\"Hello world!\"]", result.ToString());

        }
    }
}
