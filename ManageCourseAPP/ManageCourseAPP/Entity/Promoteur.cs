using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageCourseAPP.Entity
{
    public class Promoteur
    {
        public int idPro;
        public string NomPro;
        public string PrenomPro;
        public string NomGroup;
        public string PhonePro;
        public string Password;

        public static int nb;
        public Promoteur(string nomPro, string prenomPro, string nomGroup, string phonePro, string password)
        {
            this.idPro = nb++;
            NomPro = nomPro;
            PrenomPro = prenomPro;
            NomGroup = nomGroup;
            PhonePro = phonePro;
            Password = password;
        }
    }
}
