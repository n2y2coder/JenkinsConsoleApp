using System;
using Xunit;

namespace JenkinsConsoleAppTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var c1 = new JenkinsConsoleApp.MyClass();
            Assert.Equal("1", c1.GetData());
        }
    }
}
