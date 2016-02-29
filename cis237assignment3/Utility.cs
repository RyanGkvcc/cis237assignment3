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

        private const Decimal TOOLBOX_PRICE = 1m;
        private const Decimal COMPUTERCONNECTION_PRICE = 3m;
        private const Decimal ARM_PRICE = 5m;
        private const Decimal MODEL_COST = 200m;

        private Int32 toolboxOption;
        private Int32 computerConnectionOption;
        private Int32 armOption;

        //private Decimal someNumber;

        //6 parameter Constructor that uses the parent's constructor to do some of the work
        public Utility(String model, String material, String color, Boolean toolbox, Boolean computerConnection, Boolean arm) : base(model, material, color)
        {
            this.toolbox = toolbox;
            this.computerConnection = computerConnection;
            this.arm = arm;
        }

        //Public override of the ToString method. It uses the parent's
        //ToString method to get some of it's work done.
        public override String ToString()
        {
            return base.ToString() + "Toolbox: " + toolboxOption.ToString("N0") + " @ " + TOOLBOX_PRICE.ToString("C") + Environment.NewLine +
                "Computer Connection: " + computerConnectionOption.ToString("N0") + " @ " + COMPUTERCONNECTION_PRICE.ToString("C") + Environment.NewLine +
                "Arm: " + armOption.ToString("N0") + " @ " + ARM_PRICE.ToString("C") + Environment.NewLine;
        }

        //Overrides the parent ModelCost and sets the price for this model.
        protected override decimal ModelCost
        {
            get
            {
                return MODEL_COST;
            }
        }

        protected Decimal UtilityOptionCost
        {
            get
            {
                Decimal optionCost = 0m;
                toolboxOption = 0;
                computerConnectionOption = 0;
                armOption = 0;

                if (toolbox)
                {
                    toolboxOption = 1;
                    optionCost += TOOLBOX_PRICE;
                }
                if (computerConnection)
                {
                    computerConnectionOption = 1;
                    optionCost += COMPUTERCONNECTION_PRICE;
                }
                if (arm)
                {
                    armOption = 1;
                    optionCost += ARM_PRICE;
                }
                return optionCost;

            }
       }

        //Public override method to override the virtual Calculate Total Cost Droid method.
        public override void CalculateTotalCost()
        {
            CalculateBaseCost();
            this.totalCost = this.UtilityOptionCost + this.baseCost;
            
        }
    }
}
