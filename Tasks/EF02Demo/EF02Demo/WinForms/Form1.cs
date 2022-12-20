using Microsoft.EntityFrameworkCore;
using WinForms.Entities;

namespace WinForms
{
    public partial class Form1 : Form
    {
        ITIContext db;
        public Form1()
        {
             db = new ITIContext();   
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //var Result = (from Std in db.Students
            //             select Std).ToList();

            db.Students.Load();

            dataGridView1.DataSource = db.Students.Local.ToBindingList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.EndEdit();
            db.SaveChanges();
        }
    }
}