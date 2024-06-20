using QuickEV_Website.Handler;
using QuickEV_Website.Model;
using QuickEV_Website.Modules;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Web;

namespace QuickEV_Website.Controller
{
    public class KegiatanController
    {
        public static Response<Kegiatan> NameCheck1(string name)
        {
            if (name.Length == 0)
            {
                return new Response<Kegiatan>
                {
                    Message = "Nama Kegiatan harus diisi.",
                    IsSuccess = false,
                    Payload = null
                };
            }

            if (name.Length < 5)
            {
                return new Response<Kegiatan>
                {
                    Message = "Nama Kegiatan minimal terisi sebanyak 5 karakter.",
                    IsSuccess = false,
                    Payload = null
                };
            }

            if (name.Length > 50)
            {
                return new Response<Kegiatan>
                {
                    Message = "Nama Kegiatan tidak boleh terisi lebih dari 50 karakter.",
                    IsSuccess = false,
                    Payload = null
                };
            }

            return new Response<Kegiatan>
            {
                Message = "",
                IsSuccess = true,
                Payload = null
            };
        }
        public static Response<Kegiatan> DescCheck(String desc)
        {
            if (desc.Length == 0)
            {
                return new Response<Kegiatan>
                {
                    Message = "Deskripsi Kegiatan harus diisi.",
                    IsSuccess = false,
                    Payload = null
                };
            }

            char[] delimiters = new char[] { ' ', ',', '.', '!', '?', ';', ':', '-' };
            string[] words = desc.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            int wordCount = words.Length;

            if (wordCount < 10)
            {
                return new Response<Kegiatan>
                {
                    Message = "Deskripsi Kegiatan minimal terisi sebanyak 10 kata.",
                    IsSuccess = false,
                    Payload = null
                };
            }

            if (wordCount > 500)
            {
                return new Response<Kegiatan>
                {
                    Message = "Deskripsi Kegiatan tidak boleh terisi lebih dari 500 kata.",
                    IsSuccess = false,
                    Payload = null
                };
            }

            return new Response<Kegiatan>
            {
                Message = "",
                IsSuccess = true,
                Payload = null
            };
        }
        public static Response<Kegiatan> RegistCheckStart(DateTime start, DateTime end)
        {
            if (start == DateTime.MinValue)
            {
                return new Response<Kegiatan>
                {
                    Message = "Tanggal Buka Pendaftaran ini harus diisi.",
                    IsSuccess = false,
                    Payload = null
                };
            }

            if (DateTime.Compare(start, end) > 0)
            {
                return new Response<Kegiatan>
                {
                    Message = "Tanggal mulai tidak boleh melebihi tanggal berakhir.",
                    IsSuccess = false,
                    Payload = null
                };
            }

            return new Response<Kegiatan>
            {
                Message = "",
                IsSuccess = true,
                Payload = null
            };
        }
        public static Response<Kegiatan> RegistCheckEnd(DateTime end)
        {
            if (end == DateTime.MinValue)
            {
                return new Response<Kegiatan>
                {
                    Message = "Tanggal Tutup Pendaftaran ini harus diisi.",
                    IsSuccess = false,
                    Payload = null
                };
            }

            return new Response<Kegiatan>
            {
                Message = "",
                IsSuccess = true,
                Payload = null
            };
        }
        public static Response<Kegiatan> FokusCheck(String fokus)
        {
            if (fokus.Length == 0)
            {
                return new Response<Kegiatan>
                {
                    Message = "Fokus Kegiatan harus dipilih.",
                    IsSuccess = false,
                    Payload = null
                };
            }

            return new Response<Kegiatan>
            {
                Message = "",
                IsSuccess = true,
                Payload = null
            };
        }
        public static Response<Kegiatan> NameCheck2(string name)
        {
            if (name.Length == 0)
            {
                return new Response<Kegiatan>
                {
                    Message = "Nama Pekerjaan harus diisi.",
                    IsSuccess = false,
                    Payload = null
                };
            }

            if (name.Length < 5)
            {
                return new Response<Kegiatan>
                {
                    Message = "Nama Pekerjaan minimal terisi sebanyak 5 karakter.",
                    IsSuccess = false,
                    Payload = null
                };
            }

            if (name.Length > 35)
            {
                return new Response<Kegiatan>
                {
                    Message = "Nama Pekerjaan tidak boleh terisi lebih dari 35 karakter.",
                    IsSuccess = false,
                    Payload = null
                };
            }

            return new Response<Kegiatan>
            {
                Message = "",
                IsSuccess = true,
                Payload = null
            };
        }
        public static Response<Kegiatan> TugasRelawanCheck(String tugas)
        {
            if (tugas.Length == 0)
            {
                return new Response<Kegiatan>
                {
                    Message = "Tugas Relawan harus diisi.",
                    IsSuccess = false,
                    Payload = null
                };
            }

            char[] delimiters = new char[] { ' ', ',', '.', '!', '?', ';', ':', '-' };
            string[] words = tugas.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            int wordCount = words.Length;

            if (wordCount < 5)
            {
                return new Response<Kegiatan>
                {
                    Message = "Tugas Relawan minimal terisi sebanyak 5 kata.",
                    IsSuccess = false,
                    Payload = null
                };
            }

            if (wordCount > 200)
            {
                return new Response<Kegiatan>
                {
                    Message = "Tugas Relawan tidak boleh terisi lebih dari 200 kata.",
                    IsSuccess = false,
                    Payload = null
                };
            }

            return new Response<Kegiatan>
            {
                Message = "",
                IsSuccess = true,
                Payload = null
            };
        }
        public static Response<Kegiatan> KriteriaRelawanCheck(String kriteria)
        {
            if (kriteria.Length == 0)
            {
                return new Response<Kegiatan>
                {
                    Message = "Kriteria Relawan harus diisi.",
                    IsSuccess = false,
                    Payload = null
                };
            }

            char[] delimiters = new char[] { ' ', ',', '.', '!', '?', ';', ':', '-' };
            string[] words = kriteria.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            int wordCount = words.Length;

            if (wordCount < 5)
            {
                return new Response<Kegiatan>
                {
                    Message = "Kriteria Relawan minimal terisi sebanyak 5 kata.",
                    IsSuccess = false,
                    Payload = null
                };
            }

            if (wordCount > 200)
            {
                return new Response<Kegiatan>
                {
                    Message = "Kriteria Relawan tidak boleh terisi lebih dari 200 kata.",
                    IsSuccess = false,
                    Payload = null
                };
            }

            return new Response<Kegiatan>
            {
                Message = "",
                IsSuccess = true,
                Payload = null
            };
        }
        public static Response<Kegiatan> PerlengkapanRelawanCheck(String perlengkapan)
        {
            if (perlengkapan.Length == 0)
            {
                return new Response<Kegiatan>
                {
                    Message = "Perlengkapan Relawan harus diisi.",
                    IsSuccess = false,
                    Payload = null
                };
            }

            char[] delimiters = new char[] { ' ', ',', '.', '!', '?', ';', ':', '-' };
            string[] words = perlengkapan.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            int wordCount = words.Length;

            if (wordCount < 5)
            {
                return new Response<Kegiatan>
                {
                    Message = "Perlengkapan Relawan minimal terisi sebanyak 5 kata.",
                    IsSuccess = false,
                    Payload = null
                };
            }

            if (wordCount > 200)
            {
                return new Response<Kegiatan>
                {
                    Message = "Perlengkapan Relawan tidak boleh terisi lebih dari 200 kata.",
                    IsSuccess = false,
                    Payload = null
                };
            }

            return new Response<Kegiatan>
            {
                Message = "",
                IsSuccess = true,
                Payload = null
            };
        }
        public static Response<Kegiatan> DomisiliCheck(String dom)
        {
            if (dom.Length == 0)
            {
                return new Response<Kegiatan>
                {
                    Message = "Domisili Relawan harus dipilih.",
                    IsSuccess = false,
                    Payload = null
                };
            }

            return new Response<Kegiatan>
            {
                Message = "",
                IsSuccess = true,
                Payload = null
            };
        }
        public static Response<Kegiatan> LokasiCheck(String lokasi)
        {
            if (lokasi.Length == 0)
            {
                return new Response<Kegiatan>
                {
                    Message = "Lokasi Kegiatan harus diisi.",
                    IsSuccess = false,
                    Payload = null
                };
            }

            return new Response<Kegiatan>
            {
                Message = "",
                IsSuccess = true,
                Payload = null
            };
        }
        public static Response<Kegiatan> DateCheckStart(DateTime start, DateTime end)
        {
            if (start == DateTime.MinValue)
            {
                return new Response<Kegiatan>
                {
                    Message = "Tanggal Mulai Kegiatan ini harus diisi.",
                    IsSuccess = false,
                    Payload = null
                };
            }

            if (DateTime.Compare(start, end) > 0)
            {
                return new Response<Kegiatan>
                {
                    Message = "Tanggal mulai tidak boleh melebihi tanggal berakhir.",
                    IsSuccess = false,
                    Payload = null
                };
            }

            return new Response<Kegiatan>
            {
                Message = "",
                IsSuccess = true,
                Payload = null
            };
        }
        public static Response<Kegiatan> DateCheckEnd(DateTime end)
        {
            if (end == DateTime.MinValue)
            {
                return new Response<Kegiatan>
                {
                    Message = "Tanggal Akhir Kegiatan ini harus diisi.",
                    IsSuccess = false,
                    Payload = null
                };
            }

            return new Response<Kegiatan>
            {
                Message = "",
                IsSuccess = true,
                Payload = null
            };
        }
        public static Response<Kegiatan> TimeCheckStart(DateTime start, DateTime end)
        {
            if (start == DateTime.MinValue)
            {
                return new Response<Kegiatan>
                {
                    Message = "Jam Mulai Kegiatan ini harus diisi.",
                    IsSuccess = false,
                    Payload = null
                };
            }

            if (DateTime.Compare(start, end) > 0)
            {
                return new Response<Kegiatan>
                {
                    Message = "Jam mulai tidak boleh melebihi jam berakhir.",
                    IsSuccess = false,
                    Payload = null
                };
            }

            if (DateTime.Compare(start, end) == 0)
            {
                return new Response<Kegiatan>
                {
                    Message = "Jam mulai tidak boleh sama dengan jam berakhir.",
                    IsSuccess = false,
                    Payload = null
                };
            }

            return new Response<Kegiatan>
            {
                Message = "",
                IsSuccess = true,
                Payload = null
            };
        }
        public static Response<Kegiatan> TimeCheckEnd(DateTime end)
        {
            if (end == DateTime.MinValue)
            {
                return new Response<Kegiatan>
                {
                    Message = "Jam Akhir Kegiatan ini harus diisi.",
                    IsSuccess = false,
                    Payload = null
                };
            }

            return new Response<Kegiatan>
            {
                Message = "",
                IsSuccess = true,
                Payload = null
            };
        }
        public static Response<Kegiatan> DoAddKegiatan(int IdKomunitas, String NamaKegiatan,
            DateTime StartDate, DateTime EndDate, String Lokasi, Image Foto, DateTime StartTime,
            DateTime EndTime, DateTime StartRegistration, DateTime EndRegistration, String DescKegiatan,
            String NamaPekerjaan, int RelawanDibutuhkan, String TugasRelawan, String KriteriaRelawan,
            String PerlengkapanRelawan, String DomisiliRelawan, String FokusEvent)
        {
            return KegiatanHandler.AddKegiatan(IdKomunitas, NamaKegiatan, StartDate, EndDate, Lokasi,
                Foto, StartTime, EndTime, StartRegistration, EndRegistration, DescKegiatan,
                NamaPekerjaan, RelawanDibutuhkan, TugasRelawan, KriteriaRelawan, PerlengkapanRelawan,
                DomisiliRelawan, FokusEvent);
        }
        public static Response<DetailKegiatan> AddDetailKegiatan(int idKegiatan, int idRelawan)
        {
            return KegiatanHandler.AddDetailKegiatan(idKegiatan, idRelawan);
        }
        public static List<object> GetAllKegiatanOfAKomunitasForHeader(int idKomunitas)
        {
            return KegiatanHandler.GetAllKegiatanOfAKomunitasForHeader(idKomunitas);
        }
        public static List<object> GetAllKegiatanOfAKomunitasForDetail(int idKegiatan)
        {
            return KegiatanHandler.GetAllKegiatanOfAKomunitasForDetail(idKegiatan);
        }
        public static Kegiatan GetKegiatanById(int idKegiatan)
        {
            return KegiatanHandler.GetKegiatanById(idKegiatan);
        }
        public static int GetKegiatanCount(int idKegiatan)
        {
            return KegiatanHandler.GetKegiatanCount(idKegiatan);
        }
        public static List<object> GetAllKegiatanForHeader()
        {
            return KegiatanHandler.GetAllKegiatanForHeader();
        }
        public static int GetKegiatanCount2()
        {
            return KegiatanHandler.GetKegiatanCount2();
        }
        public static DetailKegiatan GetDetailKegiatanById(int idKegiatan, int idRelawan)
        {
            return KegiatanHandler.GetDetailKegiatanById(idKegiatan, idRelawan);
        }
    }
}