using QuickEV_Website.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuickEV_Website.Repository
{
    public class UserRepository
    {
        private static Database1Entities1 db = new Database1Entities1();
        public static void AddUser(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
        }
        public static User GetUserById(int id)
        {
            return (from x in db.Users
                    where x.IdUser == id
                    select x).FirstOrDefault();
        }
    }
}