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
            double baseValue = value;
            fromUnit = fromUnit.ToLower();
            toUnit = toUnit.ToLower();

            // Length Conversion
            if (UnitDefinitions.LengthUnits.ContainsKey(fromUnit)
                && UnitDefinitions.LengthUnits.ContainsKey(toUnit))
            {
                baseValue =
                    value * UnitDefinitions.LengthUnits[fromUnit];

                return baseValue /
                       UnitDefinitions.LengthUnits[toUnit];
            }

            // Weight Conversion
            if (UnitDefinitions.WeightUnits.ContainsKey(fromUnit)
                && UnitDefinitions.WeightUnits.ContainsKey(toUnit))
            {
                baseValue =
                    value * UnitDefinitions.WeightUnits[fromUnit];

                return baseValue /
                       UnitDefinitions.WeightUnits[toUnit];
            }


            // Temperature Conversion           
            baseValue = fromUnit switch
            {
                "celsius" => value,
                "fahrenheit" => (value - 32) * 5 / 9,
                "kelvin" => value - 273.15,
                _ => throw new ArgumentException(
                    $"Unsupported temperature unit: {fromUnit}")
            };

            double convertedValue = toUnit switch
            {
                "celsius" => baseValue,
                "fahrenheit" => (baseValue * 9 / 5) + 32,
                "kelvin" => baseValue + 273.15,
                _ => throw new ArgumentException(
                    $"Unsupported temperature unit: {toUnit}")
            };

            return convertedValue;
        }
    }
}
