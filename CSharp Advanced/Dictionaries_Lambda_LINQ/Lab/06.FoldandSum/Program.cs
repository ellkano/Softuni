using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.FoldandSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] originalNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int k = originalNumbers.Length / 4;

            int[] firstLeftRow = originalNumbers.Take(k).Reverse().ToArray();
            int[] firstRightRow = originalNumbers.Reverse().Take(k).ToArray();
            int[] firstRow = firstLeftRow.Concat(firstRightRow).ToArray();
            int[] secondRow = originalNumbers.Skip(k).Take(2 * k).ToArray();

            int[] sum = firstRow.Select((x, index) => x + secondRow[index]).ToArray(); // за всяко число с даден индекс от firstRow го събери с числото със същия индекс от secondRow 

             Console.WriteLine(String.Join(" ", sum));
        }
    }
}
