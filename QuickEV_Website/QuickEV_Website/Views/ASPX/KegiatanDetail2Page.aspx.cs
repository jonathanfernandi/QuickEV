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
    public partial class KegiatanDetail2Page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                String IdKegiatan = Request.QueryString["IdKegiatan"];
                if (IdKegiatan.Length != 0)
                {
                    Kegiatan kegiatan = KegiatanController.GetKegiatanById(int.Parse(IdKegiatan));
                    Komunita komunitas = KomunitasController.GetKomunitasById(kegiatan.IdKomunitas);
                    if (kegiatan != null && komunitas != null)
                    {
                        titleLbl.Text = kegiatan.NamaKegiatan;
                        fokusLbl.Text = kegiatan.FokusEvent;
                        jadwalEventLbl.Text = GetDateRange(kegiatan.StartDate, kegiatan.EndDate);
                        waktuEventLbl.Text = string.Format("{0:hh\\:mm}", kegiatan.StartTime) + " sampai " + string.Format("{0:hh\\:mm}", kegiatan.EndTime);
                        lokasiLbl.Text = kegiatan.Lokasi;
                        tanggalRegistrasiLbl.Text = GetDateRange(kegiatan.StartRegistration, kegiatan.EndRegistration);

                        imgFotoKegiatan.ImageUrl = "data:image/png;base64," + Convert.ToBase64String((byte[])kegiatan.FotoKegiatan);
                        imgLogo.ImageUrl = "data:image/png;base64," + Convert.ToBase64String((byte[])komunitas.Logo); ;
                        komunitasNameLbl.Text = komunitas.NamaKomunitas;
                        relawanTerkumpulLbl.Text = KegiatanController.GetKegiatanCount(kegiatan.IdKegiatan).ToString() + "/" + kegiatan.RelawanDibutuhkan.ToString();
                        descKegiatanLbl.Text = kegiatan.DescKegiatan;
                        namaPekerjaanLbl.Text = kegiatan.NamaPekerjaan;
                        tugasRelawanLbl.Text = kegiatan.TugasRelawan;
                        kriteriaRelawanLbl.Text = kegiatan.KriteriaRelawan;
                        perlengkapanRelawanLbl.Text = kegiatan.PerlengkapanRelawan;
                        domisiliRelawanLbl.Text = kegiatan.DomisiliRelawan;
                    }

                    if (UserController.IsUserLoggedIn())
                    {
                        User user = UserController.GetUserBySession();
                        Relawan relawan = RelawanController.GetRelawanById(user.IdRelawan.Value);
                        if (KegiatanController.GetDetailKegiatanById(kegiatan.IdKegiatan, relawan.IdRelawan) != null)
                        {
                            gabungBtn.Text = "Sudah Bergabung";
                        }
                    }

                    if (kegiatan != null)
                    {
                        if(kegiatan.StartRegistration > DateTime.Now)
                        {
                            gabungBtn.Visible = false;
                        }
                    }

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
                return $"{start:dd MMMM yyyy}";
            }
            else
            {
                return $"{start:dd MMMM yyyy} - {end:dd MMMM yyyy}";
            }
        }

        protected void gabungBtn_Click(object sender, EventArgs e)
        {
            if (UserController.IsUserLoggedIn() && UserController.IsUserRelawan())
            {
                String IdKegiatan = Request.QueryString["IdKegiatan"];
                User user = UserController.GetUserBySession();
                if (user != null && IdKegiatan.Length != 0)
                {
                    Kegiatan kegiatan = KegiatanController.GetKegiatanById(int.Parse(IdKegiatan));
                    Relawan relawan = RelawanController.GetRelawanById(user.IdRelawan.Value);
                    if (kegiatan != null && relawan != null && KegiatanController.GetDetailKegiatanById(kegiatan.IdKegiatan, relawan.IdRelawan) == null)
                    {
                        KegiatanController.AddDetailKegiatan(kegiatan.IdKegiatan, relawan.IdRelawan);
                        Response.Redirect("~/Views/ASPX/CariKegiatanPage.aspx");
                        //Response.Redirect("~/Views/ASPX/ProfilePage.aspx");
                    }
                    //else
                    //{
                    //    Response.Redirect("~/Views/ASPX/KegiatanDetail2Page.aspx");
                    //    gabungLbl.Visible = true;
                    //}
                }
            }
            else
            {
                Response.Redirect("~/Views/ASPX/SignInPage.aspx");
            }
        }
    }
}
