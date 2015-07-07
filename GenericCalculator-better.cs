using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day2Generics
{
    class Program
    {
        static void Main(string[] args)
        {
        
            Calculator<int> c = new Calculator<int>();
            c.Add(5, 8);
            c.Multiply(5, 8);   
            c.Subtract(5, 8);
            c.Mod(5, 8);

            Calculator<float> c2 = new Calculator<float>();
            float result = c2.Add(5.6f, 4.3f);
            c2.Subtract(5.6f, 4.3f);

            Calculator<CustomNumber> c3 = new Calculator<CustomNumber>();
            var num1 = new CustomNumber("Daniel");
            var num2 = new CustomNumber("Mike");
            CustomNumber num3 = c3.Add(num1, num2);
            c3.Multiply(num1, num2);
            c3.Subtract(num1, num2);
            c3.Mod(num1, num2);

            Console.ReadLine();
        }

     
        public class CustomNumber
        {
            public string Value { get; set; }
            public CustomNumber(string value)
            {
                Value = value;
            }

            public static CustomNumber operator +(CustomNumber c1, CustomNumber c2)
            {
                return new CustomNumber(c1.Value + " " + c2.Value);
            }

            public static CustomNumber operator -(CustomNumber c1, CustomNumber c2)
            {
                return new CustomNumber(c1.Value + " substract " + c2.Value);
            }

            public static CustomNumber operator *(CustomNumber c1, CustomNumber c2)
            {
                return new CustomNumber(c1.Value + " multiply " + c2.Value);
            }

            public static CustomNumber operator %(CustomNumber c1, CustomNumber c2)
            {
                return new CustomNumber(c1.Value + " mod " + c2.Value);
            }

            public override string ToString()
            {
                return Value;
            }
        }

        //Generic Calculator that uses dynamic to do some magic.
        // An object of type dynamic bypasses static type checking, but it still static. Here be dragons...
        public class Calculator<T>  
        {
            public  T Subtract(T a, T b)
            {
                Console.WriteLine("Subtracting: {0} - {1} = {2}", a, b, (dynamic)a - b);
                return (dynamic)a - b;
            }


            public  T Multiply(T a, T b)
            {
                Console.WriteLine("Multiplying: {0} * {1} = {2}", a, b, (dynamic)a * b);
                return (dynamic)a * b;
            }

            public  T Mod(T a, T b)
            {
                Console.WriteLine("Modulus-ing: {0} % {1} = {2}", a, b, (dynamic)a % b);
                return (dynamic) a % b;
            }

            public  T Add(T a, T b)
            {
                Console.WriteLine("Adding: {0} + {1} = {2}", a, b, (dynamic)a + b);
                return (dynamic) a + b;
            }
        }
     
    }


}
