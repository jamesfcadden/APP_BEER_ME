using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;


namespace APP_BEER_ME.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpClient myClient = null;

            try
            {
                myClient = new HttpClient { BaseAddress = new Uri("https://APPBEERME.azurewebsites.net/") };   // the location on Azure
                myClient.DefaultRequestHeaders.Accept.Clear();
                myClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            }
            catch (Exception)
            {
                Console.WriteLine("Failed to create HttpClient - program exiting");
                return;
            }


            GetABeersSortedByBeerNameAsync(myClient).Wait();
           
            Console.ReadLine();
        }
        static async Task GetABeersSortedByBeerNameAsync(HttpClient myClient)
        {
            try
            {
                HttpResponseMessage response = await myClient.GetAsync("api/beers");
                if (response.IsSuccessStatusCode)
                {

                    var beers = await response.Content.ReadAsAsync<IEnumerable<Beer>>();
                    var sorted = beers.OrderByDescending(s => s.Name);

                    Console.WriteLine("\n\t Order List Desc:");
                    foreach (var c in sorted)
                    {
                        Console.WriteLine("\n\t" + c.Name + " \t Sum: " + c.Style + "\t| " + c.Brewery);
                    }
                }
                else
                {
                    Console.WriteLine(response.StatusCode + " " + response.ReasonPhrase);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
