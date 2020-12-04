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
                Console.WriteLine(" ");
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
                        //ShowMembers visar nuvarande medlemmar samt fakta kring varje medlem
                        ShowMembers(membersList);
                        break;
                    case 2:
                        //CreateNewMember ger möjligheten att skapa en ny medlem
                        CreateNewMember(membersList);
                        break;
                    case 3:
                        //DeleteMember listar nuvarande medlemmar samt ger möjligheten att ta bort en medlem.
                        DeleteMember(membersList);
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
        static void ShowMembers(List<Member> membersList)
        {
            Console.WriteLine("These are our current members: ");

            foreach(var member in membersList)
            {
                Console.WriteLine($"{member.Name} - \"{member.MainReason}\"");
                Console.WriteLine($"Age: {member.Age}, Birthday: {member.Birthday} favourite Food: {member.FavouriteFood}, favourite band: {member.FavouriteBand}, favourite movie: {member.FavouriteMovie}, loves: {member.Loves}, hates: {member.Hates}, sign: {member.Sign} and superpower: {member.SuperPower}");
                Console.WriteLine(" ");
            }
            
        }
        static void CreateNewMember(List<Member> membersList)
        {
            Console.WriteLine("Join the club! answer the following questions");
            Console.Write("What's your name?: ");
            string name = Console.ReadLine();
            Console.Write("What is your main reason for programming?: ");
            string mainReason = Console.ReadLine();
            Console.Write("How old are you?: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("When's your birthday? Enter which day and month: ");
            string birthday = Console.ReadLine();
            Console.Write("What's your favourite food?: ");
            string favouriteFood = Console.ReadLine();
            Console.Write("Your favourite band?: ");
            string favouriteBand = Console.ReadLine();
            Console.Write("Favourite movie?: ");
            string favouriteMovie = Console.ReadLine();
            Console.Write("What do you love?: ");
            string loves = Console.ReadLine();
            Console.Write("and hate?: ");
            string hates = Console.ReadLine();
            Console.Write("What's your sign?: ");
            string sign = Console.ReadLine();
            Console.Write("And lastly, what is your superpower?: ");
            string superPower = Console.ReadLine();

            Member Newbie = new Member(name, mainReason, age, birthday, favouriteFood, favouriteBand, favouriteMovie, loves, hates, sign, superPower);

            Console.WriteLine(" ");
            membersList.Add(Newbie);
            Console.WriteLine($"Member {Newbie.Name} joined the club, welcome!");

        }
        static void DeleteMember(List<Member> membersList)
        {
            for(int i = 0; i < membersList.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{membersList[i].Name}");
            }

            Console.WriteLine($"Select which member you'd like to remove by entering for example \"1\": ");
            int index = int.Parse(Console.ReadLine());
            index = index - 1;

            Console.WriteLine($"Member {membersList[index].Name} was removed");
            membersList.RemoveAt(index);
        }
    }
}
