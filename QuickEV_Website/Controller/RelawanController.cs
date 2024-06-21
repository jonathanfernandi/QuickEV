using QuickEV_Website.Handler;
using QuickEV_Website.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuickEV_Website.Controller
{
    public class RelawanController
    {
        public static Relawan GetRelawanById(int id)
        {
            return RelawanHandler.GetRelawanById(id);
        }
        public static int GetKegiatanCount(int idRelawan)
        {
            return RelawanHandler.GetKegiatanCount(idRelawan);
        }
        public static int GetKomunitasCount(int idRelawan)
        {
            return RelawanHandler.GetKomunitasCount(idRelawan);
        }
        public static List<object> GetAllKegiatanOfAKomunitasForHeader(int idRelawan)
        {
            return RelawanHandler.GetAllKegiatanOfAKomunitasForHeader(idRelawan);
        }
        public static List<object> GetAllKegiatanOfAKomunitasForHeader2(int idRelawan)
        {
            return RelawanHandler.GetAllKegiatanOfAKomunitasForHeader2(idRelawan);
        }
        public static List<object> GetAllKomunitasForHeader(int idRelawan)
        {
            return RelawanHandler.GetAllKomunitasForHeader(idRelawan);
        }
        public static List<object> GetAllKomunitasForHeader2(int idRelawan)
        {
            return RelawanHandler.GetAllKomunitasForHeader2(idRelawan);
        }
        public static List<object> GetAllRelawanForHeader(int idKomunitas)
        {
            return RelawanHandler.GetAllRelawanForHeader(idKomunitas);
        }
    }
}