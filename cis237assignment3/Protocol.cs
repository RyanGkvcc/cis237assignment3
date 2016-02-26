using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Protocol : Droid
    {
        //Backing fields
        private Int32 numberLanguages;
        
        //Constants for Cost per language
        private const Decimal COST_PER_LANGUAGE = 1m;

        //4 parameter Constructor that uses the parent's constructor to do some of the work
        public Protocol(String material, String model, String color, Int32 numberLanguages) : base(material, model, color)
        {
            this.numberLanguages = numberLanguages;
        }

        //Public override of the ToString method. It uses the parent's
        //toString method to get some of it's work done.
        public override String ToString()
        {
            return base.ToString() + "Number of Languages: " + numberLanguages.ToString("N") + " @ " + COST_PER_LANGUAGE.ToString("C") + Environment.NewLine +
                "Total Cost: " + this.totalCost.ToString("C");
        }

        //Public override method to override the virtual Calculate Total Cost Droid method.
        public override void CalculateTotalCost()
        {
            this.totalCost += (this.numberLanguages * COST_PER_LANGUAGE);
        }
    }
}
