using QuickEV_Website.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;

namespace QuickEV_Website.Factory
{
    public class KomunitasFactory
    {
        public static Komunita CreateKomunitas(int IdKomunitas,  String NamaKomunitas,
            String DeskripsiKomunitas, String FokusUtama, Image Logo, String Alamat,
            String Provinsi, String TelpKomunitas)
        {
            Komunita komunitas = new Komunita();
            komunitas.IdKomunitas = IdKomunitas;
            komunitas.NamaKomunitas = NamaKomunitas;
            komunitas.DeskripsiKomunitas = DeskripsiKomunitas;
            komunitas.FokusUtama = FokusUtama;
            komunitas.Logo = ImageToByteArray(Logo);
            komunitas.Alamat = Alamat;
            komunitas.Provinsi = Provinsi;
            komunitas.TelpKomunitas = TelpKomunitas;
            return komunitas;
        }
        public static byte[] ImageToByteArray(Image image)
        {
            using (var ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }
    }
}