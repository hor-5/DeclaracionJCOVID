using DataStore;
using EntitiesModel;
using System;
using System.Collections.Generic;

namespace Services
{
    public class SecurityServices
    {
        
        DatosMaestros datosMaestros = new DatosMaestros();
        //public User login(String txtUser, String txtPass)
        //{
        //    User result = null;            
        //    List<User> users = data.getUsers();
        //    foreach (User u in users)
        //    {
        //        if (u.userName == txtUser && u.password == txtPass)
        //        {
        //            result = u;
        //            break;
        //        }
        //    }
        //    return result;
        //}

        //public void createDeclaration(DeclaracionJurada declaracion) {

        //   data.setDeclaraciones(declaracion);         
            

        //}

        public List<SintomasCovid> getSintomas() {
            return datosMaestros.GetSintomas();
        }

        public List<Generos> getGenero()
        {
            return datosMaestros.GetGenero();
        }

        public List<Departament> getDepartaments()
        {
            return datosMaestros.GetDepartaments();
        }

        public List<RiskGroup> getRiskGroups() {
            return datosMaestros.GetRiskGroup();
        }

        public List<User> getUsers()
        {
            return datosMaestros.GetUsers();
        }
        public string getUserGender(int idGender) {
            return datosMaestros.GetUserGender(idGender);
        }

        public User login(String txtUser, String txtPass)
        {
            User result = null;
            List<User> users = this.getUsers();
            foreach (User user in users)
            {
                if (user.userName == txtUser && user.password == txtPass)
                {
                    result = user;
                    break;
                }
            }
            return result;
        }




    }
}
