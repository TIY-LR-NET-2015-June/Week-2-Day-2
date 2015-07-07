using System;

namespace Week2Day2extensions
{

    
    public interface IVehicle
    {

    }

    //declare a extenstion for generic types
    public static class ShopExtensions
    {
        public static void ChangeTires<T>(this Shop<T> blahblah, IVehicle vehicle) where T : IVehicle
        {
            //
        }
    }
    public class Shop<T> 
    {

    }


    //standard extension declartions
    public static class PersonExtensions
    {
        //only works for Person
        public static string PrintReverseName(this Person p)
        {
            return p.LastName + ", " + p.FirstName;
        }

        //only works on strings
        public static int ParseANumber(this string x)
        {
            return int.Parse(x);
        }
    }

    public sealed class Person
    {
        private string v1;
        private int v2;

        public Person(string v1, int v2)
        {
            
            this.FirstName = v1.Split(' ')[0];
            this.LastName = v1.Split(' ')[1];
            this.Age = v2;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    
       

    }
}