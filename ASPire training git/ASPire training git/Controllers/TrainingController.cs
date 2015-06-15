using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using ASPire_Training;

namespace ASPire_training_git.Controllers
{
    public class TrainingController
    {
        private MasterController masterController;

        public TrainingController()
        {
            //Controller for data from the database.
            masterController = new MasterController();
        }

        public List<Exercise> GetAllExercises()
        {
            //List to collect the exercises.
            List<Exercise> exercises = new List<Exercise>();
            //Datatable with all the values of the exercises.
            List<string>[] dataTable = masterController.GetAllExercises();

            //Loop through every exercise.
            for (int i = 1; i < dataTable[0].Count(); i++)
            {
                //List of all the instruments.
                List<Instrument> instruments = new List<Instrument>();

                //Getting all the data of the instruments that belong to this exercise.
                List<string>[] instrumentDataTable = masterController.GetInstrumentsFromExercise(Convert.ToInt32(dataTable[0][i]));

                //Loop through every instrument.
                for (int j = 1; j < instrumentDataTable[0].Count(); j++)
                {
                    //Creating the instrument.
                    instruments.Add(new Instrument(Convert.ToInt32(instrumentDataTable[0][j]), instrumentDataTable[1][j], Convert.ToInt32(CheckIfEmptyToDouble(instrumentDataTable[2][j])), instrumentDataTable[3][j]));
                }

                //Creating the exercise.
                exercises.Add(new Exercise(Convert.ToInt32(dataTable[0][i]), dataTable[1][i], Convert.ToInt32(CheckIfEmptyToDouble(dataTable[2][i])),
                    Convert.ToInt32(CheckIfEmptyToDouble(dataTable[3][i])), Convert.ToInt32(CheckIfEmptyToDouble(dataTable[4][i])), instruments));
            }

            //Return list of exercises.
            return exercises;
        }

        //Check if the value is an empty string, if so it will return 0.
        static double CheckIfEmptyToDouble(object stringToCheck)
        {
            return stringToCheck.ToString() == "" ? 0 : Convert.ToDouble(stringToCheck.ToString());
        }
    }
}