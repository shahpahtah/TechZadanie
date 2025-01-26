using Newtonsoft.Json;
using Techzad;

namespace techzad.App
{
    public class CurrencyService : ICurrencyService

    {
        private readonly HttpClient _httpClient;
        public CurrencyService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<Currency>> GetCurrenciesAsync(int page, int pageSize) //метод сервиса,отвечающий за получение всех курсов с пагинацией
        {
            var response = await _httpClient.GetStringAsync("https://www.cbr-xml-daily.ru/daily_json.js");
            var json = JsonConvert.DeserializeObject<RootObject>(response); //десереализуем обьект в класс специальный для ответа с внешнего апи
            var currencies = json.Valute.Select(c => new Currency
            {
                Id = c.Value.ID,
                Name = c.Value.Name,
                Value = c.Value.Value,

            }
           ).ToList();
            return currencies.Skip((page-1)*pageSize).Take(pageSize).ToList(); //пагинация

        }

        public async Task<Currency> GetCurrencyByIdAsync(string id) //получение по айдишнику
        {
           var currencies= GetCurrenciesAsync(1,int.MaxValue);
            return currencies.Result.Single(c=>c.Id.ToLower()==id.ToLower());
        }
    }
}
