using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;


namespace AP3_FormaFlix
{
    public class ModeleCommentaire
    {
        public void charger_Commentaire()
        {
            Controleur.VmodeleC.charger("select IDCOMMENTAIRE, LIBELLECOMMENTAIRE, NOTECOMMENTAIRE, STATUSCOMMENTAIRE from commentaire where STATUSCOMMENTAIRE = 0;", Controleur.VmodeleC.DT[6]);
        }

        public bool changer_status(DataGridViewSelectedRowCollection index)
        {
            try
            { 
                string requete = "update commentaire set STATUSCOMMENTAIRE = 1 where IDCOMMENTAIRE = @index";
                MySqlCommand command = Controleur.VmodeleC.MyConnection.CreateCommand();
                command.CommandText = requete;

                command.Parameters.AddWithValue("index", index);

                int i = command.ExecuteNonQuery();

                return (i > 0);
            }
            catch(Exception e)
            {
                return false;
            }


}
    }
}
