using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesModel
{
    public class DeclarationAdmin
    {
        public int idDeclaration { get; set; }
        public DateTime created_at { get; set; }
        public string dni { get; set; }
        public string firstName { get; set; }
        public string surName { get; set; }
        public string telephone { get; set; }
        public bool closeContact { get; set; }
        public bool hasSymptom { get; set; }
        public bool isVaccinated { get; set; }
        public bool isRiskGroup { get; set; }
        public bool isTraveler { get; set; }
        public DateTime visitDate { get; set; }
        public string nameDepartament { get; set; }
        public string nameStatus { get; set; }



    }
}
