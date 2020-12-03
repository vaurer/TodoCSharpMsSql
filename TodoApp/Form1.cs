using System;
using System.Collections;
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
    public partial class Form1 : Form
    {
        TodoTask todoTask = new TodoTask();
        Form2 formX = new Form2();
        
        public Form1()
        {
            InitializeComponent();
            var timer = new Timer();
            var startTime = DateTime.Now;
            timer.Interval = 1000;
            timer.Tick += timTimer_Tick;
            timer.Enabled = true;
            timer.Start();
            formX.Show();

        }
        private void timTimer_Tick(object sender, EventArgs e)
        {
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            todoTask.isDone = false;
            todoTask.taskName = richTextBox1.Text.Trim();
            todoTask.taskTime = dateTimePicker1.Value;
            using (DBEntities db = new DBEntities())
            {
                db.TodoTasks.Add(todoTask);
                db.SaveChanges();
            }

            formX.populateGrid();
            Clear();
        }
        void Clear()
        {
            richTextBox1.Clear();
        }

    }
}
