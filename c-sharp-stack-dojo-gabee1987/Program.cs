using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_stack_dojo_gabee1987
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> testStringStack = new Stack<string>(5);

            Console.WriteLine("After adding 5 element to it: ");
            testStringStack.Push("1st Element");
            testStringStack.Push("2nd Element");
            testStringStack.Push("3rd Element");
            testStringStack.Push("4th Element");
            testStringStack.Push("5th Element");
            Console.WriteLine(testStringStack.ToString());

            Console.WriteLine();

            Console.WriteLine("After removing the last 2 element:");
            testStringStack.Pop();
            testStringStack.Pop();
            Console.WriteLine(testStringStack.ToString());

            Console.WriteLine("Peeking the last element:");
            string lastItem = testStringStack.Peek();
            Console.WriteLine(lastItem);


            Console.ReadLine();
        }
    }
}
