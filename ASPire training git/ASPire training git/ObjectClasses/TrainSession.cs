using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPire_Training
{
    public class TrainSession
    {
        //Fields
        private DateTime sessionDate;
        private string time;
        private int duration;
        private bool accepted;
        private User user;
        private Trainer trainer;
        private Location location;
        private List<Routine> routines;

        //Properties
        #region properties
        public DateTime SessionDate
        {
            get { return sessionDate; }
            set { sessionDate = value; }
        }

        public string Time
        {
            get { return time; }
            set { time = value; }
        }

        public int Duration
        {
            get { return duration; }
            set { duration = value; }
        }

        public bool Accepted
        {
            get { return accepted; }
            set { accepted = value; }
        }

        public Location Location
        {
            get { return location; }
            set { location = value; }
        }

        public Trainer Trainer
        {
            get { return trainer; }
            set { trainer = value; }
        }

        public User User
        {
            get { return user; }
            set { user = value; }
        }

        public List<Routine> Routine
        {
            get { return routines; }
            set { routines = value; }
        }

        #endregion

        //Constructor
        public TrainSession(DateTime sessionDate, string time, int duration, bool accepted, User user, Trainer trainer, Location location, List<Routine> routines)
        {
            this.sessionDate = sessionDate;
            this.time = time;
            this.duration = duration;
            this.accepted = accepted;
            this.user = user;
            this.trainer = trainer;
            this.location = location;
            this.routines = routines;
        }
    }
}