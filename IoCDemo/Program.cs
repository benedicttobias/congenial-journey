using System;
using Core;

namespace IoCDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var printer = new Emailer();
            var writter = new Writter(printer);

            writter.Write("My text");
        }
    }
}
