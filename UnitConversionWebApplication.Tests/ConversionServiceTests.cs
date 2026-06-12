using UnitConversionWebApplication.Services;
namespace UnitConversionWebApplication.Tests
{
    public class ConversionServiceTests
    {

        [Fact]
        public void Convert_Meter_To_Feet_Returns_Correct_Value()
        {
            // Arrange
            var service = new ConversionService();

            // Act
            var result =
                service.Convert(1, "meter", "feet");

            // Assert
            Assert.Equal(3.28084, result, 4);
        }



        [Fact]
        public void Convert_Feet_To_Meter_Returns_Correct_Value()
        {
            var service = new ConversionService();

            var result =
                service.Convert(3.28084, "feet", "meter");

            Assert.Equal(1, result, 4);
        }

        [Fact]
        public void Convert_Celsius_To_Fahrenheit_Returns_Correct_Value()
        {
            var service = new ConversionService();

            var result =
                service.Convert(100, "celsius", "fahrenheit");

            Assert.Equal(212, result);
        }

        [Fact]
        public void Convert_Fahrenheit_To_Celsius_Returns_Correct_Value()
        {
            var service = new ConversionService();

            var result =
                service.Convert(212, "fahrenheit", "celsius");

            Assert.Equal(100, result);
        }

        [Fact]
        public void Unsupported_Conversion_Should_Throw_Exception()
        {
            var service = new ConversionService();

            Assert.Throws<ArgumentException>(() =>
            {
                service.Convert(
                    100,
                    "meter",
                    "celsius");
            });
        }

    }
}
