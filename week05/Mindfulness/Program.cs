using System;

/*
Creativity:
This program exceeds requirements by saving a history
of all completed activities to a file named:

mindfulness_log.txt

Each log entry stores:
- Date and time
- Activity name
- Duration completed
*/

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;

        while (choice != 4)
        {
            Console.Clear();

            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Start Breathing Activity");
            Console.WriteLine(" 2. Start Reflecting Activity");
            Console.WriteLine(" 3. Start Listing Activity");
            Console.WriteLine(" 4. Quit");
            Console.WriteLine();

            Console.Write("Select a choice from the menu: ");

            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    BreathingActivity breathing =
                        new BreathingActivity();
                    breathing.Run();
                    break;

                case 2:
                    ReflectingActivity reflecting =
                        new ReflectingActivity();
                    reflecting.Run();
                    break;

                case 3:
                    ListingActivity listing =
                        new ListingActivity();
                    listing.Run();
                    break;

                case 4:
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }

            if (choice != 4)
            {
                Console.WriteLine();
                Console.WriteLine("Press Enter to return to menu...");
                Console.ReadLine();
            }
        }
    }
}