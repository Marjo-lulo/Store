namespace StoreManager
{
    partial class SalesForm
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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            btn_AddP = new Button();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            label5 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            btn_checkout = new Button();
            btn_receipt = new Button();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(799, 80);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(277, 19);
            label1.Name = "label1";
            label1.Size = new Size(213, 46);
            label1.TabIndex = 1;
            label1.Text = "SALES / POS";
            label1.Click += label1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(27, 252);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(741, 134);
            dataGridView1.TabIndex = 2;
            // 
            // btn_AddP
            // 
            btn_AddP.BackColor = SystemColors.ButtonHighlight;
            btn_AddP.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_AddP.Location = new Point(530, 131);
            btn_AddP.Name = "btn_AddP";
            btn_AddP.Size = new Size(111, 29);
            btn_AddP.TabIndex = 3;
            btn_AddP.Text = "Add Product";
            btn_AddP.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(231, 76);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(179, 28);
            comboBox1.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(264, 132);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(230, 27);
            textBox1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(123, 133);
            label2.Name = "label2";
            label2.Size = new Size(130, 23);
            label2.TabIndex = 6;
            label2.Text = "Product Search:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(295, 207);
            label3.Name = "label3";
            label3.Size = new Size(172, 28);
            label3.TabIndex = 7;
            label3.Text = " SHOPPING CART";
            // 
            // panel2
            // 
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(comboBox1);
            panel2.Location = new Point(1, 533);
            panel2.Name = "panel2";
            panel2.Size = new Size(799, 131);
            panel2.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(68, 77);
            label5.Name = "label5";
            label5.Size = new Size(153, 23);
            label5.TabIndex = 9;
            label5.Text = " Payment Method:";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(68, 29);
            label4.Name = "label4";
            label4.Size = new Size(139, 23);
            label4.TabIndex = 9;
            label4.Text = "Customer Name:";
            label4.Click += label4_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(217, 29);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(193, 27);
            textBox2.TabIndex = 9;
            // 
            // btn_checkout
            // 
            btn_checkout.BackColor = SystemColors.ButtonHighlight;
            btn_checkout.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_checkout.Location = new Point(207, 435);
            btn_checkout.Name = "btn_checkout";
            btn_checkout.Size = new Size(110, 45);
            btn_checkout.TabIndex = 9;
            btn_checkout.Text = " Checkout ";
            btn_checkout.UseVisualStyleBackColor = false;
            // 
            // btn_receipt
            // 
            btn_receipt.BackColor = SystemColors.ButtonHighlight;
            btn_receipt.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_receipt.Location = new Point(351, 435);
            btn_receipt.Name = "btn_receipt";
            btn_receipt.Size = new Size(116, 45);
            btn_receipt.TabIndex = 10;
            btn_receipt.Text = "Print Receipt";
            btn_receipt.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(530, 412);
            label6.Name = "label6";
            label6.Size = new Size(74, 20);
            label6.TabIndex = 11;
            label6.Text = "Subtotal :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(608, 412);
            label7.Name = "label7";
            label7.Size = new Size(33, 20);
            label7.TabIndex = 12;
            label7.Text = "$95";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(530, 447);
            label8.Name = "label8";
            label8.Size = new Size(75, 20);
            label8.TabIndex = 13;
            label8.Text = "Tax (5%) :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(607, 447);
            label9.Name = "label9";
            label9.Size = new Size(46, 20);
            label9.TabIndex = 14;
            label9.Text = "$4.75";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(530, 479);
            label10.Name = "label10";
            label10.Size = new Size(70, 20);
            label10.TabIndex = 15;
            label10.Text = "Total      :";
            label10.Click += label10_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(608, 479);
            label11.Name = "label11";
            label11.Size = new Size(53, 20);
            label11.TabIndex = 16;
            label11.Text = "$99.75";
            // 
            // SalesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 661);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(btn_receipt);
            Controls.Add(btn_checkout);
            Controls.Add(panel2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(btn_AddP);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "SalesForm";
            Text = "SalesForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView dataGridView1;
        private Button btn_AddP;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private Panel panel2;
        private Label label4;
        private TextBox textBox2;
        private Label label5;
        private Button btn_checkout;
        private Button btn_receipt;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
    }
}