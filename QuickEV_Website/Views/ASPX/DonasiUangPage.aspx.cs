using QuickEV_Website.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuickEV_Website.Views.ASPX
{
    public partial class DonasiUangPage : System.Web.UI.Page
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

        protected void Donate_Btn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/ASPX/ThankYouPage.aspx");
        }

        protected void Ammount_5000_Click(object sender, EventArgs e)
        {
            Donate_AmmountTxtBox.Text = "5000";
        }

        protected void Ammount_10000_Click(object sender, EventArgs e)
        {
            Donate_AmmountTxtBox.Text = "10000";
        }

        protected void Ammount_20000_Click(object sender, EventArgs e)
        {
            Donate_AmmountTxtBox.Text = "20000";
        }

        protected void Ammount_50000_Click(object sender, EventArgs e)
        {
            Donate_AmmountTxtBox.Text = "50000";
        }

        protected void Ammount_100000_Click1(object sender, EventArgs e)
        {
            Donate_AmmountTxtBox.Text = "100000";
        }
    }
}