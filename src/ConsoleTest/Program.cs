using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OpenNLP.ConsoleApp2;

namespace ConsoleTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string str = ".NET Framework (pronounced dot net) is a software framework developed by Microsoft that runs primarily on Microsoft Windows. It includes a large class library known as Framework Class Library (FCL) and provides language interoperability (each language can use code written in other languages) across several programming languages. Programs written for .NET Framework execute in a software environment (as contrasted to hardware environment) known as Common Language Runtime (CLR), an application virtual machine that provides services such as security, memory management, and exception handling. (As such, computer code written using .NET Framework is called 'managed code'.) FCL and CLR together constitute .NET Framework.";
            var arr = new NLPClass().Split(str);
            foreach (var s in arr)
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();
        }
    }
}
