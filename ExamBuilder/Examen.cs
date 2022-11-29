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

        public string getTitre()
        {
            return titre;
        }

        public string getHeureDebut()
        {
            return heureDebut;
        }

        public string getHeureFin()
        {
            return heureFin;
        }

        public string getspecialite()
        {
            return specialite;
        }



    }
}
