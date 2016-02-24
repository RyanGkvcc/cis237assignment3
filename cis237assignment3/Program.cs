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
                    switch (type)
                    {
                        case 1:
                            {
                                model = "Protocol";
                                material = userInterface.MaterialOption();
                                color = userInterface.ColorOption();
                                Int32 languages = userInterface.ProtocolNumberLanguages();
                                break;
                            }
                        case 2:
                            {
                                model = "Utility";
                                material = userInterface.MaterialOption();
                                color = userInterface.ColorOption();
                                toolbox = userInterface.UtilityToolbox();
                                computerConnection = userInterface.UtilityComputerConnection();
                                arm = userInterface.UtilityArm();
                                break;
                            }
                        case 3:
                            {
                                model = "Janitor";
                                material = userInterface.MaterialOption();
                                color = userInterface.ColorOption();
                                toolbox = userInterface.UtilityToolbox();
                                computerConnection = userInterface.UtilityComputerConnection();
                                arm = userInterface.UtilityArm();
                                trashCompactor = userInterface.JanitorTrashCompactor();
                                vacuum = userInterface.JanitorVacuum();
                                break;
                            }
                        case 4:
                            {
                                model = "Astromech";
                                material = userInterface.MaterialOption();
                                color = userInterface.ColorOption();
                                toolbox = userInterface.UtilityToolbox();
                                computerConnection = userInterface.UtilityComputerConnection();
                                arm = userInterface.UtilityArm();
                                trashCompactor = userInterface.JanitorTrashCompactor();
                                vacuum = userInterface.JanitorVacuum();
                                fireExtinquisher = userInterface.AstromechFireExtinquisher();
                                numberShips = userInterface.AstromechNumberShips();
                                break;
                            }
                    }
                }
                if (choice1 == 2)
                {
                    //String allDroids = String.Empty;
                    //foreach(Droid droid in droids)
                    //{
                    //    if (droid != null)
                    //    {
                    //        allDroids += droid.ToString() + Environment.NewLine;
                    //    }
                    //}
                    //if (allDroids != String.Empty)
                    //{
                    //    //Print the entire list of Droids
                    //    userInterface.DisplayAllDroids(allDroids);
                    //}
                    //else
                    //{
                    //    //Display No Droids Found error message
                    //    userInterface.DisplayNoDroidsError();
                    //}
                }
                choice1 = userInterface.FirstMenu();
            }
        }
    }
}
