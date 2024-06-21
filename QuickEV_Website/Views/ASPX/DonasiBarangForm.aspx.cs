using QuickEV_Website.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuickEV_Website.Views.ASPX
{
    public partial class DonasiBarangForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (UserController.IsUserLoggedIn())
                {
                    String item = Request.QueryString["item"];
                    if (item != null)
                    {
                        if (item.Equals("baju"))
                        {
                            jenisDDL.Text = "Baju";
                        }
                        else if (item.Equals("obat"))
                        {
                            jenisDDL.Text = "Obat";
                        }
                        else if (item.Equals("mainan"))
                        {
                            jenisDDL.Text = "Mainan";
                        }
                        else if (item.Equals("sembako"))
                        {
                            jenisDDL.Text = "Sembako";
                        }
                    }
                    else
                    {
                        Response.Redirect("~/Views/ASPX/DonasiBarangPage.aspx");
                    }
                }
                else
                {
                    Response.Redirect("~/Views/ASPX/SignInPage.aspx");
                }
            }

        }

        protected void donateBtn_Click(object sender, EventArgs e)
        {
            if (UserController.IsUserLoggedIn())
            {
                if (nameTxt.Text.Length != 0 && emailTxt.Text.Length != 0 && telpTxt.Text.Length != 0 && jenisDDL.Text.Length != 0 && kondisiDDL.Text.Length != 0)
                {
                    Response.Redirect("~/Views/ASPX/ThankYouPage.aspx");
                }
            }
            else
            {
                Response.Redirect("~/Views/ASPX/SignInPage.aspx");
            }
        }
    }
}