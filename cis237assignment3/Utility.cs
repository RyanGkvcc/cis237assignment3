using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Utility : Droid
    {
        //Backing fields
        protected Boolean toolbox;
        protected Boolean computerConnection;
        protected Boolean arm;

        private Decimal someNumber;

        //6 parameter Constructor that uses the parent's constructor to do some of the work
        public Utility(String material, String model, String color, Boolean toolbox, Boolean computerConnection, Boolean arm) : base(material, model, color)
        {
            this.toolbox = toolbox;
            this.computerConnection = computerConnection;
            this.arm = arm;
        }

        //Public property for the CalculateTotalCost backing field
        public Decimal CalculateTotalCost
        {
            get
            {
                someNumber = 0m;
                if (toolbox)
                {
                    someNumber += 1m;
                }
                if (computerConnection)
                {
                    someNumber += 1m;
                }
                if (arm)
                {
                    someNumber += 1m;
                }
                return this.someNumber;
            }
        }

        public override String ToString()
        {
            return base.ToString() + " " + this.CalculateTotalCost.ToString("C");
        }
    }
}
