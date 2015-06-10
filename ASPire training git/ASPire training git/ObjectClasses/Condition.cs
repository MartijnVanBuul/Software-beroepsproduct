using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPire_Training
{
    public class Condition
    {
        //Fields
        private string conditionName;
        private int difficulty;
        private string comment;

        //Properties
        #region properties
        public string ConditionName
        {
            get { return conditionName; }
            set { conditionName = value; }
        }

        public int Difficulty
        {
            get { return difficulty; }
            set { difficulty = value; }
        }

        public string Comment
        {
            get { return comment; }
            set { comment = value; }
        }
        #endregion

        //Constructor
        public Condition(string conditionName, int difficulty, string comment)
        {
            this.conditionName = conditionName;
            this.difficulty = difficulty;
            this.comment = comment;
        }
    }
}