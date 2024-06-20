using QuickEV_Website.Controller;
using QuickEV_Website.Model;
using QuickEV_Website.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuickEV_Website.Views.ASPX
{
    public partial class SignInPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (UserController.IsUserLoggedIn())
                {
                    Response.Redirect("~/Views/ASPX/HomePage.aspx");
                }
            }
        }
        protected void signInBtn_Click(object sender, EventArgs e)
        {
            String username = usernameTxt.Text;
            String password = passwordTxt.Text;

            Response<User> checkUsername = UserController.UsernameCheck(username);
            Response<User> checkPassword = UserController.PasswordCheck(username, password);
            if (checkUsername.IsSuccess && checkPassword.IsSuccess)
            {
                Session["user"] = checkPassword.Payload;
                //Response.Redirect("~/Views/ASPX/RelawanSignUpPage.aspx");
                Response.Redirect("~/Views/ASPX/HomePage.aspx");
            }

            else if (!checkUsername.IsSuccess || !checkPassword.IsSuccess)
            {
                usernameErrorLbl.Text = checkUsername.Message.ToString();
                passwordErrorLbl.Text = checkPassword.Message.ToString();
            }

        }
    }
}

