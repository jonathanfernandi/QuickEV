using QuickEV_Website.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Util;

namespace QuickEV_Website.Repository
{
    public class KegiatanRepository
    {
        private static Database1Entities2 db = new Database1Entities2();
        public static void AddKegiatan(Kegiatan kegiatan)
        {
            db.Kegiatans.Add(kegiatan);
            db.SaveChanges();
        }
        public static void AddDetailKegiatan(DetailKegiatan detailKegiatan)
        {
            db.DetailKegiatans.Add(detailKegiatan);
            db.SaveChanges();
        }
        public static Kegiatan GetLastKegiatan()
        {
            return db.Kegiatans.ToList().LastOrDefault();
        }
        public static Kegiatan GetKegiatanById(int idKegiatan)
        {
            return (from x in db.Kegiatans
                    where x.IdKegiatan == idKegiatan
                    select x).FirstOrDefault();
        }
        public static DetailKegiatan GetDetailKegiatanById(int idKegiatan, int idRelawan)
        {
            return (from x in db.DetailKegiatans
                    where x.IdKegiatan == idKegiatan && x.IdRelawan == idRelawan
                    select x).FirstOrDefault();
        }
        public static List<Kegiatan> GetAllKegiatan()
        {
            return (from x in db.Kegiatans
                    select x).ToList();
        }
        public static int GetKegiatanCount(int idKegiatan)
        {
            return db.DetailKegiatans.Count(dk => dk.IdKegiatan == idKegiatan);
        }
        public static int GetKegiatanCount2()
        {
            return db.Kegiatans.Count();
        }
        public static List<object> GetAllKegiatanOfAKomunitasForHeader(int idKomunitas)
        {
            var keg = (from kegiatan in db.Kegiatans
                       join komunitas in db.Komunitas on kegiatan.IdKomunitas equals komunitas.IdKomunitas
                       where kegiatan.IdKomunitas == idKomunitas
                       select new
                       {
                           FotoKegiatan = kegiatan.FotoKegiatan,
                           NamaKegiatan = kegiatan.NamaKegiatan,
                           NamaKomunitas = komunitas.NamaKomunitas,
                           StartEventDate = kegiatan.StartDate,
                           EndEventDate = kegiatan.EndDate,
                           Domisili = kegiatan.DomisiliRelawan,
                           IdKegiatan = kegiatan.IdKegiatan
                       }).ToList<object>();
            return keg;
        }
        public static List<object> GetAllKegiatanForHeader()
        {
            var keg = (from kegiatan in db.Kegiatans
                       join komunitas in db.Komunitas on kegiatan.IdKomunitas equals komunitas.IdKomunitas
                       select new
                       {
                           FotoKegiatan = kegiatan.FotoKegiatan,
                           NamaKegiatan = kegiatan.NamaKegiatan,
                           NamaKomunitas = komunitas.NamaKomunitas,
                           StartEventDate = kegiatan.StartDate,
                           EndEventDate = kegiatan.EndDate,
                           Domisili = kegiatan.DomisiliRelawan,
                           IdKegiatan = kegiatan.IdKegiatan
                       }).ToList<object>();
            return keg;
        }
        public static List<object> GetAllKegiatanOfAKomunitasForDetail(int idKegiatan)
        {
            var keg = (from kegiatan in db.Kegiatans
                       join detail in db.DetailKegiatans on kegiatan.IdKegiatan equals detail.IdKegiatan
                       join komunitas in db.Komunitas on kegiatan.IdKomunitas equals komunitas.IdKomunitas
                       where kegiatan.IdKegiatan == idKegiatan
                       select new
                       {
                           NamaKegiatan = kegiatan.NamaKegiatan,
                           Fokus = kegiatan.FokusEvent,
                           StartEventDate = kegiatan.StartDate,
                           EndEventDate = kegiatan.EndDate,
                           StartEventTime = kegiatan.StartTime,
                           EndEventTime = kegiatan.EndTime,
                           Lokasi = kegiatan.Lokasi,
                           StartRegistrationDate = kegiatan.StartRegistration,
                           EndRegistrationDate = kegiatan.EndRegistration,
                           IdKegiatan = kegiatan.IdKegiatan,
                           FotoKegiatan = kegiatan.FotoKegiatan,
                           LogoKomunitas = komunitas.Logo,
                           NamaKomunitas = komunitas.NamaKomunitas,
                           RelawanTerkumpul = db.DetailKegiatans.Count(d => d.IdKegiatan == kegiatan.IdKegiatan),
                           RelawanDibutuhkan = kegiatan.RelawanDibutuhkan,
                           NamaPekerjaan = kegiatan.NamaPekerjaan,
                           TugasRelawan = kegiatan.TugasRelawan,
                           KriteriaRelawan = kegiatan.KriteriaRelawan,
                           PerlengkapanRelawan = kegiatan.PerlengkapanRelawan,
                           DomisiliRelawan = kegiatan.DomisiliRelawan,
                       }).ToList<object>();
            return keg;
        }
    }
}