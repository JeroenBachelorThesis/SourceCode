using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThesisConsole
{
    internal class LinqAlloc
    {
        private static void Main2(string[] args)
        {
            // Setting baseline snapshot
            var list1 = new List<int> {4862, 6541, 7841};
            var list2 = new List<int>(list1.Count);
            var list3 = new List<int>(list1.Count);

            // First snapshot: LINQ usage
            list2.AddRange(list1.Where(item => item > 5000 && item < 7000));

            // Second snapshot: foreach-loop
            foreach (var item in list1)
            {
                if (item > 5000 && item < 7000)
                {
                    list3.Add(item);
                }
            }

            // End gather
            Console.Read();
        }
    }
}