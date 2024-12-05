using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BackGroundWorkerDemo
{
    public partial class frmBGDemo : Form
    {
        double  cnt = 0;
        public frmBGDemo()
        {
            InitializeComponent();
            backgroundWorker1.DoWork += new DoWorkEventHandler(backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorker1_RunWorkerCompleted);
        }

        private Double CalcPrime(double number, System.ComponentModel.BackgroundWorker worker, DoWorkEventArgs e)
        {
            double i, j; cnt = 0;
            double  limit=Convert.ToInt32 (txtNumber.Text);
            for (i = 2; i <= limit; i++)
            {
                for (j = 2; j < i; j++)
                {
                    if (worker.CancellationPending == true)
                        e.Cancel = true;
                    else
                    {
                        if ((i % j) == 0)
                        {
                            break;
                        }
                        else if ((i % j) != 0 && j == i - 1)
                        {
                            cnt++;
                        }
                    }
                }
            }
            return cnt+1;

        }
        private void frmBGDemo_Load(object sender, EventArgs e)
        {

        }

        private void txtNumber_TextChanged(object sender, EventArgs e)
        {
            txtPrime.Text = "";
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            double i, j; cnt = 0;
            double limit = Convert.ToInt32(txtNumber.Text);
            txtPrime.Text = "";
            for (i = 2; i <= limit; i++)
            {
                for (j = 2; j < i; j++)
                {
                   if ((i % j) == 0)
                   {
                          break;
                   }
                   else if ((i % j) != 0 && j == i - 1)
                   {
                            cnt++;
                   }
                }
            }
            txtPrime.Text= Convert.ToString( cnt + 1);
        }

        private void BtnAsync_Click(object sender, EventArgs e)
        {
            txtPrime.Text = "";
            this.Cursor = Cursors.WaitCursor;
            backgroundWorker1.RunWorkerAsync(txtNumber.Text);
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            System.ComponentModel.BackgroundWorker worker = (System.ComponentModel.BackgroundWorker)sender;
            e.Result = CalcPrime(Convert.ToDouble(e.Argument), worker, e);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
                MessageBox.Show(e.Error.Message);
            else if (e.Cancelled)
            {
                this.Cursor = Cursors.Arrow;
                MessageBox.Show("Cancelled");
            }

            else
                txtPrime.Text = Convert.ToString(e.Result);

           this.Cursor = Cursors.Default;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            backgroundWorker1.CancelAsync();
        }

        private void backgroundWorker1_RunWorkerCompleted_1(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }
    }
}