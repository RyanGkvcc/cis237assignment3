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
        private const Decimal MODEL_COST = 100m;

        //4 parameter Constructor that uses the parent's constructor to do some of the work
        public Protocol(String model, String material, String color, Int32 numberLanguages) : base(model, material, color)
        {
            this.numberLanguages = numberLanguages;
        }

        //Public override of the ToString method. It uses the parent's
        //toString method to get some of it's work done.
        public override String ToString()
        {
            return base.ToString() + "Number of Languages: " + numberLanguages.ToString("N0") + " @ " + COST_PER_LANGUAGE.ToString("C") + Environment.NewLine;
        }

        //Overrides the parent ModelCost and sets the price for this model.
        protected override decimal ModelCost
        {
            get
            {
                return MODEL_COST;
            }
        }

        //Public override method to override the virtual Calculate Total Cost Droid method.
        public override void CalculateTotalCost()
        {
            CalculateBaseCost();
            this.totalCost = (this.numberLanguages * COST_PER_LANGUAGE) + this.baseCost;
        }
    }
}
