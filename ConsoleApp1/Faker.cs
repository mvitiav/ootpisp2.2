using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ConsoleApp1
{
    class Faker : IFaker
    {
        bool isInPlugins(PropertyInfo pi) {

            return fc.checkIfPlugged(pi);
            
           }
        bool isInPlugins(FieldInfo pi)
        {

            return fc.checkIfPlugged(pi);

        }
        bool isInPlugins(ParameterInfo pi)
        {

            return fc.checkIfPlugged(pi);

        }

        static List<Type> defaultTypes = new List<Type> {typeof(int),typeof(long),typeof(double),typeof(float),typeof(string),typeof(System.DateTime) };
        List<Type> visited; 
        static Random rnd = new Random();
        
       static MethodInfo createMethodInfo = typeof(Faker).GetMethod("Create2");
        FakerConfig fc;

        public Faker(FakerConfig fakerConfig)
        {
            fc = fakerConfig;
            //todo///
        }
        public Faker()
        {

            
        }


        //private object CreateO(Type t) {

        //    return ;
        //}
        public T Create<T>()
        {

            visited = new List<Type>();
           
            
                return (T)(object)createMethodInfo.MakeGenericMethod(typeof(T)).Invoke(this, new object[] { visited });
           
        
        }
        public T Create2<T>(List<Type> visited_old)
        {
          
            List<Type> visited = new List<Type>(visited_old);
            bool isVisited = visited.Contains(typeof(T));
            visited.Add(typeof(T));
            //var mi = typeof(Faker).GetMethod("Create");
            //var fooRef = mi.MakeGenericMethod(t);

        Type itemType = typeof(T);
            //if (T=int)
            if ((itemType != typeof(string)) && (itemType.GetInterface(nameof(IEnumerable)) != null))
            {
                //return 
                int listItemsCount = rnd.Next(10);
                
                if (itemType.IsArray)
                {
                    //array
                    Type t2 = itemType.GetElementType();

                    //object instance = (object[])
                    //    Activator.CreateInstance(t2, new object[] { listItemsCount }); 
                    Array instance = Array.CreateInstance(t2, listItemsCount);
                    for (int i = 0; i < listItemsCount; i++)
                    {

                        
                        instance.SetValue(createMethodInfo.MakeGenericMethod(t2).Invoke(this, new object[] { visited }), i);
                        


                        //instance[i]=((object)
                        //    createMethodInfo.MakeGenericMethod(t2).Invoke(this, new object[] { visited })
                        //    );
                    }

                    return (T)(object)instance;
                    //array
                }
                    //if (typeof(List<object>).IsAssignableFrom(typeof(T)))
                    if ((itemType.IsGenericType)&&(itemType.GetGenericTypeDefinition() == typeof(List<>)))
                {
                    //list

                    Type[] genArgs = itemType.GetGenericArguments();
                    Type t2 = genArgs[0];
                    if (itemType.GetGenericArguments().Any())
                {
                    t2 = itemType.GetGenericArguments()[0];


                    var listType = typeof(List<>);
                    var constructedListType = listType.MakeGenericType(t2);
                    var instance = (IList)Activator.CreateInstance(constructedListType);

                    for (int i = 0; i < listItemsCount; i++)
                    {
                        instance.Add((object)
                            createMethodInfo.MakeGenericMethod(t2).Invoke(this, new object[] { visited })
                            );
                    }
                    return (T)(object)instance;
                }
                else {
                    return (T)(object)null;
                }

                //list
                }

               
            }

            if (defaultTypes.Contains(itemType))
            {
                int index = defaultTypes.IndexOf(itemType);
                switch (index)
                {
                    case (0):
                        {
                            return (T)(object)rnd.Next();
                        }
                    case (1):
                        {
                            long result = rnd.Next();
                            result = (result << 32);
                            result = result | (long)rnd.Next();
                            return (T)(object)result;
                        }
                    case (2):
                        {
                            return (T)(object)rnd.NextDouble();
                        }
                    case (3):
                        {
                            double mantissa = (rnd.NextDouble() * 2.0) - 1.0;
                            // choose -149 instead of -126 to also generate subnormal floats (*)
                            double exponent = Math.Pow(2.0, rnd.Next(-126, 128));
                            float f = (float)(mantissa * exponent);
                            return (T)(object)f;
                        }
                    case (4):
                        {
                            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                            string s = new string(Enumerable.Repeat(chars, rnd.Next(15))
                              .Select(s => s[rnd.Next(s.Length)]).ToArray());
                            return (T)(object)s;
                        }
                    case (5):
                        {
                            DateTime dt = DateTime.Now.AddDays(rnd.Next(1000)).AddHours(rnd.Next(23)+rnd.NextDouble()).AddMinutes(rnd.Next(59) + rnd.NextDouble()).AddSeconds(rnd.Next(59) + rnd.NextDouble()).AddMilliseconds(rnd.Next(1000) + rnd.NextDouble());
                            //DateTime start = new DateTime(1995, 1, 1);
                            //int range = (DateTime.Today - start).Days;
                            //DateTime dt = start.AddDays(rnd.Next(range));
                            return (T)(object)dt;
                        }
                    default:
                        throw new TypeAccessException("index or something else failed :(");

                }
            }
            else
            {
                if (!isVisited) { 

                ConstructorInfo selectedConstructor = null;
                int count = int.MaxValue;

                //todo add try section for all ther constructors
                foreach (System.Reflection.ConstructorInfo ci in itemType.GetConstructors())
                { //selecting minimal params count constructor
                    if (ci.GetParameters().Length < count)
                    {
                        selectedConstructor = ci;
                        count = ci.GetParameters().Length;
                    }
                }

                object[] paramz = null;

                paramz = new object[count];

                for (int i = 0; i < count; i++)
                {
                    
                        
                        
                    Type t = selectedConstructor.GetParameters()[i].ParameterType;
                        //var type = (selectedConstructor.GetParameters()[i].ParameterType).MakeGenericType(Type.GetType());
                        //var contextType = selectedConstructor.GetParameters()[i].ParameterType;
                        //  var createType = typeof(this.Create<>);
                        // dynamic v2 = t.GetType().GetProperty("Value").GetValue(t, null);
                        //  var type2 =        

                        //if (
                        //    (isInPlugins(itemType.GetField(selectedConstructor.GetParameters()[i].Name)))

                        //    (isInPlugins(itemType.GetProperty(selectedConstructor.GetParameters()[i].Name)))
                        //    ) { 

                        //}

                        FieldInfo fic = itemType.GetField(selectedConstructor.GetParameters()[i].Name);
                        PropertyInfo pic = itemType.GetProperty(selectedConstructor.GetParameters()[i].Name);
                        if ((fic!=null)&&(isInPlugins(fic))) {
                            paramz[i] = fc.getGen(fc.dictionary3[fic]).generate(fic.FieldType);
                        }
                        else
                        if ((pic!=null) &&(isInPlugins(pic))) {
                            paramz[i] = fc.getGen(fc.dictionary2[pic]).generate(pic.PropertyType);
                        }
                        else
                        {
                    paramz[i] = createMethodInfo.MakeGenericMethod(t).Invoke(this, new object[] { visited });
                        }

                }
                    object instance;
                    try
                    {
                        instance = selectedConstructor.Invoke(paramz);
                    }
                    catch (Exception e) {
                        instance = default(T);
                    }
              



                //var listOfFieldNames = typeof(T).GetProperties().Select(f => f.Name).ToList();

                //var listOfFieldValues = instance.GetType().GetProperties().Select(f => f.GetValue(instance, null)).ToList();



                foreach (PropertyInfo pi in typeof(T).GetProperties())
                {


                        //try
                        //{
                        if ((null != (pi.GetSetMethod(true))) && (pi.GetSetMethod(true).IsPublic))
                            if (isInPlugins(pi))
                            {
                                pi.SetValue(instance, fc.getGen(fc.dictionary2[pi]).generate(pi.PropertyType));
                            }
                            else { 
                                pi.SetValue(instance, createMethodInfo.MakeGenericMethod(pi.PropertyType).Invoke(this, new object[] { visited }));
                            
                            }
                       // }
                       // catch (Exception e) { 
                       ////todo: log?
                       // }
                    // Console.WriteLine(pi.Name + " " + pi.CanWrite + " " + pi.GetValue(instance));
                }


                foreach (FieldInfo fi in typeof(T).GetFields())
                {
                        if ((fi.IsPublic) && (!fi.IsStatic))
                            if (isInPlugins(fi))
                            {
                                fi.SetValue(instance, fc.getGen(fc.dictionary3[fi]).generate(fi.FieldType));
                            }
                            else
                            {
                                fi.SetValue(instance, createMethodInfo.MakeGenericMethod(fi.FieldType).Invoke(this, new object[] { visited }));
                            }
                    //Console.WriteLine(fi.Name + " " + fi.IsPublic + " " + fi.GetValue(instance));
                }


                return (T)instance;
            }else { return default(T); }
               
            }



           
            //throw new NotImplementedException();
        }


    }
}
