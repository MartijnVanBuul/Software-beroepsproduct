using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPire_training_git
{
    public partial class WebPageRegister : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


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
    }
}