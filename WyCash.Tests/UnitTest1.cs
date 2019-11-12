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
