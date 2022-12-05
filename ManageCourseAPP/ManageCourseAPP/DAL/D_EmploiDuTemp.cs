using ManageCourseAPP.Entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageCourseAPP.DAL
{
    public class D_EmploiDuTemp
    {
        public D_EmploiDuTemp()
        {

        }

        public void AddEmploiTemp(EmploiDuTemps emploiDuTemps)
        {
            string query = "INSERT INTO EmploiTemp(Id, DateEmp, heureDeb, heureFin, IdMatiere, IdClasse)VALUES("+ emploiDuTemps.idEmp +",'"+ emploiDuTemps.dateEmp +"', '"+ emploiDuTemps.heureDeb +"', '"+ emploiDuTemps.heureFin +"', '"+ emploiDuTemps.idMat +"', '"+ emploiDuTemps.idClasse +"')";
            Connection.con.Open();
            Connection.cmd = Connection.con.CreateCommand();
            Connection.cmd.CommandText = query;
            Connection.cmd.ExecuteNonQuery();
        }
    }
}
