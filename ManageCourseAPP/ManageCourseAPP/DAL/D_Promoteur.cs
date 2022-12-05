using ManageCourseAPP.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageCourseAPP.DAL
{
    public class D_Promoteur
    {
        public D_Promoteur()
        {
            
        }

        public void AddPromoteur(Promoteur promoteur)
        {
            string query = "INSERT INTO Promoteur(Id, NomPromoteur, PrenomPromoteur, PhonePromoteur,NomGroup) VALUES("+ promoteur.idPro +",'"+ promoteur.nomPro +"','"+ promoteur.prenomPro +"','"+ promoteur.phonePro +"','"+ promoteur.nomGroup +"')";
            Connection.con.Open();
            Connection.cmd=Connection.con.CreateCommand();
            Connection.cmd.CommandText = query;
            Connection.cmd.ExecuteNonQuery();
        }

    }
}
