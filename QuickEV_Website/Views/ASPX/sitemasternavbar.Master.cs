using QuickEV_Website.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace QuickEV_Website.Views.ASPX
{
    public partial class sitemasternavbar : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                HtmlGenericControl relawanLi = (HtmlGenericControl)FindControl("relawanLi");
                HtmlGenericControl komunitasLi = (HtmlGenericControl)FindControl("komunitasLi");
                HtmlGenericControl signInLi = (HtmlGenericControl)FindControl("signInLi");
                HtmlGenericControl cariKegiatanLi = (HtmlGenericControl)FindControl("cariKegiatanLi");
                HtmlGenericControl cariKomunitasLi = (HtmlGenericControl)FindControl("cariKomunitasLi");
                HtmlGenericControl tambahKegiatanLi = (HtmlGenericControl)FindControl("tambahKegiatanLi");
                HtmlGenericControl kegiatanLi = (HtmlGenericControl)FindControl("kegiatanLi");
                HtmlGenericControl logOutLi = (HtmlGenericControl)FindControl("logOutLi");
                if (UserController.IsUserLoggedIn())
                {
                    logOutLi.Visible = true;
                    if (UserController.IsUserRelawan())
                    {
                        relawanLi.Visible = true;
                        signInLi.Visible = false;
                    }
                    else
                    {
                        komunitasLi.Visible = true;
                        signInLi.Visible = false;
                        cariKegiatanLi.Visible = false;
                        cariKomunitasLi.Visible = false;
                        //tambahKegiatanLi.Visible = true;
                        kegiatanLi.Visible = true;
                        komunitasLbl.Visible = false;
                        kegiatanLbl.NavigateUrl = "~/Views/ASPX/KegiatanPage.aspx";
                    }
                }
                else
                {
                    signInLi.Visible = true;
                    relawanLi.Visible = false;
                    komunitasLi.Visible = false;
                }

            }
        }

        protected void logOutBtn_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Session.Remove("user");

            Response.Redirect("~/Views/ASPX/SignInPage.aspx");
        }
    }
}