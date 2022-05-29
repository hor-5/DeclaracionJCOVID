using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesModel
{
    public class DeclaracionJurada
    {
        public int idDeclaracion { get; set; }
        
        public User newUser { get; set; }

        public DeclarationFields declarationFields { get; set; }

        public DateTime createdAt { get; set; }

        public DeclaracionJurada(User user, DeclarationFields declarationFields) {
            this.idDeclaracion = idDeclaracion++;
            this.newUser = user;
            this.declarationFields = declarationFields;
            this.createdAt = DateTime.Now;
        }
        
        
    }
}
