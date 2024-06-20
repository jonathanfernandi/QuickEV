using QuickEV_Website.Factory;
using QuickEV_Website.Model;
using QuickEV_Website.Modules;
using QuickEV_Website.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuickEV_Website.Handler
{
    public class KomunitasHandler
    {
        public static int generateId()
        {
            Komunita komunitas = KomunitasRepository.GetLastKomunitas();
            if (komunitas == null)
            {
                return 1;
            }
            int lastId = komunitas.IdKomunitas;
            lastId++;
            return lastId;
        }
        public static Komunita GetKomunitasById(int id)
        {
            return KomunitasRepository.GetKomunitasById(id);
        }
        public static Komunita GetKomunitasByName(String name)
        {
            return KomunitasRepository.GetKomunitasByName(name);
        }
        public static Komunita GetKomunitasByTelp(String telp)
        {
            return KomunitasRepository.GetKomunitasByTelp(telp);
        }
        public static List<object> GetAllKomunitasForHeader()
        {
            return KomunitasRepository.GetAllKomunitasForHeader();
        }
        public static int GetKomunitasCount()
        {
            return KomunitasRepository.GetKomunitasCount();
        }
        public static int GetRelawanCount(int idKomunitas)
        {
            return KomunitasRepository.GetRelawanCount(idKomunitas);
        }
        public static int GetKegiatanCount(int idKomunitas)
        {
            return KomunitasRepository.GetKegiatanCount(idKomunitas);
        }
        public static DetailKomunita GetDetailKomunitasById(int idKomunitas, int idRelawan)
        {
            return KomunitasRepository.GetDetailKomunitasById(idKomunitas, idRelawan);
        }
        public static Response<DetailKomunita> AddDetailKomunitas(int idKomunitas, int idRelawan)
        {
            DetailKomunita detailKomunitas = DetailKomunitasFactory.CreateDetailKomunitas(idKomunitas, idRelawan, DateTime.Now);
            KomunitasRepository.AddDetailKomunitas(detailKomunitas);
            return new Response<DetailKomunita>
            {
                Message = "",
                IsSuccess = true,
                Payload = detailKomunitas
            };
        }
    }
}