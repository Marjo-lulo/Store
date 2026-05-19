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
            dataGridView1 = new DataGridView();
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
            label7 = new Label();
            panel6 = new Panel();
            label8 = new Label();
            panel7 = new Panel();
            label9 = new Label();
            panel8 = new Panel();
            label11 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(231, 391);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(566, 340);
            dataGridView1.TabIndex = 3;
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
            panel5.Controls.Add(label7);
            panel5.Controls.Add(label2);
            panel5.Location = new Point(317, 151);
            panel5.Name = "panel5";
            panel5.Size = new Size(180, 90);
            panel5.TabIndex = 10;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(27, 38);
            label7.Name = "label7";
            label7.Size = new Size(129, 36);
            label7.TabIndex = 8;
            label7.Text = "$1200 ";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            panel6.Controls.Add(label8);
            panel6.Controls.Add(label3);
            panel6.Location = new Point(317, 277);
            panel6.Name = "panel6";
            panel6.Size = new Size(180, 90);
            panel6.TabIndex = 11;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(27, 45);
            label8.Name = "label8";
            label8.Size = new Size(129, 36);
            label8.TabIndex = 8;
            label8.Text = " 58 ";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            panel7.Controls.Add(label9);
            panel7.Controls.Add(label4);
            panel7.Location = new Point(559, 151);
            panel7.Name = "panel7";
            panel7.Size = new Size(180, 90);
            panel7.TabIndex = 12;
            // 
            // label9
            // 
            label9.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(27, 38);
            label9.Name = "label9";
            label9.Size = new Size(129, 36);
            label9.TabIndex = 8;
            label9.Text = "23";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel8
            // 
            panel8.Controls.Add(label11);
            panel8.Controls.Add(label1);
            panel8.Location = new Point(559, 277);
            panel8.Name = "panel8";
            panel8.Size = new Size(180, 90);
            panel8.TabIndex = 13;
            // 
            // label11
            // 
            label11.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.ButtonHighlight;
            label11.Location = new Point(27, 38);
            label11.Name = "label11";
            label11.Size = new Size(129, 36);
            label11.TabIndex = 8;
            label11.Text = "320";
            label11.TextAlign = ContentAlignment.MiddleCenter;
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
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "DashboardForm";
            Text = "Store -POS";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private DataGridView dataGridView1;
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
        private Label label7;
        private Panel panel6;
        private Label label8;
        private Panel panel7;
        private Label label9;
        private Panel panel8;
        private Label label11;
    }
}