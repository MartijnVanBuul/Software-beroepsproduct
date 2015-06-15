using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ASPire_training_git.Controllers;
using ASPire_Training;

namespace ASPire_training_git
{
    public partial class WebPageTraining : System.Web.UI.Page
    {
        private TrainingController trainingController;
        protected void Page_Load(object sender, EventArgs e)
        {
            //Controller that processes the database data.
            trainingController = new TrainingController();
            
            //Dictionary that will be in the exercise dropdown.
            Dictionary<int, string> exercises = new Dictionary<int, string>();

            //Filling the dictionary.
            foreach (Exercise exercise in GetAllExercises())
            {
                exercises.Add(exercise.ExerciseId, exercise.ExerciseName);
            }

            //Adding the data do the dropdownlist.
            ddlExercise.DataSource = exercises;
            ddlExercise.DataValueField = "Key";
            ddlExercise.DataTextField = "Value";
            //Binding the data.
            ddlExercise.DataBind();
        }

        //Gets all the exercises from the database.
        private List<Exercise> GetAllExercises()
        {
            return trainingController.GetAllExercises();
        }
    }
}