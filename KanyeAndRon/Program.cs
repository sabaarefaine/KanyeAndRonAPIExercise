using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace KanyeAndRon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("You walk into a bar and overhear Kanye West and Ron Swanson having a chat...");

            for (int i = 0; i < 5; i++)
            {
                QuoteGenerator.KanyeQuote();

                QuoteGenerator.RonQuote();
            }
        }
    }
}
