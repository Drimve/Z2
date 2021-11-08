using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Z2
{
    public class FibonachiN : IFibonachiN
    {
        int _value;
        int n1 = 0,
            n2 = 1;

        public void Fib()
        {
            _value = n1 + n2;
            n1 = n2;
            n2 = _value;
        }

        public int Value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
            }
        }
    }
}