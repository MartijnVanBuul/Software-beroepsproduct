using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPire_Training
{
    public class Trainer
    {
        //Fields
        private string name;
        string sex;
        private DateTime dateOfBirth;
        private string emailaddress;
        private string telephoneNumber;

        //Properties
        #region properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Sex
        {
            get { return sex; }
            set { sex = value; }
        }

        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }

        public string Emailaddress
        {
            get { return emailaddress; }
            set { emailaddress = value; }
        }

        public string TelephoneNumber
        {
            get { return telephoneNumber; }
            set { telephoneNumber = value; }
        }
        #endregion

        //Constructor
        public Trainer(string name, string sex, DateTime dateOfBirth, string emailaddress, string telephoneNumber)
        {
            this.name = name;
            this.sex = sex;
            this.dateOfBirth = dateOfBirth;
            this.emailaddress = emailaddress;
            this.telephoneNumber = telephoneNumber;
        }
    }
}