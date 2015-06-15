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
    public partial class WebPageRegister : System.Web.UI.Page
    {
        private RegisterController registerController;
        protected void Page_Load(object sender, EventArgs e)
        {
           registerController = new RegisterController();
        }

        //Makes the input fields appear accordingly.
        protected void ddlGoal_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlGoal.SelectedValue == "1")
            {
                Spierenkweker.Attributes["style"] = "display: block;";
                Afvaller.Attributes["style"] = "display: none;";
            }
            else if (ddlGoal.SelectedValue == "2")
            {
                Spierenkweker.Attributes["style"] = "display: none;";
                Afvaller.Attributes["style"] = "display: block;";
            }
            else if (ddlGoal.SelectedValue == "3")
            {
                Spierenkweker.Attributes["style"] = "display: block;";
                Afvaller.Attributes["style"] = "display: block;";
            }
            else
            {
                Spierenkweker.Attributes["style"] = "display: none;";
                Afvaller.Attributes["style"] = "display: none;";
            }
        }

        //Registers the user in the database.
        protected void btnRegister_OnClick(object sender, EventArgs e)
        {
            User newUser = registerController.createUser(passwPassword.Value, tbName.Text, tbWeight.Text, tbLength.Text, ddlSex.Text, tbEmail.Text, tbPhoneNumer.Text,
                tbExperience.Text, ddlGoal.Text, tbVitamins.Text, tbMinerals.Text, tbProteins.Text, tbDailyCalories.Text, tbWeightGoal.Text);

            Session["loggedInUser"] = newUser;

            //Page is redirected to the data page.
            Response.Redirect("http://localhost:31108/WebPageMyData");
        }
    }
}