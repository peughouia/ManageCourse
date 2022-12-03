using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageCourseAPP.Entity
{
    public class Matiere
    {
        public int idMat;
        public string nomMat;

        public static int nb;

        public Matiere(string nomMat)
        { 
            this.idMat= nb++;
            this.nomMat = nomMat;
        }    
    }
}
