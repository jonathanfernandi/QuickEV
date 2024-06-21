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
    public partial class KegiatanDetailPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (UserController.IsUserLoggedIn())
                {
                    if (UserController.IsUserRelawan())
                    {
                        // you're not authorized page (HARUSNYA)
                        Response.Redirect("~/Views/ASPX/HomePage.aspx");
                    }
                }
                else
                {
                    Response.Redirect("~/Views/ASPX/SignInPage.aspx");
                }
                User user = UserController.GetUserBySession();
                String IdKegiatan = Request.QueryString["IdKegiatan"];
                if (IdKegiatan.Length != 0 && user != null)
                {
                    //if (KegiatanController.GetKegiatanById(int.Parse(IdKegiatan)) != null && KegiatanController.GetAllKegiatanOfAKomunitasForDetail(int.Parse(IdKegiatan)).Count > 0)
                    //{
                    //    detailRpt.DataSource = KegiatanController.GetAllKegiatanOfAKomunitasForDetail(int.Parse(IdKegiatan));
                    //    detailRpt.DataBind();
                    //}
                    Kegiatan kegiatan = KegiatanController.GetKegiatanById(int.Parse(IdKegiatan));
                    Komunita komunitas = KomunitasController.GetKomunitasById(user.IdKomunitas.Value);
                    if (kegiatan != null && komunitas != null)
                    {
                        titleLbl.Text = kegiatan.NamaKegiatan;
                        fokusLbl.Text = kegiatan.FokusEvent;
                        jadwalEventLbl.Text = GetDateRange(kegiatan.StartDate, kegiatan.EndDate);
                        waktuEventLbl.Text = string.Format("{0:hh\\:mm}", kegiatan.StartTime) + " sampai " + string.Format("{0:hh\\:mm}", kegiatan.EndTime);
                        lokasiLbl.Text = kegiatan.Lokasi;
                        tanggalRegistrasiLbl.Text = GetDateRange(kegiatan.StartRegistration, kegiatan.EndRegistration);

                        imgFotoKegiatan.ImageUrl = "data:image/png;base64," + Convert.ToBase64String((byte[]) kegiatan.FotoKegiatan);
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
    }
}