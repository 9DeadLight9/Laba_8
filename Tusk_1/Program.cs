class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Enter command:");
            string command = Console.ReadLine();

            if (command == "exit")
            {
                break;
            }
            else if (command.StartsWith("set "))
            {
                string[] parts = command.Split(new[] { ' ' }, 3);
                if (parts.Length == 3)
                {
                    ConfigurationManager.Instance[parts[1]] = parts[2];
                }
            }
            else if (command.StartsWith("get "))
            {
                string[] parts = command.Split(new[] { ' ' }, 2);
                if (parts.Length == 2)
                {
                    Console.WriteLine(ConfigurationManager.Instance[parts[1]]);
                }
            }
        }
    }
}