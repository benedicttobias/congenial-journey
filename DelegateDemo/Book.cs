namespace DelegateDemo
{
    public class Book
    {
        // CTOR
        public Book(string title)
        {
            Title = title;
        }

        private string _title;

        public event NameChangedDelegate NameChanged;

        public string Title
        {
            // Return title immediately
            get => _title;
            set
            {
                // Build args
                var args = new NameChangedEventArgs
                {
                    NameBefore = _title,
                    NameAfter = value
                };

                // Null propagation
                // If name changed is not null, do invoke namechanged(this, args)
                NameChanged?.Invoke(this, args);

                // Set title
                _title = value;
            }
        }
    }
}
