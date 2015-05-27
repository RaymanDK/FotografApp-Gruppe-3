﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using WS;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            const string serverUrl = "http://localhost:55001";
            HttpClientHandler handler = new HttpClientHandler();
            handler.UseDefaultCredentials = true;
            using (var client = new HttpClient(handler))
            {
                client.BaseAddress = new Uri(serverUrl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                try
                {
                    var response = client.GetAsync("api/Users").Result;
                    if (response.IsSuccessStatusCode)
                    {
                        var orders = response.Content.ReadAsAsync<IEnumerable<User>>().Result;
                        foreach (var order in orders)
                        {
                            Console.WriteLine(order);
                        }

                    }
                    Console.WriteLine("Done");

                }
                catch (Exception)
                {

                    throw;
                }
            }
            Console.ReadKey();
        
        }
    }
}