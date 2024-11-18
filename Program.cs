namespace Assignment_3_1_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the X-Coordinate");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the Y-Coordinate");
            double y = double.Parse(Console.ReadLine());

            if (x == 0 && y == 0)
            {
                Console.WriteLine("The point lies at the origin.");
            }
            else if (x == 0)
            {
                Console.WriteLine("The point lies on the Y-axis.");
            }
            else if (y == 0)
            {
                Console.WriteLine("The point lies on the X-axis.");
            }
            else
            {
                // Determine which quadrant the point lies in
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("The point lies in Quadrant I.");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("The point lies in Quadrant II.");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("The point lies in Quadrant III.");
                }
                else if (x > 0 && y < 0)
                {
                    Console.WriteLine("The point lies in Quadrant IV.");
                }
            }
        }
    }
}