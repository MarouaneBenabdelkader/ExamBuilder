using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamBuilder
{
    internal class connection
    {
        static string server = "localhost";
        static string database = "examgenerator";
        static string username = "root";
        static string password = "";
        static string constring = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + username + ";" + "PASSWORD=" + password + ";";
        static  MySqlConnection conx = new MySqlConnection(constring);
        static  MySqlCommand cmd = new MySqlCommand();
        static public MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
        public connection() 
        {
            conx.Close();
            conx.Open();
        }

        public void insertExamInfo(Examen datas)
        {
            cmd.Connection = conx;
            cmd.CommandText = "insert into examen(titre,heure_debut,heure_fin,specialite) values ('" + datas.getTitre() + "','" + datas.getHeureDebut() + "','" + datas.getHeureFin() + "','" + datas.getspecialite() + "')";
            cmd.ExecuteNonQuery();
            conx.Close();
        }

        public DataTable getQuestion()
        {
                connection connection = new connection();
                connection.cmd.CommandText = "select * from question;";
                connection.cmd.Connection = connection.conx;
                DataTable data = new DataTable();
                connection.conx.Close();
            return data;
        }

        public void AddQuestionToExam(string Txt ,string type)
        {   
            string query = "select id_question from question where txtquestion="+Txt+"and type="+type+ ";";
            string query2 = "select MAX(id_exam) from exam ;";
            //cmd.CommandText = "insert into examen_question(id_question,id_exam) values ('" + datas.getTitre() + "','" + datas.getHeureDebut() + "')";
            cmd.ExecuteNonQuery();
            conx.Close();
        }

        public void insertQuestionRes(Reponse datas , Question ques)
        {
            cmd.Connection = conx;
           
            
                cmd.CommandText = "insert into reponse(txtreponse) values ('" + datas.getReponse() +"')";
                cmd.ExecuteNonQuery();
                MySqlCommand cmd2 = new MySqlCommand("Select MAX(id_reponse) from reponse",conx);
                int id_reponse = (int)cmd2.ExecuteScalar();
                cmd.CommandText = "insert into question(txtquestion,type,id_reponse) values ('" + ques.getTxtQuestion() + "','" + ques.getType() + "','" + id_reponse + "')";
                cmd.ExecuteNonQuery();
            
            conx.Close();
        }

        public void InsertQcm(Reponse r1 ,Reponse r2 ,Reponse r3 , Reponse r4 , Question ques) {
            cmd.CommandText = "insert into reponse(txtreponse) values ('" + r1.getReponse() + "')";
            cmd.ExecuteNonQuery();
            MySqlCommand cmd2 = new MySqlCommand("Select MAX(id_reponse) from reponse", conx);
            int id_reponse = (int)cmd2.ExecuteScalar();
            cmd.CommandText = "insert into question(txtquestion,type,id_reponse) values ('" + ques.getTxtQuestion() + "','" + ques.getType() + "','" + id_reponse + "')";
            cmd.ExecuteNonQuery();
            
            cmd.CommandText = "insert into reponse(txtreponse) values ('" + r2.getReponse() + "')";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "insert into reponse(txtreponse) values ('" + r3.getReponse() + "')";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "insert into reponse(txtreponse) values ('" + r4.getReponse() + "')";
            cmd.ExecuteNonQuery();

            string reps;
            using (conx)
            {
                int i = 0;
                string[] x = new string[4];
                MySqlCommand command = new MySqlCommand(
                  "select id_reponse from reponse order by id_reponse desc limit 4;",
                  conx);
                MySqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        x[i++] = reader.GetString(0);
                    }
                }
                else
                {
                    Console.WriteLine("No rows found.");
                }
                 reps = string.Join(",", x);
                reader.Close();
            }

            MySqlCommand cmd3 = new MySqlCommand("Select MAX(id_question) from question", conx);
            int id_question = (int) cmd3.ExecuteScalar();
            cmd.CommandText = "insert into qcm(id_qcm,id_reponse) values ('" + id_question + "','" + reps + "')";
            cmd.ExecuteNonQuery();
        }

    }
}
