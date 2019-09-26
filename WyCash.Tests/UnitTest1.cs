using System;
using WyCash.Lib;
using Xunit;

namespace WyCash.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestMultiplication()
        {
            Dollar five = new Dollar(5);
            Dollar product = five.Times(2);
            Assert.Equal(10, product.amount);
            product= five.Times(3);
            Assert.Equal(15, product.amount);
        }
    }
}
