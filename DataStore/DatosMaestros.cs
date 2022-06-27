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
        public List<SintomasCovid> GetSintomas()
        {
            List<SintomasCovid> Lstsintomas = new List<SintomasCovid>();
            string sql = "SELECT idSintoma, nombreSintoma FROM SintomasCovid";
            Lstsintomas = dbOperation.OperationQuery<SintomasCovid>(sql);
            return Lstsintomas;
        }


        public List<RiskGroup> GetRiskGroup()
        {
            List<RiskGroup> LstGroupRisk = new List<RiskGroup>();
            string sql = "SELECT idGrupoRiesgo, nombreGrupo FROM GruposDeRiesgo";
            LstGroupRisk = dbOperation.OperationQuery<RiskGroup>(sql);
            return LstGroupRisk;
        }

        public List<Generos> GetGenero()
        {
            List<Generos> LstGeneros = new List<Generos>();
            string sql = "SELECT idGenero,nombreGenero FROM Generos";
            LstGeneros =dbOperation.OperationQuery<Generos>(sql);
            return LstGeneros;
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

        public string GetUserGender(int idGen)
        {
            List<Generos> lstGender = new List<Generos>();
            string sql = "SELECT idGenero nombreGenero from Generos WHERE idGenero =" + idGen.ToString();

            using (var connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Usuario\source\repos\DDJJAdministrator\DataStore\DateBase\BBDDdeclaracionJurada.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                lstGender = connection.Query<Generos>(sql).ToList();
            }
             try {
                return lstGender[0].nombreGenero; 
            } catch (Exception err){ 
                return err.Message; 
            };
        }

    }
}
