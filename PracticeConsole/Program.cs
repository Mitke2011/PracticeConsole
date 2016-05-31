using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole
{
    class Program
    {
        /// <summary>
        /// Problem 1
        /// </summary>
        /// <returns></returns>
        public int SumMultipliesOfNumbers()
        {
            int result = 0;

            for (int i = 0; i < 1000; i++)
            {
                int mod3 = i % 3;
                int mod5 = i % 5;

                if (mod3 == 0 || mod5 == 0)
                {
                    result += i;
                }
            }
            return result;
        }

        /// <summary>
        /// Problem 2
        /// </summary>
        /// <returns></returns>
        public int SumEvenElements()
        {
            int result = 0;
            int current = 2;
            int temp = 0;
            int previous = 1;

            result = 0;
            while (current < 4000000)
            {
                temp = current;
                if (current % 2 == 0)
                {
                    result += current;
                }
                current = current + previous;
                previous = temp;
            }
            return result;
        }

        /// <summary>
        /// Problem 3
        /// </summary>
        /// <param name="args"></param>
        /// 
        public long ReturnMaxPrime()
        {
            long result = 0;
            long current = 600851475143;
            long candidate = current - 1;
            List<long> list = new List<long>();

            while (candidate != 1)
            {
                if (current % candidate == 0)
                {
                    list.Add(candidate);
                }

                candidate--;

            }

            list.Distinct();
            return result;
        }
        static void Main(string[] args)
        {
            Program p = new Program();

            //Problem 1
            //Console.WriteLine(p.SumMultipliesOfNumbers());

            //Problem 2
            //Console.WriteLine(p.SumEvenElements());

            //Problem 3
            Console.WriteLine(p.ReturnMaxPrime());


            Console.ReadLine();
        }


    }
}
