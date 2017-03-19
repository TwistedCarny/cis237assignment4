using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a new droid collection and set the size of it to 100.
            IDroidCollection droidCollection = new DroidCollection(100);

            droidCollection.Add("Bronze", "Protocol", "Blue", 5);
            
            droidCollection.Add("Bronze", "Protocol", "green", 6);
            droidCollection.Add("Bronze", "Janitor", "yellow", false, true, true, false, false);
            droidCollection.Add("Bronze", "Astromech", "Blue", true, false, true, true, 4);
            droidCollection.Add("Bronze", "Utility", "Blue", true, false, true);
            droidCollection.Add("Bronze", "Astromech", "Red", true, true, true, true, 8);
            droidCollection.Add("Bronze", "Utility", "green", false, false, true);
            droidCollection.Add("Bronze", "Janitor", "red", true, false, true, true, false);
            droidCollection.Add("Bronze", "Janitor", "Blue", true, true, false, true, false);
            droidCollection.Add("Bronze", "Protocol", "red", 2);
            droidCollection.Add("Bronze", "Utility", "red", true, true, false);
            droidCollection.Add("Bronze", "Astromech", "yellow", true, false, true, false, 2);

            //Create a user interface and pass the droidCollection into it as a dependency
            UserInterface userInterface = new UserInterface(droidCollection);

            //Display the main greeting for the program
            userInterface.DisplayGreeting();

            //Display the main menu for the program
            userInterface.DisplayMainMenu();

            //Get the choice that the user makes
            int choice = userInterface.GetMenuChoice();

            //While the choice is not equal to 3, continue to do work with the program
            while (choice != 5)
            {
                //Test which choice was made
                switch (choice)
                {
                    //Choose to create a droid
                    case 1:
                        userInterface.CreateDroid();
                        break;

                    //Choose to Print the droid
                    case 2:
                        userInterface.PrintDroidList();
                        break;
                    case 3:
                        userInterface.Output("---------------- Before Sort ----------------");
                        userInterface.PrintDroidList();
                        userInterface.Output("---------------- After Sort ----------------");
                        droidCollection.SortByModel();
                        userInterface.PrintDroidList();
                        break;
                    case 4:
                        userInterface.Output("---------------- Before Sort ----------------");
                        userInterface.PrintDroidList();
                        userInterface.Output("---------------- After Sort ----------------");
                        droidCollection.SortByCost();
                        userInterface.PrintDroidList();
                        break;

                }
                //Re-display the menu, and re-prompt for the choice
                userInterface.DisplayMainMenu();
                choice = userInterface.GetMenuChoice();
            }


        }
    }
}
