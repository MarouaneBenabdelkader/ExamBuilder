using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamBuilder
{
    public class Question
    {
        private string txtQuestion;
        private string type;

        public void setTxtQuestion(string txtQuestion)
        {
            this.txtQuestion = txtQuestion;
        }
        public void setType(string type) {
            this.type = type;
        }
        public string getTxtQuestion()
        {
            return this.txtQuestion;
        }

        public string getType() {
            return this.type;
        } 
        
      

    }
}
