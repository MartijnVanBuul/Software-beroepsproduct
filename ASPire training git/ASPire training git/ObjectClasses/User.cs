using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPire_Training
{
    public class User
    {
        //Fields
        private string name;
        private int weight;
        private int length;
        private string sex;
        private DateTime dateOfBirth;
        private string emailaddress;
        private int experience;
        private string vitamins;
        private string minerals;
        private string proteins;
        private int dailyCalories;
        private int goalWeight;
        private List<Skill> skills;

        //Properties
        #region properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public int Length
        {
            get { return length; }
            set { length = value; }
        }

        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }

        public string Sex
        {
            get { return sex; }
            set { sex = value; }
        }

        public string Emailaddress
        {
            get { return emailaddress; }
            set { emailaddress = value; }
        }

        public int Experience
        {
            get { return experience; }
            set { experience = value; }
        }

        public string Proteins
        {
            get { return proteins; }
            set { proteins = value; }
        }

        public string Vitamins
        {
            get { return vitamins; }
            set { vitamins = value; }
        }

        public string Minerals
        {
            get { return minerals; }
            set { minerals = value; }
        }

        public int DailyCalories
        {
            get { return dailyCalories; }
            set { dailyCalories = value; }
        }

        public int GoalWeight
        {
            get { return goalWeight; }
            set { goalWeight = value; }
        }

        public List<Skill> Skills
        {
            get { return skills; }
            set { skills = value; }
        }

        #endregion

        //Constructor
        public User(int goalWeight, int dailyCalories, string name, int length, int weight, string sex, DateTime dateOfBirth, string emailaddress, int experience, string vitamins, string minerals, string proteins, List<Skill> skills)
        {
            this.goalWeight = goalWeight;
            this.dailyCalories = dailyCalories;
            this.name = name;
            this.length = length;
            this.weight = weight;
            this.sex = sex;
            this.dateOfBirth = dateOfBirth;
            this.emailaddress = emailaddress;
            this.experience = experience;
            this.vitamins = vitamins;
            this.minerals = minerals;
            this.proteins = proteins;
            this.skills = skills;
        }
    }
}