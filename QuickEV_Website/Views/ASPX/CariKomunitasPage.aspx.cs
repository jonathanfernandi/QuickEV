using QuickEV_Website.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuickEV_Website.Views.ASPX
{
    public partial class CariKomunitasPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (KomunitasController.GetAllKomunitasForHeader().Count > 0)
                //if (KomunitasController.GetKomunitasCount() > 0)
                {
                    volunteeringRpt.DataSource = KomunitasController.GetAllKomunitasForHeader();
                    volunteeringRpt.DataBind();
                    counterLbl.Text = KomunitasController.GetKomunitasCount().ToString();
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