using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesModel
{
    public class DeclarationFields
    {
        public int idDeclarationField { get; set; }
        public bool isRiskGroup { get; set; }
        public bool isVaccinated { get; set; }
        public bool fk_idDepartament { get; set; }
        public DateTime visitDate { get; set; }
        public bool isTraveler { get; set; }
        public bool closeContact { get; set; }
        public bool hasSymptom { get; set; }

    }
}
