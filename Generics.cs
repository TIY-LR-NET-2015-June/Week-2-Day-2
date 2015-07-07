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
            var mikeCalc = new OneCalculatorToRuleThemAll<MikesNumbers>();
            mikeCalc.Add(new MikesNumbers("Blah"), new MikesNumbers("Foo"));

            Console.ReadLine();

            IntCalculator c = new IntCalculator();

            c.Add(5, 8);
            c.Multiply(5, 8);
            c.Subtract(5, 8);
            c.Mod(5, 8);

            FloatCalculator c2 = new FloatCalculator();
            float result = c2.Add(5.6f, 4.3f);
            c2.Subtract(5.6f, 4.3f);

            CustomNumberCalculator c3 = new CustomNumberCalculator();
            var num1 = new CustomNumber("Daniel");
            var num2 = new CustomNumber("Mike");
            CustomNumber num3 = c3.Add(num1, num2);
            c3.Multiply(num1, num2);
            c3.Subtract(num1, num2);
            c3.Mod(num1, num2);



            Console.ReadLine();
        }

        public class DanielsNumbers : BaseNumber
        {
            public DanielsNumbers(string value)
                :base(value)
            {
            }


            public static DanielsNumbers operator +(DanielsNumbers c1, DanielsNumbers c2)
            {
                return new DanielsNumbers(c1.Value + " " + c2.Value);
            }

          
            public override string ToString()
            {
                return "DanielsNumber: " + Value;
            }
        }

        public class MikesNumbers : BaseNumber
        {
            public MikesNumbers(string value)
                :base(value)
            {
            }


            public static MikesNumbers operator +(MikesNumbers c1, MikesNumbers c2)
            {
                return new MikesNumbers(c1.Value + " " + c2.Value);
            }


            public override string ToString()
            {
                return "MikesNumbers: " + Value;
            }
        }

        public class CustomNumber : BaseNumber
        {
            public CustomNumber(string value)
                : base(value)
            {
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

            //public static bool operator =(CustomNumber c1, CustomNumber c2)
            //{
            //    new CustomNumber(c1.Value + " equals " + c2.Value);
            //    return true;
            //} NOT POSSIBLE

            public override string ToString()
            {
                return Value;
            }
        }

      

        public class BaseNumber
        {
            public string Value { get; set; }

            public BaseNumber(string value)
            {
                this.Value = value;
            }

            //override the + operator... when added 2 custom types like we have, our sum can be whatever we want to be.
            public static BaseNumber operator +(BaseNumber c1, BaseNumber c2)
            {
                return new BaseNumber(c1.Value + " " + c2.Value);
            }
        }


        //Generic Calculator that handles anything derived from BaseNumber
        public class OneCalculatorToRuleThemAll<T> where T : BaseNumber
        {
            public T Add(T a, T b)
            {
               
                return (T) (a + b);
            }
        }


        //generic abstract calculator
        public abstract class BaseCalc<T>
        {
            public abstract T Add(T a, T b);
            public abstract T Subtract(T a, T b);
            public abstract T Multiply(T a, T b);
            public abstract T Mod(T a, T b);
        }

        public class IntCalculator : BaseCalc<int>
        {

            public override int Subtract(int a, int b)
            {
                Console.WriteLine("Subtracting: {0} - {1} = {2}", a, b, a - b);
                return a - b;
            }


            public override int Multiply(int a, int b)
            {
                Console.WriteLine("Multiplying: {0} * {1} = {2}", a, b, a * b);
                return a * b;
            }

            public override int Mod(int a, int b)
            {
                Console.WriteLine("Modulus-ing: {0} % {1} = {2}", a, b, a % b);
                return a % b;
            }

            public override int Add(int a, int b)
            {
                Console.WriteLine("Adding: {0} + {1} = {2}", a, b, a + b);
                return a + b;
            }


        }

        public class FloatCalculator : BaseCalc<float>
        {
            public override float Subtract(float a, float b)
            {
                Console.WriteLine("Subtracting: {0} - {1} = {2}", a, b, a - b);
                return a - b;
            }


            public override float Multiply(float a, float b)
            {
                Console.WriteLine("Multiplying: {0} * {1} = {2}", a, b, a * b);
                return a * b;
            }

            public override float Mod(float a, float b)
            {
                Console.WriteLine("Modulus-ing: {0} % {1} = {2}", a, b, a % b);
                return a % b;
            }

            public override float Add(float a, float b)
            {
                Console.WriteLine("Adding: {0} + {1} = {2}", a, b, a + b);
                return a + b;
            }

        }

        public class CustomNumberCalculator : BaseCalc<CustomNumber>
        {
            public override CustomNumber Subtract(CustomNumber a, CustomNumber b)
            {
                Console.WriteLine("Subtracting: {0} - {1} = {2}", a, b, a - b);
                return a - b;
            }


            public override CustomNumber Multiply(CustomNumber a, CustomNumber b)
            {
                Console.WriteLine("Multiplying: {0} * {1} = {2}", a, b, a * b);
                return a * b;
            }

            public override CustomNumber Mod(CustomNumber a, CustomNumber b)
            {
                Console.WriteLine("Modulus-ing: {0} % {1} = {2}", a, b, a % b);
                return a % b;
            }

            public override CustomNumber Add(CustomNumber a, CustomNumber b)
            {
                Console.WriteLine("Adding: {0} + {1} = {2}", a, b, a + b);
                return a + b;
            }

        }
    }


}
