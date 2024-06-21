using QuickEV_Website.Factory;
using QuickEV_Website.Model;
using QuickEV_Website.Modules;
using QuickEV_Website.Repository;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace QuickEV_Website.Handler
{
    public class UserHandler
    {
        public static User GetUserById(int id)
        {
            return UserRepository.GetUserById(id);
        }
        public static User GetUserByUsername(string username)
        {
            return UserRepository.GetUserByUsername(username);
        }
        public static int generateId()
        {
            User user = UserRepository.GetLastUser();
            if (user == null)
            {
                return 1;
            }
            int lastId = user.IdUser;
            lastId++;
            return lastId;
        }
        public static Response<User> DoRegister(String name, String username, String email,
    String password, String gender, DateTime DOB, String provinsi)
        {
            Relawan relawan = RelawanFactory.CreateRelawan(RelawanHandler.generateId(), name, email,
                gender, DOB, provinsi);
            RelawanRepository.AddRelawan(relawan);
            String userRole = "Relawan";              
            User user = UserFactory.CreateUser(generateId(), username, password, userRole,
                null, relawan.IdRelawan);
            UserRepository.AddUser(user);
            return new Response<User>
            {
                Message = "",
                IsSuccess = true,
                Payload = user
            };
        }
        public static Response<User> DoRegister2(String name, String desc, String fokus, Image logo,
            String alamat, String provinsi, String telp, String username, String password)
        {
            Komunita komunitas = KomunitasFactory.CreateKomunitas(KomunitasHandler.generateId(), name,
                desc, fokus, logo, alamat, provinsi, telp);
            KomunitasRepository.AddKomunitas(komunitas);
            String userRole = "Komunitas";
            User user = UserFactory.CreateUser(generateId(), username, password, userRole,
                komunitas.IdKomunitas, null);
            UserRepository.AddUser(user);
            return new Response<User>
            {
                Message = "",
                IsSuccess = true,
                Payload = user
            };
        }
    }
}