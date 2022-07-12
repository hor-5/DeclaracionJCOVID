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

        public List<User> GetUsers()
        {
            List<User> LstUsers = new List<User>();
            string sql = "SELECT * FROM Users";
            LstUsers = dbOperation.OperationQuery<User>(sql);
            return LstUsers;
        }

        public List<Country> GetCountries()
        {
            List<Country> LstCountries = new List<Country>();
            string sql = "SELECT idCountry,nameCountry,codCountry FROM Countrys order by nameCountry ASC";
            LstCountries = dbOperation.OperationQuery<Country>(sql);
            return LstCountries;
        }

        public Person GetUserData(int idUser)
        {            
            List<Person> LstPersons = new List<Person>();
            string sql = "SELECT * FROM Users INNER JOIN Persons on Persons.fk_idUser="+idUser;
            LstPersons=dbOperation.OperationQuery<Person>(sql);            
            Person currentPerson = LstPersons[0];
            return currentPerson;
        }

        public int InsertDeclarationFields(DeclarationFields declarationFields) {

            string sql = "INSERT INTO DeclarationFields (isRiskGroup,isVaccinated,fk_idDepartament,visitDate,isTraveler,closeContact,hasSymptom) " +
                         "OUTPUT INSERTED.idDeclarationField " +
                         "Values (@isRiskGroup,@isVaccinated,@fk_idDepartament,@visitDate,@isTraveler,@closeContact,@hasSymptom)";

            Object paramList = new
            {
                isRiskGroup = declarationFields.isRiskGroup ? 1 : 0,
                isVaccinated = declarationFields.isVaccinated ? 1 : 0,
                fk_idDepartament = declarationFields.fk_idDepartament,
                visitDate = declarationFields.visitDate,
                isTraveler = declarationFields.isTraveler?1:0,
                closeContact = declarationFields.closeContact?1:0,
                hasSymptom = declarationFields.hasSymptom?1:0
            };

            int execute = dbOperation.OperationExecuteWithIdentity(sql, paramList);

            return execute;

        }

        public int InsertDeclaration(int idPerson, int idDeclarationFields, DateTime created_at) {

            string sql = "INSERT INTO Declarations (fk_idPerson, fk_idDeclarationFields, created_at)  Values" +
                "(@fk_idPerson, @fk_idDeclarationFields, @created_at)";

            Object paramList = new {
                                     fk_idPerson = idPerson,
                                     fk_idDeclarationFields = idDeclarationFields,
                                     created_at = created_at
            };

            int result = dbOperation.OperationExecute(sql, paramList);

            return result;
            
        }


    }
}
