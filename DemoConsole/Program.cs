using BinanceClient;
using BinanceClient.Models.Account;
using BinanceClient.Models.Market;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            ApiClient _ApiClient;
            BinanceClient.BinanceClient _BinanceClient;

            _ApiClient = new ApiClient("8UY4Sr4IUroMRflEfOOot0QidZOANt35eXvZVEGwGfHSe3oDLWQNngRI9ikKwq6P", "zbNTpeYzd8lGlWByuzcR0Jk6whA6xbADESE2wnxx8aSGDWpFxhVic3KwMZgxiPqj");
            _BinanceClient = new BinanceClient.BinanceClient(_ApiClient, false);

            long time = _BinanceClient.GetTradeList("HOTUSDT").Result.ToList<Trade>().Last<Trade>().Time;
            DateTime epoch = new DateTime(1970, 1, 1, 0, 0, 0, 0).ToLocalTime();
            epoch = epoch.AddMilliseconds(time);

            Console.ReadKey();
        }
    }
}
