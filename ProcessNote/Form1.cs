using System;
using System.Windows.Forms;
using System.Diagnostics;




namespace ProcessNote
{
    public partial class Form1 : Form
    {
        static Timer t;
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            t = new Timer();
            t.Interval = 3000;
            t.Tick += new EventHandler(showListGrid);
            t.Start();


        }

        public void showListGrid(object sender, EventArgs e)
        {
            ListViewItem itm;
            Process[] allProcceses = Process.GetProcesses();
            string[] arr = new string[6]; ;
            foreach (Process process in allProcceses)
            {

                if (process.Id != 0)
                {
                    PerformanceCounter ramCounter = new PerformanceCounter("Process", "Working Set", process.ProcessName);
                    PerformanceCounter cpuCounter = new PerformanceCounter("Process", "% Processor Time", process.ProcessName);

                    arr[0] = process.Id.ToString();
                    arr[1] = process.ProcessName;
                    arr[2] = cpuCounter.NextValue().ToString() + " %";
                    arr[3] = (ramCounter.NextValue() / 1024 / 1024).ToString() + " MB";
                    arr[4] = (DateTime.Now - process.StartTime).ToString();
                    arr[5] = process.StartTime.ToString();

                    itm = new ListViewItem(arr);

                    listView1.Items.Add(itm);
                }
            }
        }
        
    }

}