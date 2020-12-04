using System;
using System.Collections.Generic;
using System.Text;

namespace MembershipInlamningsUppgift
{
    class Member
    {
        private string name;
        private string mainReason;

        private int age;
        private string birthday;
        private string favouriteFood;
        private string favouriteBand;
        private string favouriteMovie;
        private string loves;
        private string hates;
        private string sign;
        private string superPower;

        public Member(string name, string mainReason, int age, string birthday, string favouriteFood, string favouriteBand, string favouriteMovie, string loves, string hates, string sign, string superPower)
        {
            this.name = name;
            this.mainReason = mainReason;
            this.age = age;
            this.birthday = birthday;
            this.favouriteFood = favouriteFood;
            this.favouriteBand = favouriteBand;
            this.favouriteMovie = favouriteMovie;
            this.loves = loves;
            this.hates = hates;
            this.sign = sign;
            this.superPower = superPower;
        }


        public string Name
        {
            get
            {
                return name;
            }
        }
        public string MainReason
        {
            get
            {
                return mainReason;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
        }
        public string Birthday
        {
            get
            {
                return birthday;
            }
        }
        public string FavouriteFood
        {
            get
            {
                return favouriteFood;
            }
        }
        public string FavouriteBand
        {
            get
            {
                return favouriteBand;
            }
        }
        public string FavouriteMovie
        {
            get
            {
                return favouriteMovie;
            }
        }
        public string Loves
        {
            get
            {
                return loves;
            }
        }
        public string Hates
        {
            get
            {
                return hates;
            }
        }
        public string Sign
        {
            get
            {
                return sign;
            }
        }
        public string SuperPower
        {
            get
            {
                return superPower;
            }
        }
    }
}
