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
