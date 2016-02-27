using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Astromech : Utility
    {
        //Backing fields
        private Boolean fireExtinquisher;
        private Int32 numberShips;

        //Constant for Cost per ship
        private const Decimal COST_PER_SHIP = 13m;
        private const Decimal MODEL_COST = 400m;

        //private Decimal someNumber3;

        //8 parameter Constructor that uses the parent's constructor to do some of the work
        public Astromech(String material, String model, String color, Boolean toolbox, Boolean computerConnection, Boolean arm, Boolean fireExtinquisher, Int32 numberShips)
            : base (material, model, color, toolbox, computerConnection, arm)
        {
            this.fireExtinquisher = fireExtinquisher;
            this.numberShips = numberShips;
        }

        //Public override of the ToString method. It uses the parent's
        //ToString method to get some of it's work done.
        public override String ToString()
        {
            return base.ToString() + "Fire Extinquisher: " + this.numberShips.ToString("N") + " @ " + COST_PER_SHIP.ToString("C") + Environment.NewLine +
                "Total Cost: " + this.totalCost.ToString("C");
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
            if (fireExtinquisher)
            {
                this.totalCost += (numberShips * COST_PER_SHIP);
            }
        }
    }
}
