using QuickEV_Website.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuickEV_Website.Repository
{
    public class RelawanRepository
    {
        private static Database1Entities2 db = new Database1Entities2();
        public static void AddRelawan(Relawan relawan)
        {
            db.Relawans.Add(relawan);
            db.SaveChanges();
        }
        public static Relawan GetRelawanById(int id)
        {
            return (from x in db.Relawans
                    where x.IdRelawan == id
                    select x).FirstOrDefault();
        }
        public static Relawan GetRelawanByEmail(String email)
        {
            return (from x in db.Relawans
                    where x.EmailRelawan.Equals(email)
                    select x).FirstOrDefault();
        }
        public static Relawan GetLastRelawan()
        {
            return db.Relawans.ToList().LastOrDefault();
        }
        public static int GetKegiatanCount(int idRelawan)
        {
            return db.DetailKegiatans.Count(d => d.IdRelawan == idRelawan);
        }
        public static int GetKomunitasCount(int idRelawan)
        {
            return db.DetailKomunitas.Count(d => d.IdRelawan == idRelawan);
        }
        public static List<object> GetAllKegiatanOfAKomunitasForHeader(int idRelawan)
        {
            var keg = (from kegiatan in db.Kegiatans
                       join detailKegiatan in db.DetailKegiatans on kegiatan.IdKegiatan equals detailKegiatan.IdKegiatan
                       join komunitas in db.Komunitas on kegiatan.IdKomunitas equals komunitas.IdKomunitas
                       where detailKegiatan.IdRelawan == idRelawan
                       select new
                       {
                           FotoKegiatan = kegiatan.FotoKegiatan,
                           NamaKegiatan = kegiatan.NamaKegiatan,
                           NamaKomunitas = komunitas.NamaKomunitas,
                           StartEventDate = kegiatan.StartDate,
                           EndEventDate = kegiatan.EndDate,
                           Domisili = kegiatan.DomisiliRelawan,
                           IdKegiatan = kegiatan.IdKegiatan
                       }).Take(4).ToList<object>();
            return keg;
        }
        public static List<object> GetAllKegiatanOfAKomunitasForHeader2(int idRelawan)
        {
            var keg = (from kegiatan in db.Kegiatans
                       join detailKegiatan in db.DetailKegiatans on kegiatan.IdKegiatan equals detailKegiatan.IdKegiatan
                       join komunitas in db.Komunitas on kegiatan.IdKomunitas equals komunitas.IdKomunitas
                       where detailKegiatan.IdRelawan == idRelawan
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
        public static List<object> GetAllKomunitasForHeader(int idRelawan)
        {
            var kom = (from komunitas in db.Komunitas
                       join detailKomunitas in db.DetailKomunitas on komunitas.IdKomunitas equals detailKomunitas.IdKomunitas
                       where detailKomunitas.IdRelawan == idRelawan
                       select new
                       {
                           LogoKomunitas = komunitas.Logo,
                           NamaKomunitas = komunitas.NamaKomunitas,
                           Domisili = komunitas.Provinsi,
                           Fokus = komunitas.FokusUtama,
                           CountRelawan = db.DetailKomunitas.Count(d => d.IdKomunitas == komunitas.IdKomunitas),
                           CountKegiatan = db.Kegiatans.Count(d => d.IdKomunitas == komunitas.IdKomunitas),
                           IdKomunitas = komunitas.IdKomunitas
                       }).Take(4).ToList<object>();
            return kom;
        }
        public static List<object> GetAllKomunitasForHeader2(int idRelawan)
        {
            var kom = (from komunitas in db.Komunitas
                       join detailKomunitas in db.DetailKomunitas on komunitas.IdKomunitas equals detailKomunitas.IdKomunitas
                       where detailKomunitas.IdRelawan == idRelawan
                       select new
                       {
                           LogoKomunitas = komunitas.Logo,
                           NamaKomunitas = komunitas.NamaKomunitas,
                           Domisili = komunitas.Provinsi,
                           Fokus = komunitas.FokusUtama,
                           CountRelawan = db.DetailKomunitas.Count(d => d.IdKomunitas == komunitas.IdKomunitas),
                           CountKegiatan = db.Kegiatans.Count(d => d.IdKomunitas == komunitas.IdKomunitas),
                           IdKomunitas = komunitas.IdKomunitas
                       }).ToList<object>();
            return kom;
        }
        public static List<object> GetAllRelawanForHeader(int idKomunitas)
        {
            var rel = (from relawan in db.Relawans
                       join detailKomunitas in db.DetailKomunitas on relawan.IdRelawan equals detailKomunitas.IdRelawan
                       where detailKomunitas.IdKomunitas == idKomunitas
                       select new
                       {
                           NamaRelawan = relawan.NamaRelawan,
                           Email = relawan.EmailRelawan,
                           Domisili = relawan.ProvinsiRelawan
                       }).ToList<object>();
            return rel;
        }
    }
}