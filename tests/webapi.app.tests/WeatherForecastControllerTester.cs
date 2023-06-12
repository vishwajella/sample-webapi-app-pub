using FluentAssertions;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestPlatform.Common.Exceptions;
using NSubstitute;
using webapi.app.Controllers;

namespace webapi.app.tests
{
    [TestClass]
    public class WeatherForecastControllerTester
    {
        [TestMethod]
        public void Given_No_Inputs_When_Called_Get_Then_Return_Expected_Result()
        {
            // Arrange
            var substitureForILogger = Substitute.For<ILogger<WeatherForecastController>>();
            var weatherForecastController = new WeatherForecastController(substitureForILogger);
            // Act
            var actual = weatherForecastController.Get();

            // Assert
            actual.Should().NotBeNullOrEmpty();
        }
    }
}