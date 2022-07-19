using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesModel
{
    public class Declarations
    {
        public int idDeclaration { get; set; }
        
        public Person fk_idPerson { get; set; }

        public DeclarationFields fk_idDeclarationFields { get; set; }

        public DateTime created_at { get; set; }

        public int fk_idStatus { get; set; }

        public Declarations(Person person, DeclarationFields declarationFields) {            
            this.fk_idPerson = person;
            this.fk_idDeclarationFields = declarationFields;
            this.created_at = DateTime.Now;
        }
        
        
    }
}
