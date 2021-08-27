using currency_rates.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace currency_rates.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CurrencyController : ControllerBase
    {
        private readonly ILogger<CurrencyController> _logger;

        public CurrencyController(ILogger<CurrencyController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("GetCurrencyList")]
        public JsonResult GetCurrencyList()
        {
            var response = CurrencyApi.GetCurrencyList();
            return new JsonResult(response);
        }

        [Route("Convert/{baseCurrency}/{targetCurrency}")]
        public async Task<ConversionRate> GetRates(string baseCurrency, string targetCurrency)
        { 
            if (string.IsNullOrEmpty(baseCurrency) || string.IsNullOrEmpty(targetCurrency))
            {
                return null;
            }

            var response = await CurrencyApi.GetConversionRateAsync(baseCurrency, targetCurrency);
            return response;
        }

        [Route("GetRates/{currency}")]
        public async Task<StandardRate> GetRates(string currency)
        {
            if (string.IsNullOrEmpty(currency))
            {
                return null;
            }

            //TODO : figureout way to make serialization do not convert property names to lowercase;
            var response = await CurrencyApi.GetRatesAsync(currency);
            return response;
        }
    }
}
