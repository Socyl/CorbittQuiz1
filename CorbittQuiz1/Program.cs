using System;

namespace CorbittQuiz1
{
    class Program
    {
        static void Main(string[] args)
        {
            string another;

            do
            {
                Gravity grav = new Gravity();

                //get Mass1 from user
                Console.WriteLine("Please input the mass of the first object in kg: ");
                grav.Mass1 = Convert.ToDouble(Console.ReadLine());

                //get Mass2 from user
                Console.WriteLine("Please input the mass of the second object in kg: ");
                grav.Mass2 = Convert.ToDouble(Console.ReadLine());

                //get distance from user
                Console.WriteLine("Please input the distance between the objects in meters: ");
                grav.Distance = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("\n\nThe gravitational force between your two objects is " +
                  grav.Force + " newtons.");

                Console.WriteLine("Would you like to calculate another gravitational force? (enter yes to continue): ");
                another = Console.ReadLine();
            }
            while (string.Equals(another.ToLower(), "yes"));
        }
    }
}
