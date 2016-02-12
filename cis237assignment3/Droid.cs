using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Droid
    {
        //Backing fields
        protected String material;
        protected String model;
        protected String color;
        protected Decimal baseCost;
        protected Decimal totalCost;

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
            return this.material + " " + this.model + " " + this.color + " " + this.baseCost + " " + this.totalCost;
        }
    }
}
