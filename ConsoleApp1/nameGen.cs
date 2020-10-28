using PlugBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class nameGen : Generator
    {
        List<string> names;

        public nameGen(List<string> names)
        {
            this.names = names;
        }

        public nameGen()
        {
            this.names = new List<string>();
            names.Add("Smith");
            names.Add("Johnson");
            names.Add("Williams");
            names.Add("Jones");
            names.Add("Brown");
            names.Add("Davis");
            names.Add("Miller");
            names.Add("Wilson");
            names.Add("Moore");
            names.Add("Taylor");
            names.Add("Anderson");
            names.Add("Thomas");
            names.Add("Jackson");
            names.Add("White");
            names.Add("Harris");
            names.Add("Martin");
            names.Add("Thompson");
            names.Add("Garcia");
            names.Add("Martinez");
            names.Add("Robinson");
            names.Add("Clark");
            names.Add("Rodriguez");
            names.Add("Lewis");
            names.Add("Lee");
            names.Add("Walker");
            names.Add("Hall");
            names.Add("Allen");
            names.Add("Young");
            names.Add("Hernandez");
            names.Add("King");
            names.Add("Wright");
            names.Add("Lopez");
            names.Add("Hill");
            names.Add("Scott");
            names.Add("Green");
            names.Add("Adams");
            names.Add("Baker");
            names.Add("Gonzalez");
            names.Add("Nelson");
            names.Add("Carter");
            names.Add("Mitchell");
            names.Add("Perez");
            names.Add("Roberts");
            names.Add("Turner");
            names.Add("Phillips");
            names.Add("Campbell");
            names.Add("Parker");
            names.Add("Evans");
            names.Add("Edwards");
            names.Add("Collins");
            names.Add("Stewart");
            names.Add("Sanchez");
            names.Add("Morris");
            names.Add("Rogers");
            names.Add("Reed");
            names.Add("Cook");
            names.Add("Morgan");
            names.Add("Bell");
            names.Add("Murphy");
            names.Add("Bailey");
            names.Add("Rivera");
            names.Add("Cooper");
            names.Add("Richardson");
            names.Add("Cox");
            names.Add("Howard");
            names.Add("Ward");
            names.Add("Torres");
            names.Add("Peterson");
            names.Add("Gray");
            names.Add("Ramirez");
            names.Add("James");
            names.Add("Watson");
            names.Add("Brooks");
            names.Add("Kelly");
            names.Add("Sanders");
            names.Add("Price");
            names.Add("Bennett");
            names.Add("Wood");
            names.Add("Barnes");
            names.Add("Ross");
            names.Add("Henderson");
            names.Add("Coleman");
            names.Add("Jenkins");
            names.Add("Perry");
            names.Add("Powell");
            names.Add("Long");
            names.Add("Patterson");
            names.Add("Hughes");
            names.Add("Flores");
            names.Add("Washington");
            names.Add("Butler");
            names.Add("Simmons");
            names.Add("Foster");
            names.Add("Gonzales");
            names.Add("Bryant");
            names.Add("Alexander");
            names.Add("Russell");
            names.Add("Griffin");
            names.Add("Diaz");
            names.Add("Hayes");
        }

        public object generate(Type t)
        {
            Random rand = new Random(DateTime.Now.Second);


            if (t == typeof(string))
            {
                return (object)names.OrderBy(xx => rand.Next()).First();

            }
            else { return null; }
           


            //throw new NotImplementedException();
        }
    }
}
