using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesModel
{
    public class Person
    {
        public int idPerson { get; set; }
        public int fk_idUser { get; set; }
        public string dni { get; set; }
        public string firstName { get; set; }
        public string surName { get; set; }
        public string codArea { get; set; }        
        public string telephone { get; set; }
        public string enterprise { get; set; }
        public string email { get; set; }
        public int fk_idGender { get; set; }
        public DateTime birthday { get; set; }       
        public int fk_nationalityCountry { get; set; }
        public int  fk_residenceCountry  { get; set; }

        //public Person( string dni, string firstName, string surName, string codArea, string codCountry,
        //    string telephone, string enterprise, string email, Gender gender, 
        //    DateTime birthday, int age, Country nationality, Country residenceCountry) {
            
        //    this.dni = dni;
        //    this.firstName = firstName;
        //    this.surName = surName;
        //    this.codArea = codArea;
        //    this.telephone = telephone;
        //    this.enterprise = enterprise;
        //    this.email = email;
        //    this.fk_idGender = gender;
        //    this.birthday = birthday;            
        //    this.fk_nationalityCountry = nationality;
        //    this.fk_residenceCountry = residenceCountry;
        //}

        //public Person()
        //{

        //}

    }
}

