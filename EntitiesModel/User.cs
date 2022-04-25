using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesModel
{
    public class User
    {
        private string userName { get; set; }
        private string password { get; set; }
        private int dni { get; set; }
        private string firstName { get; set; }
        private string surName { get; set; }
        private int codArea { get; set; }
        private string codCountry { get; set; }
        private int telephone { get; set; }
        private string enterprise { get; set; }
        private MailAddress email { get; set; }
        private string gender { get; set; }
        private DateOnly birthday { get; set; }
        private int age { get; set; }   
        private string nationality { get; set; }
        private string residenceCountry  { get; set; }

        public User(string userName, string password, int dni, string firstName, string surName, int codArea, string codCountry,
            int telephone, string enterprise, MailAddress email, string gender, 
            DateOnly birthday, int age, string nationality, string residenceCountry) {
            
            this.userName = userName;
            this.password = password;
            this.dni = dni;
            this.firstName = firstName;
            this.surName = surName;
            this.codArea = codArea;
            this.telephone = telephone;
            this.enterprise = enterprise;
            this.email = email;
            this.gender = gender;
            this.birthday = birthday;
            this.age = age;
            this.nationality = nationality;
            this.residenceCountry = residenceCountry;
        }



    }
}

