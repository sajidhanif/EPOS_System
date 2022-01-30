namespace Shop_System
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmb_items = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_qty = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_sub = new System.Windows.Forms.TextBox();
            this.txt_discount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_net = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_paid = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_balance = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(26, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1169, 329);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cmb_items
            // 
            this.cmb_items.FormattingEnabled = true;
            this.cmb_items.Location = new System.Drawing.Point(379, 411);
            this.cmb_items.Name = "cmb_items";
            this.cmb_items.Size = new System.Drawing.Size(676, 45);
            this.cmb_items.TabIndex = 1;
            this.cmb_items.SelectedIndexChanged += new System.EventHandler(this.cmb_items_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 414);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Item";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(457, 364);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(137, 41);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Normal";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(641, 364);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(132, 41);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Special";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(185, 524);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(225, 43);
            this.txt_price.TabIndex = 5;
            this.txt_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 472);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 37);
            this.label2.TabIndex = 6;
            this.label2.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(538, 472);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 37);
            this.label3.TabIndex = 8;
            this.label3.Text = "Qty";
            // 
            // txt_qty
            // 
            this.txt_qty.Location = new System.Drawing.Point(463, 524);
            this.txt_qty.Name = "txt_qty";
            this.txt_qty.Size = new System.Drawing.Size(225, 43);
            this.txt_qty.TabIndex = 7;
            this.txt_qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_qty.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(812, 472);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 37);
            this.label4.TabIndex = 10;
            this.label4.Text = "Total";
            // 
            // txt_total
            // 
            this.txt_total.Location = new System.Drawing.Point(737, 524);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(225, 43);
            this.txt_total.TabIndex = 9;
            this.txt_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(995, 522);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 52);
            this.button1.TabIndex = 11;
            this.button1.Text = "Add Items";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(54, 662);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1046, 327);
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Item Name";
            this.columnHeader1.Width = 250;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Price";
            this.columnHeader2.Width = 75;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Qty";
            this.columnHeader3.Width = 75;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Total";
            this.columnHeader4.Width = 75;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 1040);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 37);
            this.label5.TabIndex = 13;
            this.label5.Text = "Sub Total";
            // 
            // txt_sub
            // 
            this.txt_sub.Location = new System.Drawing.Point(179, 1037);
            this.txt_sub.Name = "txt_sub";
            this.txt_sub.Size = new System.Drawing.Size(225, 43);
            this.txt_sub.TabIndex = 14;
            this.txt_sub.Text = "0";
            this.txt_sub.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_discount
            // 
            this.txt_discount.Location = new System.Drawing.Point(558, 1040);
            this.txt_discount.Name = "txt_discount";
            this.txt_discount.Size = new System.Drawing.Size(225, 43);
            this.txt_discount.TabIndex = 16;
            this.txt_discount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_discount.TextChanged += new System.EventHandler(this.txt_discount_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(431, 1040);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 37);
            this.label6.TabIndex = 15;
            this.label6.Text = "Discount";
            // 
            // txt_net
            // 
            this.txt_net.Location = new System.Drawing.Point(875, 1040);
            this.txt_net.Name = "txt_net";
            this.txt_net.Size = new System.Drawing.Size(225, 43);
            this.txt_net.TabIndex = 18;
            this.txt_net.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_net.TextChanged += new System.EventHandler(this.txt_net_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(809, 1040);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 37);
            this.label7.TabIndex = 17;
            this.label7.Text = "Net";
            // 
            // txt_paid
            // 
            this.txt_paid.Location = new System.Drawing.Point(875, 1117);
            this.txt_paid.Name = "txt_paid";
            this.txt_paid.Size = new System.Drawing.Size(225, 43);
            this.txt_paid.TabIndex = 20;
            this.txt_paid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_paid.TextChanged += new System.EventHandler(this.txt_paid_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(792, 1123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 37);
            this.label8.TabIndex = 19;
            this.label8.Text = "Paid";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(752, 1194);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 37);
            this.label9.TabIndex = 21;
            this.label9.Text = "Balance";
            // 
            // txt_balance
            // 
            this.txt_balance.Location = new System.Drawing.Point(875, 1188);
            this.txt_balance.Name = "txt_balance";
            this.txt_balance.Size = new System.Drawing.Size(225, 43);
            this.txt_balance.TabIndex = 22;
            this.txt_balance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(995, 595);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 52);
            this.button2.TabIndex = 23;
            this.button2.Text = "Remove Items";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 1279);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txt_balance);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_paid);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_net);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_discount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_sub);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_qty);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_items);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Shop System";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private ComboBox cmb_items;
        private Label label1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private TextBox txt_price;
        private Label label2;
        private Label label3;
        private TextBox txt_qty;
        private Label label4;
        private TextBox txt_total;
        private Button button1;
        private ListView listView1;
        private Label label5;
        private TextBox txt_sub;
        private TextBox txt_discount;
        private Label label6;
        private TextBox txt_net;
        private Label label7;
        private TextBox txt_paid;
        private Label label8;
        private Label label9;
        private TextBox txt_balance;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Button button2;
    }
}