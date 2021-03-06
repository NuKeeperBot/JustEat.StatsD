using System.Net;
using Shouldly;
using Xunit;

namespace JustEat.StatsD.EndpointLookups
{
    public static class SimpleEndpointTests
    {
        [Fact]
        public static void CanHoldValue()
        {
            var wrapped = new SimpleEndpointSource(MakeTestIpEndPoint());

            var expected = MakeTestIpEndPoint();
            wrapped.GetEndpoint().ShouldBe(expected);
        }

        [Fact]
        public static void ValueIsConsistent()
        {
            var wrapped = new SimpleEndpointSource(MakeTestIpEndPoint());

            wrapped.GetEndpoint().ShouldBe(wrapped.GetEndpoint());
        }

        private static IPEndPoint MakeTestIpEndPoint()
        {
            return new IPEndPoint(new IPAddress(new byte[] {1, 2, 3, 4}), 8125);
        }
    }
}
