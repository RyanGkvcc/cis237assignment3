using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    interface IDroid
    {
        //Ensure that all classes that implement the IDroid Interface use the following.
        void CalculateTotalCost();

        decimal TotalCost { get; set; }
    }
}
