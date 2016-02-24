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

        private Int32 trashCompactorOption;
        private Int32 vacuumOption;
        
        //private Decimal someNumber2;

        //8 parameter Constructor that uses the parent's constructor to do some of the work
        public Janitor(String material, String model, String color, Boolean toolbox, Boolean computerConnection, Boolean arm, Boolean trashCompactor, Boolean vacuum)
            : base(material, model, color, toolbox, computerConnection, arm)
        {
            this.trashCompactor = trashCompactor;
            this.vacuum = vacuum;
        }

        //Public override of the ToString method. It uses the parent's
        //ToString method to get some of it's work done.
        public override String ToString()
        {
            return base.ToString() + "Trash Compactor: " + trashCompactorOption.ToString("N") + " @ " + TRASHCOMPACTOR_PRICE.ToString("C") + Environment.NewLine +
                "Vacuum: " + vacuumOption.ToString("N") + " @ " + VACUUM_PRICE.ToString("C") + Environment.NewLine + 
                "Total Cost: " + this.totalCost.ToString("C");
        }

        //Public override method to override the virtual Calculate Total Cost Droid method.
        public override void CalculateTotalCost()
        {
            trashCompactorOption = 0;
            vacuumOption = 0;

            if (trashCompactor)
            {
                trashCompactorOption = 1;
                this.totalCost += TRASHCOMPACTOR_PRICE;
            }
            if (vacuum)
            {
                vacuumOption = 1;
                this.totalCost += VACUUM_PRICE;
            }
            //get
            //{
            //    someNumber2 = 0m;
            //    if (trashCompactor)
            //    {
            //        someNumber2 += 1m;
            //    }
            //    if (vacuum)
            //    {
            //        someNumber2 += 1m;
            //    }
            //    return this.someNumber2;
            //}
        }
    }
}
