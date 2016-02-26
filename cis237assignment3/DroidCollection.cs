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

        //Populate the Sting array of each droid to be printed to the display.
        public String[] AquireAllDroids()
        {
            String[] allDroidsString = new String[droidsLength];
            Int32 counter = 0;

            //If there is at least 1 Droid, add it to the array.
            if (droidsLength > 0)
            {
                //For each Droid in the collection.
                foreach (Droid droid in droids)
                {
                    //If there is another droid to add, proceed to add it to the array.
                    if (droid != null)
                    {
                        //Add the droid to the array.
                        allDroidsString[counter] = droid.ToString();
                        counter++;
                    }
                }
            }
            //Return the populated array to be printed to the terminal.
            return allDroidsString;
        }
        
    }
}
