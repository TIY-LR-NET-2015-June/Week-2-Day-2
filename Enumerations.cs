using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day2Enumerations
{
    class Program
    {
        public enum Color
        {
            Indigo = 3,
            Violet = 4,
            Fuscha = 500,
            Red = 0,
            Blue = 1,
            Green = 2,
           
            Orange = 5
        }


        [Flags]
        public enum Food
        {
            GroundBeef = 1,
            Cheese = 2,
            Lettuce =4,
            Sourcream =8,
            Salsa = 16,
            Pepperoni =32,
            Crust = 64,

            StandardTaco = GroundBeef | Cheese | Lettuce
        }

        static void Main(string[] args)
        {
            var JasonsTaco = Food.StandardTaco | Food.Salsa;


            //check if his taco has salsa
            if (Food.Salsa == (JasonsTaco & Food.Salsa) )
            {
                Console.WriteLine("It has salsa!!");

            }
            else
            {
                Console.WriteLine("It has no salsa!!");
            }

            //check if his taco has a crust
            if (Food.Crust == (JasonsTaco & Food.Crust))
            {
                Console.WriteLine("It has a crust!!");

            }
            else
            {
                Console.WriteLine("It has no crust!!");
            }


            Console.ReadLine();


            Color scottsFavoriteColor = Color.Green; // 2;
            Color jasonFavoriteColor = Color.Blue;

            //Attempt to safely parse color enum value from string
            Color parsedValue;
            if (Enum.TryParse("Orange", out parsedValue))
            {
                Console.WriteLine("We parsed it!");
            }
            else
            {
                Console.WriteLine("We could NOT parse it!");
            }

            //attempt to dangerously parse color enum from string
            Color parsedColor = (Color)Enum.Parse(typeof(Color), "Red");

            //it's safer to cast the enum to an int then an int to the enum 
            if ((int)jasonFavoriteColor == 5)
            {
                Console.WriteLine("Jason's favorite color is orange....");
            }
            else
            {
                Console.WriteLine("Jason's favorite color is NOT orange....");
            }

            Console.WriteLine("Scotts Favorite Color is " + scottsFavoriteColor);

 
            Console.ReadLine();
        }
    }
}
