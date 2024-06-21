using QuickEV_Website.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;

namespace QuickEV_Website.Factory
{
    public class KegiatanFactory
    {
        public static Kegiatan CreateKegiatan(int IdKegiatan, int IdKomunitas, String NamaKegiatan,
            DateTime StartDate, DateTime EndDate, String Lokasi, Image Foto, DateTime StartTime,
            DateTime EndTime, DateTime StartRegistration, DateTime EndRegistration, String DescKegiatan,
            String NamaPekerjaan, int RelawanDibutuhkan, String TugasRelawan, String KriteriaRelawan,
            String PerlengkapanRelawan, String DomisiliRelawan, String FokusEvent)
        {
            Kegiatan kegiatan = new Kegiatan();
            kegiatan.IdKegiatan = IdKegiatan;
            kegiatan.IdKomunitas = IdKomunitas;
            kegiatan.NamaKegiatan = NamaKegiatan;
            kegiatan.StartDate = StartDate;
            kegiatan.EndDate = EndDate;
            kegiatan.Lokasi = Lokasi;
            kegiatan.FotoKegiatan = ImageToByteArray(Foto);
            kegiatan.StartTime = StartTime;
            kegiatan.EndTime = EndTime;
            kegiatan.StartRegistration = StartRegistration;
            kegiatan.EndRegistration = EndRegistration;
            kegiatan.DescKegiatan = DescKegiatan;
            kegiatan.NamaPekerjaan = NamaPekerjaan;
            kegiatan.RelawanDibutuhkan = RelawanDibutuhkan;
            kegiatan.TugasRelawan = TugasRelawan;
            kegiatan.KriteriaRelawan = KriteriaRelawan;
            kegiatan.PerlengkapanRelawan = PerlengkapanRelawan;
            kegiatan.DomisiliRelawan = DomisiliRelawan;
            kegiatan.FokusEvent = FokusEvent;
            return kegiatan;
        }
        public static byte[] ImageToByteArray(Image image)
        {
            using (var ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }
    }
}