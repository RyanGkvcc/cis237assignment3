using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class DroidCollection
    {
        //Private Variables
        Droid[] droids;
        Int32 droidsLength;

        //DroidCollection constructor.
        //THe size of the collection must be passed.
        public DroidCollection(Int32 size)
        {
            droids = new Droid[size];
            droidsLength = 0;
        }

        //Add new Protocol Droid to the Droid Collection and increase the length variable.
        public void NewDroid(String material, String model, String color, Int32 numberLanguages)
        {
            droids[droidsLength] = new Protocol(material, model, color, numberLanguages);
            droidsLength++;
        }

        //Add new Utility Droid to the Droid Collection and increase the length variable.
        public void NewDroid(String material, String model, String color, Boolean toolbox, Boolean computerConnection, Boolean arm)
        {
            droids[droidsLength] = new Utility(material, model, color, toolbox, computerConnection, arm);
            droidsLength++;
        }

        //Add new Janitor Droid to the Droid Collection and increase the length variable.
        public void NewDroid(String material, String model, String color, Boolean toolbox, Boolean computerConnection, Boolean arm, Boolean trashCompactor, Boolean vacuum)
        {
            droids[droidsLength] = new Janitor(material, model, color, toolbox, computerConnection, arm, trashCompactor, vacuum);
            droidsLength++;
        }

        //Add new Astromech Droid to the Droid Collection and increase the length variable.
        public void NewDroid(String material, String model, String color, Boolean toolbox, Boolean computerConnection, Boolean arm, Boolean fireExtinquisher, Int32 numberShips)
        {
            droids[droidsLength] = new Astromech(material, model, color, toolbox, computerConnection, arm, fireExtinquisher, numberShips);
            droidsLength++;
        }

        
    }
}
