using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageCourseAPP.Entity
{
    public class Parent
    {
        public int idPar;
        public string NomPar;
        public string PrenomPar;
        public string PhoneParent;
        public string Password;

        public static int nb;

        public Parent(string nomPar, string prenomPar, string phonePar,string password)
        {
            this.idPar = nb++;
           NomPar = nomPar;
           PrenomPar = prenomPar;
           PhoneParent = phonePar;
            Password = password;
        }
    }
}
