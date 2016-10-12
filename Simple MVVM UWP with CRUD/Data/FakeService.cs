using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Diagnostics;

namespace Data
{
    public class Person
    {
        public String Name { get; set; }
        public String Line1 { get; set; }
        public String Line2 { get; set; }
        public String Line3 { get; set; }
        public String City { get; set; }
        public String County { get; set; }
        public String Postcode { get; set; }
        public int Age { get; set; }
    }

    public class FakeService
    {
        public static String Name = "Fake Data Service.";

        public static List<Person> GetPeople()
        {
            Debug.WriteLine("GET for people.");
            return new List<Person>()
                {
                    new Person() { Name="Chris Cole", Age=10, Line1="35", Line2="Walton Park Lane", Line3="Hersham", City="Walton on Thames", County="Surrey", Postcode="KT12 3HH" },
                    new Person() { Name="Kelly Kale", Age=32, Line1="35", Line2="Walton Park Lane", Line3="Hersham", City="Walton on Thames", County="Surrey", Postcode="KT12 3HH" },
                    new Person() { Name="David Smith", Age=32, Line1="35", Line2="Walton Park Lane", Line3="Hersham", City="Walton on Thames", County="Surrey", Postcode="KT12 3HH" },
                    new Person() { Name="Warren King", Age=32, Line1="35", Line2="Walton Park Lane", Line3="Hersham", City="Walton on Thames", County="Surrey", Postcode="KT12 3HH" },
                    new Person() { Name="Siu-Ki Lau", Age=32, Line1="35", Line2="Walton Park Lane", Line3="Hersham", City="Walton on Thames", County="Surrey", Postcode="KT12 3HH" },
                    new Person() { Name="Ges Thompson", Age=32, Line1="35", Line2="Walton Park Lane", Line3="Hersham", City="Walton on Thames", County="Surrey", Postcode="KT12 3HH" },
                    new Person() { Name="David Ancona", Age=32, Line1="35", Line2="Walton Park Lane", Line3="Hersham", City="Walton on Thames", County="Surrey", Postcode="KT12 3HH" },
                    new Person() { Name="Chan Ali", Age=32, Line1="35", Line2="Walton Park Lane", Line3="Hersham", City="Walton on Thames", County="Surrey", Postcode="KT12 3HH" },
                    new Person() { Name="Fred Askew", Age=32, Line1="35", Line2="Walton Park Lane", Line3="Hersham", City="Walton on Thames", County="Surrey", Postcode="KT12 3HH" },
                    new Person() { Name="Manu Mohammed", Age=32, Line1="35", Line2="Walton Park Lane", Line3="Hersham", City="Walton on Thames", County="Surrey", Postcode="KT12 3HH" },
                    new Person() { Name="Brian Zaw", Age=32, Line1="35", Line2="Walton Park Lane", Line3="Hersham", City="Walton on Thames", County="Surrey", Postcode="KT12 3HH" },
                    new Person() { Name="Tom lees", Age=32, Line1="35", Line2="Walton Park Lane", Line3="Hersham", City="Walton on Thames", County="Surrey", Postcode="KT12 3HH" },
                    new Person() { Name="Christian Champion", Age=32, Line1="35", Line2="Walton Park Lane", Line3="Hersham", City="Walton on Thames", County="Surrey", Postcode="KT12 3HH" },
                    new Person() { Name="Kelly Kale", Age=32, Line1="35", Line2="Walton Park Lane", Line3="Hersham", City="Walton on Thames", County="Surrey", Postcode="KT12 3HH" },
                    new Person() { Name="Dylan Durbin", Age=18, Line1="35", Line2="Walton Park Lane", Line3="Hersham", City="Walton on Thames", County="Surrey", Postcode="KT12 3HH" }
                };
        }

        public static void Write(Person person)
        {
            Debug.WriteLine("INSERT person with name " + person.Name);
        }

        public static void Delete(Person person)
        {
            Debug.WriteLine("DELETE person with name " + person.Name);
        }
    }
}