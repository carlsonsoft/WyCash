using System;
using System.Linq.Expressions;
using WyCash.Lib;
using Xunit;

namespace WyCash.Lib
{
}

namespace WyCash.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestMultiplication()
        {
            Money five = Money.Dollar(5);
            Assert.Equal(Money.Dollar(10), five.Times(2));
            Assert.Equal(Money.Dollar(15), five.Times(3));
        }

        [Fact]
        public void TestEqulity()
        {
            Assert.True(Money.Dollar(5).Equals(Money.Dollar(5)));
            Assert.False(Money.Dollar(5).Equals(Money.Dollar(6)));
            Assert.False(Money.Franc(5).Equals(Money.Dollar(5)));
        }

        [Fact]
        public void TestSimpleAddition()
        {
            Money five = Money.Dollar(5);
            IBankExpression result = five.Plus(five);
            Sum sum = (Sum) result;
            Assert.Equal(five, sum.Augend);
        }

        [Fact]
        public void TestReduceMoney()
        {
            var bank = new Bank();
            var result = bank.Reduce(Money.Dollar(1), "USD");
            Assert.Equal(Money.Dollar(1),result);
        }
        [Fact]
        public void TestReduceMoneyDifferentCurrency()
        {
            Bank bank = new Bank();
            bank.AddRate("CHF", "USD", 2);
            var result = bank.Reduce(Money.Franc(2),"USD");
            Assert.Equal(Money.Dollar(1),result);
        }

        [Fact]
        public void TestIdentityRate()
        {
            Assert.Equal(1,new Bank().Rate("USD","USD"));
        }

        [Fact]
        public void TestMixedAddition()
        {
            IBankExpression fiveBucks = Money.Dollar(5);
            IBankExpression tenFrancs = Money.Franc(10);
            var bank = new Bank();
            bank.AddRate("CHF","USD",2);
            var result = bank.Reduce(fiveBucks.Plus(tenFrancs), "USD");
            Assert.Equal(Money.Dollar(10),result);

        }
        [Fact]
        public void TestSumPlusMoney()
        {
            IBankExpression fiveBucks = Money.Dollar(5);
            IBankExpression tenFrancs = Money.Franc(10);
            var bank = new Bank();
            bank.AddRate("CHF","USD",2);
            IBankExpression sum = new Sum(fiveBucks,tenFrancs).Plus(fiveBucks);
            var result = bank.Reduce(sum,"USD");
            Assert.Equal(Money.Dollar(15),result);

        }
        [Fact]
        public void TestSumTimesMoney()
        {
            IBankExpression fiveBucks = Money.Dollar(5);
            IBankExpression tenFrancs = Money.Franc(10);
            var bank = new Bank();
            bank.AddRate("CHF","USD",2);
            IBankExpression sum = new Sum(fiveBucks,tenFrancs).Times(2);
            var result = bank.Reduce(sum,"USD");
            Assert.Equal(Money.Dollar(20),result);

        }
        [Fact]
        public void TestPlusSameCurrencyReturnsMoney()
        {
            IBankExpression sum = Money.Dollar(1).Plus(Money.Dollar(1));
            Assert.True(sum is Sum);
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