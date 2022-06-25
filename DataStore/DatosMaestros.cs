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
            string sql = "SELECT idSintoma, NombreSintoma FROM Sintomas";
            Lstsintomas = dbOperation.OperationQuery<SintomasCovid>(sql);
            return Lstsintomas;
        }


        public List<RiskGroup> GetGroup()
        {
            List<RiskGroup> LstGroupRisk = new List<RiskGroup>();
            string sql = "SELECT idGrupoRiesgo, NombreGrupo FROM GrupoDeRiesgo";
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
    }
}
