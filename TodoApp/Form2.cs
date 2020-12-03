using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TodoApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public void dataGridView1_Show(object sender, EventArgs e)
        {
            
            using (DBEntities db = new DBEntities())
            {
                dataGridView1.DataSource = db.TodoTasks.ToList<TodoTask>();
            }
        
        }

        public void populateGrid()
        {
            using (DBEntities db = new DBEntities())
            {
                dataGridView1.DataSource = db.TodoTasks.ToList<TodoTask>();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'todoDataSet.TodoTasks' table. You can move, or remove it, as needed.
            this.todoTasksTableAdapter.Fill(this.todoDataSet.TodoTasks);

        }

    }
}
