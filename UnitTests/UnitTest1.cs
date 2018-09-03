using System;
using Xunit;

namespace UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void FailingTest()
        {
            Assert.NotEqual(3, 2);
        }

        [Fact]
        public void PassingTest()
        {
            Assert.Equal(2, 2);
        }
    }
}
