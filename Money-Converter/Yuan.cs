using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money_Converter
{
    internal class Yuan
    {
        public decimal Money  { get; set; }

        public static implicit operator Yuan(Euro x)
        {

            return new Yuan { Money = x.Money * (decimal) 2.0 };
        }
        public static explicit operator Euro(Yuan counter)
        {

            return new Euro { Money=counter.Money / (decimal)1.15 };
        }
        public void Summ()
        {
            
            Console.WriteLine();
        }
    }
}
