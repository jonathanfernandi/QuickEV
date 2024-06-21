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
    public partial class SemuaRelawanKomunitasPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (UserController.IsUserLoggedIn())
                {
                    if (!UserController.IsUserRelawan())
                    {
                        User user = UserController.GetUserBySession();
                        Komunita komunitas = KomunitasController.GetKomunitasById(user.IdKomunitas.Value);
                        if (komunitas != null)
                        {
                            if (RelawanController.GetAllRelawanForHeader(komunitas.IdKomunitas).Count > 0)
                            {
                                volunteeringRpt.DataSource = RelawanController.GetAllRelawanForHeader(komunitas.IdKomunitas);
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
    }
}