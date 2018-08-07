using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.NET.Models.Helpers
{
    public class User_Informations_Helper
    {
        public static void Update(User_Informations User)
        {
            using (var context = new ApplicationDbContext())
            {
                context.User_Informationses.Add(User);
                context.SaveChanges();
            }
        }

        public static int Get_ID(string UID)
        {
            int id = 0;
            using (var context = new ApplicationDbContext())
            {
                var Users = context.User_Informationses.ToList();

                foreach (var User in Users)
                {
                    if (User.UID == UID)
                        if (User.id > id)
                            id = User.id;
                }
            }
            return id;
        }
    }
}