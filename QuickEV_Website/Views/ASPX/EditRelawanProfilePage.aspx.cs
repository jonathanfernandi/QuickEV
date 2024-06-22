using QuickEV_Website.Controller;
using QuickEV_Website.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuickEV_Website.Views.ASPX
{
    public partial class EditRelawanProfilePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (UserController.IsUserLoggedIn())
                {
                    if (UserController.IsUserRelawan())
                    {
                        User user = UserController.GetUserBySession();
                        if (user != null)
                        {
                            Relawan relawan = RelawanController.GetRelawanById(user.IdRelawan.Value);
                            if (relawan != null)
                            {
                                usernameTxt.Text = user.Username;
                                nameTxt.Text = relawan.NamaRelawan;
                                provinsiDDL.Text = relawan.ProvinsiRelawan;
                            }
                        }
                    }
                    else
                    {
                        Response.Redirect("~/Views/ASPX/ProfilePage.aspx");
                    }
                }
                else
                {
                    Response.Redirect("~/Views/ASPX/SignInPage.aspx");
                }
            }
        }
    }
}