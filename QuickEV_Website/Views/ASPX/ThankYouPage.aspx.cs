using QuickEV_Website.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuickEV_Website.Views.ASPX
{
    public partial class ThankYouPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (!UserController.IsUserLoggedIn())
                {
                    Response.Redirect("~/Views/ASPX/SignInPage.aspx");
                }
            }
        }

        protected void GoHome_Btn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/ASPX/HomePage.aspx");
        }
    }
}