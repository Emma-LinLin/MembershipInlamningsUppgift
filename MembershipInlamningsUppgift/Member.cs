using System;
using System.Collections.Generic;
using System.Text;

namespace MembershipInlamningsUppgift
{
    class Member
    {
        public Member(string name, string mainReason, int age, string birthday, string favouriteFood, string favouriteBand, string favouriteMovie, string loves, string hates, string sign, string superPower)
        {
            this.Name = name;
            this.MainReason = mainReason;
            this.Age = age;
            this.Birthday = birthday;
            this.FavouriteFood = favouriteFood;
            this.FavouriteBand = favouriteBand;
            this.FavouriteMovie = favouriteMovie;
            this.Loves = loves;
            this.Hates = hates;
            this.Sign = sign;
            this.SuperPower = superPower;
        }


        public string Name { get; }
        public string MainReason { get; }
        public int Age { get; }
        public string Birthday { get; }
        public string FavouriteFood { get; }
        public string FavouriteBand { get; }
        public string FavouriteMovie { get; }
        public string Loves { get; }
        public string Hates { get; }
        public string Sign { get; }
        public string SuperPower { get; }
    }
}
