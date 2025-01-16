namespace Assignment1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaring variables
            double number, width;

            //input and validate the numbers
            Console.Write("Enter a number: ");
            while (!double.TryParse(Console.ReadLine(), out number))
            {
                Console.Write("Only numbers are allowded!! Enter a number: ");
            }
            Console.Write("Enter the  width: ");
            while (!double.TryParse(Console.ReadLine(), out width) || width <= 0)
            {
                Console.Write(" Enter a valid width: ");
            }

            // Display the triangle
            Console.WriteLine("\nHere is your triangle:");
            for (int i = 1; i <= width; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(number + " ");
                }
                Console.WriteLine();
            }

            // Keep the console window open
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

    }

}