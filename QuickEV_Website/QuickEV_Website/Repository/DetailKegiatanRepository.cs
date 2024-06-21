using QuickEV_Website.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuickEV_Website.Repository
{
    public class DetailKegiatanRepository
    {
        private static Database1Entities2 db = new Database1Entities2();
        public static void AddDetailKegiatan(DetailKegiatan detailKegiatan)
        {
            db.DetailKegiatans.Add(detailKegiatan);
            db.SaveChanges();
        }
        public static DetailKegiatan GetLastDetailKegiatan()
        {
            return db.DetailKegiatans.ToList().LastOrDefault();
        }
        public static List<DetailKegiatan> GetDetailKegiatanByIdRelawan(int idRelawan)
        {
            return  (from x in db.DetailKegiatans
                     where x.IdRelawan ==  idRelawan
                     select x).ToList();
        }
    }
}