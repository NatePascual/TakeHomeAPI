using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using TakeHome.API.Entities;

namespace TakeHome.ConsoleApp
{

    class Program
    {
        private static HttpClient httpClient = new HttpClient();
        private const string apiBaseUrl = "https://localhost:7178/home/";

        static async Task Main()
        {
            bool continueApp = true;

            while (continueApp)
            {
                
                Console.Clear();
                Console.WriteLine("1) Greetings");
                Console.WriteLine("2) Get all persons");
                Console.WriteLine("3) Get a particular person by Id");
                Console.WriteLine("4) Clear");
                Console.WriteLine("5) Exit");

                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Greetings();
                        break;
                    case "2":
                        await GetPeopleAsync();
                        break;
                    case "3":
                        await GetPersonByIdAsync();
                        break;
                    case "4":
                        Console.Clear();
                        break;
                    case "5":
                        continueApp = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                if (continueApp)
                {
                    Console.WriteLine("Press Enter to continue...");
                    Console.ReadLine();
                }
            }
        }

        static async Task Greetings()
        {
            var response = await httpClient.GetStringAsync(apiBaseUrl);
            Console.WriteLine(response);
        }

        static async Task GetPeopleAsync()
        {
            Console.WriteLine("All People:");

            var response = await httpClient.GetStringAsync(apiBaseUrl + "people");
            var people = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Person>>(response);

            foreach (var person in people)
            {
                Console.WriteLine($"Id: {person.Id}, Name: {person.FullName}, Job : {person.Job}");
            }
        }

        static async Task GetPersonByIdAsync()
        {
            Console.Write("Enter person Id: ");
            int id;
            if (int.TryParse(Console.ReadLine(), out id))
            {
                var response = await httpClient.GetStringAsync(apiBaseUrl + $"person/{id}");
                var person = Newtonsoft.Json.JsonConvert.DeserializeObject<Person>(response);

                if (person != null)
                {
                    Console.WriteLine($"Person found - Id: {person.Id}, Name: {person.FullName},  Job: {person.Job}");
                }
                else
                {
                    Console.WriteLine("Person not found.");
                }
            }
            else
            {
                Console.WriteLine("Invalid Id format. Please enter a valid number.");
            }
        }
    }
}
