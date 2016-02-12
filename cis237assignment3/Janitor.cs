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

        private Decimal someNumber2;

        //8 parameter Constructor that uses the parent's constructor to do some of the work
        public Janitor(String material, String model, String color, Boolean toolbox, Boolean computerConnection, Boolean arm, Boolean trashCompactor, Boolean vacuum)
            : base(material, model, color, toolbox, computerConnection, arm)
        {
            this.trashCompactor = trashCompactor;
            this.vacuum = vacuum;
        }

        //Public property for the CalculateTotalCost backing field
        public Decimal CalculateTotalCost2
        {
            get
            {
                someNumber2 = 0m;
                if (trashCompactor)
                {
                    someNumber2 += 1m;
                }
                if (vacuum)
                {
                    someNumber2 += 1m;
                }
                return this.someNumber2;
            }
        }

        public override String ToString()
        {
            return base.ToString() + " " + this.CalculateTotalCost2.ToString("C");
        }
    }
}
