using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ASPire_Training;

namespace ASPire_training_git
{
    public partial class AspireMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["loggedInUser"] != null)
            {
                User loggedInUser = Session["loggedInUser"] as User;
                lblLoggedIn.Text = "U bent ingelogd als " + loggedInUser.Name + ".";
            }
            else
            {
                lblLoggedIn.Text = "U bent nog niet ingelogd.";
            }
        }
    }
}