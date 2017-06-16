namespace ProcessNote
{
    partial class Form1
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.PID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.processname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CPU = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.memory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.runningtime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.starttime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PID,
            this.processname,
            this.CPU,
            this.memory,
            this.runningtime,
            this.starttime});
            this.listView1.ForeColor = System.Drawing.Color.Black;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(12, 31);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(640, 379);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // PID
            // 
            this.PID.Text = "PID";
            this.PID.Width = 50;
            // 
            // processname
            // 
            this.processname.Text = "Process Name";
            this.processname.Width = 100;
            // 
            // CPU
            // 
            this.CPU.Text = "CPU usage";
            this.CPU.Width = 100;
            // 
            // memory
            // 
            this.memory.Text = "Memory usage";
            this.memory.Width = 100;
            // 
            // runningtime
            // 
            this.runningtime.Text = "Running Time";
            // 
            // starttime
            // 
            this.starttime.Text = "Start Time";
            this.starttime.Width = 132;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(922, 422);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader PID;
        private System.Windows.Forms.ColumnHeader processname;
        private System.Windows.Forms.ColumnHeader CPU;
        private System.Windows.Forms.ColumnHeader memory;
        private System.Windows.Forms.ColumnHeader runningtime;
        private System.Windows.Forms.ColumnHeader starttime;
    }
}

