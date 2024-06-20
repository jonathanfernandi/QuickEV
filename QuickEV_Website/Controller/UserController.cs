using QuickEV_Website.Handler;
using QuickEV_Website.Model;
using QuickEV_Website.Modules;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace QuickEV_Website.Controller
{
    public class UserController
    {
        public static bool IsUserLoggedIn()
        {
            if (HttpContext.Current.Session != null && !HttpContext.Current.Session.IsNewSession)
            {
                if (HttpContext.Current.Session["user"] != null)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool IsUserRelawan()
        {
            if (HttpContext.Current.Session != null && HttpContext.Current.Session["user"] != null)
            {
                User user = (User)HttpContext.Current.Session["user"];
                if (user.RoleUser.Equals("Relawan"))
                {
                    return true;
                }
            }
            return false;
        }
        public static User GetUserBySession()
        {
            if (HttpContext.Current.Session != null && HttpContext.Current.Session["user"] != null)
            {
                User user = (User)HttpContext.Current.Session["user"];
                return user;
            }
            return null;
        }
        public static Response<User> UsernameCheck(String username)
        {
            if (username.Length == 0)
            {
                return new Response<User>
                {
                    Message = "Username must be filled.",
                    IsSuccess = false,
                    Payload = null
                };
            }

            User user = UserHandler.GetUserByUsername(username);
            if (user == null)
            {
                return new Response<User>
                {
                    Message = "Username is invalid!",
                    IsSuccess = false,
                    Payload = null
                };
            }

            return new Response<User>
            {
                Message = "",
                IsSuccess = true,
                Payload = user
            };
        }
        public static Response<User> PasswordCheck(String username, String password)
        {
            if (password.Length == 0)
            {
                return new Response<User>
                {
                    Message = "Password must be filled.",
                    IsSuccess = false,
                    Payload = null
                };
            }
            User user = UserHandler.GetUserByUsername(username);
            if (user != null)
            {
                if (user.Password.Equals(password))
                {
                    return new Response<User>
                    {
                        Message = "",
                        IsSuccess = true,
                        Payload = user
                    };
                }
                return new Response<User>
                {
                    Message = "Password is incorrect!",
                    IsSuccess = false,
                    Payload = null
                };
            }
            return new Response<User>
            {
                Message = "",
                IsSuccess = false,
                Payload = null
            };
        }
        public static Response<User> UsernameCheck2(String username)
        {
            if (username.Length == 0)
            {
                return new Response<User>
                {
                    Message = "Username must be filled.",
                    IsSuccess = false,
                    Payload = null
                };
            }

            if(UserHandler.GetUserByUsername(username) != null)
            {
                return new Response<User>
                {
                    Message = "Username exists already.",
                    IsSuccess = false,
                    Payload = null
                };
            }

            return new Response<User>
            {
                Message = "",
                IsSuccess = true,
                Payload = null
            };
        }
        public static Response<User> NameCheck(string name)
        {
            if (name.Length == 0)
            {
                return new Response<User>
                {
                    Message = "Name must be filled.",
                    IsSuccess = false,
                    Payload = null
                };
            }

            if (name.Length < 5)
            {
                return new Response<User>
                {
                    Message = "Name must be higher than 5 characters",
                    IsSuccess = false,
                    Payload = null
                };
            }

            if (name.Length > 35)
            {
                return new Response<User>
                {
                    Message = "Name must be lower than 35 characters",
                    IsSuccess = false,
                    Payload = null
                };
            }

            return new Response<User>
            {
                Message = "",
                IsSuccess = true,
                Payload = null
            };
        }
        public static Response<User> NameCheck2(string name)
        {
            if (name.Length == 0)
            {
                return new Response<User>
                {
                    Message = "Name must be filled.",
                    IsSuccess = false,
                    Payload = null
                };
            }

            if (name.Length < 5)
            {
                return new Response<User>
                {
                    Message = "Name must be higher than 5 characters",
                    IsSuccess = false,
                    Payload = null
                };
            }

            if (name.Length > 35)
            {
                return new Response<User>
                {
                    Message = "Name must be lower than 35 characters",
                    IsSuccess = false,
                    Payload = null
                };
            }

            if(KomunitasHandler.GetKomunitasByName(name) != null)
            {
                return new Response<User>
                {
                    Message = "Name exists already.",
                    IsSuccess = false,
                    Payload = null
                };
            }

            return new Response<User>
            {
                Message = "",
                IsSuccess = true,
                Payload = null
            };
        }
        public static Response<User> EmailCheck(String email)
        {
            if (email.Length == 0)
            {
                return new Response<User>
                {
                    Message = "Email must be filled.",
                    IsSuccess = false,
                    Payload = null
                };
            }
            return new Response<User>
            {
                Message = "",
                IsSuccess = true,
                Payload = null
            };
        }
        //public static Response<User> PasswordCheck2(String password)
        //{
        //    if (password.Length == 0)
        //    {
        //        return new Response<User>
        //        {
        //            Message = "Password must be filled.",
        //            IsSuccess = false,
        //            Payload = null
        //        };
        //    }
        //    return new Response<User>
        //    {
        //        Message = "",
        //        IsSuccess = true,
        //        Payload = null
        //    };
        //}
        //public static Response<User> ConfPasswordCheck(String confPassword)
        //{
        //    if (confPassword.Length == 0)
        //    {
        //        return new Response<User>
        //        {
        //            Message = "Confirm Password must be filled.",
        //            IsSuccess = false,
        //            Payload = null
        //        };
        //    }
        //    return new Response<User>
        //    {
        //        Message = "",
        //        IsSuccess = true,
        //        Payload = null
        //    };
        //}
        public static Response<User> PasswordMatchCheck(String password, String confPassword)
        {
            if (password.Length > 0 && confPassword.Length > 0)
            {
                if (!confPassword.Equals(password))
                {
                    return new Response<User>
                    {
                        Message = "Password does not match.",
                        IsSuccess = false,
                        Payload = null
                    };
                }
                return new Response<User>
                {
                    Message = "",
                    IsSuccess = true,
                    Payload = null
                };
            }
            return new Response<User>
            {
                Message = "This field must be filled.",
                IsSuccess = false,
                Payload = null
            };
        }
        public static Response<User> GenderCheck(String gender)
        {
            if (gender.Length == 0)
            {
                return new Response<User>
                {
                    Message = "Gender must be chosen.",
                    IsSuccess = false,
                    Payload = null
                };
            }

            return new Response<User>
            {
                Message = "",
                IsSuccess = true,
                Payload = null
            };
        }
        private static int CalculateAge(DateTime DOB)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - DOB.Year;

            if (DOB.Date > today.AddYears(-age))
                age--;

            return age;
        }
        public static Response<User> DOBCheck(DateTime DOB)
        {
            if (DOB == DateTime.MinValue)
            {
                return new Response<User>
                {
                    Message = "Date Of Birth must be filled!",
                    IsSuccess = false,
                    Payload = null
                };
            }

            int age = CalculateAge(DOB);
            if (age < 17)
            {
                return new Response<User>
                {
                    Message = "Age must be at least 17 years old.",
                    IsSuccess = false,
                    Payload = null
                };
            }
            return new Response<User>
            {
                Message = "",
                IsSuccess = true,
                Payload = null
            };
        }
        public static Response<User> ProvinsiCheck(String provinsi)
        {
            if (provinsi.Length == 0)
            {
                return new Response<User>
                {
                    Message = "Provinsi must be chosen.",
                    IsSuccess = false,
                    Payload = null
                };
            }

            return new Response<User>
            {
                Message = "",
                IsSuccess = true,
                Payload = null
            };
        }
        public static Response<User> DescCheck(String desc)
        {
            if (desc.Length == 0)
            {
                return new Response<User>
                {
                    Message = "Description must be filled.",
                    IsSuccess = false,
                    Payload = null
                };
            }

            char[] delimiters = new char[] { ' ', ',', '.', '!', '?', ';', ':', '-' };
            string[] words = desc.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            int wordCount = words.Length;

            if (wordCount < 10)
            {
                return new Response<User>
                {
                    Message = "Description must have at least 10 words.",
                    IsSuccess = false,
                    Payload = null
                };
            }

            if (wordCount > 100)
            {
                return new Response<User>
                {
                    Message = "Description must not exceed 100 words.",
                    IsSuccess = false,
                    Payload = null
                };
            }

            return new Response<User>
            {
                Message = "",
                IsSuccess = true,
                Payload = null
            };
        }
        public static Response<User> FokusCheck(String fokus)
        {
            if (fokus.Length == 0)
            {
                return new Response<User>
                {
                    Message = "Fokus must be chosen.",
                    IsSuccess = false,
                    Payload = null
                };
            }

            return new Response<User>
            {
                Message = "",
                IsSuccess = true,
                Payload = null
            };
        }
        public static Response<User> AlamatCheck(String alamat)
        {
            if (alamat.Length == 0)
            {
                return new Response<User>
                {
                    Message = "Alamat must be filled.",
                    IsSuccess = false,
                    Payload = null
                };
            }

            return new Response<User>
            {
                Message = "",
                IsSuccess = true,
                Payload = null
            };
        }
        public static Response<User> TelpCheck(String telp)
        {
            if (telp.Length == 0)
            {
                return new Response<User>
                {
                    Message = "No. Telepon must be filled.",
                    IsSuccess = false,
                    Payload = null
                };
            }

            if(KomunitasHandler.GetKomunitasByTelp(telp) != null)
            {
                return new Response<User>
                {
                    Message ="This number is used already.",
                    IsSuccess = false,
                    Payload = null
                };
            }

            return new Response<User>
            {
                Message = "",
                IsSuccess = true,
                Payload = null
            };
        }
        public static Response<User> DoRegister(String name, String username, String email,
            String password, String gender, DateTime DOB, String provinsi)
        {
            return UserHandler.DoRegister(name, username, email, password, gender, DOB, provinsi);
        }
        public static Response<User> DoRegister2(String name, String desc, String fokus, Image logo,
            String alamat, String provinsi, String telp, String username, String password)
        {
            return UserHandler.DoRegister2(name, desc, fokus, logo, alamat, provinsi, telp, username, password);
        }
    }
}