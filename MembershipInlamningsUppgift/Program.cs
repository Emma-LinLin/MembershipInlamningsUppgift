using System;

namespace MembershipInlamningsUppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter secret word: ");
            string pass = Console.ReadLine().ToLower();
            //CheckPass kontrollerar användarens svar
            CheckPass(pass);


            Console.ReadKey();
        }
        static void CheckPass(string pass)
        {
            int numberOfTries = 3;

            while(numberOfTries >= 0)
            {
                if (pass == "götebuggarna")
                {
                    Console.WriteLine("Correct!");
                    //MainMeny tar dig vidare till huvudmenyn
                    MainMeny();
                    break;
                }
                else
                {
                    numberOfTries--;
                    Console.WriteLine($"Incorrect. You have {numberOfTries} tries left: ");
                    pass = Console.ReadLine().ToLower();
                }
            }
        }
        static void MainMeny()
        {
            string[] mainMeny = new string[] { "Meet the members", "Join the club!", "Remove a member", "Log out" };

            bool keepGoing = true;

            while (keepGoing)
            {
                Console.WriteLine("This is our meny: ");

                for (int i = 0; i < mainMeny.Length; i++)
                {
                    Console.WriteLine($"{i + 1}.{mainMeny[i]}");
                }

                Console.WriteLine(" ");
                Console.WriteLine("What would you like to do?: ");
                int userChoice = int.Parse(Console.ReadLine());

                switch (userChoice)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        Console.WriteLine("Have a nice day!");
                        keepGoing = false;
                        break;
                    default:
                        Console.WriteLine("Not a valid option");
                        break;
                }
            }
        }
        static void ShowMembers()
        {
            
        }
        static void CreateNewMember()
        {

        }
        static void DeleteMember()
        {

        }
    }
}
