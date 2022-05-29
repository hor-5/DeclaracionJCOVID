using DataStore;
using EntitiesModel;
using System;
using System.Collections.Generic;

namespace Services
{
    public class SecurityServices
    {
        SecurityData data = new SecurityData();
        public User login(String txtUser, String txtPass)
        {
            User result = null;            
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

        public void createDeclaration(DeclaracionJurada declaracion) {

           data.setDeclaraciones(declaracion);         
            

        }


    }
}
