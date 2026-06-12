using UnitConversionWebApplication.Data;

namespace UnitConversionWebApplication.Services
{
    public class ConversionService : IConversionService
    {
        public double Convert(
       double value,
       string fromUnit,
       string toUnit)
        {
            fromUnit = fromUnit.ToLower();
            toUnit = toUnit.ToLower();

            // Length Conversion
            if (UnitDefinitions.LengthUnits.ContainsKey(fromUnit)
                && UnitDefinitions.LengthUnits.ContainsKey(toUnit))
            {
                double baseValue =
                    value * UnitDefinitions.LengthUnits[fromUnit];

                return baseValue /
                       UnitDefinitions.LengthUnits[toUnit];
            }

            // Weight Conversion
            if (UnitDefinitions.WeightUnits.ContainsKey(fromUnit)
                && UnitDefinitions.WeightUnits.ContainsKey(toUnit))
            {
                double baseValue =
                    value * UnitDefinitions.WeightUnits[fromUnit];

                return baseValue /
                       UnitDefinitions.WeightUnits[toUnit];
            }

            // Temperature Conversion
            return ConvertTemperature(
                value,
                fromUnit,
                toUnit);
        }

        private static double ConvertTemperature(
            double value,
            string fromUnit,
            string toUnit)
        {
            if (fromUnit == "celsius" &&
                toUnit == "fahrenheit")
            {
                return (value * 9 / 5) + 32;
            }

            if (fromUnit == "fahrenheit" &&
                toUnit == "celsius")
            {
                return (value - 32) * 5 / 9;
            }

            if (fromUnit == toUnit)
            {
                return value;
            }

            throw new ArgumentException(
     $"Conversion from '{fromUnit}' to '{toUnit}' is not supported.");
        }
    }
}
