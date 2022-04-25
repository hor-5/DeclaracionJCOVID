using EntitiesModel;
using System;
using System.Collections.Generic;
using System.Net.Mail;

namespace DataStore
{
    public class SecurityData
    {
        private List<User> dataUsers = new List<User>();
        public List<User> getUsers() {
        
            User user1 = new User("horacio","horacio", "37880949", "horacio","capdevila", "011", "Argentina: +54",
                "1534567897", "ISTIC",new MailAddress("horacio.capdevila@gmail.com"),
                "masculino",new DateTime(1994,06,06),27,"Argentina","Argentina");

            User user2 = new User("pablo", "calvo", "35994686", "pablo", "calvo","011", "Argentina: +54",
                "1531813930", "ISTIC", new MailAddress("pablo.calvo@gmail.com"),
                "masculino", new DateTime(1991, 12, 31),30, "Argentina", "Argentina");

            dataUsers.Add(user1);
            dataUsers.Add(user2);
            return dataUsers;
        }
       

    }

}
