using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamBuilder
{
    public class Reponse
    {
        private string txtReponse;
        public Reponse() { }  
        public void setReponse(string txt)
        {
            txtReponse= txt;
        }        

        public string getReponse()
        {
            return txtReponse;
        }
    }
}
