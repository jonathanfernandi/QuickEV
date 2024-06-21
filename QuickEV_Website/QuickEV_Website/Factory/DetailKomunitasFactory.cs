using QuickEV_Website.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuickEV_Website.Factory
{
    public class DetailKomunitasFactory
    {
        public static DetailKomunita CreateDetailKomunitas(int idKomunitas, int idRelawan, DateTime tanggalDaftar)
        {
            return new DetailKomunita()
            {
                IdKomunitas = idKomunitas,
                IdRelawan = idRelawan,
                TanggalDaftar = tanggalDaftar
            };
        }
    }
}