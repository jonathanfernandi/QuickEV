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
    public partial class KegiatanPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (UserController.IsUserLoggedIn())
                {
                    if (UserController.IsUserRelawan())
                    {
                        // you're not authorized page (HARUSNYA)
                        Response.Redirect("~/Views/ASPX/HomePage.aspx");
                    }
                }
                else
                {
                    Response.Redirect("~/Views/ASPX/SignInPage.aspx");
                }
                User user = UserController.GetUserBySession();
                if (KegiatanController.GetAllKegiatanOfAKomunitasForHeader(user.IdKomunitas.Value).Count > 0)
                {
                    volunteeringRpt.DataSource = KegiatanController.GetAllKegiatanOfAKomunitasForHeader(user.IdKomunitas.Value);
                    volunteeringRpt.DataBind();
                }
                else
                {
                    countZeroLbl.Visible = true;
                    countZeroImg.Visible = true;
                    bigHeaderLbl.Visible = false;
                }
            }
        }
        public static string GetDateRange(object startDate, object endDate)
        {
            if (startDate == null || endDate == null)
                return string.Empty;

            DateTime start = Convert.ToDateTime(startDate);
            DateTime end = Convert.ToDateTime(endDate);

            if (start == end)
            {
                return $"<span>{start:dd MMMM yyyy}</span>";
            }
            else
            {
                return $"<span>{start:dd MMMM yyyy} - {end:dd MMMM yyyy}</span>";
            }
        }

    }
}