namespace ExamBuilder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_MouseDown(object sender, MouseEventArgs e)
        {
            Timepicker1.CustomFormat = "hh:mm";
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            if(TxtBox1.Text != string.Empty && TxtBox2.Text!= string.Empty) { 
                Examen examen = new Examen();
                examen.setTitre(TxtBox1.Text);
                examen.setSpecialite(TxtBox2.Text);
                examen.setHeureFin(Timepicker2.Value.ToString("hh:mm:ss"));
                examen.setHeureDebut(Timepicker1.Value.ToString("hh:mm:ss"));
                connection conx = new connection();
                conx.insertExamInfo(examen);
                this.Hide();
                Form2 f2 = new Form2();
                f2.Show();
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}