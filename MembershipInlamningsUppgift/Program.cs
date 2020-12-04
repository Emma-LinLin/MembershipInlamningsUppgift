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

            Console.WriteLine("This is our meny: ");

            for(int i = 0; i < mainMeny.Length; i++)
            {
                Console.WriteLine($"{i + 1}.{mainMeny[i]}");
            }
        }
    }
}
