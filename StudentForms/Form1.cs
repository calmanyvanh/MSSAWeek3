namespace StudentForms
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
            cmoa.DataSource = Enum.GetValues(typeof(moa));
            cgrade.DataSource = Enum.GetValues(typeof(grade));

        }

        private void add_Click_1(object sender, EventArgs e)
        {
            var newStu = new Student();
            newStu.studentId = int.Parse(studentId.Text);
            newStu.firstName = firstName.Text;
            newStu.lastName = lastName.Text;
            newStu.address = address.Text;
            newStu.smoa = (moa)(cmoa.SelectedIndex + 1);
            newStu.sgrade = (grade)(cgrade.SelectedIndex + 1);
            students.Add(newStu);
            studentId.Clear(); address.Clear(); firstName.Clear(); lastName.Clear();
            moa.SelectedIndex = -1; cgrade.SelectedIndex = -1;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = students;
        }

        private void delete_Click(object sender, EventArgs e)
        {
            students.RemoveAt(dataGridView1.CurrentRow.Index);
            studentId.Clear(); address.Clear(); firstName.Clear(); lastName.Clear();
            moa.SelectedIndex = -1; cgrade.SelectedIndex = -1;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = students;
        }

        private void studentId_TextChanged(object sender, EventArgs e)
        {

        }

        private void moa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
