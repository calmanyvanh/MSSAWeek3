/* 
Windows form assignments

    Use different controls on windows forms and change their properties (do not submit this assignment)
    Create a class: Student with fields like studid, firstname, lastname, address, monthofadmission, and grade to hold character.

Create a list of students and perform following operations in windows application:

    add new records,
    delete record and
    display them in grid.

Monthofadmission should be enum.
*/


using System.ComponentModel;


namespace DataGrid
{
    public partial class Form1 : Form
    {
        private DataGridView
        public Form1()
        {
            InitializeComponent();

            List<Person> persons = new List<Person>();
            persons.Add(new Person() { Name = "Bob", Surname = "Smith" });
            persons.Add(new Person() { Name = "asda", Surname = "Sgsd" });
            persons.Add(new Person() { Name = "dgsg", Surname = "sdgs" });
            persons.Add(new Person() { Name = "dgsa", Surname = "dsgh" });

            var bindingList = new BindingList<Person>(persons);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;
        }
    }

    class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}