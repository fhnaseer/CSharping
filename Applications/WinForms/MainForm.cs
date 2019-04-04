using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace WinForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Instantiatesearch1Thread();
        }

        private BackgroundWorker search1Thread;

        private void Instantiatesearch1Thread()
        {
            search1Thread = new BackgroundWorker();
            search1Thread.WorkerReportsProgress = true;
            search1Thread.WorkerSupportsCancellation = true;
            search1Thread.ProgressChanged += search1Thread_ProgressChanged;
            search1Thread.DoWork += search1Thread_Dowrk;
            search1Thread.RunWorkerCompleted += search1Thread_RunWorkerCompleted;
            CheckForIllegalCrossThreadCalls = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            search1Thread.RunWorkerAsync();
        }

        private void search1Thread_Dowrk(object sender, DoWorkEventArgs e)
        {
            try
            {
                MessageBox.Show(comboBox1.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                throw;
            }

        }

        private void search1Thread_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
        }

        private void search1Thread_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            comboBox1.Text = "Two";
            MessageBox.Show("All Done!");
        }
    }
}
