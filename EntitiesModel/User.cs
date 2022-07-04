using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesModel
{
    public class User
    {
        public int idUser { get; set; }
        public string username { get; set; }
        public string pass { get; set; }
        public bool is_admin { get; set; }
    }
}
