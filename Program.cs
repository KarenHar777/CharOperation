using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharOperation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char a = 'a';   
            char b = 'b';
            Console.WriteLine(a+b); //195
            Console.WriteLine(a.ToString()+b.ToString()); // ab

            Console.ReadKey();  
        }
    }
}
