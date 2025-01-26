using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using techzad.App;

namespace techzad.Web.Controllers
{
    public class CurrencyController : Controller
    {
        private readonly ICurrencyService _currencyService;
        public CurrencyController(ICurrencyService currencyService)
        {
            _currencyService = currencyService;
        }
        [HttpGet("currencies")] // для маршута /currencies
        public async Task<IActionResult> GetCurrencies([FromQuery] int page = 1, [FromQuery] int pagesize = 10)
        {
            var currencies = await _currencyService.GetCurrenciesAsync(page, pagesize);
            return Ok(currencies);
        }
        [HttpGet("currency/{id}")]// для маршута /currencies/id
        public async Task<IActionResult> GetCurrencyById(string id)
        {
            var currency= await _currencyService.GetCurrencyByIdAsync(id);
            if (currency == null)
            {
                return NotFound();
            }
            return Ok(currency);
        }
    }
}
