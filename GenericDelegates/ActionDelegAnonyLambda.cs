using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDelegates
{
    internal class ActionDelegAnonyLambda
    {
        public void print(string name)
        {
            Console.WriteLine(name);
        }
        public void print()
        {
            Console.WriteLine("Hello");
        }

        public void AddingNum(double num1, double num2) 
        {
            Console.WriteLine(num1 + num2);
        }
    }
}
