namespace StoreManager
{
    partial class DashboardForm
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
            panel1 = new Panel();
            btn_logout = new Button();
            btn_Inventory = new Button();
            btn_Sales = new Button();
            Btn_Produkt = new Button();
            pictureBox1 = new PictureBox();
            data = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel3 = new Panel();
            label5 = new Label();
            label6 = new Label();
            dateTimePicker1 = new DateTimePicker();
            panel2 = new Panel();
            panel5 = new Panel();
            lbl_TotalSales = new Label();
            panel6 = new Panel();
            lbl_Customers = new Label();
            panel7 = new Panel();
            lbl_Orders = new Label();
            panel8 = new Panel();
            lbl_TotalProducts = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)data).BeginInit();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_logout);
            panel1.Controls.Add(btn_Inventory);
            panel1.Controls.Add(btn_Sales);
            panel1.Controls.Add(Btn_Produkt);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(2, 123);
            panel1.Name = "panel1";
            panel1.Size = new Size(225, 608);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btn_logout
            // 
            btn_logout.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_logout.Location = new Point(32, 188);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(124, 38);
            btn_logout.TabIndex = 5;
            btn_logout.Text = "Logout";
            btn_logout.UseVisualStyleBackColor = true;
            btn_logout.Click += Btn_logout_Click;
            // 
            // btn_Inventory
            // 
            btn_Inventory.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Inventory.Location = new Point(32, 140);
            btn_Inventory.Name = "btn_Inventory";
            btn_Inventory.Size = new Size(124, 42);
            btn_Inventory.TabIndex = 4;
            btn_Inventory.Text = "Inventory";
            btn_Inventory.UseVisualStyleBackColor = true;
            btn_Inventory.Click += btn_inventory;
            // 
            // btn_Sales
            // 
            btn_Sales.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Sales.Location = new Point(32, 88);
            btn_Sales.Name = "btn_Sales";
            btn_Sales.Size = new Size(124, 46);
            btn_Sales.TabIndex = 3;
            btn_Sales.Text = "Customers";
            btn_Sales.UseVisualStyleBackColor = true;
            btn_Sales.Click += btn_Sales_Click;
            // 
            // Btn_Produkt
            // 
            Btn_Produkt.BackColor = SystemColors.ButtonHighlight;
            Btn_Produkt.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_Produkt.Location = new Point(32, 41);
            Btn_Produkt.Name = "Btn_Produkt";
            Btn_Produkt.Size = new Size(124, 41);
            Btn_Produkt.TabIndex = 1;
            Btn_Produkt.Text = "Products";
            Btn_Produkt.UseVisualStyleBackColor = false;
            Btn_Produkt.Click += Btn_Produckt_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonFace;
            pictureBox1.Location = new Point(3, 268);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(222, 335);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // data
            // 
            data.BackgroundColor = SystemColors.ButtonHighlight;
            data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data.Location = new Point(231, 391);
            data.Name = "data";
            data.RowHeadersWidth = 51;
            data.Size = new Size(566, 340);
            data.TabIndex = 3;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(3, 2);
            label1.Name = "label1";
            label1.Size = new Size(174, 36);
            label1.TabIndex = 4;
            label1.Text = " Total Products ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(27, 3);
            label2.Name = "label2";
            label2.Size = new Size(129, 39);
            label2.TabIndex = 7;
            label2.Text = "Total Sales";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(156, 36);
            label3.TabIndex = 8;
            label3.Text = " Customers  ";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(33, 10);
            label4.Name = "label4";
            label4.Size = new Size(123, 32);
            label4.TabIndex = 9;
            label4.Text = " Orders  ";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.Location = new Point(3, 126);
            panel3.Name = "panel3";
            panel3.Size = new Size(291, 386);
            panel3.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(47, 19);
            label5.Name = "label5";
            label5.Size = new Size(164, 46);
            label5.TabIndex = 7;
            label5.Text = "Store Ma";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(545, 28);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.AccessibleRole = AccessibleRole.OutlineButton;
            dateTimePicker1.CalendarFont = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.CalendarMonthBackground = SystemColors.GradientActiveCaption;
            dateTimePicker1.CalendarTitleForeColor = SystemColors.ButtonHighlight;
            dateTimePicker1.Location = new Point(527, 19);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(2, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(795, 122);
            panel2.TabIndex = 5;
            panel2.Paint += panel2_Paint;
            // 
            // panel5
            // 
            panel5.Controls.Add(lbl_TotalSales);
            panel5.Controls.Add(label2);
            panel5.Location = new Point(317, 151);
            panel5.Name = "panel5";
            panel5.Size = new Size(180, 90);
            panel5.TabIndex = 10;
            // 
            // lbl_TotalSales
            // 
            lbl_TotalSales.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_TotalSales.ForeColor = SystemColors.ButtonHighlight;
            lbl_TotalSales.Location = new Point(27, 38);
            lbl_TotalSales.Name = "lbl_TotalSales";
            lbl_TotalSales.Size = new Size(129, 36);
            lbl_TotalSales.TabIndex = 8;
            lbl_TotalSales.Text = "$1200 ";
            lbl_TotalSales.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            panel6.Controls.Add(lbl_Customers);
            panel6.Controls.Add(label3);
            panel6.Location = new Point(317, 277);
            panel6.Name = "panel6";
            panel6.Size = new Size(180, 90);
            panel6.TabIndex = 11;
            // 
            // lbl_Customers
            // 
            lbl_Customers.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Customers.ForeColor = SystemColors.ButtonHighlight;
            lbl_Customers.Location = new Point(27, 45);
            lbl_Customers.Name = "lbl_Customers";
            lbl_Customers.Size = new Size(129, 36);
            lbl_Customers.TabIndex = 8;
            lbl_Customers.Text = " 58 ";
            lbl_Customers.TextAlign = ContentAlignment.MiddleCenter;
            lbl_Customers.Click += lbl_Orders_Click;
            // 
            // panel7
            // 
            panel7.Controls.Add(lbl_Orders);
            panel7.Controls.Add(label4);
            panel7.Location = new Point(559, 151);
            panel7.Name = "panel7";
            panel7.Size = new Size(180, 90);
            panel7.TabIndex = 12;
            // 
            // lbl_Orders
            // 
            lbl_Orders.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Orders.ForeColor = SystemColors.ButtonHighlight;
            lbl_Orders.Location = new Point(27, 38);
            lbl_Orders.Name = "lbl_Orders";
            lbl_Orders.Size = new Size(129, 36);
            lbl_Orders.TabIndex = 8;
            lbl_Orders.Text = "23";
            lbl_Orders.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel8
            // 
            panel8.Controls.Add(lbl_TotalProducts);
            panel8.Controls.Add(label1);
            panel8.Location = new Point(559, 277);
            panel8.Name = "panel8";
            panel8.Size = new Size(180, 90);
            panel8.TabIndex = 13;
            // 
            // lbl_TotalProducts
            // 
            lbl_TotalProducts.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_TotalProducts.ForeColor = SystemColors.ButtonHighlight;
            lbl_TotalProducts.Location = new Point(27, 38);
            lbl_TotalProducts.Name = "lbl_TotalProducts";
            lbl_TotalProducts.Size = new Size(129, 36);
            lbl_TotalProducts.TabIndex = 8;
            lbl_TotalProducts.Text = "320";
            lbl_TotalProducts.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 734);
            Controls.Add(panel1);
            Controls.Add(panel8);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel2);
            Controls.Add(data);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "DashboardForm";
            Text = "Store -POS";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)data).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel8.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button Btn_Produkt;
        private PictureBox pictureBox1;
        private DataGridView data;
        private Label label1;
        private Button btn_logout;
        private Button btn_Inventory;
        private Button btn_Sales;
        private Label label2;
        private Label label3;
        private Label label4;
        private Panel panel3;
        private Label label5;
        private Label label6;
        private DateTimePicker dateTimePicker1;
        private Panel panel2;
        private Panel panel5;
        private Label lbl_TotalSales;
        private Panel panel6;
        private Label lbl_Customers;
        private Panel panel7;
        private Label lbl_Orders;
        private Panel panel8;
        private Label lbl_TotalProducts;
    }
}