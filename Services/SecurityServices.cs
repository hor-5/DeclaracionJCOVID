using DataStore;
using EntitiesModel;
using System;
using System.Collections.Generic;

namespace Services
{
    public class SecurityServices
    {
        public User login(String txtUser, String txtPass)
        {
            User result = null;
            SecurityData data = new SecurityData();
            List<User> users = data.getUsers();
            foreach (User u in users)
            {
                if (u.userName == txtUser && u.password == txtPass)
                {
                    result = u;
                    break;
                }
            }
            return result;
        }


    }
}
