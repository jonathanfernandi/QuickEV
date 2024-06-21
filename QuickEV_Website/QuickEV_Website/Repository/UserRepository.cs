using QuickEV_Website.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuickEV_Website.Repository
{
    public class UserRepository
    {
        private static Database1Entities2 db = new Database1Entities2();
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
        public static User GetUserByUsername(String username)
        {
            return (from x in db.Users
                    where x.Username.Equals(username)
                    select x).FirstOrDefault();
        }
        public static User GetLastUser()
        {
            return db.Users.ToList().LastOrDefault();
        }
    }
}