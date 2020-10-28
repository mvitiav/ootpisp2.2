using System;
using System.Collections.Generic;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;

using PlugBase;

namespace SeparatePlugin1
{
    class PluginBody : Generator
 
    {

        private static RNGCryptoServiceProvider rngProvider = new RNGCryptoServiceProvider();
        private static Random random = new Random(DateTime.Now.Millisecond);
        private static byte[] someBytes;
        public static BigInteger GetRandomBigInteger(int nBits, bool onlyPositive = true)
        {
            someBytes = new byte[nBits / 8];
            rngProvider.GetBytes(someBytes);

            BigInteger bg = new BigInteger(someBytes);
            if (onlyPositive && bg.Sign == -1) bg = bg * -1;

            return bg;
        }
        Random rnd = new Random();
        public bool IsPrime(int n)
        {
            for (int i = 3; i * i <= n; i += 2)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }

        public object generate(Type t)
        {

            ////if (t.Equals(typeof(int)))
            ////{
            ////    return (object)FindPrime(0,int.MaxValue,5);
            ////}

            //int i = 131;
            ////int i = rnd.Next();
            ////while (!IsPrime(i)) {
            ////    i++;
            ////}


            if (t.Equals(typeof(BigInteger)))
            {
                return (object)GetRandomBigInteger(random.Next(10)*8);
            }
            else {
                return (0);
            }

            //return (object)i;



        }


    }
}
