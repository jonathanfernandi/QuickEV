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
    }
}