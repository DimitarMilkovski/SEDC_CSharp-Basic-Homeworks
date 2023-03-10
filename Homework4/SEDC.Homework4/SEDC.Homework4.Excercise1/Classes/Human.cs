using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Homework4.Excercise1.Classes
{
    public class Human
    {
        public Human(string firstname, string lastname, int age)
        {
            FirstName = firstname;
            LastName = lastname;
            Age = age;

        }


        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public void GetPersonStats()
        {
            Console.WriteLine($"{FirstName} {LastName} is {Age} years old. ");
        }
    }
}
