using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using FluentAssertions;
using NetworkUtility.Ping;

namespace NetworkUtility.Tests.PingTests
{
    public class NetworkServiceTests
    {
        [Fact]
        public void NetworkService_SendPing_ReturnString()
        {
            //Arrange - variables, classes,mocks
            var pingService = new NetworkService();
            //Act
            var result = pingService.SendPing();
            //Assert
            result.Should();
            result.Should().NotBeNullOrWhiteSpace();
            result.Should().Be("Success:Ping Sent!");
            result.Should().Contain("Success", Exactly.Once());

         }
        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(2, 2, 4)]
        public void NetworkService_PingTimeOut_ReturnInt(int a, int b, int expected)
        {
            //Arrange
            var pingService = new NetworkService();
            //Act
            var result = pingService.PingTimeOut(a, b);
            //Assert
            result.Should().Be(expected);
            result.Should().BeGreaterThanOrEqualTo(3);
            result.Should().NotBeInRange(-10000, 0);
        }
    }
}
