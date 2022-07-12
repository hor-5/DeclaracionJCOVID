using DataStore;
using EntitiesModel;
using System;
using System.Collections.Generic;

namespace Services
{
    public class SecurityServices
    {

        DatosMaestros datosMaestros = new DatosMaestros();

        public List<CovidSymptom> getSintomas() {
            return datosMaestros.GetSintomas();
        }

        public List<Gender> getGenero()
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

        public Person getUserData(int idUser)
        {
            return datosMaestros.GetUserData(idUser);
        }
        public List<Country> getCountries() {
            return datosMaestros.GetCountries();
        }

        public Country getCountryById(int idCountry) {
            return datosMaestros.GetCountryById(idCountry);
        }
        public User login(String txtUser, String txtPass)
        {
            User result = null;
            List<User> users = this.getUsers();
            foreach (User user in users)
            {
                
                if (user.username == txtUser && user.pass == txtPass)
                {
                    result = user;
                    break;
                }

            }
            return result;
        }



    }
}
