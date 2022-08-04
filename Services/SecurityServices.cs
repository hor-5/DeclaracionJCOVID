using DataStore;
using EntitiesModel;
using System;
using System.Collections.Generic;

namespace Services
{
    public class SecurityServices
    {

        DatosMaestros datosMaestros = new DatosMaestros();

        //selects a la db
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

        public Boolean asThePersonPendientsDeclarations(int id) {
            return datosMaestros.HasThePersonPendientsDeclarations(id);
        }

        public List<DeclarationAdmin> getDeclarations() {
            return datosMaestros.GetDeclarations();
        }

        public List<Status> getStatus() {
            return datosMaestros.GetStatus();
        }

        //fin selects a la db

        // actualizaciones en la db
        public int editDeclarationStatus(int idDeclaration, int idStatus) {
            return datosMaestros.EditDeclarationStatus(idDeclaration, idStatus);
        }
        // fin actualizaciones en la db

        //inserciones a la db

        public int insertDeclarationFields(DeclarationFields declarationFields) {
            return datosMaestros.InsertDeclarationFields(declarationFields);
        }

        public int insertDeclaration(int idPerson, int idDeclarationFields) {
            return datosMaestros.InsertDeclaration(idPerson, idDeclarationFields);
        }

        public int insertPerson(Person newPerson)
        {
            return datosMaestros.InsertPerson(newPerson);
        }

        //fin inserciones a la db


        //logueo
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

        //fin logueo

        


    }
}
