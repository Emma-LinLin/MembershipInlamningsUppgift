using System;
using System.Collections.Generic;

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
            Member Andrei = new Member("Andrei", "Problemlösning", 26, "12e Januari", "Carbonara", "Two Steps From Hell", "Lord of the rings", "Resa", "Oliver", "Stenbock", "Instant olive detection");
            Member Jesper = new Member("Jesper", "Frihet", 28, "29e Maj", "Lammracks", "Lars Winnerbäck", "Catch me if you can", "De enkla sakerna", "Folk som filmar på konserter", "Tvilling", "Teleportering");
            Member Leroy = new Member("Leroy", "Dynamisk", 32, "22e Oktober", "Pizza", "We the best music", "Matrix", "Choklad", "Kaviar", "Våg", "Flyga");
            Member Ma = new Member("MA", "Skapande", 29, "13e Mars", "Rårakor", "Modest Mouse", "Snatch", "Höst/Vinter", "Banan", "Fisk", "Mrs.Hindsight");
            Member Gurra = new Member("Gurra", "Kreativitet", 33, "17e November", "Tacos", "Berliner Philharmoniker", "Any Star Wars", "J.S Bach", "Schlager", "Skorpion", "Tala med hundvalpar");
            Member Jonna = new Member("Jonna", "Tjurskallig", 30, "5e Februari", "Pizza", "Full of hell", "Interstellar", "Musik", "Kött", "Vattuman", "Odödlig");
            Member Linus = new Member("Linus", "Få ett riktigt skoj jobb", 27, "17e Juli", "Fisksoppa", "Jack Moy", "The secret life of walter mitty", "Banan", "Senap", "Kräfta", "Andas under vatten");
            Member Nils = new Member("Nils", "Roligt", 21, "15e Februari", "Pannkakor", "Beach Boys", "American Psycho", "Snö", "Slask", "Fisk", "Räkna med fingrarna");
            Member Yulrok = new Member("Yulrok", "Biljett till digital nomad-livet", 38, "23e April", "Müsli", "Morcheeba", "The green book", "Ost", "Slöseri", "Oxen", "Tankeöverföring");

            List<Member> membersList = new List<Member>() { Andrei, Jesper, Leroy, Ma, Gurra, Jonna, Linus, Nils, Yulrok };


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
