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

        //TODO:���ɶ���Ԫ2��1
        // 5��Ԫ* 2=10��Ԫ
        // ��amount����Ϊ˽��
        // doller�и�������(l������˵�ʱ��amount��仯)
        // Ǯ����Ϊ������
        // ʵ��Equals����
        // ʵ��GethashCode����
        // ��ն����е�
        // ���ͬ������е�
        // 5��ʿ���� * 2 = 10 ��ʿ����
    }
}