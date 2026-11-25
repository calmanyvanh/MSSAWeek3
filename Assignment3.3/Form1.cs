/*
Windows form assignments

    Use different controls on windows forms and change their properties (do not submit this assignment)
    Create a class: Student with fields like studid, firstname, lastname, address, monthofadmission, grade to hold character.

Create a list of students and perform following operations in windows application:

    add new records,
    delete record and
    display them in grid.

Monthofadmission should be enum.
*/


namespace Assignment3._3
{
    public partial class Form1 : Form
    {

        List<Student> students = new List<Student>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = students; 

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
