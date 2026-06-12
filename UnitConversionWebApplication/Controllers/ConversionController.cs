using Microsoft.AspNetCore.Mvc;
using UnitConversionWebApplication.Models;
using UnitConversionWebApplication.Services;

namespace UnitConversionWebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConversionController : ControllerBase
    {
        private readonly IConversionService _conversionService;

        public ConversionController(
        IConversionService conversionService)
        {
            _conversionService = conversionService;
        }

        /// <summary>
        /// Converts a value from one unit to another.
        /// </summary>
        /// <param name="request">Conversion request</param>
        /// <returns>Converted value</returns>
        [HttpPost]
        public IActionResult Convert(
            ConversionRequest request)
        {
            var result = _conversionService.Convert(
                request.Value,
                request.FromUnit,
                request.ToUnit);

            return Ok(new ConversionResponse
            {
                OriginalValue = request.Value,
                FromUnit = request.FromUnit,
                ToUnit = request.ToUnit,
                ConvertedValue = result
            });
        }

    }
}
