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
    public partial class RelawanSignUpPage : System.Web.UI.Page
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

        protected void daftarBtn_Click(object sender, EventArgs e)
        {
            String name = nameTxt.Text;
            String username = usernameTxt.Text;
            String email = emailTxt.Text;
            String password = passwordTxt.Text;
            String confPassword = confPasswordTxt.Text;
            String gender = genderDDL.Text;
            String DOB = DOBTxt.Text;
            DateTime DateOfBirth;
            if (DateTime.TryParse(DOB, out DateOfBirth))
            {
                DateOfBirth = DateTime.Parse(DOB);
            }
            else
            {
                DOBErrorLbl.Text = "Date Of Birth must be filled!";
            }
            String provinsi = provinsiDDL.Text;

            Response<User> checkName = UserController.NameCheck(name);
            Response<User> checkUsername = UserController.UsernameCheck2(username);
            Response<User> checkEmail = UserController.EmailCheck(email);
            Response<User> checkMatch = UserController.PasswordMatchCheck(password, confPassword);
            Response<User> checkGender = UserController.GenderCheck(gender);
            Response<User> checkDOB = UserController.DOBCheck(DateOfBirth);
            Response<User> checkProvinsi = UserController.ProvinsiCheck(provinsi);

            if (checkName.IsSuccess && checkUsername.IsSuccess && checkEmail.IsSuccess &&
                checkGender.IsSuccess && checkDOB.IsSuccess && checkProvinsi.IsSuccess)
            {
                UserController.DoRegister(name, username, email, password, gender, DateOfBirth, provinsi);
                Response.Redirect("~/Views/ASPX/SignInPage.aspx");
            }

            else if (!checkName.IsSuccess || !checkUsername.IsSuccess || !checkEmail.IsSuccess ||
                !checkGender.IsSuccess || !checkDOB.IsSuccess || !checkProvinsi.IsSuccess)
            {
                nameErrorLbl.Text = checkName.Message.ToString();
                usernameErrorLbl.Text = checkUsername.Message.ToString();
                emailErrorLbl.Text = checkEmail.Message.ToString();
                passwordErrorLbl.Text = checkMatch.Message.ToString();
                confPasswordErrorLbl.Text = checkMatch.Message.ToString();
                genderErrorLbl.Text = checkGender.Message.ToString();
                DOBErrorLbl.Text = checkDOB.Message.ToString();
                provinsiErrorLbl.Text = checkProvinsi.Message.ToString();
            }
        }
    }
}