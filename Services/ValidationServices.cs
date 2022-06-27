using EntitiesModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ValidationServices
    {
        
        public string validationDeclaracionFields(DeclaracionJurada declaracionJurada)
        {
           if (declaracionJurada.newUser.dni.Trim().Length < 7 ||
               declaracionJurada.newUser.dni.Trim().Length > 8 ) return "DNI Incorrecto";
           if(declaracionJurada.newUser.firstName.Trim().Length==0)return "Debe completar el nombre";
           if (declaracionJurada.newUser.surName.Trim().Length == 0) return "Debe completar el apellido";
           if (declaracionJurada.newUser.codCountry.Trim().Length == 0 ||
                declaracionJurada.newUser.codCountry == null) return "Debe completar el código de pais";
           if (declaracionJurada.newUser.codArea.Trim().Length == 0 ||
               declaracionJurada.newUser.codArea == null) return "Debe completar el código de area";
           if (declaracionJurada.newUser.telephone.Trim().Length == 0) return "Debe completar el telefono";
           if (declaracionJurada.newUser.enterprise.Trim().Length == 0) return "Debe completar la empresa";
           //if (declaracionJurada.newUser.email == null ||
           //    declaracionJurada.newUser.email == new MailAddress("vacio@vacio.com")) return "Debe ingresar un email válido";
           if (declaracionJurada.newUser.gender.Trim().Length == 0 || declaracionJurada.newUser.gender == null) return "Debe seleccionar el género";
           if (declaracionJurada.newUser.birthday == null) return "Debe selecionar su fecha de nacimiento";
           if (declaracionJurada.newUser.age<=0) return "Seleccione su fecha de nacimiento";
           if (declaracionJurada.newUser.nationality.Trim().Length == 0 ||
               declaracionJurada.newUser.nationality == null) return "Seleccione su nacionalidad";
           if (declaracionJurada.newUser.residenceCountry.Trim().Length == 0 ||
               declaracionJurada.newUser.residenceCountry == null) return "Seleccione su pais de residencia";
           //checkboxs
           if (!declaracionJurada.declarationFields.isRiskGroup) return "Debe contestar si pertence a un grupo de riesgo";
           if (!declaracionJurada.declarationFields.isVaccinated) return "Debe contestar si está vacunadx";
           if (declaracionJurada.declarationFields.departamentName.Trim().Length == 0) return "Debe seleccionar el area de la empresa";
           if (declaracionJurada.declarationFields.visitDate==null) return "Debe seleccionar la fecha de visita";
           if(!declaracionJurada.declarationFields.isTraveler)return "Debe contestar si viajó al exterior";
           if (!declaracionJurada.declarationFields.closeContact) return "Debe contestar las preguntas de contacto estrecho";
           if (!declaracionJurada.declarationFields.hasSymptom) return "Debe contestar si tiene síntomas";

           return string.Empty;
        
        }
    }
}
