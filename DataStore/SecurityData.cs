using EntitiesModel;
using System;
using System.Collections.Generic;
using System.Net.Mail;

namespace DataStore
{
    public class SecurityData
    {
        private List<User> dataUsers;
        public List<User> getUsers() {
        
            User user1 = new User("horacio","horacio",37880949,"horacio","capdevila",011,"Argentina :+54",
                1134567897,"ISTIC",new MailAddress("horacio.capdevila@gmail.com"),
                "masculino",new DateOnly(1994,06,06),27,"Argentina","Argentina");

            User user2 = new User("pablo", "calvo", 35994686, "pablo", "calvo", 011, "Argentina :+54",
                1131813930, "ISTIC", new MailAddress("pablo.calvo@gmail.com"),
                "masculino", new DateOnly(1991, 12, 31), 30, "Argentina", "Argentina");

            dataUsers.Add(user1);
            dataUsers.Add(user2);
            return dataUsers;
        }
       

    }

}
