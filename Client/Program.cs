using System;
using System.Net.Http;

namespace Client
{
    class Program
    {
        static string HGApiKey = "cee950a4"; 
        static string stringURLWeatherForecast = "https://api.hgbrasil.com/weather?";
        static string stringURLFinance = "https://api.hgbrasil.com/finance?";
        static string stringURLFinanceCurrency = "https://api.hgbrasil.com/finance/quotations?key=cee950a4";
        static string stringURLCep = "http://viacep.com.br/ws/";
        static string stringURLWebServiceLocal = "https://localhost:44303/api/";

        static void Main(string[] args)
        {
            Console.WriteLine("Ex 01: forecast Lages,SC");
            Console.WriteLine("Ex 02: currency");
            Console.WriteLine("Ex 03: finance USD");
            Console.WriteLine("Ex 04: cep 88502300");
            Console.WriteLine("Ex 05: address SC Lages Doutor+Caetano+Costa+Junior");
            Console.WriteLine("Ex 06: local hoursInMinutes 60");
            Console.WriteLine("Enter Your Query:");

            while (true)
            {
                string message = Console.ReadLine();
                if (message.Contains("forecast"))
                {
                    string url = BuildUrlWeatherForecast(message);
                    CallWebService(url);
                }          
                else if (message.Contains("currency"))
                {
                    string url = stringURLFinanceCurrency;
                    CallWebService(url);
                }
                else if (message.Contains("finance"))
                {
                    string url = BuildUrlFinance(message);
                    CallWebService(url);
                }
                else if (message.Contains("address"))
                {
                    string url = BuildUrlAddress(message);
                    CallWebService(url);
                }
                else if (message.Contains("cep"))
                {
                    string url = BuildUrlCep(message);
                    CallWebService(url);
                }
                else if (message.Contains("local"))
                {
                    string url = BuildUrlLocal(message);
                    CallWebService(url);
                }
            }            
        }

        private static string BuildUrlLocal(string message)
        {
            string[] messageSplit = message.Split(" ");
            string convert = messageSplit[1];
            string value = messageSplit[2];
            string url = stringURLWebServiceLocal + "get/" + convert + "/" + value;
            return url;
        }

        private static string BuildUrlCep(string message)
        {
            string[] messageSplit = message.Split(" ");
            string cep = messageSplit[1];
            string url = stringURLCep + cep + "/json";
            return url;
        }

        private static string BuildUrlAddress(string message)
        {
            string[] messageSplit = message.Split(" ");
            string state = messageSplit[1];
            string city = messageSplit[2];
            string street = messageSplit[3];
            string url = stringURLCep + "/"+state+"/"+city+"/"+street+"/json";
            return url;
        }

        private static string BuildUrlFinance(string message)
        {
            string[] messageSplit = message.Split(" ");
            string currency = messageSplit[1];
            string url = stringURLFinance + "array_limit=1&fields=only_results," + currency + "&key=" + HGApiKey;
            return url;
        }

        private static string BuildUrlWeatherForecast(string message)
        {      
            string[] messageSplit = message.Split(" ");
            string localization = messageSplit[1];
            string url = stringURLWeatherForecast + "key=" + HGApiKey + "&city_name=" + localization;
            return url;
        }

        private static void CallWebService(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    var response = client.GetAsync(url).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        var result = response.Content.ReadAsStringAsync().Result;
                        Console.WriteLine(result);
                    }
                    else
                    {
                        Console.WriteLine("Invalid Command");
                    }
                }
                catch 
                {
                    Console.WriteLine("Invalid Command");
                }
            }
        }      
    }
}
