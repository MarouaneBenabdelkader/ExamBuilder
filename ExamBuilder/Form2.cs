using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ExamBuilder
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void ComoboxFill()
        {
            connection connection = new connection();
            DataTable data = connection.getQuestion();
            connection.adapter.Fill(data);
            comboBox2.DataSource = data;
            comboBox2.ValueMember = "txtquestion";
            comboBox2.DisplayMember = "txtquestion";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ComoboxFill();
            TxtBox2.Enabled = false;
            TxtBox3.Enabled = false;
            TxtBox4.Enabled = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection conx = new connection();
            conx.AddQuestionToExam(comboBox2.Text,comboBox1.Text);
        }

        private void comboBox3_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void comboBox3_TextChanged(object sender, EventArgs e)
        {
         
           
        }

        private void comboBox3_DropDownClosed(object sender, EventArgs e)
        {
            
        }

        private void comboBox3_Leave(object sender, EventArgs e)
        {
            if (comboBox3.Text != "QCM")
            {
                TxtBox2.Enabled = false;
                TxtBox3.Enabled = false;
                TxtBox4.Enabled = false;
            }
            else
            {
                TxtBox2.Enabled = true; 
                TxtBox3.Enabled = true; 
                TxtBox4.Enabled = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            connection conx = new connection();
            Question ques = new Question();
            Reponse rep = new Reponse();
            ques.setTxtQuestion(TxtBox0.Text);
            ques.setType(comboBox3.Text);
            rep.setReponse(TxtBox1.Text);
            if (ques.getType().Equals("Ouverte") || ques.getType().Equals("DICOTHOMIQUE"))
                conx.insertQuestionRes(rep,ques);
            else
            {
                Reponse rep2 = new Reponse();
                Reponse rep3 = new Reponse();
                Reponse rep4 = new Reponse();
                rep2.setReponse(TxtBox2.Text);
                rep3.setReponse(TxtBox3.Text);
                rep4.setReponse(TxtBox4.Text);
                
                conx.InsertQcm(rep,rep2,rep3,rep4,ques);
            }
                

            
        }
    }
}
