using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp14.UserDefinedCompoundAssignmentOperators
{
    internal sealed class Bottle
    {
        public float Capacity { get; set; }
        public float Volume { get; private set; }

        public Bottle(float capacity) => Capacity = capacity;

        //Use + operator to increase the Volume
        public void operator +=(float volume)
        {
            if (this.Volume + volume > Capacity)
                throw new InvalidOperationException("Not enough capacity!");

            this.Volume += volume;
        }
    }
}
