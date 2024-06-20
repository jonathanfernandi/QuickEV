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
    }
}