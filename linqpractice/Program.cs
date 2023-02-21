using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqpractice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("輸入一個用逗號區隔的整數數列 ");
            string str = Console.ReadLine();
            string[] numbers = str.Split(',');
            var results=numbers.OrderByDescending(x => x);
            foreach(var result in results)
            {
                Console.Write($"{result},");
            }
            Console.ReadLine();
        }
    }
}
