using QuickEV_Website.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuickEV_Website.Repository
{
    public class KomunitasRepository
    {
        private static Database1Entities1 db = new Database1Entities1 ();

        public static void AddKomunitas(Komunitas komunitas)
        {
            db.Komunitas1.Add(komunitas);
            db.SaveChanges();
        }
        public static Komunitas GetKomunitasById(int id)
        {
            return (from x in db.Komunitas1
                    where x.IdKomunitas == id
                    select x).FirstOrDefault();
        }
    }
}