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
        private const Decimal COST_PER_SHIP = 1m;

        private Decimal someNumber3;

        //8 parameter Constructor that uses the parent's constructor to do some of the work
        public Astromech(String material, String model, String color, Boolean toolbox, Boolean computerConnection, Boolean arm, Boolean fireExtinquisher, Int32 numberShips)
            : base (material, model, color, toolbox, computerConnection, arm)
        {
            this.fireExtinquisher = fireExtinquisher;
            this.numberShips = numberShips;
        }

        //Public property for the CalculateTotalCost backing field
        public Decimal CalculateTotalCost3
        {
            get
            {
                someNumber3 = 0m;
                if (fireExtinquisher)
                {
                    someNumber3 += 1m;
                }
                return this.someNumber3;
            }
        }

        //Public override of the ToString method. It uses the parent's
        //toString method to get some of it's work done.
        public override String ToString()
        {
            return base.ToString() + " " + this.CalculateTotalCost3.ToString("C");
        }
    }
}
