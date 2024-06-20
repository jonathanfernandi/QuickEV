using QuickEV_Website.Controller;
using QuickEV_Website.Model;
using QuickEV_Website.Modules;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace QuickEV_Website.Views.ASPX
{
    public partial class TambahKegiatan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
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
        }

        protected void tambahBtn_Click(object sender, EventArgs e)
        {
            String namaKegiatan = nameKegiatanTxt.Text;
            String desc = descTxt.Text;
            String fokus = fokusDDL.Text;
            String startRegist = startRegistTxt.Text;
            DateTime startRegistDate;
            if (DateTime.TryParse(startRegist, out startRegistDate))
            {
                startRegistDate = DateTime.Parse(startRegist);
            }
            else
            {
                startRegistErrorLbl.Text = "Tanggal Buka Pendaftaran harus diisi!";
            }
            String endRegist = endRegistTxt.Text;
            DateTime endRegistDate;
            if (DateTime.TryParse(endRegist, out endRegistDate))
            {
                endRegistDate = DateTime.Parse(endRegist);
            }
            else
            {
                endRegistErrorLbl.Text = "Tanggal Tutup Pendaftaran harus diisi!";
            }
            String fileExtension = Path.GetExtension(fotoFU.FileName).ToLower();
            bool fileExtensionSuccess = false;
            if (fotoFU.HasFile)
            {
                if (fileExtension == ".png")
                {
                    fileExtensionSuccess = true;
                }
                else
                {
                    fotoErrorLbl.Text = "Invalid file type. Please upload a .PNG file.";
                }
            }
            else
            {
                fotoErrorLbl.Text = "Please select a file to upload.";
            }
            String namaPekerjaan = namaPekerjaanTxt.Text;
            String relawanDibutuhkanString = relawanDibutuhkanTxt.Text;
            int relawanDibutuhkan;
            bool relawanDibutuhkanSuccess = false;
            if (int.TryParse(relawanDibutuhkanString, out relawanDibutuhkan))
            {
                relawanDibutuhkan = int.Parse(relawanDibutuhkanString);
                relawanDibutuhkanSuccess = true;
            }
            else
            {
                relawanDibutuhkanErrorLbl.Text = "Jumlah Relawan Dibutuhkan harus diisi.";
            }
            if(relawanDibutuhkan <= 0)
            {
                relawanDibutuhkanErrorLbl.Text = "Jumlah Relawan tidak boleh kurang dari sama dengan 0.";
            }
            else
            {
                relawanDibutuhkanSuccess = true;
            }
            String tugasRelawan = tugasRelawanTxt.Text;
            String kriteriaRelawan = kriteriaRelawanTxt.Text;
            String perlengkapanRelawan = perlengkapanRelawanTxt.Text;
            String domisiliRelawan = domisiliRelawanDDL.Text;
            String lokasi = lokasiTxt.Text;
            String startDate = startDateTxt.Text;
            DateTime startEventDate;
            if (DateTime.TryParse(startDate, out startEventDate))
            {
                startEventDate = DateTime.Parse(startDate);
            }
            else
            {
                startDateErrorLbl.Text = "Tanggal Mulai Kegiatan harus diisi!";
            }
            String endDate = endDateTxt.Text;
            DateTime endEventDate;
            if (DateTime.TryParse(endDate, out endEventDate))
            {
                endEventDate = DateTime.Parse(endDate);
            }
            else
            {
                endDateErrorLbl.Text = "Tanggal Akhir Kegiatan harus diisi!";
            }
            String startTime = startTimeTxt.Text;
            DateTime startTimeForreal;
            if (DateTime.TryParse(startTime, out startTimeForreal))
            {
                startTimeForreal = DateTime.Parse(startTime);
            }
            else
            {
                startTimeErrorLbl.Text = "Jam Mulai Kegiatan harus diisi!";
            }
            String endTime = endTimeTxt.Text;
            DateTime endTimeForreal;
            if (DateTime.TryParse(endTime, out endTimeForreal))
            {
                endTimeForreal = DateTime.Parse(endTime);
            }
            else
            {
                endTimeErrorLbl.Text = "Jam Akhir Kegiatan harus diisi!";
            }

            Response<Kegiatan> checkNamaKegiatan = KegiatanController.NameCheck1(namaKegiatan);
            Response<Kegiatan> checkDesc = KegiatanController.DescCheck(desc);
            Response<Kegiatan> checkFokus = KegiatanController.FokusCheck(fokus);
            Response<Kegiatan> checkStartRegist = KegiatanController.RegistCheckStart(startRegistDate, endRegistDate);
            Response<Kegiatan> checkEndRegist = KegiatanController.RegistCheckEnd(endRegistDate);
            Response<Kegiatan> checkNamaPekerjaan = KegiatanController.NameCheck2(namaPekerjaan);
            Response<Kegiatan> checkTugasRelawan = KegiatanController.TugasRelawanCheck(tugasRelawan);
            Response<Kegiatan> checkKriteriaRelawan = KegiatanController.KriteriaRelawanCheck(kriteriaRelawan);
            Response<Kegiatan> checkPerlengkapanRelawan = KegiatanController.PerlengkapanRelawanCheck(perlengkapanRelawan);
            Response<Kegiatan> checkDomisiliRelawan = KegiatanController.DomisiliCheck(domisiliRelawan);
            Response<Kegiatan> checkLokasi = KegiatanController.LokasiCheck(lokasi);
            Response<Kegiatan> checkStartDate = KegiatanController.DateCheckStart(startEventDate, endEventDate);
            Response<Kegiatan> checkEndDate = KegiatanController.DateCheckEnd(endEventDate);
            Response<Kegiatan> checkStartTime = KegiatanController.TimeCheckStart(startTimeForreal, endTimeForreal);
            Response<Kegiatan> checkEndTime = KegiatanController.TimeCheckEnd(endTimeForreal);

            if (checkNamaKegiatan.IsSuccess && checkDesc.IsSuccess && checkFokus.IsSuccess && checkStartRegist.IsSuccess &&
                checkEndRegist.IsSuccess && fileExtensionSuccess && checkNamaPekerjaan.IsSuccess && relawanDibutuhkanSuccess && checkTugasRelawan.IsSuccess && checkKriteriaRelawan.IsSuccess &&
                checkPerlengkapanRelawan.IsSuccess && checkDomisiliRelawan.IsSuccess && checkLokasi.IsSuccess && checkStartDate.IsSuccess &&
                checkEndDate.IsSuccess && checkStartTime.IsSuccess && checkEndTime.IsSuccess)
            {
                using (MemoryStream ms = new MemoryStream(fotoFU.FileBytes))
                {
                    System.Drawing.Image foto = System.Drawing.Image.FromStream(ms);
                    User user = UserController.GetUserBySession();
                    Response<Kegiatan> response = KegiatanController.DoAddKegiatan(user.IdKomunitas.Value, namaKegiatan, startEventDate, endEventDate,
                        lokasi, foto, startTimeForreal, endTimeForreal, startRegistDate, endRegistDate, desc, namaPekerjaan, relawanDibutuhkan,
                        tugasRelawan, kriteriaRelawan, perlengkapanRelawan, domisiliRelawan, fokus);
                    Response.Redirect("~/Views/ASPX/KegiatanPage.aspx");
                }
            }
            else if (!checkNamaKegiatan.IsSuccess || !checkDesc.IsSuccess || !checkFokus.IsSuccess || !checkStartRegist.IsSuccess ||
                !checkEndRegist.IsSuccess || !fileExtensionSuccess || !checkNamaPekerjaan.IsSuccess || !relawanDibutuhkanSuccess || !checkTugasRelawan.IsSuccess || !checkKriteriaRelawan.IsSuccess ||
                !checkPerlengkapanRelawan.IsSuccess || !checkDomisiliRelawan.IsSuccess || !checkLokasi.IsSuccess || !checkStartDate.IsSuccess ||
                !checkEndDate.IsSuccess || !checkStartTime.IsSuccess || !checkEndTime.IsSuccess)
            {
                nameKegiatanErrorLbl.Text = checkNamaKegiatan.Message.ToString();
                descErrorLbl.Text = checkDesc.Message.ToString();
                fokusErrorLbl.Text = checkFokus.Message.ToString();
                startRegistErrorLbl.Text = checkStartRegist.Message.ToString();
                endRegistErrorLbl.Text = checkEndRegist.Message.ToString();
                namaPekerjaanErrorLbl.Text = checkNamaPekerjaan.Message.ToString();
                tugasRelawanErrorLbl.Text = checkTugasRelawan.Message.ToString();
                kriteriaRelawanErrorLbl.Text = checkKriteriaRelawan.Message.ToString();
                perlengkapanRelawanErrorLbl.Text = checkPerlengkapanRelawan.Message.ToString();
                domisiliRelawanErrorLbl.Text = checkDomisiliRelawan.Message.ToString();
                lokasiErrorLbl.Text = checkLokasi.Message.ToString();
                startDateErrorLbl.Text = checkStartDate.Message.ToString();
                endDateErrorLbl.Text = checkEndDate.Message.ToString();
                startTimeErrorLbl.Text = checkStartTime.Message.ToString();
                endTimeErrorLbl.Text = checkEndTime.Message.ToString();
            }
        }
    }
}