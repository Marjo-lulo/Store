namespace StoreManager
{
    partial class ProductForm
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
            label1 = new Label();
            panel1 = new Panel();
            btn_update = new Button();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            btn_add = new Button();
            btn_clear = new Button();
            btn_delete = new Button();
            label6 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(183, 19);
            label1.Name = "label1";
            label1.Size = new Size(393, 41);
            label1.TabIndex = 0;
            label1.Text = " PRODUCT MANAGEMENT ";
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 79);
            panel1.TabIndex = 1;
            // 
            // btn_update
            // 
            btn_update.BackColor = SystemColors.ButtonHighlight;
            btn_update.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_update.Location = new Point(549, 184);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(94, 29);
            btn_update.TabIndex = 2;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(242, 126);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(223, 27);
            textBox1.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(242, 184);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(223, 28);
            comboBox1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 412);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(800, 200);
            dataGridView1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(61, 133);
            label2.Name = "label2";
            label2.Size = new Size(125, 23);
            label2.TabIndex = 5;
            label2.Text = "Product Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(61, 239);
            label3.Name = "label3";
            label3.Size = new Size(51, 23);
            label3.TabIndex = 6;
            label3.Text = "Price:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(61, 187);
            label4.Name = "label4";
            label4.Size = new Size(85, 23);
            label4.TabIndex = 7;
            label4.Text = "Category:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(61, 287);
            label5.Name = "label5";
            label5.Size = new Size(86, 23);
            label5.TabIndex = 8;
            label5.Text = "Quantity: ";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(242, 239);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(223, 27);
            textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(242, 289);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(223, 27);
            textBox3.TabIndex = 10;
            // 
            // btn_add
            // 
            btn_add.BackColor = SystemColors.ButtonHighlight;
            btn_add.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_add.Location = new Point(549, 125);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(94, 29);
            btn_add.TabIndex = 11;
            btn_add.Text = "Add ";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += button2_Click;
            // 
            // btn_clear
            // 
            btn_clear.BackColor = SystemColors.ButtonHighlight;
            btn_clear.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_clear.Location = new Point(549, 289);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(94, 29);
            btn_clear.TabIndex = 12;
            btn_clear.Text = "Clear";
            btn_clear.UseVisualStyleBackColor = false;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = SystemColors.ButtonHighlight;
            btn_delete.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_delete.Location = new Point(549, 235);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(94, 29);
            btn_delete.TabIndex = 13;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(61, 353);
            label6.Name = "label6";
            label6.Size = new Size(222, 41);
            label6.TabIndex = 14;
            label6.Text = "PRODUCT LIST";
            label6.Click += label6_Click;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 615);
            Controls.Add(label6);
            Controls.Add(btn_delete);
            Controls.Add(btn_clear);
            Controls.Add(btn_add);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(btn_update);
            Controls.Add(panel1);
            Name = "ProductForm";
            Text = "ProductForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Button btn_update;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button btn_add;
        private Button btn_clear;
        private Button btn_delete;
        private Label label6;
    }
}