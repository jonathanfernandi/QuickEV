using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuickEV_Website.Views.ASPX
{
    public partial class ContactUsPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void KirimPesan_Btn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/ASPX/ContactUsPage.aspx");
        }
    }
}