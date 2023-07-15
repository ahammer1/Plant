// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string greeting = @"Welcome to the Plant App!
Here is a List of Available Plants:";

Console.WriteLine(greeting);


        for (int i = 0; i < plants.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {plants[i].Species}");
        }

class Program
{
    static void Main()
    {
        List<Plant> plants = new List<Plant>
        {
            new Plant { Species = "Rose", LightNeeds = 4, AskingPrice = 12.99m, City = "New York", ZIP = "10001", Sold = false },
            new Plant { Species = "Fern", LightNeeds = 2, AskingPrice = 8.5m, City = "Los Angeles", ZIP = "90001", Sold = true },
            new Plant { Species = "Tulip", LightNeeds = 3, AskingPrice = 5.25m, City = "Chicago", ZIP = "60601", Sold = false },
            new Plant { Species = "Orchid", LightNeeds = 5, AskingPrice = 19.99m, City = "Miami", ZIP = "33101", Sold = false },
            new Plant { Species = "Cactus", LightNeeds = 1, AskingPrice = 6.75m, City = "Phoenix", ZIP = "85001", Sold = true }
        };

        //
    }
}
