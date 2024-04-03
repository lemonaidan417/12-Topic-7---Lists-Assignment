namespace _12_Topic_7___Lists_Assignment
{
    internal class Program
    {
        public static void listsOfIntegers()
        {
            List<int> list = new List<int>();
            Random generator = new Random();

            Console.WriteLine("Welcome to my list assignment. " +
                "\nI will be generating a random list of numbers between 10 and 20 and " +
                "doing various things to said list.");

            for (int i = 0; i < 25; i++) // Making default list
            {
                list.Add(generator.Next(10, 21));
            }
            list.Sort();
            for (int i = 0; i < list.Count; i++)
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

            string choice = "";

            while (choice != "q")
            {
                Console.WriteLine();
                Console.WriteLine("Please select :");
                Console.WriteLine();
                Console.WriteLine("1 - Sort the list");
                Console.WriteLine("2 - Make a new list of random numbers");
                Console.WriteLine("3 - Remove a number (by value)");
                Console.WriteLine("4 - Add a value to the list");
                Console.WriteLine("5 - Count the number of occurrences of a specified number");
                Console.WriteLine("6 - Print the largest value");
                Console.WriteLine("7 - Print the smallest value");
                Console.WriteLine("8 - Sum and Average"); // Bonus
                Console.WriteLine("9 - Determine the most frequently occurring value(s)"); // Bonus
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
                }
                else if (choice == "4")
                {
                    Console.WriteLine("You chose");

                }
                else if (choice == "5")
                {
                    Console.WriteLine("You chose");

                }
                else if (choice == "6")
                {
                    Console.WriteLine("You chose");

                }
                else if (choice == "7")
                {
                    Console.WriteLine("You chose");

                }
                else if (choice == "8")
                {
                    Console.WriteLine("You chose");

                }
                else if (choice == "9")
                {
                    Console.WriteLine("You chose");

                }
                // Add an else for each valid choice...
                else
                {
                    Console.WriteLine("Invalid choice, press ENTER to continue.");
                    Console.ReadLine();
                }
            }
        }
        public static void listsOfStrings()
        {

        }
        static void Main(string[] args)
        {
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