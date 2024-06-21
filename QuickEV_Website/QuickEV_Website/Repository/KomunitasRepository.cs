using QuickEV_Website.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuickEV_Website.Repository
{
    public class KomunitasRepository
    {
        private static Database1Entities2 db = new Database1Entities2();

        public static void AddKomunitas(Komunita komunitas)
        {
            db.Komunitas.Add(komunitas);
            db.SaveChanges();
        }
        public static Komunita GetKomunitasById(int id)
        {
            return (from x in db.Komunitas
                    where x.IdKomunitas == id
                    select x).FirstOrDefault();
        }
        public static Komunita GetLastKomunitas()
        {
            return db.Komunitas.ToList().LastOrDefault();
        }
        public static Komunita GetKomunitasByName(String name)
        {
            return (from x in db.Komunitas
                    where x.NamaKomunitas.Equals(name)
                    select x).FirstOrDefault();
        }
        public static Komunita GetKomunitasByTelp(String telp)
        {
            return (from x in db.Komunitas
                    where x.TelpKomunitas.Equals(telp)
                    select x).FirstOrDefault();
        }
        public static List<object> GetAllKomunitasForHeader()
        {
            var kom = (from komunitas in db.Komunitas
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
        public static int GetKomunitasCount()
        {
            return db.Komunitas.Count();
        }
        public static int GetRelawanCount(int idKomunitas)
        {
            return db.DetailKomunitas.Count(d => d.IdKomunitas == idKomunitas);
        }
        public static int GetKegiatanCount(int idKomunitas)
        {
            return db.Kegiatans.Count(d => d.IdKomunitas == idKomunitas);
        }
        public static DetailKomunita GetDetailKomunitasById(int idKomunitas, int idRelawan)
        {
            return (from x in db.DetailKomunitas
                    where x.IdKomunitas == idKomunitas && x.IdRelawan == idRelawan
                    select x).FirstOrDefault();
        }
        public static void AddDetailKomunitas(DetailKomunita detailKomunitas)
        {
            db.DetailKomunitas.Add(detailKomunitas);
            db.SaveChanges();
        }
    }
}