using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CodeWars.CountIPAddresses
{
    public  class CountIPAddressesTests
    {
        [Fact]
        public void SmapleTest()
        {
            Assert.Equal(50, CountIPAddressesClass.IpsBetween("10.0.0.0", "10.0.0.50"));
        }
        [Fact]
        public void SmapleTest02()
        {
            Assert.Equal(246, CountIPAddressesClass.IpsBetween("20.0.0.10", "20.0.1.0"));
        }
        [Fact]
        public void SmapleTest03()
        {
            Assert.Equal((1L << 32) - 1L, CountIPAddressesClass.IpsBetween("0.0.0.0", "255.255.255.255"));
        }
    }
}
