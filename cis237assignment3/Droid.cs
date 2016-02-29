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
        protected String model;
        protected String material;
        protected String color;
        protected Decimal baseCost;
        protected Decimal totalCost;

        //const Decimal MATERIAL_COST = 25m;

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
        public Droid(String model, String material,  String color)
        {
            //Assign the passed in values to the fields
            this.model = model;
            this.material = material;
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
            return "Model: " + this.model + Environment.NewLine +
                "Material: " + this.material + Environment.NewLine + 
                "Color: " + this.color + Environment.NewLine + 
                "Base Cost: " + this.baseCost.ToString("C") + Environment.NewLine +
                "Total Cost: " + this.totalCost.ToString("C") + Environment.NewLine + 
                "Options: " + Environment.NewLine + 
                "---------" + Environment.NewLine;
        }

        public void CalculateBaseCost()
        {
            this.baseCost = this.MaterialCost + this.ModelCost;
        }

        //The Material Cost can be overriden by the children classes
        private Decimal MaterialCost
        {
            get
            {
                Decimal materialCost = 0;
                switch(this.material)
                {
                    case "Metal":
                        {
                            materialCost = 50m;
                            break;
                        }
                    case "Stone":
                        {
                            materialCost = 45m;
                            break;
                        }
                    case "Carbon Fiber":
                        {
                            materialCost = 40m;
                            break;
                        }
                    case "Wood":
                        {
                            materialCost = 35m;
                            break;
                        }
                    case "Plastic":
                        {
                            materialCost = 30m;
                            break;
                        }
                }
                switch(this.color)
                {
                    case "Metallic Silver":
                        {
                            materialCost = 25m;
                            break;
                        }
                    case "Dusty Brown":
                        {
                            materialCost = 20m;
                            break;
                        }
                    case "Stealth Black":
                        {
                            materialCost = 15m;
                            break;
                        }
                    case "Natural Woodgrain":
                        {
                            materialCost = 10m;
                            break;
                        }
                    case "Fluorscent Neon":
                        {
                            materialCost = 5m;
                            break;
                        }
                }

                return materialCost;
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
            CalculateBaseCost();
            this.totalCost = this.baseCost;
        }
    }
}
