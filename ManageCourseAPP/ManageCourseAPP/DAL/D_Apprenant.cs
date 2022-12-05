using ManageCourseAPP.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageCourseAPP.DAL
{
    public class D_Apprenant
    {
        public D_Apprenant()
        {

        }

        public void AddApprenant(Apprenant apprenant)
        {
            string query = "INSERT INTO Apprenant(Id, NomApprenant, PrenonApprenant, idclasse, IdParent)VALUES(" + apprenant.idApp + ", '"+ apprenant.nomApp +"', '"+ apprenant.prenomApp +"', '"+ apprenant.idClasse +"', '"+ apprenant.idPar +"')";
            Connection.con.Open();
            Connection.cmd = Connection.con.CreateCommand();
            Connection.cmd.CommandText = query;
            Connection.cmd.ExecuteNonQuery();

        }

    }
}
