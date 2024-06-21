using QuickEV_Website.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuickEV_Website.Factory
{
    public class UserFactory
    {
        public static User CreateUser(int IdUser, String Username, String Password,
            String RoleUser, int? IdKomunitas, int? IdRelawan)
        {
            User user = new User();
            user.IdUser = IdUser;
            user.Username = Username;
            user.Password = Password;
            user.RoleUser = RoleUser;
            user.IdKomunitas = IdKomunitas;
            user.IdRelawan = IdRelawan;
            return user;
        }
    }
}