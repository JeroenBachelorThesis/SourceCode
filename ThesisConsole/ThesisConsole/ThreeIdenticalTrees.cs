using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp;

#pragma warning disable 219

namespace ThesisConsole
{
    internal class ThreeIdenticalTrees
    {
        public const string tree1 = @"
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
        private static void Main(string[] args)
        {
            var obj1 = CSharpSyntaxTree.ParseText(tree1);
            var objects = obj1.GetRoot().DescendantNodesAndSelf().ToArray();
        }
    }
}