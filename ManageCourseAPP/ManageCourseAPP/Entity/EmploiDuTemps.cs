using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageCourseAPP.Entity
{
    public class EmploiDuTemps
    {
        public int idEmp;
        public Matiere idMat;
        public DateTime heureDeb;
        public DateTime heureFin;
        public DateTime dateEmp;
        public Classe idClasse;

        public static int nb;
        public EmploiDuTemps(Matiere idMat, DateTime heureDeb, DateTime heureFin,DateTime dateEmp,Classe idClasse)
        {
            this.idEmp = nb++;
            this.idMat = idMat;
            this.heureDeb= heureDeb;
            this.heureFin = heureFin;
            this.dateEmp = dateEmp;
            this.idClasse= idClasse;
        }
    }
}
