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
    public partial class KomunitasDetailPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                String idKomunitas = Request.QueryString["IdKomunitas"];
                if(idKomunitas.Length > 0)
                {
                    Komunita komunitas = KomunitasController.GetKomunitasById(int.Parse(idKomunitas));
                    if(komunitas != null)
                    {
                        imgLogo.ImageUrl = "data:image/png;base64," + Convert.ToBase64String((byte[])komunitas.Logo);
                        komunitasNameLbl.Text = komunitas.NamaKomunitas;
                        fokusLbl.Text = komunitas.FokusUtama;
                        countRelawanLbl.Text = KomunitasController.GetRelawanCount(komunitas.IdKomunitas).ToString();
                        countKegiatanLbl.Text = KomunitasController.GetKegiatanCount(komunitas.IdKomunitas).ToString();
                        descLbl.Text = komunitas.DeskripsiKomunitas;
                        alamatLbl.Text = komunitas.Alamat;
                        teleLbl.Text = komunitas.TelpKomunitas;
                    }
                }
            }
        }
    }
}