using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Person
    {
        public string Name;
        public string LastName;
        public string Country;
        public string Street;
        public int Age;

        public Person(string name, string lastName, string country, string street, int age)
        {
            Name = name;    
            LastName = lastName;
            Country = country;
            Street = street;
            Age = age;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            Person rafal = new Person("Rafal", "Zuzewicz", "Sweden", "Grönbacka", 26);

            Console.WriteLine(rafal.Name);



            string[] dane = { "Rafal", "Zuzewicz", "Poland", "Grönbacka ", "26" };
            
            for(int i = 0; i < dane.Length; i++)
            {
                Console.WriteLine(dane[i]);
            }
        }
    }
}
