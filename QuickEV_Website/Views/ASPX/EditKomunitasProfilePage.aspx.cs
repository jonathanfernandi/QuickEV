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

namespace QuickEV_Website.Views.ASPX
{
    public partial class EditKomunitasProfilePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (UserController.IsUserLoggedIn())
                {
                    if (!UserController.IsUserRelawan())
                    {
                        User user = UserController.GetUserBySession();
                        if (user != null)
                        {
                            Komunita komunitas = KomunitasController.GetKomunitasById(user.IdKomunitas.Value);
                            if (komunitas != null)
                            {
                                logoImage.ImageUrl = "data:image/png;base64," + Convert.ToBase64String((byte[])komunitas.Logo);
                                usernameTxt.Text = user.Username;
                                nameTxt.Text = komunitas.NamaKomunitas;
                                descTxt.Text = komunitas.DeskripsiKomunitas;
                                alamatTxt.Text = komunitas.Alamat;
                                provinsiDDL.Text = komunitas.Provinsi;
                                telpTxt.Text = komunitas.TelpKomunitas;
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

        protected void updateBtn_Click(object sender, EventArgs e)
        {
            //User user = UserController.GetUserBySession();
            //if (user != null)
            //{
            //    Komunita komunitas = KomunitasController.GetKomunitasById(user.IdKomunitas.Value);
            //    if (komunitas != null)
            //    {
            //        String name = nameTxt.Text;
            //        String desc = descTxt.Text;
            //        String fileExtension = Path.GetExtension(logoFU.FileName).ToLower();
            //        bool fileExtensionSuccess = false;
            //        if (logoFU.HasFile)
            //        {
            //            if (fileExtension == ".png")
            //            {
            //                fileExtensionSuccess = true;
            //            }
            //            else
            //            {
            //                logoErrorLbl.Text = "Invalid file type. Please upload a .PNG file.";
            //            }
            //        }
            //        String alamat = alamatTxt.Text;
            //        String provinsi = provinsiDDL.Text;
            //        String telp = telpTxt.Text;
            //        String username = usernameTxt.Text;
            //        String password = passwordTxt.Text;


            //        Response<User> checkName = UserController.NameCheck2(name);
            //        Response<User> checkDesc = UserController.DescCheck(desc);
            //        Response<User> checkAlamat = UserController.AlamatCheck(alamat);
            //        Response<User> checkProvinsi = UserController.ProvinsiCheck(provinsi);
            //        Response<User> checkTelp = UserController.TelpCheck(telp);
            //        Response<User> checkUsername = UserController.UsernameCheck2(username);
            //        Response<User> checkMatch = UserController.PasswordCheck(user.Username, password);

            //        if (checkName.IsSuccess && checkDesc.IsSuccess &&
            //            fileExtensionSuccess && checkAlamat.IsSuccess && checkProvinsi.IsSuccess &&
            //            checkTelp.IsSuccess && checkUsername.IsSuccess && checkMatch.IsSuccess)
            //        {
            //            using (MemoryStream ms = new MemoryStream(logoFU.FileBytes))
            //            {
            //                System.Drawing.Image logo = System.Drawing.Image.FromStream(ms);
            //                Response<Komunita> response = KomunitasController.UpdateKomunitas(komunitas, logo, name, desc, alamat, telp, provinsi, user, username);
            //                Response.Redirect("~/Views/ASPX/ProfilePage.aspx");
            //            }
            //        }

            //        else if (!checkName.IsSuccess || !checkDesc.IsSuccess ||
            //            !fileExtensionSuccess || !checkAlamat.IsSuccess || !checkProvinsi.IsSuccess ||
            //            !checkTelp.IsSuccess || !checkUsername.IsSuccess || !checkMatch.IsSuccess)
            //        {
            //            nameErrorLbl.Text = checkName.Message.ToString();
            //            descErrorLbl.Text = checkDesc.Message.ToString();
            //            alamatErrorLbl.Text = checkAlamat.Message.ToString();
            //            provinsiErrorLbl.Text = checkProvinsi.Message.ToString();
            //            telpErrorLbl.Text = checkTelp.Message.ToString();
            //            usernameErrorLbl.Text = checkUsername.Message.ToString();
            //            passwordErrorLbl.Text = checkMatch.Message.ToString();
            //        }
            //    }
            //}
        }
    }
}