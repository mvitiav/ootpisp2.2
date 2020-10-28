using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class PersonID
    {

        public PersonID(string name, string surname, int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }

        public DateTime birthDay;

        public string name { get; private set;}
        public string surname { get; private set;}
        public int age { get; private set; }
        public int height { get; private set; }

        public string secondName;
        private string secretSecondName;

        public override string ToString()
        {
            return (this.name+" "+this.surname+": "+this.age);
        }
    }
}
