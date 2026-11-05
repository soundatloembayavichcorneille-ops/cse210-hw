using System;
using System.Collections.Generic;

// Creativity:
// This program contains multiple scriptures.
// A scripture is selected randomly each time the
// program starts. It also only hides words that
// are still visible.
// also it hides 3 words at a time

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptures = new List<Scripture>();

        scriptures.Add(
            new Scripture(
                new Reference("John", 3, 16),
                "For God so loved the world that he gave his only begotten Son"
            )
        );

        scriptures.Add(
            new Scripture(
                new Reference("Proverbs", 3, 5, 6),
                "Trust in the Lord with all thine heart and lean not unto thine own understanding"
            )
        );

        scriptures.Add(
            new Scripture(
                new Reference("Mosiah", 2, 17),
                "When ye are in the service of your fellow beings ye are only in the service of your God"
            )
        );

        scriptures.Add(
            new Scripture(
                new Reference("2 Nephi", 2, 25),
                "Adam fell that men might be and men are that they might have joy"
            )
        );

        Random random = new Random();

        Scripture scripture =
            scriptures[random.Next(scriptures.Count)];

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();

            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine();

            Console.Write(
                "Press Enter to continue or type quit: "
            );

            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);
        }

        Console.Clear();

        Console.WriteLine(scripture.GetDisplayText());

        Console.WriteLine();
        Console.WriteLine("Program finished.");
    }
}