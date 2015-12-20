using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThesisConsole
{
    internal class ThreeIdenticalTrees
    {
        private const int y = 5;
        static void Main(string[] args)
        {
            const string tree1 = @"
using System;
using System.Text;

class MyClass 
{
    void MyMethod()
    {
        int result = 2 + 2;
        Console.WriteLine(result);
    }
}";

            //            const string tree2 = @"
            //using System;
            //using System.Text;

            //class MyClass 
            //{
            //    void MyMethod()
            //    {
            //        int result = 2 + 2;
            //        Console.WriteLine(result);
            //    }
            //}";

            //            const string tree3 = @"
            //using System;
            //using System.Text;

            //class MyClass 
            //{
            //    void MyMethod()
            //    {
            //        int result = 2 + 2;
            //        Console.WriteLine(result);
            //    }
            //}";
            //        }

        }
}
