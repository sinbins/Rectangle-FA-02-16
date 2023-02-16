using System.ComponentModel.DataAnnotations;

namespace FA_CreateRectangle
{
    //Creating a rectangle
    //Fabian Acosta
    //02-16-2023
    internal class Program
    {
        public static Random random;
        static void Main(string[] args)
        {
            //random object to get a random number between the users minimum and maximum values
            random = new Random();
            //Variables
            int length = 0;
            int width = 0;

            //Prompts user for their min and max 
            Console.WriteLine("Enter a minimum int value(e.g 1 or 200): ");
            int minimum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a maximum int value(e.g 40 or 1000): ");
            int maximum = Convert.ToInt32(Console.ReadLine());

            //Gets the rectangle's length and width out
            MakeRectangle(minimum, maximum, out length, out width);
            
            //new rectangle object
            Rectangle r = new Rectangle(length, width);

            //Output rectangle's properties 
            Console.WriteLine("Length: " + r.length + "\nWidth: " + r.width + "\nArea: " + RectangleUtilities.GetArea(r.length, r.width)
                + "\nPerimeter: " + RectangleUtilities.GetPerimeter(r.length, r.width));

           
        }

        //Rectangle class
       class Rectangle
        {
            //Attributes
            public int length;
            public int width;

            //Constructor
            public Rectangle(int l, int w)
            {
                length = l;
                width = w;
            }
            
        }


        
        //Will choose a random value between users min and max and set it to the width and length of rectangle
        static void MakeRectangle(int min, int max, out int length, out int width)
        {
            length = random.Next(min, max);
            width = random.Next(min, max);
        }

        //Utility class for area and perimeter of rectangle
        class RectangleUtilities
        {
           public static int GetArea(int l, int w)
            {
                return l * w;
            }

           public static int GetPerimeter(int l, int w)
            {
                return 2 * (l + w);
            }
        }
    }
}