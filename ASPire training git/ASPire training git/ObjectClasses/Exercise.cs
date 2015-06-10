﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPire_Training
{
    public class Exercise
    {
        //Fields
        private string exerciseName;
        private int repetitions;
        private int sets;
        private int kCalories;
        private List<Instrument> instruments;

        //Properties
        #region properties
        public string ExerciseName
        {
            get { return exerciseName; }
            set { exerciseName = value; }
        }

        public int Repetitions
        {
            get { return repetitions; }
            set { repetitions = value; }
        }

        public int Sets
        {
            get { return sets; }
            set { sets = value; }
        }

        public int KCalories
        {
            get { return kCalories; }
            set { kCalories = value; }
        }

        public List<Instrument> Instruments
        {
            get { return instruments; }
            set { instruments = value; }
        }

        #endregion

        //Constructor
        public Exercise(string exerciseName, int repetitions, int sets, int kCalories, List<Instrument> instruments)
        {
            this.exerciseName = exerciseName;
            this.repetitions = repetitions;
            this.sets = sets;
            this.kCalories = kCalories;
            this.instruments = instruments;
        }
    }
}