using QuickEV_Website.Handler;
using QuickEV_Website.Model;
using QuickEV_Website.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuickEV_Website.Controller
{
    public class KomunitasController
    {
        public static Komunita GetKomunitasById(int id)
        {
            return KomunitasHandler.GetKomunitasById(id);
        }
        public static List<object> GetAllKomunitasForHeader()
        {
            return KomunitasHandler.GetAllKomunitasForHeader();
        }
        public static int GetKomunitasCount()
        {
            return KomunitasHandler.GetKomunitasCount();
        }
        public static int GetRelawanCount(int idKomunitas)
        {
            return KomunitasHandler.GetRelawanCount(idKomunitas);
        }
        public static int GetKegiatanCount(int idKomunitas)
        {
            return KomunitasHandler.GetKegiatanCount(idKomunitas);
        }
        public static DetailKomunita GetDetailKomunitasById(int idKomunitas, int idRelawan)
        {
            return KomunitasHandler.GetDetailKomunitasById(idKomunitas, idRelawan);
        }
        public static Response<DetailKomunita> AddDetailKomunitas(int idKomunitas, int idRelawan)
        {
            return KomunitasHandler.AddDetailKomunitas(idKomunitas, idRelawan);
        }
    }
}