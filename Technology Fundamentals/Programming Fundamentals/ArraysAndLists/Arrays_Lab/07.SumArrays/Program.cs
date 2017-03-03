using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.SumArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            int[] nums2 = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

            int length1 = nums1.Length;
            int length2 = nums2.Length;

            int[] sum = new int[Math.Max(length1, length2)];

            for (int i = 0; i < sum.Length; i++)
            {
                sum[i] = nums1[i % length1] + nums2[i % length2];
            }




            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
