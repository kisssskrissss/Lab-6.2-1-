using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            str = str.Replace(" ", "");
            str = str.ToLower();
            string str1 = "";

            foreach (char c in str)
            {
                str1 = c + str1;
            }
            Console.WriteLine(str1);
            Console.WriteLine(str.Equals(str1));



            Console.ReadKey();
        }

    }
}
