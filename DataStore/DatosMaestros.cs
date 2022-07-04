using Dapper;
using EntitiesModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStore
{
    public class DatosMaestros
    {
        DBOperation dbOperation = new DBOperation();
        public List<CovidSymptom> GetSintomas()
        {
            List<CovidSymptom> Lstsintomas = new List<CovidSymptom>();
            string sql = "SELECT idSymptom, nameSymptom FROM CovidSymptoms";
            Lstsintomas = dbOperation.OperationQuery<CovidSymptom>(sql);
            return Lstsintomas;
        }


        public List<RiskGroup> GetRiskGroup()
        {
            List<RiskGroup> LstGroupRisk = new List<RiskGroup>();
            string sql = "SELECT idRiskGroup, nameRiskGroup FROM RiskGroups";
            LstGroupRisk = dbOperation.OperationQuery<RiskGroup>(sql);
            return LstGroupRisk;
        }

        public List<Gender> GetGenero()
        {
            List<Gender> LstGenders = new List<Gender>();
            string sql = "SELECT idGender,nameGender FROM Genders";
            LstGenders = dbOperation.OperationQuery<Gender>(sql);
            return LstGenders;
        }

        public List<Departament> GetDepartaments()
        {
            List<Departament> LstDepartaments = new List<Departament>();
            string sql = "SELECT idDepartament,nameDepartament FROM Departaments";
            LstDepartaments = dbOperation.OperationQuery<Departament>(sql);
            return LstDepartaments;
        }

        public List<Person> GetUsers()
        {
            List<Person> LstUsers = new List<Person>();
            string sql = "SELECT * FROM Users";
            LstUsers = dbOperation.OperationQuery<Person>(sql);
            return LstUsers;
        }

        public List<Country> GetCountries()
        {
            List<Country> LstCountries = new List<Country>();
            string sql = "SELECT idCountry,nameCountry,codCountry FROM Countrys";
            LstCountries = dbOperation.OperationQuery<Country>(sql);
            return LstCountries;
        }


    }
}
