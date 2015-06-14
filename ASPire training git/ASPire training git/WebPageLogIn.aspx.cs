using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ASPire_training_git.Controllers;
using ASPire_Training;

namespace ASPire_training_git
{
    public partial class WebPageLogIn : System.Web.UI.Page
    {
        //Controller that is used between the mastercontroller and the log in page.
        LogInController logInController = new LogInController();

        protected void Page_Load(object sender, EventArgs e)
        {
            //If someone is logged in already, the e-mailaddress is shown.
            if (Session["loggedInUser"] != null)
            {
                //User is retreived from the current session.
                User loggedInUser = Session["loggedInUser"] as User;
                tbEmailAddress.Text = loggedInUser.Emailaddress;
            }
        }

        protected void btnLogIn_Click(object sender, EventArgs e)
        {
            //If the page is valid, the data is checked with the database.
            if (Page.IsValid)
            {
                //If the combination between emailaddress and password is correct, the user is saved and the page is changed.
                if (logInController.ParseLogIn(tbEmailAddress.Text, passLogIn.Value))
                {
                    //No error is needed.
                    lblFailedLogIn.Text = "";

                    //User is retreived from the database.
                    User loggedInUser = logInController.GetUser(tbEmailAddress.Text);

                    //User is put into the current session.
                    Session.Add("loggedInUser", loggedInUser);

                    //Page is redirected to the data page.
                    Response.Redirect("http://localhost:31108/WebPageMyData");
                }
                else
                {
                    //Error message if the log in will fail.
                    lblFailedLogIn.Text = "De combinatie tussen het e-mailadres en het wachtwoord is incorrect.";
                    lblFailedLogIn.ForeColor = Color.Red;
                    lblFailedLogIn.Font.Bold = true;
                }
            }
        }
    }
}