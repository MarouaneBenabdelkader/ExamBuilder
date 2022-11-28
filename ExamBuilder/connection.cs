using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
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
        static public MySqlConnection conx = new MySqlConnection(constring);
        static public MySqlCommand cmd = new MySqlCommand();
        public connection() 
        {
            conx.Open();
        }
        
    }
}
