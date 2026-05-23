using Store.DAL;
using Microsoft.EntityFrameworkCore;
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
            LoadDashboardStats();
            LoadProductImage();
        }

        private void LoadDashboardStats()
        {
            using (var context = new StoreDbContext())
            {
                int totalOrders = context.Sales;
                lbl_Orders.Text = totalOrders.ToString();

                int totalCustomers = context.Clients?.Count() ?? 0;
                lbl_Customers.Text = totalCustomers.ToString();

                int totalProducts = context.Products?.Count() ?? 0;
                lbl_TotalProducts.Text = totalProducts.ToString();
            }
        }

        private void LoadProductImage()
        {
            string imagePath = Path.Combine(Application.StartupPath, "Images", "product.jpg");
            if (File.Exists(imagePath))
            {
                pictureBox1.Image = Image.FromFile(imagePath);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }
        private void btn_Sales_Click(object sender, EventArgs e)
        {
            SalesForm sf = new SalesForm();
            sf.Show();

            this.Close();
        }
        private void Btn_logout_Click(object sender, EventArgs e)
        {
            LoginForm lg = new LoginForm();
            lg.Show();

            this.Close();

        }

        private void Btn_Produckt_Click(object sender, EventArgs e)
        {
            ProductForm p = new ProductForm();
            p.Show();

            this.Close();
        }

        private void btn_inventory(object sender, EventArgs e)
        {
            data.Controls.Clear();

            DataGridView dgv = new DataGridView();
            dgv.Dock = DockStyle.Fill;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.None;

            using (var context = new StoreDbContext())
            {
                var products = context.Products.ToList();
                dgv.DataSource = products;

            }
            data.Controls.Add(dgv);
        }
    }
}
