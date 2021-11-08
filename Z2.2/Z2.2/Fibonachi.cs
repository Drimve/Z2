using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Z2._2
{
        public class Fibonachi : IFibonachi
        {
            int x1 = 0;
            int x2 = 1;
            private int _value;

            public void Fibo()
            {
                _value = x1 + x2;
                x1 = x2;
                x2 = _value;
            }

            public int Value
            {
                get { return _value; }
            }
        }
    }
