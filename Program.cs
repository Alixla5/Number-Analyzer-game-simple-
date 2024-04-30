class NumberAnalyzer
{
    static void Main(string[] args)
    {
        string userName;
        Console.WriteLine("Welcome to the Number Analyzer.");
        Console.Write("Please enter your name: ");
        userName = Console.ReadLine();

        bool continueRunning = true;

        while (continueRunning)
        {
            Console.Write($"\nHello, {userName}. Please enter an integer between 1 and 100 inclusive: ");
            int number;

            // Validation input
            while (!int.TryParse(Console.ReadLine(), out number) || number < 1 || number > 100)
            {
                Console.Write("Invalid input. Please enter a positive integer between 1 and 100: ");
            }

            if (number % 2 == 0)
            {
                if (number >= 2 && number <= 24)
                {
                    Console.WriteLine("Even and less than 25.");
                }
                else if (number >= 26 && number <= 60)
                {
                    Console.WriteLine("Even and between 26 and 60 inclusive.");
                }
                else
                {
                    Console.WriteLine($"Even and greater than 60 ({number}).");
                }
            }
            else
            {
                if (number < 60)
                {
                    Console.WriteLine($"Odd and less than 60 ({number}).");
                }
                else
                {
                    Console.WriteLine($"Odd and greater than 60 ({number}).");
                }
            }

            // Ask user to continue
            Console.Write("Do you want to analyze another number? (yes/no): ");
            string answer = Console.ReadLine().ToLower();
            continueRunning = answer == "yes" || answer == "y";
        }

        Console.WriteLine("Thank you for using the Number Analyzer. Goodbye!");
    }
}
