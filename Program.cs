using System.Collections.Generic;

namespace _12_Topic_7___Lists_Assignment
{
    internal class Program
    {
        public static void listsOfIntegers()
        {
            List<int> list = new List<int>();
            Random generator = new Random();

            Console.WriteLine("Welcome to my List of Integers assignment. " +
                "\nI will be generating a random list of numbers between 10 and 20 and " +
                "doing various things to said list.");

            for (int i = 0; i < 25; i++) // Making default list
            {
                list.Add(generator.Next(10, 21));
            }
            Console.WriteLine(string.Join(", ", list));

            string choice = "";
            int valueAdd, userOccurrence;

            while (choice != "q")
            {
                Console.WriteLine();
                Console.WriteLine("Please select :");
                Console.WriteLine();
                Console.WriteLine("1 - Sort the list");
                Console.WriteLine("2 - Make a new list of random numbers");
                Console.WriteLine("3 - Remove a number (by value)");
                Console.WriteLine("4 - Add a value to the list");
                Console.WriteLine("5 - Count the number of occurrences of a specified number (Not done)");
                Console.WriteLine("6 - Print the largest value");
                Console.WriteLine("7 - Print the smallest value");
                Console.WriteLine("8 - Sum and Average (Not done)"); // Bonus
                Console.WriteLine("9 - Determine the most frequently occurring value(s) (Not done)"); // Bonus
                Console.WriteLine("q - Quit");
                Console.WriteLine();
                choice = Console.ReadLine().ToLower().Trim();
                Console.WriteLine();

                if (choice == "1")
                {
                    Console.WriteLine("You chose Sort the list");
                    list.Sort();
                    foreach (int i in list)
                        if (i == list.Count)
                        {
                            Console.Write(list[i]);
                        }
                        else
                        {
                            Console.Write(list[i] + ", ");
                        }
                } // Done
                else if (choice == "2")
                {
                    Console.WriteLine("You chose Make a new list of random numbers");
                    list.Clear();
                    for (int i = 0; i < 25; i++)
                    {
                        list.Add(generator.Next(10, 21));
                    }
                    foreach (int i in list)
                    {
                        if (i == list.Count)
                        {
                            Console.Write(list[i]);
                        }
                        else
                        {
                            Console.Write(list[i] + ", ");
                        }
                    }
                } // Done
                else if (choice == "3")
                {
                    Console.WriteLine("You chose Remove a number (by value)");
                    Console.WriteLine("What number would you like to remove?");
                    int numRemove = Convert.ToInt32(Console.ReadLine());
                    list.RemoveAll(i => i == numRemove);
                    list.Sort();
                    Console.WriteLine(string.Join(", ", list));
                } // Done
                else if (choice == "4")
                {
                    Console.WriteLine("You chose Add a value to the list");
                    Console.WriteLine("Please input the value that you would like added to the list.");
                    list.Add(valueAdd = Convert.ToInt32(Console.ReadLine()));
                    Console.WriteLine(string.Join(", ", list));
                } // Done
                else if (choice == "5")
                {
                    Console.WriteLine("You chose Count the number of occurrences of a specified number");
                    userOccurrence = Convert.ToInt32(Console.ReadLine());
                    
                } // Not Done
                else if (choice == "6")
                {
                    Console.WriteLine("You chose Print the largest value");
                    int max = list.Max();
                    Console.WriteLine($"The largest value is {max}");
                } // Done
                else if (choice == "7")
                {
                    Console.WriteLine("You chose Print the smallest value");
                    int min = list.Min();
                    Console.WriteLine($"The smallest value is {min}");
                } // Don
                else if (choice == "8")
                {
                    Console.WriteLine("You chose");

                } // Bonus (Didn't do)
                else if (choice == "9")
                {
                    Console.WriteLine("You chose");

                } // Bonus (Didn't do)
                else
                {
                    Console.WriteLine("Invalid choice, press ENTER to continue.");
                    Console.ReadLine();
                }
            }
        }
        public static void listsOfStrings()
        {
            Console.WriteLine("Welcome to my List of String assignment." +
                "\nI will now create a list of 5 of my favourite vegetables.");
            List<string> vegList = new List<string>(); List<int> vegListPos = new List<int>();
            string vegChoice = "";
            vegList.Add("GREEN ONION");
            vegList.Add("GREEN BEANS");
            vegList.Add("LETTUCE");
            vegList.Add("POTATO");
            vegList.Add("BROCCOLI");
            Console.WriteLine();
            Console.WriteLine("Vegetables");
            Console.WriteLine("--------------");
            Console.WriteLine(string.Join("\n", $"{vegListPos} - {vegList}"));
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            while (vegChoice != "q")
            {
                Console.WriteLine("Please select what you would like to to do to the list:");
                Console.WriteLine();
                Console.WriteLine("1 - Remove a vegetable by index");
                Console.WriteLine("2 - Remove a vegetable by value");
                Console.WriteLine("3 - Search for a vegetable");
                Console.WriteLine("4 - Add a vegetable");
                Console.WriteLine("5 - Sort list");
                Console.WriteLine("6 - Clear the list");
                Console.WriteLine("q - Quit");
                Console.WriteLine();
                vegChoice = Console.ReadLine();
                if (vegChoice == "1")
                {
                    Console.WriteLine("You chose Remove a vegetable by index");
                    Console.WriteLine("Please input the index of the vegetable you would like to remove: ");
                    int vegRemoveInt = int.Parse(Console.ReadLine());
                    vegList.RemoveAt((vegRemoveInt - 1));
                    Console.WriteLine(string.Join("\n", vegList));
                }
                else if (vegChoice == "2")
                {
                    Console.WriteLine("You chose Remove a vegetable by value");
                    Console.WriteLine("Please input the name of the vegetable you would like to remove: ");
                    string vegRemoveVal = Console.ReadLine().ToUpper().Trim();
                    vegList.Remove(vegRemoveVal);
                    Console.WriteLine(string.Join("\n", vegList));
                }
                else if (vegChoice == "3")
                {
                    Console.WriteLine("You chose Search for a vegetable");
                    Console.WriteLine("Please input the name of a vegetable and I will tell you" +
                        "its position in the list: ");
                    string vegStringPos = Console.ReadLine().ToUpper().Trim();
                    
                }
                else if (vegChoice == "4")
                {
                    Console.WriteLine("You chose Add a vegetable");
                }
                else if (vegChoice == "5")
                {
                    Console.WriteLine("You chose Sort the list");
                }
                else if (vegChoice == "6")
                {
                    Console.WriteLine("You chose Clear the list");
                }
                else
                {
                    Console.WriteLine("Invalid choice, press ENTER to continue.");
                    Console.ReadLine();
                }
            }
        }
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            string choice = "";

            while (choice != "q")
            {
                Console.Clear();
                Console.WriteLine("Welcome to my generic menu.  Please select an option:");
                Console.WriteLine();
                Console.WriteLine("1 - Lists of Integers");
                Console.WriteLine("2 - Lists of Strings");
                Console.WriteLine("q - Quit");
                Console.WriteLine();
                choice = Console.ReadLine().ToLower().Trim();
                Console.WriteLine();

                if (choice == "1")
                {
                    //Do option 1
                    Console.WriteLine("You chose option 1");
                    listsOfIntegers();
                    Console.ReadLine();
                }
                else if (choice == "2")
                {
                    // Do option 2
                    Console.WriteLine("You chose option 2");
                    listsOfStrings();
                    Console.ReadLine();
                }
                // Add an else for each valid choice...
                else
                {
                    Console.WriteLine("Invalid choice, press ENTER to continue.");
                    Console.ReadLine();
                }
            }
        }
    }
}