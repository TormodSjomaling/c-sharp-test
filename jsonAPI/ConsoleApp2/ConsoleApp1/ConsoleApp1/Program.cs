using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static readonly HttpClient client = new HttpClient();
        static async Task Main(string[] args)
        {
            var url2 = "http://dummy.restapiexample.com/api/v1/employees";

            HttpResponseMessage response = await client.GetAsync(url2);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();

            Emoplyee emoplyee = JsonSerializer.Deserialize<Emoplyee>(responseBody);

            Console.WriteLine(responseBody);
        }
    }
}
