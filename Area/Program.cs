using System;

namespace Area
{
    class Program
    {
        static void Hello(string[] args)
        {
            Console.WriteLine("Congratulations!");
        }
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the radius: ");
            string input = Console.ReadLine();
            int Circ = int.Parse(input);

            if (Circ > 0) {
                double Area = 3.14 * Circ * Circ;
                Console.WriteLine("The area is " + Area);
                Hello(args);
            }
            else {
                Console.WriteLine("No negatives.");
                Main(args);

            }

        }
    }
}
