using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    partial class Program
    {
        // Start program
        static void Main(string[] args)
        {
            // Build new instance
            var myBook = new Book("Speech 101");

            // Assign event
            myBook.NameChanged += OnNameChanged;

            // Trigger event
            myBook.Title = "General Science 101";

            // Trigger event
            myBook.Title = "Mathematics 101";
        }

        // What we want to do for the event
        public static void OnNameChanged(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine($"Book title changed from {args.NameBefore} to {args.NameAfter}");
        }
    }
}