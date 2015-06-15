using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ASPire_Training;

namespace ASPire_training_git.Controllers
{
    public class RegisterController
    {
        private MasterController masterController;

        public RegisterController()
        {
            this.masterController = new MasterController();
        }

        //Creating a user in the database.
        public User createUser(string password, string name, string weight, string length, string sex, string email, string phoneNumber, 
            string experience, string goal, string vitamins, string minerals, string proteins, string dailyCalories, string goalWeight)
        {
            //Creating the user in the database.
            masterController.CreateUser(password, name, weight, length, (Sex)Enum.Parse(typeof(Sex), sex) - 1, email, phoneNumber,
             experience, (Goal)Enum.Parse(typeof(Goal), goal) - 1, vitamins, minerals, proteins, CheckIfEmptyToDouble(dailyCalories), CheckIfEmptyToDouble(goalWeight));

            //After the user is created, it is retrieved from the database.
            List<string>[] dataTable = masterController.GetUser(email);

            //Correct user is being made.
            if (dataTable[9][0].ToUpper() == "AFVALLER")
            {
                return new User(Convert.ToInt32(dataTable[14][0]), Convert.ToInt32(dataTable[13][0]), dataTable[2][0],
                    Convert.ToInt32(dataTable[4][0]), Convert.ToInt32(dataTable[3][0]), (Sex)Enum.Parse(typeof(Sex), dataTable[5][0].ToUpper()),
                    dataTable[6][0], dataTable[7][0], Convert.ToInt32(dataTable[8][0]), Goal.Afvaller,
                    "", "", "");
            }
            else if (dataTable[9][0].ToUpper() == "SPIERENKWEKER")
            {
                return new User(0, 0, dataTable[2][0],
                    Convert.ToDouble(dataTable[4][0]), Convert.ToDouble(dataTable[3][0]), (Sex)Enum.Parse(typeof(Sex), dataTable[5][0].ToUpper()),
                    dataTable[6][0], dataTable[7][0], Convert.ToInt32(dataTable[8][0]), Goal.Spierenkweker,
                    CheckIfNullToString(dataTable[10][0]), CheckIfNullToString(dataTable[11][0]), CheckIfNullToString(dataTable[12][0]));
            }
            else
            {
                return new User(Convert.ToInt32(dataTable[14][0]), Convert.ToInt32(dataTable[13][0]), dataTable[2][0],
                    Convert.ToDouble(dataTable[4][0]), Convert.ToDouble(dataTable[3][0]), (Sex)Enum.Parse(typeof(Sex), dataTable[5][0].ToUpper()),
                    dataTable[6][0], dataTable[7][0], Convert.ToInt32(dataTable[8][0]), Goal.Beide,
                    CheckIfNullToString(dataTable[10][0]), CheckIfNullToString(dataTable[11][0]), CheckIfNullToString(dataTable[12][0]));
            }
        }

        //Check yo make sure a double is returned
        static double CheckIfEmptyToDouble(object stringToCheck)
        {
            return stringToCheck.ToString() == "" ? 0 : Convert.ToDouble(stringToCheck.ToString());
        }

        //Function to make sure no null values are being converted to strings.
        static string CheckIfNullToString(object stringToCheck)
        {
            return stringToCheck == null ? "" : stringToCheck.ToString();
        }
    }
}