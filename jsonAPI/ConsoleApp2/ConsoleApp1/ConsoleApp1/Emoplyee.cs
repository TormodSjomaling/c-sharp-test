using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace ConsoleApp1
{
    class Emoplyee
    {
        [JsonPropertyName("id")]
        public string id { get; set; }

        [JsonPropertyName("employee_name")]
        public string employee_name { get; set; }

        [JsonPropertyName("employee_salary")]
        public string employee_salary { get; set; }

        [JsonPropertyName("employee_age")]
        public string employee_age { get; set; }

        public Emoplyee(string id, string employee_name, string employee_salary, string employee_age)
        {
            this.id = id;
            this.employee_name = employee_name;
            this.employee_salary = employee_salary;
            this.employee_age = employee_age;
        }

        public Emoplyee()
        { }
    }
}
