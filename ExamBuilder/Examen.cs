using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ExamBuilder
{
    public class Examen
    {
        private string titre = string.Empty;
        private string heureDebut;
        private string heureFin;
        private string specialite = string.Empty;

        public Examen() { }
        public Examen(string titre, string heureDebut, string heurFin, string specialite)
        {
            this.titre = titre;
            this.heureDebut = heureDebut;
            this.heureFin = heurFin;
            this.specialite = specialite;
        }
        

        public void setTitre(string Txt )
        {
            titre = Txt;
        }

        public void setHeureDebut(string time)
        {
            heureDebut = time;
        }

        public void setHeureFin(string time)
        {
            heureFin = time;
        }
        public void setSpecialite(string Txt)
        {
            specialite = Txt;
        }

        

        public void InserExamData(Examen datas)
        {
            connection connecton = new connection();
            connection.cmd.Connection = connection.conx;
            connection.cmd.CommandText = "insert into examen(titre,heure_debut,heure_fin,specialite) values ('" + datas.titre + "','" + datas.heureDebut + "','" + datas.heureFin + "','" + datas.specialite + "')";
            connection.cmd.ExecuteNonQuery();
            connection.conx.Close();
        }
        
    }
}
