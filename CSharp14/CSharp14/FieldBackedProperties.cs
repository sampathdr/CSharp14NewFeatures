using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp14
{
    internal sealed class FieldBackedProperties
    {
        public  string Message 
        { 
            get => field; 
            set => field = value ?? throw new ArgumentNullException(nameof(value)); 
        }
    }
}
