using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ASPire_Training;
using ICT4Events.Database;
using Oracle.ManagedDataAccess.Client;

namespace ASPire_training_git
{
    public class MasterController
    {
        private Database database;
        public MasterController()
        {
            database = new Database();
        }
        //Method to check if a user can log in.
        public bool LogIn(string eMailAddress, string password)
        {
            List<string> columns = new List<string>();

            columns.Add("loggedBoolean");

            List<OracleParameter> inParameters = new List<OracleParameter>();

            inParameters.Add(new OracleParameter("emailIN", eMailAddress));
            inParameters.Add(new OracleParameter("passwordIN", password));

            List<OracleParameter> outParameters = new List<OracleParameter>();

            outParameters.Add(new OracleParameter("loggedInOUT", OracleDbType.Varchar2, 255));

            return database.ExecuteProcedureLogIn("CheckLogIn", columns, inParameters, outParameters);
        }

        //Method to get a user from the database using his/her emailaddress.
        public List<string>[] GetUser(string eMailAddress)
        {
            List<string> columns = new List<string>();

            columns.Add("GEBRUIKERID");
            columns.Add("WACHTWOORD");
            columns.Add("NAAM");
            columns.Add("GEWICHT");
            columns.Add("LENGTE");
            columns.Add("GESLACHT");
            columns.Add("EMAILADRES");
            columns.Add("TELEFOONNUMMER");
            columns.Add("ERVARING");
            columns.Add("DOEL");
            columns.Add("VITAMINEN");
            columns.Add("MINERALEN");
            columns.Add("EIWITTEN");
            columns.Add("DAGELIJKSEKCAL");
            columns.Add("STREEFGEWICHT");

            List<OracleParameter> inParameters = new List<OracleParameter>();

            inParameters.Add(new OracleParameter("emailIN", eMailAddress));

            List<OracleParameter> outParameters = new List<OracleParameter>();

            outParameters.Add(new OracleParameter("userCursorOUT", OracleDbType.RefCursor));

            return database.ExecuteProcedureGetUser("getUser", columns, inParameters, outParameters);
        }

        //Method to change the data of a user.
        public void ChangeUserData(string name, string weight, string length, string email,
                string phoneNumber, string experience, string vitamins, string minerals, string proteins, double dailyCalories, double goalWeight)
        {
            List<OracleParameter> inParameters = new List<OracleParameter>();

            inParameters.Add(new OracleParameter("nameIN", name));
            inParameters.Add(new OracleParameter("weightIN", Convert.ToDouble(weight)));
            inParameters.Add(new OracleParameter("lengthIN", Convert.ToDouble(length)));
            inParameters.Add(new OracleParameter("emailIN", email));
            inParameters.Add(new OracleParameter("phoneNumberIN", phoneNumber));
            inParameters.Add(new OracleParameter("experienceIN", Convert.ToInt32(experience)));
            inParameters.Add(new OracleParameter("vitaminsIN", vitamins));
            inParameters.Add(new OracleParameter("mineralsIN", minerals));
            inParameters.Add(new OracleParameter("proteinsIN", proteins));

            if (Convert.ToInt32(dailyCalories) != 0 && Convert.ToDouble(goalWeight) != 0)
            {
                inParameters.Add(new OracleParameter("dailyCaloriesIN", Convert.ToInt32(dailyCalories)));
                inParameters.Add(new OracleParameter("goalWeightIN", Convert.ToDouble(goalWeight)));
            }
            else
            {
                inParameters.Add(new OracleParameter("dailyCaloriesIN", null));
                inParameters.Add(new OracleParameter("goalWeightIN", null));
            }

            database.ExecuteProcedureChangeUser("changeUser", inParameters);
        }

        //Method to create a user in the database.
        public void CreateUser(string password, string name, string weight, string length, Sex sex, string email, string phoneNumber, 
            string experience, Goal goal, string vitamins, string minerals, string proteins, double dailyCalories, double goalWeight)
        {
            List<OracleParameter> inParameters = new List<OracleParameter>();

            inParameters.Add(new OracleParameter("passwordIN", password));
            inParameters.Add(new OracleParameter("nameIN", name));
            inParameters.Add(new OracleParameter("weightIN", Convert.ToDouble(weight)));
            inParameters.Add(new OracleParameter("lengthIN", Convert.ToDouble(length)));
            inParameters.Add(new OracleParameter("sexIN", Enum.GetName(typeof(Sex), sex)));
            inParameters.Add(new OracleParameter("emailIN", email));
            inParameters.Add(new OracleParameter("phoneNumberIN", phoneNumber));
            inParameters.Add(new OracleParameter("experienceIN", Convert.ToInt32(experience)));

            if (Convert.ToInt32(dailyCalories) != 0 && Convert.ToDouble(goalWeight) != 0)
            {
                inParameters.Add(new OracleParameter("dailyCaloriesIN", Convert.ToInt32(dailyCalories)));
                inParameters.Add(new OracleParameter("goalWeightIN", Convert.ToDouble(goalWeight)));
                inParameters.Add(new OracleParameter("vitaminsIN", null));
                inParameters.Add(new OracleParameter("mineralsIN", null));
                inParameters.Add(new OracleParameter("proteinsIN", null));
            }
            else
            {
                inParameters.Add(new OracleParameter("dailyCaloriesIN", null));
                inParameters.Add(new OracleParameter("goalWeightIN", null));
                inParameters.Add(new OracleParameter("vitaminsIN", vitamins));
                inParameters.Add(new OracleParameter("mineralsIN", minerals));
                inParameters.Add(new OracleParameter("proteinsIN", proteins));
            }

            
            inParameters.Add(new OracleParameter("goalIN", Enum.GetName(typeof(Goal), goal)));

            database.ExecuteProcedureCreateUser("createUser", inParameters);
        }

        //Method to retreive all the exercises from the database.
        public List<string>[] GetAllExercises()
        {
            List<string> columns = new List<string>();
            columns.Add("OEFENINGID");
            columns.Add("OEFENINGNAAM");
            columns.Add("REPETITIES");
            columns.Add("REPSETS");
            columns.Add("CALORIEEN");

            return database.SelectQuery("SELECT * FROM OEFENING", columns);
        }
        
        //Method to retreive all the instruments from the database.
        public List<string>[] GetInstrumentsFromExercise(int ID)
        {
            List<string> columns = new List<string>();
            columns.Add("INSTRUMENTID");
            columns.Add("INSTRUMENTNAAM");
            columns.Add("GEWICHT");
            columns.Add("SOORT");

            return database.SelectQuery("SELECT * FROM INSTRUMENT, OEFENING_INSTRUMENT, OEFENING WHERE INSTRUMENT.INSTRUMENTID = OEFENING_INSTRUMENT.INSTRUMENTID AND OEFENING_INSTRUMENT.OEFENINGID = " + ID, columns);
        }
    }
}