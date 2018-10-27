using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Writter
    {
        private readonly IWritterDevice _writterDevice;

        // Dependency injection
        public Writter(IWritterDevice writterDevice)
        {
            _writterDevice = writterDevice;
        }

        public void Write(string myText)
        {
            _writterDevice.Write(myText);
        }
    }
}
