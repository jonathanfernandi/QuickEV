using QuickEV_Website.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuickEV_Website.Factory
{
    public class DetailKegiatanFactory
    {
        public static DetailKegiatan CreateDetailKegiatan(int idKegiatan, int idRelawan, DateTime tanggalRegistrasi)
        {
            return new DetailKegiatan()
            {
                IdKegiatan = idKegiatan,
                IdRelawan = idRelawan,
                TanggalRegistrasi = tanggalRegistrasi
            };
        }
    }
}