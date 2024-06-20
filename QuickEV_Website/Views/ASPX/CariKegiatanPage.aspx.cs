using QuickEV_Website.Controller;
using QuickEV_Website.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuickEV_Website.Views.ASPX
{
    public partial class CariKegiatan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (KegiatanController.GetAllKegiatanForHeader().Count > 0)
                {
                    volunteeringRpt.DataSource = KegiatanController.GetAllKegiatanForHeader();
                    volunteeringRpt.DataBind();
                    counterLbl.Text = KegiatanController.GetKegiatanCount2().ToString();
                }
                else
                {
                    countZeroLbl.Visible = true;
                    countZeroImg.Visible = true;
                    counterLbl.Text = "0";
                }
            }
        }
    }
}
