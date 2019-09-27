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
            Assert.Equal(new Dollar(10), five.Times(2));
            Assert.Equal(new Dollar(15),  five.Times(3));
        }
        [Fact]
        public void TestEqulity()
        {
            Assert.True(new Dollar(5).Equals(new Dollar(5)));
            Assert.False(new Dollar(5).Equals(new Dollar(6)));
        }
        [Fact]
        public void TestFrancMultiplication()
        {
            Franc five = new Franc(5);
            Assert.Equal(new Franc(10), five.Times(2));
            Assert.Equal(new Franc(15), five.Times(3));
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
