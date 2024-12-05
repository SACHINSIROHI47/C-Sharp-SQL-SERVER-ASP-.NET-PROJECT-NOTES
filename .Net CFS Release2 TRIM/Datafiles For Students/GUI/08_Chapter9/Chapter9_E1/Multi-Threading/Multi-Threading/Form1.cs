using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Multi_Threading
{
    public partial class BackGroundWorker : Form
    {
        
        public BackGroundWorker()
        {
            InitializeComponent();
        }

        private void btnasync_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            lblresult.Text = "";
            btncancel.Enabled = true;
            btnasync.Enabled = false;
            ProgressBar1.Value = 0;
            this.Cursor = Cursors.WaitCursor;
            BackgroundWorker1.RunWorkerAsync(txtnum.Text);
        }

        private double SumNumbers(double number, System.ComponentModel.BackgroundWorker worker, DoWorkEventArgs e)
        {
            int lastPercent  = 0;
            double sum = 0,i=0;

            for(i=0;i<=number;i++)
            {
               //---check if user cancelled the process
               if (worker.CancellationPending == true)
                    e.Cancel = true;
                else
                {
                    sum += i;
                    if (i%10==0) 
                    {
                        int percentDone  = Convert.ToInt32((i / number) * 100);
                        //---update the progress bar if there is a change
                        if (percentDone > lastPercent)
                        {
                            //This method calls BackgroundWorker1_ProgressChanged method
                            worker.ReportProgress(percentDone);
                            lastPercent = percentDone;
                        }
                    }
                }
            }
            return sum;
        }

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
           System.ComponentModel.BackgroundWorker worker= (System.ComponentModel.BackgroundWorker)sender ;
           e.Result = SumNumbers(Convert.ToDouble(e.Argument), worker, e);
        }

        private void BackgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            ProgressBar1.Value = e.ProgressPercentage;
        }

        private void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null ) 
                MessageBox.Show (e.Error.Message);
            else if (e.Cancelled)
                MessageBox.Show ("Cancelled");
            else
                lblresult.Text = "Sum of 0 to " +txtnum.Text + " is " + e.Result;
            
            btnasync.Enabled = true;
            btncancel.Enabled = false;
            this.Cursor = Cursors.Default;
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            BackgroundWorker1.CancelAsync();
            btncancel.Enabled = false;
        }

        private void btnsync_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            double number=0,i=0;
            int lastPercent= 0;
            double sum = 0;
            number = Convert.ToDouble(txtnum.Text);
            ProgressBar1.Value = 0;
        
            for( i  = 0;i<= number;i++)
            {
                sum += i;
                if (i%10 == 0)
                {
                    int percentDone  = Convert.ToInt32((i / number) * 100);
                    //---update the progress bar if there is a change
                    if (percentDone > lastPercent)
                    {
                        updateProgress(percentDone);
                        lastPercent = percentDone;
                    }
                }

            }
        //Return
            lblresult.Text = "Sum of 0 to " + txtnum.Text + " is " + sum;
        }
        
        private void updateProgress(int percentComplete)
        {
            // Indicate progress using progress bar
            ProgressBar1.Value = percentComplete;
        }

        private void lblgetinfo_Click(object sender, EventArgs e)
        {
            //AddHandler DataGridView1.DataError, AddressOf DataGridView1_DataError;
            //this.DataGridView1.DataSource = My.Computer.FileSystem.Drives;
            string Filedir = @"..\\..\\photo";
            pictureBox1.Image = Image.FromFile(Filedir + "\\Sunset.jpg");
        }

        private void txtnum_TextChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ProgressBar1_Click(object sender, EventArgs e)
        {

        }

               
    }

}