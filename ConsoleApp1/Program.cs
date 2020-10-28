using Microsoft.VisualBasic.CompilerServices;
using PlugBase;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.SymbolStore;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Numerics;
using System.Reflection;

namespace ConsoleApp1
{
    //class exprTest
    //{
    //    public List<Expression<Func<int, bool>>> exprList =;
    //    public Expression<Func<int, bool>> lambda;
    //}
    class TestPrime {
        public BigInteger prime;
        public override string ToString()
        {      
            return prime.ToString();
        }
    }

    class Test {
        public List<AA> l1;
        public override string ToString()
        {
            //return l1.ToString();
            return '<'+String.Join("><",l1)+'>';
        }
    }

    class Test2
    {
        public Test[] l1;
        public override string ToString()
        {          
            return '[' + String.Join("]\n[", (object[])l1) + ']';
        }
    }

    class AA
    {
        public string s1;
        public BB bb { get; set; } 
        public BB bb2 { get; set; }

        public override string ToString()
        {
            return "s1: "+s1+" s2: "+bb.s2+" s3: "+bb.cc.s3;
        }
    }

    class BB
    {
        public string s2;
     public CC cc{ get; set; }
        public override string ToString()
        {
            return "s2: "+s2 + " s3: " + cc.s3+" s1: "+cc.aa.s1;
        }
    }

    class CC
    {
        public string s3;
        public AA aa{ get; set; }
        public override string ToString()
        {
            return "s3: " + s3 + " s1: " + aa.s1 + " s2: " + aa.bb.s2;
        }

    }

class Program
    {
        static Assembly LoadPlugin(string relativePath)
        {
            // Navigate up to the solution root
            string root = Path.GetFullPath(Path.Combine(
                Path.GetDirectoryName(
                    Path.GetDirectoryName(
                        Path.GetDirectoryName(
                            Path.GetDirectoryName(
                                Path.GetDirectoryName(typeof(Program).Assembly.Location)))))));

            string pluginLocation = Path.GetFullPath(Path.Combine(root, relativePath.Replace('\\', Path.DirectorySeparatorChar)));
            Console.WriteLine($"Loading Generator from: {pluginLocation}");
            PluginLoadContext loadContext = new PluginLoadContext(pluginLocation);
            return loadContext.LoadFromAssemblyName(new AssemblyName(Path.GetFileNameWithoutExtension(pluginLocation)));
        }
        static IEnumerable<Generator> CreateGenerator (Assembly assembly)
        {
            int count = 0;

            foreach (Type type in assembly.GetTypes())
            {
                if (typeof(Generator).IsAssignableFrom(type))
                {
                    Generator result = Activator.CreateInstance(type) as Generator;
                    if (result != null)
                    {
                        count++;
                        yield return result;
                    }
                }
            }

            if (count == 0)
            {
                string availableTypes = string.Join(",", assembly.GetTypes().Select(t => t.FullName));
                throw new ApplicationException(
                    $"Can't find any type which implements Generator in {assembly} from {assembly.Location}.\n" +
                    $"Available types: {availableTypes}");
            }
        }
        static void Main(string[] args)
        {
            string[] pluginPaths = new string[]
            {
            @"SeparatePlugin1\bin\Debug\netcoreapp3.1\SeparatePlugin1.dll"
            };


            IEnumerable<Generator> generators = pluginPaths.SelectMany(pluginPath =>
            {
                Assembly pluginAssembly = LoadPlugin(pluginPath);
                return CreateGenerator(pluginAssembly);
            }).ToList();

           


            //List<Expression<Func<object, string>>> exprList =new List<Expression<Func<object, object>>>();
            //      List<Expression<Statement<object>>> exprList =new List<Expression<Action<object>>>();
            //    exprList.Add(foo => foo.City);

            //var p = Expression.Parameter(typeof(object));

            //Expression<Func<T, object>> expr = (foo => foo.City);

            FakerConfig fc = new FakerConfig();

            fc.addGen(new nameGen());
            fc.addGen(new RussianSurnameGen());
        
            foreach (Generator g in generators)
            {
                try
                {
                    fc.addGen(g);
                    Console.WriteLine(g.GetType().Name);
                    fc.add<TestPrime>(fc.generators[2], TestPrime => TestPrime.prime);
               
                }
                catch (ArgumentException E){
                    if (E.Message.Contains("Convert")) {
                        Console.WriteLine("it (lambda in .net) was broken from begining");
                        System.Environment.Exit(-1);
                    }
                }


            }


            //fc.add <TestPrime, string, g.GetType() > ((TestPrime => TestPrime.bi));
            //;

            //typeof(FakerConfig).GetMethod("add").MakeGenericMethod(t2).Invoke(fc, new object[] { (TestPrime => TestPrime.bi) });

            //fc.add<PersonID, string, fc.generators[0] > ((PersonId => PersonId.secondName));
            //fc.add<PersonID, string, fc.generators[0] > ((PersonId => PersonId.name));
            //fc.add<PersonID, string, fc.generators[1] > ((PersonId => PersonId.surname));
            fc.add<PersonID>(fc.generators[0], PersonId => PersonId.secondName);
            fc.add<PersonID>(fc.generators[0], PersonId => PersonId.name);
            fc.add<PersonID>(fc.generators[1], PersonId => PersonId.surname);

        
            

            //fc.add<PersonID, string, RussianSurnameGen>((PersonId => PersonId.surname));


            IFaker myFaker = new Faker(fc);


            AA aa = new AA();
            BB bb = new BB();
            CC cc = new CC();
            aa.bb = bb;
            bb.cc = cc;
            cc.aa = aa;

            // new FakerConfig().add< AA, string, null >(AA => AA.s1);
           

            //PropertyInfo pi = fc.GetPropertyInfo(aa, u => u.bb);
            // Console.WriteLine(pi.ReflectedType);


            //AA aa = myFaker.Create<AA>();
            //  Console.WriteLine(fc.checkIfPlugged(aa.GetType(), aa.GetType().GetField("s1")));

            //fc.add2<AA,string,>((AA => AA.s1));

            //Console.WriteLine(myFaker.Create<int>());
            //Console.WriteLine(myFaker.Create<string>());
            //Console.WriteLine(myFaker.Create<float>());
            //Console.WriteLine(myFaker.Create<double>());
            //Console.WriteLine(myFaker.Create<long>());
            //Console.WriteLine(new PersonID("Denni","C",20));
            //Console.WriteLine(myFaker.Create<Person>());        
            Console.WriteLine(myFaker.Create<TestPrime>());        
            //Console.WriteLine(myFaker.Create<Person>());        
            //Console.WriteLine(myFaker.Create<Person>());  
            //Console.WriteLine(myFaker.Create<AA>());  
            //Console.WriteLine(myFaker.Create<BB>());  
            //Console.WriteLine(myFaker.Create<CC>());  
            //Console.WriteLine(myFaker.Create<Test>());
            //Console.WriteLine(myFaker.Create<Test2>());

        }
    }
}
