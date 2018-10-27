using System;

namespace DelegateDemo
{
    public class NameChangedEventArgs : EventArgs
    {
        public string NameBefore { get; set; }
        public string NameAfter { get; set; }
    }

}
