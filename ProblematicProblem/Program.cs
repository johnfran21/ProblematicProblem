using System;
using System.Collections.Generic;
using System.Threading;

namespace ProblematicProblem
{
    class Program
    {
        Random rng;
        static bool cont = true;
        static List<string> activities = new List<string>() { "Movies", "Paintball", "Bowling", "Lazer Tag", "LAN Party", "Hiking", "Axe Throwing", "Wine Tasting" };

        static void Main(string[] args)
        {
            Random rng = new Random();
            Console.Write("Hello, welcome to the random activity generator! \nWould you like to generate a random activity? yes/no: ");
            //bool cont = bool.Parse(Console.ReadLine());
            string contResponse = Console.ReadLine();
            Console.WriteLine();
            Console.Write("We are going to need your information first! What is your name? ");
            string userName = Console.ReadLine();
            Console.WriteLine();
            Console.Write("What is your age? ");
            int userAge = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Would you like to see the current list of activities? Sure/No thanks: ");
            bool seeList;
            string seeList1 = Console.ReadLine();
            if (seeList1 == "Sure" || seeList1 == "yes")
                {
                seeList = true;
                }
            else
                { seeList = false; }

            if (seeList)
            {
                foreach (string activity in activities)
                {
                    Console.Write($"{activity} ");
                    Thread.Sleep(250);
                }
                Console.WriteLine();
                Console.Write("Would you like to add any activities before we generate one? yes/no: ");
                bool addToList;
                string addToList1 = Console.ReadLine();
                if (addToList1 == "yes")
                {
                    addToList = true;
                }
                else
                {
                    addToList = false;
                }
                Console.WriteLine();
                while (addToList)
                {
                    Console.Write("What would you like to add? ");
                    string userAddition = Console.ReadLine();
                    activities.Add(userAddition);
                    foreach (string activity in activities)
                    {
                        Console.Write($"{activity} ");
                        Thread.Sleep(250);
                    }
                    Console.WriteLine();
                    Console.WriteLine("Would you like to add more? yes/no: ");
                    string addMore = Console.ReadLine();
                    if (addMore == "yes")
                    {
                        addToList = true;
                    }
                    else
                    {
                        addToList = false;
                    }
                }
            }

            while (cont)
            {
                Console.Write("Connecting to the database");
                for (int i = 0; i < 10; i++)
                {
                    Console.Write(". ");
                    Thread.Sleep(500);
                }
                Console.WriteLine();
                Console.Write("Choosing your random activity");
                for (int i = 0; i < 9; i++)
                {
                    Console.Write(". ");
                    Thread.Sleep(500);
                }
                Console.WriteLine();
                int newRandomNumber = rng.Next(activities.Count);
                string newRandomActivity = activities[newRandomNumber];
                if (userAge < 21 && newRandomActivity == "Wine Tasting")
                {
                    Console.WriteLine($"Oh no! Looks like you are too young to do {newRandomActivity}");
                    Console.WriteLine("Pick something else!");
                    activities.Remove(newRandomActivity);
                    int randomNumber = rng.Next(activities.Count);
                    string randomActivity = activities[newRandomNumber];
                }
                Console.Write($"Ah got it! {userName}, your random activity is: {newRandomActivity}! Is this ok or do you want to grab another activity? Keep/Redo: ");
                Console.WriteLine("");
                cont = Console.ReadLine().Trim().Equals("Redo", StringComparison.OrdinalIgnoreCase);
               
            }
        }
    }
}