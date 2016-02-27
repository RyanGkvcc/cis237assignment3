using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    abstract class Droid : IDroid
    {
        //Backing fields
        protected String material;
        protected String model;
        protected String color;
        protected Decimal baseCost;
        protected Decimal totalCost;

        const Decimal MATERIAL_COST = 25m;

        //Properties for the backing fields
        public String Material
        {
            get { return material; }
            set { material = value; }
        }

        public String Model
        {
            get { return model; }
            set { model = value; }
        }

        public String Color
        {
            get { return color; }
            set { color = value; }
        }

        public Decimal BaseCost
        {
            get { return baseCost; }
            set { baseCost = value; }
        }

        public Decimal TotalCost
        {
            get { return totalCost; }
            set { totalCost = value; }
        }

        //3 Parameter constructor
        public Droid(String material, String model, String color)
        {
            //Assign the passed in values to the fields
            this.material = material;
            this.model = model;
            this.color = color;
        }

        //Default constructor
        public Droid()
        {
            //Lets just leave this blank
        }

        //Override method that will print all of the fields
        //It overrides the default ToString that every object gets for free!
        public override String ToString()
        {
            return "Color: " + this.color + Environment.NewLine + 
                "Material: " + this.material + Environment.NewLine + 
                "Model: " + this.model + Environment.NewLine + 
                "Base Cost: " + this.totalCost.ToString("C") + Environment.NewLine;
        }

        public void CalculateBaseCost()
        {
            this.baseCost = this.MaterialCost + this.ModelCost;
        }

        //The Material Cost can be overriden by the children classes
        protected virtual Decimal MaterialCost
        {
            get
            {
                return MATERIAL_COST;
            }
        }

        //The Model Cost MUST be overridden by the children classes
        protected abstract Decimal ModelCost
        {
            get;
        }


        //This method is virtual to ensure that it can be overriden by the children classes.
        //It assigns the base cost to the total cost.
        public virtual void CalculateTotalCost()
        {
            this.totalCost = this.baseCost;
        }
    }
}
