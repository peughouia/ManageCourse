using ManageCourseAPP.Entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageCourseAPP.DAL
{
    public class D_Classe
    {
       public D_Classe()
        {

        }


        public void AddClasse(Classe classe)
        {
            string query = "INSERT INTO Classe(Id, NomClasse)VALUES(" + classe.idClasse + ",'" + classe.nomClasses + "')";
            Connection.con.Open();
            Connection.cmd = Connection.con.CreateCommand();
            Connection.cmd.CommandText = query;
            Connection.cmd.ExecuteNonQuery();
        }

    }
}
