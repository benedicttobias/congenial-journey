using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Emailer : IWritterDevice
    {
        public void Write(string text)
        {
            Console.WriteLine("Emailing...." + text);
        }
    }
}
