﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace techzad.App
{
    public class ValuteInfo // класс для десереализации валюты
    {
        public string ID {  get; set; }
        public string NumCode {  get; set; }
        public string CharCode { get; set; }
        public int Nominal { get; set; }
        public string Name { get; set; }
        public decimal Value { get; set; }
        public decimal Previous {  get; set; }  
    }
}
