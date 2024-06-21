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
    public partial class KomunitasDetailPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                String idKomunitas = Request.QueryString["IdKomunitas"];
                if (idKomunitas.Length > 0)
                {
                    Komunita komunitas = KomunitasController.GetKomunitasById(int.Parse(idKomunitas));
                    if (komunitas != null)
                    {
                        imgLogo.ImageUrl = "data:image/png;base64," + Convert.ToBase64String((byte[])komunitas.Logo);
                        komunitasNameLbl.Text = komunitas.NamaKomunitas.ToUpper();
                        fokusLbl.Text = komunitas.FokusUtama;
                        countRelawanLbl.Text = KomunitasController.GetRelawanCount(komunitas.IdKomunitas).ToString() + " Relawan";
                        countKegiatanLbl.Text = KomunitasController.GetKegiatanCount(komunitas.IdKomunitas).ToString() + " Kegiatan";
                        descLbl.Text = komunitas.DeskripsiKomunitas;
                        alamatLbl.Text = komunitas.Alamat;
                        teleLbl.Text = komunitas.TelpKomunitas;
                    }

                    if (UserController.IsUserLoggedIn())
                    {
                        User user = UserController.GetUserBySession();
                        Relawan relawan = RelawanController.GetRelawanById(user.IdRelawan.Value);
                        if (KomunitasController.GetDetailKomunitasById(komunitas.IdKomunitas, relawan.IdRelawan) != null)
                        {
                            gabungBtn.Text = "Sudah Bergabung";
                        }
                    }

                }
            }
        }

        protected void gabungBtn_Click(object sender, EventArgs e)
        {
            if (UserController.IsUserLoggedIn() && UserController.IsUserRelawan())
            {
                String IdKomunitas = Request.QueryString["IdKomunitas"];
                User user = UserController.GetUserBySession();
                if (user != null && IdKomunitas.Length != 0)
                {
                    Komunita komunitas = KomunitasController.GetKomunitasById(int.Parse(IdKomunitas));
                    Relawan relawan = RelawanController.GetRelawanById(user.IdRelawan.Value);
                    if (komunitas != null && relawan != null && KomunitasController.GetDetailKomunitasById(komunitas.IdKomunitas, relawan.IdRelawan) == null)
                    {
                        KomunitasController.AddDetailKomunitas(komunitas.IdKomunitas, relawan.IdRelawan);
                        Response.Redirect("~/Views/ASPX/CariKomunitasPage.aspx");
                        //Response.Redirect("~/Views/ASPX/ProfilePage.aspx");
                    }
                }
            }
            else
            {
                Response.Redirect("~/Views/ASPX/SignInPage.aspx");
            }
        }
    }
}