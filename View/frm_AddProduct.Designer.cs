namespace Kotches.View
{
    partial class frm_AddProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_AddProduct));
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.combo_producttype = new System.Windows.Forms.ComboBox();
            this.txt_productPrice = new System.Windows.Forms.TextBox();
            this.txt_productCost = new System.Windows.Forms.TextBox();
            this.txt_productName = new System.Windows.Forms.TextBox();
            this.txt_productCode = new System.Windows.Forms.TextBox();
            this.combo_productColor = new System.Windows.Forms.ComboBox();
            this.combo_productSize = new System.Windows.Forms.ComboBox();
            this.combo_productNumber = new System.Windows.Forms.ComboBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Badiefont-Dima", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(228, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 32);
            this.label4.TabIndex = 60;
            this.label4.Text = "المعلومات الاساسية";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(274, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(179, 458);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Badiefont-Dima", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(84, 236);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 29);
            this.label9.TabIndex = 62;
            this.label9.Text = "سعر البيع";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Badiefont-Dima", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(55, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 29);
            this.label8.TabIndex = 61;
            this.label8.Text = "تكلفة المنتج";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Badiefont-Dima", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(116, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 29);
            this.label3.TabIndex = 57;
            this.label3.Text = "الفئة";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Badiefont-Dima", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(66, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 29);
            this.label2.TabIndex = 56;
            this.label2.Text = "كود المنتج";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Badiefont-Dima", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(142, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 29);
            this.label1.TabIndex = 55;
            this.label1.Text = "م";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Badiefont-Dima", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(116, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 29);
            this.label6.TabIndex = 59;
            this.label6.Text = "اللون";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Badiefont-Dima", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(96, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 29);
            this.label5.TabIndex = 58;
            this.label5.Text = "المقاس";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Badiefont-Dima", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(110, 391);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 29);
            this.label7.TabIndex = 60;
            this.label7.Text = "العدد";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.combo_producttype);
            this.groupBox2.Controls.Add(this.txt_productPrice);
            this.groupBox2.Controls.Add(this.txt_productCost);
            this.groupBox2.Controls.Add(this.txt_productName);
            this.groupBox2.Controls.Add(this.txt_productCode);
            this.groupBox2.Controls.Add(this.combo_productColor);
            this.groupBox2.Controls.Add(this.combo_productSize);
            this.groupBox2.Controls.Add(this.combo_productNumber);
            this.groupBox2.Location = new System.Drawing.Point(29, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(222, 458);
            this.groupBox2.TabIndex = 61;
            this.groupBox2.TabStop = false;
            // 
            // combo_producttype
            // 
            this.combo_producttype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_producttype.FormattingEnabled = true;
            this.combo_producttype.Items.AddRange(new object[] {
            "اطفالي",
            "شبابي",
            "بناتي",
            "محير",
            "حريمي",
            "رجالي",
            "اولادي"});
            this.combo_producttype.Location = new System.Drawing.Point(39, 137);
            this.combo_producttype.Name = "combo_producttype";
            this.combo_producttype.Size = new System.Drawing.Size(159, 21);
            this.combo_producttype.TabIndex = 9;
            // 
            // txt_productPrice
            // 
            this.txt_productPrice.Location = new System.Drawing.Point(39, 243);
            this.txt_productPrice.Name = "txt_productPrice";
            this.txt_productPrice.Size = new System.Drawing.Size(159, 20);
            this.txt_productPrice.TabIndex = 5;
            // 
            // txt_productCost
            // 
            this.txt_productCost.Location = new System.Drawing.Point(39, 193);
            this.txt_productCost.Name = "txt_productCost";
            this.txt_productCost.Size = new System.Drawing.Size(159, 20);
            this.txt_productCost.TabIndex = 4;
            // 
            // txt_productName
            // 
            this.txt_productName.Location = new System.Drawing.Point(39, 82);
            this.txt_productName.Name = "txt_productName";
            this.txt_productName.Size = new System.Drawing.Size(159, 20);
            this.txt_productName.TabIndex = 2;
            // 
            // txt_productCode
            // 
            this.txt_productCode.Location = new System.Drawing.Point(39, 29);
            this.txt_productCode.Name = "txt_productCode";
            this.txt_productCode.ReadOnly = true;
            this.txt_productCode.Size = new System.Drawing.Size(159, 20);
            this.txt_productCode.TabIndex = 1;
            // 
            // combo_productColor
            // 
            this.combo_productColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_productColor.FormattingEnabled = true;
            this.combo_productColor.Items.AddRange(new object[] {
            "أبيض",
            "أسود",
            "أصفر",
            "بني",
            "بيج",
            "أحمر",
            "وردي",
            "برتقالي",
            "أخضر",
            "بنفسجي",
            "رمادي",
            "أزرق",
            "ارجواني",
            "ليموني"});
            this.combo_productColor.Location = new System.Drawing.Point(39, 301);
            this.combo_productColor.Name = "combo_productColor";
            this.combo_productColor.Size = new System.Drawing.Size(159, 21);
            this.combo_productColor.TabIndex = 6;
            // 
            // combo_productSize
            // 
            this.combo_productSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_productSize.FormattingEnabled = true;
            this.combo_productSize.Items.AddRange(new object[] {
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49"});
            this.combo_productSize.Location = new System.Drawing.Point(39, 352);
            this.combo_productSize.Name = "combo_productSize";
            this.combo_productSize.Size = new System.Drawing.Size(159, 21);
            this.combo_productSize.TabIndex = 7;
            // 
            // combo_productNumber
            // 
            this.combo_productNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_productNumber.FormattingEnabled = true;
            this.combo_productNumber.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13"});
            this.combo_productNumber.Location = new System.Drawing.Point(39, 399);
            this.combo_productNumber.Name = "combo_productNumber";
            this.combo_productNumber.Size = new System.Drawing.Size(159, 21);
            this.combo_productNumber.TabIndex = 8;
            // 
            // btn_exit
            // 
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_exit.Font = new System.Drawing.Font("Badiefont-Dima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_exit.ForeColor = System.Drawing.Color.White;
            this.btn_exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_exit.Image")));
            this.btn_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_exit.Location = new System.Drawing.Point(39, 18);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(159, 52);
            this.btn_exit.TabIndex = 10;
            this.btn_exit.Text = "خروج";
            this.btn_exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_save
            // 
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_save.Font = new System.Drawing.Font("Badiefont-Dima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Image = ((System.Drawing.Image)(resources.GetObject("btn_save.Image")));
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.Location = new System.Drawing.Point(203, 19);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(183, 51);
            this.btn_save.TabIndex = 9;
            this.btn_save.Text = "حفظ";
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_exit);
            this.groupBox4.Controls.Add(this.btn_save);
            this.groupBox4.Location = new System.Drawing.Point(29, 524);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(424, 94);
            this.groupBox4.TabIndex = 62;
            this.groupBox4.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(459, 605);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(10, 13);
            this.dataGridView1.TabIndex = 63;
            this.dataGridView1.Visible = false;
            // 
            // frm_AddProduct
            // 
            this.AcceptButton = this.btn_save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(477, 626);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.Name = "frm_AddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_AddProduct";
            this.Load += new System.EventHandler(this.frm_AddProduct_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.GroupBox groupBox4;
        public System.Windows.Forms.ComboBox combo_productSize;
        public System.Windows.Forms.ComboBox combo_productColor;
        public System.Windows.Forms.ComboBox combo_productNumber;
        public System.Windows.Forms.ComboBox combo_producttype;
        public System.Windows.Forms.TextBox txt_productPrice;
        public System.Windows.Forms.TextBox txt_productCost;
        public System.Windows.Forms.TextBox txt_productName;
        public System.Windows.Forms.TextBox txt_productCode;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}