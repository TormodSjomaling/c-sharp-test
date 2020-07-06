using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static readonly HttpClient client = new HttpClient();

        static async Task Main(string[] args)
        {
            var url = "https://jsonplaceholder.typicode.com/todos/1";
            var url2 = "http://dummy.restapiexample.com/api/v1/employees";

            HttpResponseMessage response = await client.GetAsync(url2);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();

            //Console.WriteLine(responseBody);

            dynamic deserializedResponse = JsonConvert.DeserializeObject(responseBody);
            var listOfEmoplyeeData = deserializedResponse.data;

            List<Employee> listOfEmployees = new List<Employee>();

            foreach (var emoplyee in listOfEmoplyeeData)
            {
                Employee newEmployee = new Employee(emoplyee.id, emoplyee.employee_name, emoplyee.employee_salary, emoplyee.employee_age);
                listOfEmployees.Add(newEmployee);
            }

           foreach (var item in listOfEmployees)
            {
                Console.WriteLine(item.employee_name + " " + item.employee_salary);
            }


            //Employee employee = new Employee();
            //Car car = new Car(shit.userId, shit.id, shit.title, shit.completed);

            //Console.WriteLine(car.title);
        }
    }
}
