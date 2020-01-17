using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dvonna.site.Model
{
    public class NumberOfLegs
    {
        private readonly int _value;

        public NumberOfLegs(int value)
        {
            if (value < 0 || value > 3)
            {
                throw new ArgumentException("Should be between 0 and 3", nameof(value));
            }

            _value = value;
        }

        public override string ToString()
        {
            return _value.ToString();
        }
    }
}
