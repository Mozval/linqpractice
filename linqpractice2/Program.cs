using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqpractice2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("輸入一個用逗號區隔的整數數列 ");
            string str = Console.ReadLine();
            var numbers = str.Split(',');
            List<MyData> list = new List<MyData>();
            foreach (var item in numbers)
            {
                list.AddRange(CreateList(item));
            }
            var odd = list.Where(x => x.num % 2 == 1).OrderBy(x => x.num).Select(x => x.num);
            var even = list.Where(x => x.num % 2 == 0).OrderBy(x => x.num).Select(x => x.num);
            Console.WriteLine($"odd {String.Join(",", odd)}");
            Console.WriteLine($"even {String.Join(",", even)}");
            Console.ReadKey();
        }
        static List<MyData> CreateList(string rd)
        {
            return new List<MyData>()
            {
                new MyData{ num = Convert.ToInt32(rd) },
            };
        }
        class MyData
        {
            public int num { get; set; }
        }



    }
    
}