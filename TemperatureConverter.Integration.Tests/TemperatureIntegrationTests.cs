using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemperatureConverter.Integration.Tests.shared;
using Xunit;

namespace TemperatureConverter.Integration.Tests
{
    public class TemperatureIntegrationTests : IClassFixture<TemperatureConverterIntegrationTestsFixture>
    {
        private readonly TemperatureConverterIntegrationTestsFixture _temperatureConverterFixture;

        public TemperatureIntegrationTests(TemperatureConverterIntegrationTestsFixture temperatureConverterFixture)
        {
            _temperatureConverterFixture = temperatureConverterFixture;
        }

        [Theory]
        [InlineData(0, 32, 100, 212, -273.15, -459.67)]
        public void Convert_CelsiusToFahrenheitAndBack_AccurateResults(double celsius, double expectedFahrenheit, double anotherCelsius, double expectedAnotherFahrenheit, double yetAnotherCelsius, double expectedYetAnotherFahrenheit)
        {
            // Arrange
            var temperatureConverter = _temperatureConverterFixture.TemperatureConverter;

            // Act
            var result1 = temperatureConverter.CelsiusToFahrenheit(celsius);
            var result2 = temperatureConverter.FahrenheitToCelsius(result1);
            var result3 = temperatureConverter.CelsiusToFahrenheit(anotherCelsius);
            var result4 = temperatureConverter.FahrenheitToCelsius(result3);
            var result5 = temperatureConverter.CelsiusToFahrenheit(yetAnotherCelsius);
            var result6 = temperatureConverter.FahrenheitToCelsius(result5);

            // Assert
            Assert.Equal(expectedFahrenheit, result1, 2);
            Assert.Equal(celsius, result2, 2);
            Assert.Equal(expectedAnotherFahrenheit, result3, 2);
            Assert.Equal(anotherCelsius, result4, 2);
            Assert.Equal(expectedYetAnotherFahrenheit, result5, 2);
            Assert.Equal(yetAnotherCelsius, result6, 2);
        }

        [Theory]
        [InlineData(-274.15, -469.67)]
        public void Convert_NegativeAbsoluteTemperature_ThrowsException(double negativeAbsoluteCelsius, double negativeAbsoluteFahrenheit)
        {
            // Arrange
            var temperatureConverter = _temperatureConverterFixture.TemperatureConverter;

            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => temperatureConverter.CelsiusToFahrenheit(negativeAbsoluteCelsius));
            Assert.Throws<ArgumentOutOfRangeException>(() => temperatureConverter.FahrenheitToCelsius(negativeAbsoluteFahrenheit));
        }
    }
}
