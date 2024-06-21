using QuickEV_Website.Controller;
using QuickEV_Website.Model;
using QuickEV_Website.Modules;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

namespace QuickEV_Website.Views.ASPX
{
    public partial class KomunitasSignUpPage : System.Web.UI.Page
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
            String desc = descTxt.Text;
            String fokus = fokusDDL.Text;
            String fileExtension = Path.GetExtension(logoFU.FileName).ToLower();
            bool fileExtensionSuccess = false;
            if (logoFU.HasFile)
            {
                if (fileExtension == ".png")
                {
                    fileExtensionSuccess = true;
                }
                else
                {
                    logoErrorLbl.Text = "Invalid file type. Please upload a .PNG file.";
                }
            }
            else
            {
                logoErrorLbl.Text = "Please select a file to upload.";
            }
            String alamat = alamatTxt.Text;
            String provinsi = provinsiDDL.Text;
            String telp = telpTxt.Text;
            String username = usernameTxt.Text;
            String password = passwordTxt.Text;
            String confPassword = confPasswordTxt.Text;

            Response<User> checkName = UserController.NameCheck2(name);
            Response<User> checkDesc = UserController.DescCheck(desc);
            Response<User> checkFokus = UserController.FokusCheck(fokus);
            Response<User> checkAlamat = UserController.AlamatCheck(alamat);
            Response<User> checkProvinsi = UserController.ProvinsiCheck(provinsi);
            Response<User> checkTelp = UserController.TelpCheck(telp);
            Response<User> checkUsername = UserController.UsernameCheck2(username);
            Response<User> checkMatch = UserController.PasswordMatchCheck(password, confPassword);

            if (checkName.IsSuccess && checkDesc.IsSuccess && checkFokus.IsSuccess &&
                fileExtensionSuccess && checkAlamat.IsSuccess && checkProvinsi.IsSuccess &&
                checkTelp.IsSuccess && checkUsername.IsSuccess && checkMatch.IsSuccess)
            {
                using (MemoryStream ms = new MemoryStream(logoFU.FileBytes))
                {
                    System.Drawing.Image logo = System.Drawing.Image.FromStream(ms);
                    Response<User> response = UserController.DoRegister2(name, desc, fokus, logo, alamat, provinsi,
                        telp, username, password);
                    Response.Redirect("~/Views/ASPX/SignInPage.aspx");
                }
            }

            else if (!checkName.IsSuccess || !checkDesc.IsSuccess || !checkFokus.IsSuccess ||
                !fileExtensionSuccess || !checkAlamat.IsSuccess || !checkProvinsi.IsSuccess ||
                !checkTelp.IsSuccess || !checkUsername.IsSuccess || !checkMatch.IsSuccess)
            {
                nameErrorLbl.Text = checkName.Message.ToString();
                descErrorLbl.Text = checkDesc.Message.ToString();
                fokusErrorLbl.Text = checkFokus.Message.ToString();
                alamatErrorLbl.Text = checkAlamat.Message.ToString();
                provinsiErrorLbl.Text = checkProvinsi.Message.ToString();
                telpErrorLbl.Text = checkTelp.Message.ToString();
                usernameErrorLbl.Text = checkUsername.Message.ToString();
                passwordErrorLbl.Text = checkMatch.Message.ToString();
                confPasswordErrorLbl.Text = checkMatch.Message.ToString();
            }
        }
    }
}