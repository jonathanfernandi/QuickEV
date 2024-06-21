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
    public partial class ProfilePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (UserController.IsUserLoggedIn())
                {
                    User user = UserController.GetUserBySession();
                    if (user != null)
                    {
                        if (UserController.IsUserRelawan())
                        {
                            Relawan relawan = RelawanController.GetRelawanById(user.IdRelawan.Value);
                            if (relawan != null)
                            {
                                nameLblRelawan.Text = relawan.NamaRelawan;
                                usernameLblRelawan.Text = "@" + user.Username;
                                countKegiatanLblRelawan.Text = RelawanController.GetKegiatanCount(relawan.IdRelawan).ToString() + "  Kegiatan Diikuti";
                                countKomunitasLblRelawan.Text = RelawanController.GetKomunitasCount(relawan.IdRelawan).ToString() + "  Komunitas Diikuti";
                                if (RelawanController.GetAllKegiatanOfAKomunitasForHeader(relawan.IdRelawan).Count > 0)
                                {
                                    volunteeringRpt.DataSource = RelawanController.GetAllKegiatanOfAKomunitasForHeader(relawan.IdRelawan);
                                    volunteeringRpt.DataBind();
                                }
                                else
                                {
                                    countZeroLbl.Visible = true;
                                    seeAllBtnRelawan.Visible = false;
                                    countKegiatanLblRelawan.NavigateUrl = "~/Views/ASPX/ProfilePage.aspx";
                                }
                                if (RelawanController.GetAllKomunitasForHeader(relawan.IdRelawan).Count > 0)
                                {
                                    volunteeringRpt2.DataSource = RelawanController.GetAllKomunitasForHeader(relawan.IdRelawan);
                                    volunteeringRpt2.DataBind();
                                }
                                else
                                {
                                    countZeroLbl2.Visible = true;
                                    seeAllBtnRelawan2.Visible = false;
                                    countKomunitasLblRelawan.NavigateUrl = "~/Views/ASPX/ProfilePage.aspx";
                                }
                            }
                        }
                        else if (!UserController.IsUserRelawan())
                        {
                            Komunita komunitas = KomunitasController.GetKomunitasById(user.IdKomunitas.Value);
                            if (komunitas != null)
                            {
                                imgLogo.ImageUrl = "data:image/png;base64," + Convert.ToBase64String((byte[])komunitas.Logo);
                                nameLbl.Text = komunitas.NamaKomunitas;
                                usernameLbl.Text = "@" + user.Username;
                                countRelawanLbl.Text = KomunitasController.GetRelawanCount(komunitas.IdKomunitas).ToString() + "  Relawan";
                                countKegiatanLbl.Text = KomunitasController.GetKegiatanCount(komunitas.IdKomunitas).ToString() + "  Kegiatan";

                                if (RelawanController.GetAllRelawanForHeader(komunitas.IdKomunitas).Count == 0)
                                {
                                    countRelawanLbl.NavigateUrl = "~/Views/ASPX/ProfilePage.aspx";
                                }
                            }
                        }
                    }
                }
                else
                {
                    Response.Redirect("~/Views/ASPX/SignInPage.aspx");
                }
            }
        }
        public static string GetDateRange(object startDate, object endDate)
        {
            if (startDate == null || endDate == null)
                return string.Empty;

            DateTime start = Convert.ToDateTime(startDate);
            DateTime end = Convert.ToDateTime(endDate);

            if (start == end)
            {
                return $"<span>{start:dd MMMM yyyy}</span>";
            }
            else
            {
                return $"<span>{start:dd MMMM yyyy} - {end:dd MMMM yyyy}</span>";
            }
        }
        protected void updateBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/ASPX/EditKomunitasProfilePage.aspx");
        }

        protected void updateBtnRelawan_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/ASPX/EditRelawanProfilePage.aspx");
        }

        protected void seeAllBtnRelawan_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/ASPX/SemuaKegiatanRelawanPage.aspx");
        }

        protected void seeAllBtnRelawan2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/ASPX/SemuaKomunitasRelawanPage.aspx");
        }
    }
}