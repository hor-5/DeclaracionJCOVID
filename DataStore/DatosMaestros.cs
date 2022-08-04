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

        //SELECTS
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

        public Boolean HasThePersonPendientsDeclarations(int id) {
            List<int> LstStatus = new List<int>();
            string sql = "SELECT fk_idStatus FROM Declarations WHERE fk_idPerson="+id;
            LstStatus = dbOperation.OperationQuery<int>(sql);
            Boolean Result = LstStatus.Contains(1);
            return Result;
        }

        public List<DeclarationAdmin> GetDeclarations()
        {
            List<DeclarationAdmin> LstDeclarations = new List<DeclarationAdmin>();
            string sql = "SELECT D.idDeclaration,D.created_at,"
                        + "P.dni, P.firstName, P.surName,P.telephone,"
                        + "DF.closeContact,DF.hasSymptom,DF.isVaccinated,DF.isRiskGroup,DF.isTraveler,DF.visitDate,"
                        + "DP.nameDepartament,"
                        + "S.nameStatus "
                        + "FROM Declarations D "
                        + "INNER JOIN Persons P ON D.fk_idPerson = P.idPerson "
                        + "INNER JOIN DeclarationFields DF ON D.fk_idDeclarationFields = DF.idDeclarationField "
                        + "INNER JOIN Status S ON D.fk_idStatus = S.idStatus "
                        + "INNER JOIN Departaments DP ON DF.fk_idDepartament = DP.idDepartament";
            LstDeclarations = dbOperation.OperationQuery<DeclarationAdmin>(sql);
            return LstDeclarations;
        }

        public List<Status> GetStatus() {
            List<Status> LstStatus = new List<Status>();
            string sql = "SELECT idStatus, nameStatus FROM Status";
            LstStatus = dbOperation.OperationQuery<Status>(sql);
            return LstStatus;
        }


        //END OF SELECTS

        // UPDATES
        public int EditDeclarationStatus(int idDeclaration, int idStatus) {
            string sql = "UPDATE Declarations SET fk_idStatus = @idStatus WHERE idDeclaration = @idDeclaration";
            Object paramList = new { idDeclaration= idDeclaration , idStatus = idStatus };
            int affectedRows = dbOperation.OperationExecute(sql,paramList);

            return affectedRows;
        }
        // END OF UPDATES

        //INSERTS
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

            int result = dbOperation.OperationExecuteWithIdentity(sql, paramList);

            return result;

        }

        public int InsertDeclaration(int idPerson, int idDeclarationFields) {

            string sql = "INSERT INTO Declarations (fk_idPerson, fk_idDeclarationFields, created_at, fk_idStatus)  Values" +
                "(@fk_idPerson, @fk_idDeclarationFields, @created_at,@fk_idStatus)";

            Object paramList = new {
                                     fk_idPerson = idPerson,
                                     fk_idDeclarationFields = idDeclarationFields,
                                     created_at = DateTime.Now,
                                     fk_idStatus=1
            };

            int result = dbOperation.OperationExecute(sql, paramList);

            return result;
            
        }

        public int InsertPerson(Person newPerson)
        {
            string sql = "INSERT INTO Persons (dni,firstName,surName,codArea,telephone,enterprise,email,fk_idGender,birthday,fk_nationalityCountry,fk_residenceCountry)" +
                "OUTPUT INSERTED.idPerson " +
                "VALUES(@dni,@firstName,@surName,@codArea,@telephone,@enterprise,@email,@fk_idGender,@birthday,@fk_nationalityCountry,@fk_residenceCountry) ";

            object paramList = new
            {
                dni = newPerson.dni,
                firstName = newPerson.firstName,
                surName = newPerson.surName,
                codArea = newPerson.codArea,
                telephone = newPerson.telephone,
                enterprise = newPerson.enterprise,
                email = newPerson.email,
                fk_idGender = newPerson.fk_idGender,
                birthday = newPerson.birthday,
                fk_nationalityCountry = newPerson.fk_nationalityCountry,
                fk_residenceCountry = newPerson.fk_residenceCountry
            };

            int result=dbOperation.OperationExecuteWithIdentity(sql, paramList);

            return result;
        }

        //END OF INSERTS

    }
}
