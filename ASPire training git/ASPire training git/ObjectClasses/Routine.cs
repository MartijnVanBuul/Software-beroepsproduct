using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPire_Training
{
    public class Routine
    {
        //Fields
        private string routineName;
        private int duration;
        private int difficulty;
        private Condition condition;
        private List<Exercise> exercise;

        //Properties
        #region properties
        public string RoutineName
        {
            get { return routineName; }
            set { routineName = value; }
        }

        public int Duration
        {
            get { return duration; }
            set { duration = value; }
        }

        public int Difficulty
        {
            get { return difficulty; }
            set { difficulty = value; }
        }

        public List<Exercise> Exercise
        {
            get { return exercise; }
            set { exercise = value; }
        }

        #endregion

        //Constructor
        public Routine(string routineName, int duration, int difficulty, List<Exercise> exercise)
        {
            this.routineName = routineName;
            this.duration = duration;
            this.difficulty = difficulty;
            this.exercise = exercise;
        }
    }
}