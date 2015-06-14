using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPire_Training
{
    public enum Goal
    {
        Afvaller,
        Spierenkweker,
        Beide
    }

    public enum Sex
    {
        M,
        V
    }
    public class User
    {
        //Fields
        private string name;
        private double weight;
        private double length;
        private Sex sex;
        private string emailaddress;
        private string phoneNumber;
        private int experience;
        private Goal goal;
        private string vitamins;
        private string minerals;
        private string proteins;
        private int dailyCalories;
        private double goalWeight;

        //Properties
        #region properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public double Length
        {
            get { return length; }
            set { length = value; }
        }

        public Sex Sex
        {
            get { return sex; }
            set { sex = value; }
        }

        public string Emailaddress
        {
            get { return emailaddress; }
            set { emailaddress = value; }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public int Experience
        {
            get { return experience; }
            set { experience = value; }
        }

        public Goal Goal
        {
            get { return goal; }
            set { goal = value; }
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

        public double GoalWeight
        {
            get { return goalWeight; }
            set { goalWeight = value; }
        }
        #endregion

        //Constructor
        public User(double goalWeight, int dailyCalories, string name, double length, double weight, Sex sex, string emailaddress, string phoneNumber, int experience, Goal goal, string vitamins, string minerals, string proteins)
        {
            this.goalWeight = goalWeight;
            this.dailyCalories = dailyCalories;
            this.name = name;
            this.length = length;
            this.weight = weight;
            this.sex = sex;
            this.emailaddress = emailaddress;
            this.phoneNumber = phoneNumber;
            this.experience = experience;
            this.goal = goal;
            this.vitamins = vitamins;
            this.minerals = minerals;
            this.proteins = proteins;
        }
    }
}