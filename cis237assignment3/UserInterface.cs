using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class UserInterface
    {
        String input;
        String range;
        String option;
        Boolean choice;

        //Displays the menu for the user to choose to build a Droid or print the inventory
        public Int32 FirstMenu()
        {
            //Resets the input variable
            input = String.Empty;
            //Displays the first menu
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Add a new Droid");
            Console.WriteLine("2. Print the list of current Droids");
            Console.WriteLine("3. Exit");
            Console.WriteLine();
            //Stores the user input in string format
            input = Console.ReadLine();
            //Validates the input or we get to try again.
            while (input != "1" && input != "2" && input != "3")
            {
                //Tell them that they did not enter a valid choice
                range = "(1-3).";
                this.WrongSelection(range);
                //Reprint the menu for the user.
                this.FirstMenu();
            }

            //A valid selection has been chosen since the user is now out of the loop
            return Int32.Parse(input);
        }

        //Displays a error message and the valid choices
        private void WrongSelection(String range)
        {
            Console.WriteLine("That is not a valid entry");
            Console.WriteLine("Please make a valid choice {0}", range);
            Console.WriteLine();
        }

        //Displays the menu for the user to select a type of Droid to build.
        public Int32 BeginBuild()
        {
            //Resets the input variable
            input = String.Empty;
            //Displays the menu for the user to select a Droid type to build.
            Console.WriteLine("What type of Droid would you like to build?");
            Console.WriteLine("1. Protocol");
            Console.WriteLine("2. Utility");
            Console.WriteLine("3. Janitor");
            Console.WriteLine("4. Astromech");
            Console.WriteLine();
            //Stores the user input in string format.
            input = Console.ReadLine();
            //Validates the input or we get to try again.
            while (input != "1" && input != "2" && input != "3" && input != "4")
            {
                //Tell them that they did not enter a valid choice
                range = "(1-4).";
                this.WrongSelection(range);
                //Reprint the menu for the user.
                this.BeginBuild();
            }

            //A valid selection has been chosen since the user is now out of the loop
            return Int32.Parse(input);
        }

        //Displays the menu for the user to select a material.
        public String MaterialOption()
        {
            //Resets the input variable
            input = String.Empty;
            //Displays the menu for the user to select a material for their Droid.
            Console.WriteLine("What material would you like to use to build your Droid?");
            Console.WriteLine("1. Metal");
            Console.WriteLine("2. Stone");
            Console.WriteLine("3. Carbon Fiber");
            Console.WriteLine("4. Wood");
            Console.WriteLine("5. Plastic");
            Console.WriteLine();
            //Stores the user input in string format.
            input = Console.ReadLine();
            //Validates the input or we get to try again.
            while (input != "1" && input != "2" && input != "3" && input != "4" && input != "5")
            {
                //Tell them that they did not enter a valid choice
                range = "(1-5).";
                this.WrongSelection(range);
                //Reprint the menu for the user.
                this.MaterialOption();
            }

            //A valid selection has been chosen since the user is now out of the loop
            switch (input)
            {
                case "1":
                    {
                        option = "Metal";
                        break;
                    }
                case "2":
                    {
                        option = "Stone";
                        break;
                    }
                case "3":
                    {
                        option = "Carbon Fiber";
                        break;
                    }
                case "4":
                    {
                        option = "Wood";
                        break;
                    }
                case "5":
                    {
                        option = "Plastic";
                        break;
                    }
                
            }
            //returns the selected material.
            return option;
        }

        //Displays the menu for the user to select a color.
        public String ColorOption()
        {
            //Resets the input variable
            input = String.Empty;
            //Displays the menu for the user to select a color for their Droid.
            Console.WriteLine("What color would you like your Droid to be?");
            Console.WriteLine("1. Metallic Silver");
            Console.WriteLine("2. Dusty Brown");
            Console.WriteLine("3. Stealth Black");
            Console.WriteLine("4. Natural Woodgrain");
            Console.WriteLine("5. Fluorescent Neon");
            Console.WriteLine();
            //Stores the user input in string format.
            input = Console.ReadLine();
            //Validates the input or we get to try again.
            while (input != "1" && input != "2" && input != "3" && input != "4" && input != "5")
            {
                //Tell them that they did not enter a valid choice
                range = "(1-5).";
                this.WrongSelection(range);
                //Reprint the menu for the user.
                this.ColorOption();
            }

            //A valid selection has been chosen since the user is now out of the loop
            switch (input)
            {
                case "1":
                    {
                        option = "Metallic Silver";
                        break;
                    }
                case "2":
                    {
                        option = "Dusty Brown";
                        break;
                    }
                case "3":
                    {
                        option = "Stealth Black";
                        break;
                    }
                case "4":
                    {
                        option = "Natural Woodgrain";
                        break;
                    }
                case "5":
                    {
                        option = "Fluorescent Neon";
                        break;
                    }

            }
            //returns the selected color.
            return option;
        }

        //Displays the menu for the user to select how many languages the Droid should have.
        public Int32 ProtocolNumberLanguages()
        {
            //Resets the input variable
            input = String.Empty;
            //Displays the menu for the user to select a how many languages their Droid should have.
            Console.WriteLine("How many languages would you like available on your Protocol?");
            Console.WriteLine("1-5");
            Console.WriteLine();
            //Stores the user input in string format.
            input = Console.ReadLine();
            //Validates the input or we get to try again.
            while (input != "1" && input != "2" && input != "3" && input != "4" && input != "5")
            {
                //Tell them that they did not enter a valid choice
                range = "(1-5).";
                this.WrongSelection(range);
                //Reprint the menu for the user.
                this.ProtocolNumberLanguages();
            }

            //A valid selection has been chosen since the user is now out of the loop.
            //returns the number of selected languages.
            return Int32.Parse(input);
        }

        //Displays the menu for the user to select if they want a Toolbox on their Droid.
        public Boolean UtilityToolbox()
        {
            //Resets the input variable
            input = String.Empty;
            choice = false;
            //Displays the menu for the user choose if they want a Toolbox on their Droid.
            Console.WriteLine("Would you like your Droid to have a Toolbox?");
            Console.WriteLine("y or n");
            Console.WriteLine();
            //Stores the user input in string format.
            input = Console.ReadLine();
            //Validates the input or we get to try again.
            while (input != "y" || input != "Y" || input != "n" || input != "N")
            {
                //Tell them that they did not enter a valid choice
                range = "(y or n).";
                this.WrongSelection(range);
                //Reprint the menu for the user.
                this.UtilityToolbox();
            }

            //A valid selection has been chosen since the user is now out of the loop.
            if (input == "y" || input == "Y")
            {
                choice = true;
            }
            return choice;
        }

        //Displays the menu for the user to select if they want a Toolbox on their Droid.
        public Boolean UtilityComputerConnection()
        {
            //Resets the input variable
            input = String.Empty;
            choice = false;
            //Displays the menu for the user choose if they want a Computer Connection on their Droid.
            Console.WriteLine("Would you like your Droid to have a Computer Connection?");
            Console.WriteLine("y or n");
            Console.WriteLine();
            //Stores the user input in string format.
            input = Console.ReadLine();
            //Validates the input or we get to try again.
            while (input != "y" || input != "Y" || input != "n" || input != "N")
            {
                //Tell them that they did not enter a valid choice
                range = "(y or n).";
                this.WrongSelection(range);
                //Reprint the menu for the user.
                this.UtilityComputerConnection();
            }

            //A valid selection has been chosen since the user is now out of the loop.
            if (input == "y" || input == "Y")
            {
                choice = true;
            }
            return choice;
        }

        //Displays the menu for the user to select if they want a Arm on their Droid.
        public Boolean UtilityArm()
        {
            //Resets the input variable
            input = String.Empty;
            choice = false;
            //Displays the menu for the user choose if they want a Arm on their Droid.
            Console.WriteLine("Would you like your Droid to have a Arm?");
            Console.WriteLine("y or n");
            Console.WriteLine();
            //Stores the user input in string format.
            input = Console.ReadLine();
            //Validates the input or we get to try again.
            while (input != "y" || input != "Y" || input != "n" || input != "N")
            {
                //Tell them that they did not enter a valid choice
                range = "(y or n).";
                this.WrongSelection(range);
                //Reprint the menu for the user.
                this.UtilityArm();
            }

            //A valid selection has been chosen since the user is now out of the loop.
            if (input == "y" || input == "Y")
            {
                choice = true;
            }
            return choice;
        }

        //Displays the menu for the user to select if they want a Trash Compactor on their Droid.
        public Boolean JanitorTrashCompactor()
        {
            //Resets the input variable
            input = String.Empty;
            choice = false;
            //Displays the menu for the user choose if they want a Trash Compactor on their Droid.
            Console.WriteLine("Would you like your Droid to have a Trash Compactor?");
            Console.WriteLine("y or n");
            Console.WriteLine();
            //Stores the user input in string format.
            input = Console.ReadLine();
            //Validates the input or we get to try again.
            while (input != "y" || input != "Y" || input != "n" || input != "N")
            {
                //Tell them that they did not enter a valid choice
                range = "(y or n).";
                this.WrongSelection(range);
                //Reprint the menu for the user.
                this.JanitorTrashCompactor();
            }

            //A valid selection has been chosen since the user is now out of the loop.
            if (input == "y" || input == "Y")
            {
                choice = true;
            }
            return choice;
        }

        //Displays the menu for the user to select if they want a Vacuum on their Droid.
        public Boolean JanitorVacuum()
        {
            //Resets the input variable
            input = String.Empty;
            choice = false;
            //Displays the menu for the user choose if they want a Vacuum on their Droid.
            Console.WriteLine("Would you like your Droid to have a Vacuum?");
            Console.WriteLine("y or n");
            Console.WriteLine();
            //Stores the user input in string format.
            input = Console.ReadLine();
            //Validates the input or we get to try again.
            while (input != "y" || input != "Y" || input != "n" || input != "N")
            {
                //Tell them that they did not enter a valid choice
                range = "(y or n).";
                this.WrongSelection(range);
                //Reprint the menu for the user.
                this.JanitorVacuum();
            }

            //A valid selection has been chosen since the user is now out of the loop.
            if (input == "y" || input == "Y")
            {
                choice = true;
            }
            return choice;
        }

        //Displays the menu for the user to select if they want a Fire Extinquisher on their Droid.
        public Boolean AstromechFireExtinquisher()
        {
            //Resets the input variable
            input = String.Empty;
            choice = false;
            //Displays the menu for the user choose if they want a Fire Extinquisher on their Droid.
            Console.WriteLine("Would you like your Droid to have a Fire Extinquisher?");
            Console.WriteLine("y or n");
            Console.WriteLine();
            //Stores the user input in string format.
            input = Console.ReadLine();
            //Validates the input or we get to try again.
            while (input != "y" || input != "Y" || input != "n" || input != "N")
            {
                //Tell them that they did not enter a valid choice
                range = "(y or n).";
                this.WrongSelection(range);
                //Reprint the menu for the user.
                this.AstromechFireExtinquisher();
            }

            //A valid selection has been chosen since the user is now out of the loop.
            if (input == "y" || input == "Y")
            {
                choice = true;
            }
            return choice;
        }

        //Displays the menu for the user to select how many Ships their Droid should have.
        public Int32 AstromechNumberShips()
        {
            //Resets the input variable
            input = String.Empty;
            //Displays the menu for the user to select a how many Ships their Droid should have.
            Console.WriteLine("How many Ships would you like available on your Astromech?");
            Console.WriteLine("1-6");
            Console.WriteLine();
            //Stores the user input in string format.
            input = Console.ReadLine();
            //Validates the input or we get to try again.
            while (input != "1" && input != "2" && input != "3" && input != "4" && input != "5" && input != "6")
            {
                //Tell them that they did not enter a valid choice
                range = "(1-6).";
                this.WrongSelection(range);
                //Reprint the menu for the user.
                this.AstromechNumberShips();
            }

            //A valid selection has been chosen since the user is now out of the loop.
            //returns the number of Ships selected.
            return Int32.Parse(input);
        }

        //Displays the entire list of Droids
        public void DisplayAllDroids(String allDroids)
        {
            Console.WriteLine(allDroids);
        }

        //Displays a error message if there were no Droids found
        public void DisplayNoDroidsError()
        {
            Console.WriteLine();
            Console.WriteLine("There are no Droids currently in your inventory");
            Console.WriteLine();
        }
    }
}
