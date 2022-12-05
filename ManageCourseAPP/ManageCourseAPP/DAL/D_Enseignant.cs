using ManageCourseAPP.Entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageCourseAPP.DAL
{
    public class D_Enseignant
    {
        public D_Enseignant()
        {

        }

        public void AddEnseignant(Enseignant enseignant)
        {
            string query = "INSERT INTO Enseignant(Id, NomEnseignant, PrenomEnseignant, AdresseEnseignant, idPromoteur, idMatiere)VALUES("+ enseignant.idEnsei +",'"+ enseignant.nomEnsei +"','"+ enseignant.prenomEnsei+"', '"+enseignant.adresseEnsei+"','"+ enseignant.idpro+"','"+ enseignant.idmat+"')";
            Connection.con.Open();
            Connection.cmd = Connection.con.CreateCommand();
            Connection.cmd.CommandText = query;
            Connection.cmd.ExecuteNonQuery();
        }
    }
}
