
namespace TodoApp
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chkIsDone = new System.Windows.Forms.CheckBox();
            this.todoDataSet = new TodoApp.TodoDataSet();
            this.todoTasksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.todoTasksTableAdapter = new TodoApp.TodoDataSetTableAdapters.TodoTasksTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isDoneDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.todoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.todoTasksBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.taskNameDataGridViewTextBoxColumn,
            this.taskTimeDataGridViewTextBoxColumn,
            this.isDoneDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.todoTasksBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1026, 460);
            this.dataGridView1.TabIndex = 0;
            // 
            // chkIsDone
            // 
            this.chkIsDone.AutoSize = true;
            this.chkIsDone.Location = new System.Drawing.Point(5, 466);
            this.chkIsDone.Name = "chkIsDone";
            this.chkIsDone.Size = new System.Drawing.Size(78, 21);
            this.chkIsDone.TabIndex = 1;
            this.chkIsDone.Text = "Erledigt";
            this.chkIsDone.UseVisualStyleBackColor = true;
            // 
            // todoDataSet
            // 
            this.todoDataSet.DataSetName = "TodoDataSet";
            this.todoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // todoTasksBindingSource
            // 
            this.todoTasksBindingSource.DataMember = "TodoTasks";
            this.todoTasksBindingSource.DataSource = this.todoDataSet;
            // 
            // todoTasksTableAdapter
            // 
            this.todoTasksTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // taskNameDataGridViewTextBoxColumn
            // 
            this.taskNameDataGridViewTextBoxColumn.DataPropertyName = "taskName";
            this.taskNameDataGridViewTextBoxColumn.HeaderText = "taskName";
            this.taskNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.taskNameDataGridViewTextBoxColumn.Name = "taskNameDataGridViewTextBoxColumn";
            this.taskNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // taskTimeDataGridViewTextBoxColumn
            // 
            this.taskTimeDataGridViewTextBoxColumn.DataPropertyName = "taskTime";
            this.taskTimeDataGridViewTextBoxColumn.HeaderText = "taskTime";
            this.taskTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.taskTimeDataGridViewTextBoxColumn.Name = "taskTimeDataGridViewTextBoxColumn";
            this.taskTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // isDoneDataGridViewCheckBoxColumn
            // 
            this.isDoneDataGridViewCheckBoxColumn.DataPropertyName = "isDone";
            this.isDoneDataGridViewCheckBoxColumn.HeaderText = "isDone";
            this.isDoneDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.isDoneDataGridViewCheckBoxColumn.Name = "isDoneDataGridViewCheckBoxColumn";
            this.isDoneDataGridViewCheckBoxColumn.Width = 125;
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(1028, 505);
            this.Controls.Add(this.chkIsDone);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.todoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.todoTasksBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView Timer_Tick;
        private System.Windows.Forms.CheckBox chkFinished;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox chkIsDone;
        private TodoDataSet todoDataSet;
        private System.Windows.Forms.BindingSource todoTasksBindingSource;
        private TodoDataSetTableAdapters.TodoTasksTableAdapter todoTasksTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isDoneDataGridViewCheckBoxColumn;
    }
}