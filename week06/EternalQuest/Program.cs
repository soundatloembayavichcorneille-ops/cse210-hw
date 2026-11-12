using System;

/*
EXCEEDING REQUIREMENTS

Added player levels:

0-999 = Novice
1000-1999 = Adventurer
2000-4999 = Hero
5000+ = Legend

The player's level is displayed with their score.
*/

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}