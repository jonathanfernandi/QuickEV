using QuickEV_Website.Factory;
using QuickEV_Website.Model;
using QuickEV_Website.Modules;
using QuickEV_Website.Repository;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace QuickEV_Website.Handler
{
    public class KegiatanHandler
    {
        public static List<object> GetAllKegiatanOfAKomunitasForHeader(int idKomunitas)
        {
            return KegiatanRepository.GetAllKegiatanOfAKomunitasForHeader(idKomunitas);
        }
        public static List<object> GetAllKegiatanOfAKomunitasForDetail(int idKegiatan)
        {
            return KegiatanRepository.GetAllKegiatanOfAKomunitasForDetail(idKegiatan);
        }
        public static List<Kegiatan> GetAllKegiatan()
        {
            return KegiatanRepository.GetAllKegiatan();
        }
        public static Kegiatan GetKegiatanById(int idKegiatan)
        {
            return KegiatanRepository.GetKegiatanById(idKegiatan);
        }
        public static int GetKegiatanCount(int idKegiatan)
        {
            return KegiatanRepository.GetKegiatanCount(idKegiatan);
        }
        public static int generateId()
        {
            Kegiatan kegiatan = KegiatanRepository.GetLastKegiatan();
            if (kegiatan == null)
            {
                return 1;
            }
            int lastId = kegiatan.IdKegiatan;
            lastId++;
            return lastId;
        }
        public static Response<Kegiatan> AddKegiatan(int IdKomunitas, String NamaKegiatan,
            DateTime StartDate, DateTime EndDate, String Lokasi, Image Foto, DateTime StartTime,
            DateTime EndTime, DateTime StartRegistration, DateTime EndRegistration, String DescKegiatan,
            String NamaPekerjaan, int RelawanDibutuhkan, String TugasRelawan, String KriteriaRelawan,
            String PerlengkapanRelawan, String DomisiliRelawan, String FokusEvent)
        {
            Kegiatan kegiatan = KegiatanFactory.CreateKegiatan(KegiatanHandler.generateId(), IdKomunitas, NamaKegiatan,
                StartDate, EndDate, Lokasi, Foto, StartTime, EndTime, StartRegistration, EndRegistration, DescKegiatan,
                NamaPekerjaan, RelawanDibutuhkan, TugasRelawan, KriteriaRelawan, PerlengkapanRelawan, DomisiliRelawan, FokusEvent);
            KegiatanRepository.AddKegiatan(kegiatan);
            return new Response<Kegiatan>
            {
                Message = "",
                IsSuccess = true,
                Payload = kegiatan
            };
        }
        public static Response<DetailKegiatan> AddDetailKegiatan(int idKegiatan, int idRelawan)
        {
            DetailKegiatan detailKegiatan = DetailKegiatanFactory.CreateDetailKegiatan(idKegiatan, idRelawan, DateTime.Now);
            KegiatanRepository.AddDetailKegiatan(detailKegiatan);
            return new Response<DetailKegiatan>
            {
                Message = "",
                IsSuccess = true,
                Payload = detailKegiatan
            };
        }
        public static List<object> GetAllKegiatanForHeader()
        {
            return KegiatanRepository.GetAllKegiatanForHeader();
        }
        public static int GetKegiatanCount2()
        {
            return KegiatanRepository.GetKegiatanCount2();
        }
        public static DetailKegiatan GetDetailKegiatanById(int idKegiatan, int idRelawan)
        {
            return KegiatanRepository.GetDetailKegiatanById(idKegiatan, idRelawan);
        }
    }
}