namespace UnitConversionWebApplication.Data
{
    public class UnitDefinitions
    {
        public static readonly Dictionary<string, double> LengthUnits = new()
        {
            { "meter",      1       },
            { "kilometer",  1000    },
            { "centimeter", 0.01    },
            { "millimeter", 0.001   },
            { "feet",       0.3048  },
            { "inch",       0.0254  },
            { "yard",       0.9144  },
            { "mile",       1609.34 }
        };

        public static readonly Dictionary<string, double> WeightUnits = new()
        {
            { "kg",        1          },
            { "gm",        0.001      },
            { "milligram", 0.000001   },
            { "pound",     0.453592   },
            { "ounce",     0.0283495  }
        };

        public static readonly Dictionary<string, double> TemperatureUnits = new()
        {
            { "celsius",    1        },
            { "fahrenheit", 212      },
            { "kelvin",     -272.15  }
        };
    }
}
