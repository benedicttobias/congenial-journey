using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
using Unity;

namespace IoCUnityDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // build container
            var container = new UnityContainer();

            // Register
            container.RegisterType<IWritterDevice, Printer>();
            container.RegisterType<IWritterDevice, Emailer>(); // Unity using the last registered

            // Get instance using IoC
            var writer = container.Resolve<Writter>();

            // Write them
            writer.Write("My text is using Unity");
        }
        
    }
}
