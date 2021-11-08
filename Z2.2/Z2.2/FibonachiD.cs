using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Z2._2
{
    public class FibonachiD
    {
        protected internal IFibonachi Fibon { get; }

        public FibonachiD(IFibonachi fibon)
        {
            Fibon = fibon;
        }

        public int Value
        {
            get
            {
                return Fibon.Value * 2;
            }
        }
    }
}
