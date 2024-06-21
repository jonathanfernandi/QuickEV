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
    public partial class SemuaKegiatanRelawanPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (UserController.IsUserLoggedIn())
                {
                    if (UserController.IsUserRelawan())
                    {
                        User user = UserController.GetUserBySession();
                        Relawan relawan = RelawanController.GetRelawanById(user.IdRelawan.Value);
                        if (relawan != null)
                        {
                            if (RelawanController.GetAllKegiatanOfAKomunitasForHeader2(relawan.IdRelawan).Count > 0)
                            {
                                volunteeringRpt.DataSource = RelawanController.GetAllKegiatanOfAKomunitasForHeader2(relawan.IdRelawan);
                                volunteeringRpt.DataBind();
                            }
                        }
                    }
                    else
                    {
                        Response.Redirect("~/Views/ASPX/ProfilePage.aspx");
                    }
                }
                else
                {
                    Response.Redirect("~/Views/ASPX/SignInPage.aspx");
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