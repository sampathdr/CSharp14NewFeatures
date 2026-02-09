using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp14.PartialEventsAndConstructors
{
    internal partial class User
    {
        public partial string FirstName 
        { 
            get => field; 
            set => field = value ?? throw new ArgumentNullException(nameof(value)); 
        }

        public partial string LastName
        {
            get => field;
            set => field = value ?? throw new ArgumentNullException(nameof(value));
        }

        public partial User(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            OnCreated();
        }

        public partial void OnCreated()
        {
            Console.WriteLine($"User created: {FirstName} {LastName}");
        }
    }
}
