using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPire_training_git
{
    public partial class WebPageLogOut : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //If there is a user he is logged out.
            if (Session["loggedInUser"] != null && !Page.IsPostBack)
            {
                Session["loggedInUser"] = null;
            }
        }
    }
}