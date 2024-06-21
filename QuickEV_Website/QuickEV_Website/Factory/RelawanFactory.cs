using QuickEV_Website.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuickEV_Website.Factory
{
    public class RelawanFactory
    {
        public static Relawan CreateRelawan(int IdRelawan, String NamaRelawan, String EmailRelawan,
            String GenderRelawan, DateTime DOBRelawan, String ProvinsiRelawan)
        {
            Relawan relawan = new Relawan();
            relawan.IdRelawan = IdRelawan;
            relawan.NamaRelawan = NamaRelawan;  
            relawan.EmailRelawan = EmailRelawan;
            relawan.GenderRelawan = GenderRelawan;
            relawan.DOBRelawan = DOBRelawan;
            relawan.ProvinsiRelawan = ProvinsiRelawan;
            return relawan;
        }
    }
}