using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp14.PartialEventsAndConstructors
{
    internal partial class User
    {
        public partial string FirstName { get; set; }
        public partial string LastName { get; set; }

        public partial User(string firstName, string lastName);
        public partial void OnCreated();

    }
}
