using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace techzad.App
{
    public class RootObject // класс для десереализации ответа с вашего стороннего апи
    {
        public DateTime Date { get; set; }
        public DateTime PreviousDate {  get; set; }
        public DateTime Timestamp { get; set; }
        public Dictionary<string, ValuteInfo> Valute { get; set; } 
    }
}
