using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace RentRoom
{
    public partial class Form1 : Form
    {
        private const decimal ROOMRENT = 500;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {

            decimal total = nudNoRoom.Value * ROOMRENT;
            txtRoomRent.Text = nudNoRoom.Value.ToString();
            txtTotal.Text = total.ToString("C", CultureInfo.CreateSpecificCulture("en-US"));
            lblThankYou.Text = "Thank You" + "  " + txtFname.Text + "  " + txtLname.Text;
            btnClear.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFname.Clear();
            txtLname.Clear();
            txtTotal.Clear();
            txtRoomRent.Clear();
            lblThankYou.Text = "";
            nudNoRoom.Value = 0;
            txtFname.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }

            if (keyData == Keys.Enter)
            {

                decimal total = nudNoRoom.Value * ROOMRENT;
                txtRoomRent.Text = nudNoRoom.Value.ToString();
                txtTotal.Text = total.ToString("C", CultureInfo.CreateSpecificCulture("en-US"));
                lblThankYou.Text = "Thank You" + "  " + txtFname.Text + "  " + txtLname.Text;
                btnClear.Focus();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
