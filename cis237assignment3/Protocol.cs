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

        //Public property for the CalculateTotalCost backing field
        public Decimal CalculateTotalCost
        {
            get
            {
                return this.numberLanguages * COST_PER_LANGUAGE;
            }
        }

        //Public override of the ToString method. It uses the parent's
        //toString method to get some of it's work done.
        public override String ToString()
        {
            return base.ToString() + " " + this.CalculateTotalCost.ToString("C");
        }
    }
}
