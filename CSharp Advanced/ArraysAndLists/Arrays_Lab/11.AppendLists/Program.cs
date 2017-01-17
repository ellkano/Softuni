using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.AppendLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split('|').ToList();

            list.Reverse();

            List<string> final  = new List<string>();

            foreach (string item in list)
            {
                List<string> temp = item.Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries).ToList();
                foreach (var newstring in temp)
                {
                    final.Add(newstring);
                }
            }

            Console.WriteLine(string.Join(" ", final));
        }
    }
}



//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _11.AppendLists
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            List<string> list = Console.ReadLine().Split('|').ToList();

//            list.Reverse();

//            List<string> final = new List<string>();

//            foreach (string item in list)
//            {
//                List<string> temp = item.Split().ToList();
//                foreach (var newstring in temp)
//                {

//                    if (newstring != "")
//                    {
//                        final.Add(newstring);
//                    }

//                }
//            }

//            Console.WriteLine(string.Join(" ", final));
//        }
//    }
//}
