using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.SumAdjacentEqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<decimal> numbers = Console.ReadLine().Split().Select(x => decimal.Parse(x)).ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (i < numbers.Count - 1 && numbers[i] == numbers[i + 1])
                {
                    numbers[i] += numbers[i + 1];
                    numbers.RemoveAt(i + 1);
                    i = -1;
                }
            }

            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}




//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _12.SumAdjacentEqualNumbers
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            List<decimal> numbers = Console.ReadLine().Split().Select(x => decimal.Parse(x)).ToList();

//            for (int i = 1; i < numbers.Count; i++)
//            {
//                if (numbers[i - 1] == numbers[i])
//                {
//                    numbers[i - 1] += numbers[i];
//                    numbers.RemoveAt(i);
//                    i = 0;
//                }
//            }

//            Console.WriteLine(String.Join(" ", numbers));
//        }
//    }
//}
