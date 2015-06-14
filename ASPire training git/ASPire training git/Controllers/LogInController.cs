using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ASPire_Training;

namespace ASPire_training_git.Controllers
{
    public class LogInController
    {
        private MasterController masterController;
        public LogInController()
        {
            masterController = new MasterController();
        }

        //Function that checks if it is possible to log in with the input.
        public bool ParseLogIn(string eMailAddress, string password)
        {
            return masterController.LogIn(eMailAddress, password);
        }

        //Function that gets user from the database.
        public User GetUser(string eMailAddress)
        {
            //Gets the complete set of data from the user.
            List<string>[] dataTable = masterController.GetUser(eMailAddress);

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

        //Function to make sure no null values are being converted to strings.
        static string CheckIfNullToString(object stringToCheck)
        {
            return stringToCheck == null ? "" : stringToCheck.ToString();
        }
    }
}