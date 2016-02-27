///Programmer:  Ryan Gowan
///Date:        2/27/2016
///POV:         What are you suppossed to learn from this project.
///                 Console app, if/else statements, switch statements, 
///                 Arrays, User Interface, Collections, Interface, Inheiritance,
///                 Abstract classes, and Polymorphism.
///             Populate collection of Droids that ara all similarly based on an abstract class, yet are different
///             based on the user input. Have the ability to print out the entire collection of Droids, including the 
///             price.
///                            
///BOV:         Purpose of this project, if any.
///                 The ability to create an abstract class and manipulate other classes to inherit properties and methods from it.
///                 The ability to implement a interface.
///                 The ability to utilize Polymorphism.
///                 The ability to display information within the console terminal.

//  This project shows Documentation comments, above.
/*  Notes:
 *  ???/100
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            String model = String.Empty;
            String material = String.Empty;
            String color = String.Empty;
            Boolean toolbox = false;
            Boolean computerConnection = false;
            Boolean arm = false;
            Boolean trashCompactor = false;
            Boolean vacuum = false;
            Boolean fireExtinquisher = false;
            Int32 numberShips = 0;

            //Constant size for the Droid Collection
            const Int32 DROID_COLLECTION_SIZE = 100;

            //Create an instance of the UserInterface class
            UserInterface userInterface = new UserInterface();


            DroidCollection droidCollection = new DroidCollection(DROID_COLLECTION_SIZE);

            Int32 choice1 = userInterface.FirstMenu();
            Int32 type;

            while (choice1 != 3)
            {
                if (choice1 == 1)
                {
                    type = userInterface.BeginBuild();
                    material = userInterface.MaterialOption();
                    color = userInterface.ColorOption();

                    switch (type)
                    {
                        case 1:
                            {
                                model = "Protocol";
                                Int32 languages = userInterface.ProtocolNumberLanguages();
                                droidCollection.NewDroid(model, material, color, languages);
                                userInterface.DroidAddSuccess();
                                break;
                            }
                        case 2:
                            {
                                model = "Utility";
                                toolbox = userInterface.UtilityToolbox();
                                computerConnection = userInterface.UtilityComputerConnection();
                                arm = userInterface.UtilityArm();
                                droidCollection.NewDroid(model, material, color, toolbox, computerConnection, arm);
                                userInterface.DroidAddSuccess();
                                break;
                            }
                        case 3:
                            {
                                model = "Janitor";
                                toolbox = userInterface.UtilityToolbox();
                                computerConnection = userInterface.UtilityComputerConnection();
                                arm = userInterface.UtilityArm();
                                trashCompactor = userInterface.JanitorTrashCompactor();
                                vacuum = userInterface.JanitorVacuum();
                                droidCollection.NewDroid(model, material, color, toolbox, computerConnection, arm, trashCompactor, vacuum);
                                userInterface.DroidAddSuccess();
                                break;
                            }
                        case 4:
                            {
                                model = "Astromech";
                                toolbox = userInterface.UtilityToolbox();
                                computerConnection = userInterface.UtilityComputerConnection();
                                arm = userInterface.UtilityArm();
                                fireExtinquisher = userInterface.AstromechFireExtinquisher();
                                numberShips = userInterface.AstromechNumberShips();
                                droidCollection.NewDroid(model, material, color, toolbox, computerConnection, arm, fireExtinquisher, numberShips);
                                userInterface.DroidAddSuccess();
                                break;
                            }
                    }
                }
                if (choice1 == 2)
                {
                    string[] allDroids = droidCollection.AquireAllDroids();
                    if (allDroids.Length > 0)
                    {
                        userInterface.DisplayAllDroids(allDroids);
                    }
                    else
                    {
                        userInterface.DisplayNoDroidsError();
                    }
                    
                }
                choice1 = userInterface.FirstMenu();
            }
        }
    }
}
