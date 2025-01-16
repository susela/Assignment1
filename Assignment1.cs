namespace Assignment1
{
    internal class Assignment1
    {
        static void Main(string[] args)
        {
            string originalUserName = "admin";
            string originalPassword = "admin123";

            string userName, password;
            int attempt = 0;
            const int maxAttempts = 3;

            //user authentication loop
            while (attempt < maxAttempts)
            {
                Console.Write("Enter user name:");
                userName = Console.ReadLine();

                Console.Write("Enter password:");
                password = Console.ReadLine();

                if (userName == originalUserName && password == originalPassword)
                {
                    Console.WriteLine("Login Successfully!");
                    break;
                }

                else
                {
                    attempt++;
                    Console.WriteLine($"Invalid credentials.Attempt{attempt} out of {maxAttempts}");
                }
                if (attempt == maxAttempts)
                {
                    Console.WriteLine("Invalid Credentials. Exceeds 3 attempts!");
                }
                Console.WriteLine("Press any key to exit..");
                Console.ReadKey();
            }
        }
    }
}
