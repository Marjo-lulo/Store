using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StoreManager
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Sales_Click(object sender, EventArgs e)
        {
            SalesForm sf = new SalesForm();
            sf.Show();

            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btn_logout_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Produckt_Click(object sender, EventArgs e)
        {
            ProductForm p = new ProductForm();
            p.Show();

            this.Close();
        }
    }
}
