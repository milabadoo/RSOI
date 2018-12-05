using System;
using Xunit;
using RSOIlab1.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            ValuesController vs = new ValuesController();
            var actionResult = vs.Get("2");
            String result = actionResult.Value;
            Assert.Equal("2", result);
           
        }
    }
}
