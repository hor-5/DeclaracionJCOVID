using EntitiesModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ValidationServices
    {
        
        public bool validationDeclaracionFields(DeclaracionJurada declaracionJurada)
        {
           if(declaracionJurada.newUser.firstName.Trim().Length==0)return false;
           if (declaracionJurada.newUser.dni.Trim().Length == 0) return false;
           if (declaracionJurada.newUser.surName.Trim().Length == 0) return false;
           if (declaracionJurada.newUser.codArea.Trim().Length == 0) return false;
           if (declaracionJurada.newUser.telephone.Trim().Length == 0) return false;
           if (declaracionJurada.newUser.gender.Trim().Length == 0) return false;
           if (declaracionJurada.newUser.email.Address.Trim().Length==0) return false;
           if (declaracionJurada.newUser.enterprise.Trim().Length == 0) return false;
           if (declaracionJurada.newUser.age<=0) return false;
           if (declaracionJurada.newUser.nationality.Trim().Length == 0) return false;
           if (declaracionJurada.newUser.residenceCountry.Trim().Length == 0) return false;
           if (declaracionJurada.declarationFields.isRiskGroup) return false;
           if(declaracionJurada.declarationFields.isTraveler)return false;
           if (declaracionJurada.declarationFields.isVaccinated) return false;
           if (declaracionJurada.declarationFields.visitDate==null) return false;
           if (declaracionJurada.declarationFields.closeContact) return false;

           return true;
        
        }
    }
}
