using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Janitor : Utility
    {
        //Backing fields
        private Boolean trashCompactor;
        private Boolean vacuum;

        private const Decimal TRASHCOMPACTOR_PRICE = 9m;
        private const Decimal VACUUM_PRICE = 11m;
        private const Decimal MODEL_COST = 300m;

        private Int32 trashCompactorOption;
        private Int32 vacuumOption;
        
        //8 parameter Constructor that uses the parent's constructor to do some of the work.
        public Janitor(String model, String material, String color, Boolean toolbox, Boolean computerConnection, Boolean arm, Boolean trashCompactor, Boolean vacuum)
            : base(model, material, color, toolbox, computerConnection, arm)
        {
            this.trashCompactor = trashCompactor;
            this.vacuum = vacuum;
        }

        //Public override of the ToString method. It uses the parent's
        //ToString method to get some of it's work done.
        public override String ToString()
        {
            return base.ToString() + "Trash Compactor: " + trashCompactorOption.ToString("N0") + " @ " + TRASHCOMPACTOR_PRICE.ToString("C") + Environment.NewLine +
                "Vacuum: " + vacuumOption.ToString("N0") + " @ " + VACUUM_PRICE.ToString("C") + Environment.NewLine;
        }

        //Overrides the parent ModelCost and returns the price for this model.
        protected override decimal ModelCost
        {
            get
            {
                return MODEL_COST;
            }
        }

        //Returns the option cost for the Janitor being built.
        protected Decimal JanitorOptionCost
        {
            get
            {
                Decimal optionCost = 0m;
                trashCompactorOption = 0;
                vacuumOption = 0;

                if (trashCompactor)
                {
                    trashCompactorOption = 1;
                    optionCost += TRASHCOMPACTOR_PRICE;
                }
                if (vacuum)
                {
                    vacuumOption = 1;
                    optionCost += VACUUM_PRICE;
                }

                return optionCost;
            }
        }

        //Public override method to override the virtual Calculate Total Cost Droid method.
        public override void CalculateTotalCost()
        {
            CalculateBaseCost();
            this.totalCost = this.baseCost + UtilityOptionCost + JanitorOptionCost;
        }
    }
}
