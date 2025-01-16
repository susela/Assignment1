namespace Assignment1_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaring varibales
            double distance, time, speedInKmH, speedInMph;

            //to get inputs
            Console.Write("Enter the Distance in KiloMeter: ");
            while (!double.TryParse(Console.ReadLine(), out distance) || distance <= 0)
            {
                Console.Write("Enter a number: ");
            }

            Console.Write("Enter Time in Hours: ");
            while (!double.TryParse(Console.ReadLine(), out time) || time <= 0)
            {
                Console.Write("Enter a  positive number : ");
            }
            // Calculating speed in kilometers per hour (km/h)
            speedInKmH = distance / time;

            // Converting speed from kilometers per hour to miles per hour
            speedInMph = speedInKmH * 0.621371;

            // Displaying the results
            Console.WriteLine($"Speed in kilometers per hour: {speedInKmH} km/h");
            Console.WriteLine($"Speed in miles per hour: {speedInMph} mph");

            // Keep the console open
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
// takes distance and time as input
// display speed in kilometers per hour and miles per hour
