using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuickEV_Website.Views.ASPX
{
    public partial class TentangKamiPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void AmbilBagianBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/ASPX/CariKegiatanPage.aspx");
        }
    }
}