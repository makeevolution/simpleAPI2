using System;
using Xunit;
using SimpleAPI.Pages;

namespace SimpleAPI.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            string returnValue = IndexModel.Get();
            Assert.Equal("Jackson lee", returnValue);
        }
    }
}
