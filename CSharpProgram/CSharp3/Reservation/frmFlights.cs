using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Reservation
{
    public partial class frmFlights : Form
    {
        public frmFlights()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            String strFlightNo,strDestination,strDate;
            strFlightNo=txtFlightNumbewr.Text;
            strDestination=txtDestination.Text;
            strDate = dtpFlightDate.Text;

            MessageBox.Show("Flight Nuumber is " + strFlightNo + "\n Destination is " 
             + strDestination + "\n Flight Date is " + strDate);
        }
    }
}
