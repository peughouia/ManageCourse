using ManageCourseAPP.Entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageCourseAPP.DAL
{
    public class D_Matiere
    {
        public D_Matiere()
        {

        }

        public void AddMatiere(Matiere matiere)
        {
            string query = "INSERT INTO Matiere(Id,NomMatiere)VALUES("+matiere.idMat+",'"+matiere.nomMat+"')";
            Connection.con.Open();
            Connection.cmd = Connection.con.CreateCommand();
            Connection.cmd.CommandText = query;
            Connection.cmd.ExecuteNonQuery();
        }
    }

}
