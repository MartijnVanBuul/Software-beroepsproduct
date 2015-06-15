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
    public partial class WebPageMyData : System.Web.UI.Page
    {
        private MyDataController myDataController;
        protected void Page_Load(object sender, EventArgs e)
        {
            myDataController = new MyDataController();

            //Fills the data fields if a user is logged in.
            if (Session["loggedInUser"] != null && !Page.IsPostBack)
            {
                loggedIn.Attributes["style"] = "display: block;";
                lblNotLoggedIn.Text = "";

                User loggedInUser = Session["loggedInUser"] as User;

                tbName.Text = loggedInUser.Name;
                tbWeight.Text = loggedInUser.Weight.ToString();
                tbLength.Text = loggedInUser.Length.ToString();

                if (loggedInUser.Sex == Sex.M)
                {
                    lblSex.Text = "Man";
                }
                else
                {
                    lblSex.Text = "Vrouw";
                }

                tbEmail.Text = loggedInUser.Emailaddress;
                tbPhoneNumer.Text = loggedInUser.PhoneNumber;
                tbExperience.Text = loggedInUser.Experience.ToString();

                if (loggedInUser.Goal == Goal.Spierenkweker)
                {
                    Spierenkweker.Attributes["style"] = "display: block;";
                    Afvaller.Attributes["style"] = "display: none;";

                    tbVitamins.Text = loggedInUser.Vitamins;
                    tbMinerals.Text = loggedInUser.Minerals;
                    tbProteins.Text = loggedInUser.Proteins;
                }
                else if (loggedInUser.Goal == Goal.Afvaller)
                {
                    Spierenkweker.Attributes["style"] = "display: none;";
                    Afvaller.Attributes["style"] = "display: block;";

                    tbDailyCalories.Text = loggedInUser.DailyCalories.ToString();
                    tbWeightGoal.Text = loggedInUser.GoalWeight.ToString();
                }
                else
                {
                    Spierenkweker.Attributes["style"] = "display: block;";
                    Afvaller.Attributes["style"] = "display: block;";

                    tbVitamins.Text = loggedInUser.Vitamins;
                    tbMinerals.Text = loggedInUser.Minerals;
                    tbProteins.Text = loggedInUser.Proteins;
                    tbDailyCalories.Text = loggedInUser.DailyCalories.ToString();
                    tbWeightGoal.Text = loggedInUser.GoalWeight.ToString();
                }
            }
            else
            {
                loggedIn.Attributes["style"] = "display: none;";
                lblNotLoggedIn.Text = "Log in om je gegevens te bekijken.";
            }
        }

        //Updates the data.
        protected void btnUpdate_OnClick(object sender, EventArgs e)
        {
            myDataController.ChangeData(tbName.Text, tbWeight.Text, tbLength.Text, tbEmail.Text,
                tbPhoneNumer.Text, tbExperience.Text, tbVitamins.Text, tbMinerals.Text, tbProteins.Text, tbDailyCalories.Text, tbWeightGoal.Text);

            User updatedUser = myDataController.GetUser(tbEmail.Text);

            Session["loggedInUser"] = updatedUser;

            Response.Redirect(Request.RawUrl);
        }
    }
}