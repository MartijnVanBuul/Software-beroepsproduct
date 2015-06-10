using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPire_Training
{
    public class Skill
    {
        //Fields
        private string name;
        private int level;
        private string comment;

        //Properties
        #region properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Level
        {
            get { return level; }
            set { level = value; }
        }

        public string Comment
        {
            get { return comment; }
            set { comment = value; }
        }
        #endregion

        //Constructor
        public Skill(string name, int level, string comment)
        {
            this.name = name;
            this.level = level;
            this.comment = comment;
        }
    }
}