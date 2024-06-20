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
    }
}