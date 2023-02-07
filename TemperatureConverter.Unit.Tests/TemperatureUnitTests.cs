using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemperatureConverter.Shared;
using Xunit;

namespace TemperatureConverter.Unit.Tests
{
    [CollectionDefinition("TemperatureConverter Collection")]
    public class TemperatureUnitTests : IClassFixture<TemperatureConverterFixture>
    {
        private readonly TemperatureConverterFixture _temperatureConverterFixture;

        public TemperatureUnitTests(TemperatureConverterFixture temperatureConverterFixture)
        {
            _temperatureConverterFixture = temperatureConverterFixture;
        }

        [Theory]
        [InlineData(100, 212)]
        public void CelsiusToFahrenheit_ValidInput_ReturnsCorrectValue(double celsius, double expectedTemperature)
        {
            // Arrange
            var temperatureConverter = _temperatureConverterFixture.TemperatureConverter;

            // Act
            double result = temperatureConverter.CelsiusToFahrenheit(celsius);

            // Assert
            Assert.Equal(expectedTemperature, result, 0);
        }

        [Theory]
        [InlineData(212, 100)]
        public void FahrenheitToCelsius_ValidInput_ReturnsCorrectValue(double fahrenheit, double expectedTemperature)
        {
            // Arrange
            var temperatureConverter = _temperatureConverterFixture.TemperatureConverter;

            // Act
            double result = temperatureConverter.FahrenheitToCelsius(fahrenheit);

            // Assert
            Assert.Equal(expectedTemperature, result, 0);
        }

        [Theory]
        [InlineData(-273.15, -459.67)]
        [InlineData(0, 32)]
        [InlineData(37, 98.6)]
        public void CelsiusToFahrenheit_MultipleValues_ReturnsCorrectValues(double celsius, double expectedFahrenheit)
        {
            // Arrange
            var temperatureConverter = _temperatureConverterFixture.TemperatureConverter;

            // Act
            double result = temperatureConverter.CelsiusToFahrenheit(celsius);

            // Assert
            Assert.Equal(expectedFahrenheit, result, 0);
        }

        [Theory]
        [InlineData(-459.67, -273.15)]
        [InlineData(32, 0)]
        [InlineData(98.6, 37)]
        public void FahrenheitToCelsius_MultipleValues_ReturnsCorrectValues(double fahrenheit, double expectedCelsius)
        {
            // Arrange
            var temperatureConverter = _temperatureConverterFixture.TemperatureConverter;

            // Act
            double result = temperatureConverter.FahrenheitToCelsius(fahrenheit);

            // Assert
            Assert.Equal(expectedCelsius, result, 0);
        }

        [Theory]
        [InlineData(-274)]
        public void CelsiusToFahrenheit_NegativeAbsoluteTemperature_ThrowsException(double celsius)
        {
            // Arrange
            var temperatureConverter = _temperatureConverterFixture.TemperatureConverter;

            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => temperatureConverter.CelsiusToFahrenheit(celsius));
        }

        [Theory]
        [InlineData(-460)]
        public void FahrenheitToCelsius_NegativeAbsoluteTemperature_ThrowsException(double fahrenheit)
        {
            // Arrange
            var temperatureConverter = _temperatureConverterFixture.TemperatureConverter;

            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => temperatureConverter.FahrenheitToCelsius(fahrenheit));
        }
    }
}
