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
        public string userName { get; set; }
        public string password { get; set; }
        public string dni { get; set; }
        public string firstName { get; set; }
        public string surName { get; set; }
        public string codArea { get; set; }
        public string codCountry { get; set; }
        public string telephone { get; set; }
        public string enterprise { get; set; }
        public MailAddress email { get; set; }
        public string gender { get; set; }
        public DateTime birthday { get; set; }
        public int age { get; set; }
        public string nationality { get; set; }
        public string residenceCountry  { get; set; }

        public User(string userName, string password, string dni, string firstName, string surName, string codArea, string codCountry,
            string telephone, string enterprise, MailAddress email, string gender, 
            DateTime birthday, int age, string nationality, string residenceCountry) {
            
            this.userName = userName;
            this.password = password;
            this.dni = dni;
            this.firstName = firstName;
            this.surName = surName;
            this.codArea = codArea;
            this.codCountry = codCountry;
            this.telephone = telephone;
            this.enterprise = enterprise;
            this.email = email;
            this.gender = gender;
            this.birthday = birthday;
            this.age = age;
            this.nationality = nationality;
            this.residenceCountry = residenceCountry;
        }

        public User()
        {

        }

    }
}

