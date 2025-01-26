using Techzad;

namespace techzad.App
{
    public interface ICurrencyService
    {
        Task<List<Currency>> GetCurrenciesAsync(int page,int pageSize);
        Task<Currency> GetCurrencyByIdAsync(string id);
    }
}