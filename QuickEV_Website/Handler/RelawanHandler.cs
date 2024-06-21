using QuickEV_Website.Model;
using QuickEV_Website.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuickEV_Website.Handler
{
    public class RelawanHandler
    {
        public static int generateId()
        {
            Relawan relawan = RelawanRepository.GetLastRelawan();
            if (relawan == null)
            {
                return 1;
            }
            int lastId = relawan.IdRelawan;
            lastId++;
            return lastId;
        }
        public static Relawan GetRelawanById(int id)
        {
            return RelawanRepository.GetRelawanById(id);
        }
        public static int GetKegiatanCount(int idRelawan)
        {
            return RelawanRepository.GetKegiatanCount(idRelawan);
        }
        public static int GetKomunitasCount(int idRelawan)
        {
            return RelawanRepository.GetKomunitasCount(idRelawan);
        }
        public static List<object> GetAllKegiatanOfAKomunitasForHeader(int idRelawan)
        {
            return RelawanRepository.GetAllKegiatanOfAKomunitasForHeader(idRelawan);
        }
        public static List<object> GetAllKegiatanOfAKomunitasForHeader2(int idRelawan)
        {
            return RelawanRepository.GetAllKegiatanOfAKomunitasForHeader2(idRelawan);
        }
        public static List<object> GetAllKomunitasForHeader(int idRelawan)
        {
            return RelawanRepository.GetAllKomunitasForHeader(idRelawan);
        }
        public static List<object> GetAllKomunitasForHeader2(int idRelawan)
        {
            return RelawanRepository.GetAllKomunitasForHeader2(idRelawan);
        }
        public static List<object> GetAllRelawanForHeader(int idKomunitas)
        {
            return RelawanRepository.GetAllRelawanForHeader(idKomunitas);
        }
    }
}