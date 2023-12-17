class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the type of product to create (1 - Smartphone, 2 - Laptop): ");
        string choice = Console.ReadLine();

        Client client = null;

        if (choice == "1")
        {
            client = new Client(new SmartphoneFactory());
        }
        else if (choice == "2")
        {
            client = new Client(new LaptopFactory());
        }

        client?.Run();

        Console.ReadKey();
    }
}