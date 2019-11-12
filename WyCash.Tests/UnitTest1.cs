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
            Money five = Money.CreateDollar(5);
            Assert.Equal(Money.CreateDollar(10), five.Times(2));
            Assert.Equal(Money.CreateDollar(15),  five.Times(3));
        }
        [Fact]
        public void TestEqulity()
        {
            Assert.True(Money.CreateDollar(5).Equals(Money.CreateDollar(5)));
            Assert.False(Money.CreateDollar(5).Equals(Money.CreateDollar(6)));
            Assert.True(Money.CreateFranc(5).Equals(Money.CreateFranc(5)));
            Assert.False(Money.CreateFranc(5).Equals(Money.CreateFranc(6)));
            Assert.False(Money.CreateFranc(5).Equals(Money.CreateDollar(5)));
        }
        [Fact]
        public void TestFrancMultiplication()
        {
            Money five = Money.CreateFranc(5);
            Assert.Equal(Money.CreateFranc(10), five.Times(2));
            Assert.Equal(Money.CreateFranc(15), five.Times(3));
        }
        //TODO:法郎兑美元2：1
        // 5美元* 2=10美元
        // 将amount定义为私有
        // doller有副作用吗(l连续相乘的时候amount会变化)
        // 钱必须为整数吗
        // 实现Equals函数
        // 实现GethashCode方法
        // 与空对象判等
        // 与非同类对象判等
        // 5瑞士法郎 * 2 = 10 瑞士法郎
    }
}
