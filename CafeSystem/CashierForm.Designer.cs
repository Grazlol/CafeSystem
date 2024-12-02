namespace CafeSystem
{
    partial class CashierForm
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.itemVar = new System.Windows.Forms.ComboBox();
            this.itemCat = new System.Windows.Forms.ComboBox();
            this.milktea_panel = new System.Windows.Forms.Panel();
            this.item_btn16 = new System.Windows.Forms.Button();
            this.item_btn15 = new System.Windows.Forms.Button();
            this.item_btn14 = new System.Windows.Forms.Button();
            this.item_btn13 = new System.Windows.Forms.Button();
            this.item_btn12 = new System.Windows.Forms.Button();
            this.item_btn11 = new System.Windows.Forms.Button();
            this.item_btn10 = new System.Windows.Forms.Button();
            this.item_btn9 = new System.Windows.Forms.Button();
            this.item_btn8 = new System.Windows.Forms.Button();
            this.item_btn7 = new System.Windows.Forms.Button();
            this.item_btn6 = new System.Windows.Forms.Button();
            this.item_btn5 = new System.Windows.Forms.Button();
            this.item_btn4 = new System.Windows.Forms.Button();
            this.item_btn3 = new System.Windows.Forms.Button();
            this.item_btn2 = new System.Windows.Forms.Button();
            this.item_btn1 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.desc_bar = new System.Windows.Forms.TextBox();
            this.reorderbut = new System.Windows.Forms.Button();
            this.txt_qty = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.adorderbut = new System.Windows.Forms.Button();
            this.btn_placeOrder = new System.Windows.Forms.Button();
            this.btn_resetOrder = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_50 = new System.Windows.Forms.Button();
            this.btn_100 = new System.Windows.Forms.Button();
            this.btn_200 = new System.Windows.Forms.Button();
            this.btn_500 = new System.Windows.Forms.Button();
            this.btn_1000 = new System.Windows.Forms.Button();
            this.txt_amountPay = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_change = new System.Windows.Forms.TextBox();
            this.btn_20 = new System.Windows.Forms.Button();
            this.btn_clearAmount = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_customerName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_totalPrice = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.milktea_panel.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_qty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.itemVar);
            this.panel1.Controls.Add(this.itemCat);
            this.panel1.Controls.Add(this.milktea_panel);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Location = new System.Drawing.Point(-1, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(516, 555);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(266, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 34);
            this.label11.TabIndex = 26;
            this.label11.Text = "Variant";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(9, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 34);
            this.label3.TabIndex = 25;
            this.label3.Text = "Category";
            // 
            // itemVar
            // 
            this.itemVar.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemVar.FormattingEnabled = true;
            this.itemVar.Location = new System.Drawing.Point(267, 64);
            this.itemVar.Name = "itemVar";
            this.itemVar.Size = new System.Drawing.Size(238, 39);
            this.itemVar.TabIndex = 8;
            // 
            // itemCat
            // 
            this.itemCat.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemCat.FormattingEnabled = true;
            this.itemCat.Location = new System.Drawing.Point(4, 64);
            this.itemCat.Name = "itemCat";
            this.itemCat.Size = new System.Drawing.Size(257, 39);
            this.itemCat.TabIndex = 7;
            this.itemCat.TextChanged += new System.EventHandler(this.itemCat_TextChanged);
            // 
            // milktea_panel
            // 
            this.milktea_panel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.milktea_panel.Controls.Add(this.item_btn16);
            this.milktea_panel.Controls.Add(this.item_btn15);
            this.milktea_panel.Controls.Add(this.item_btn14);
            this.milktea_panel.Controls.Add(this.item_btn13);
            this.milktea_panel.Controls.Add(this.item_btn12);
            this.milktea_panel.Controls.Add(this.item_btn11);
            this.milktea_panel.Controls.Add(this.item_btn10);
            this.milktea_panel.Controls.Add(this.item_btn9);
            this.milktea_panel.Controls.Add(this.item_btn8);
            this.milktea_panel.Controls.Add(this.item_btn7);
            this.milktea_panel.Controls.Add(this.item_btn6);
            this.milktea_panel.Controls.Add(this.item_btn5);
            this.milktea_panel.Controls.Add(this.item_btn4);
            this.milktea_panel.Controls.Add(this.item_btn3);
            this.milktea_panel.Controls.Add(this.item_btn2);
            this.milktea_panel.Controls.Add(this.item_btn1);
            this.milktea_panel.Location = new System.Drawing.Point(15, 111);
            this.milktea_panel.Name = "milktea_panel";
            this.milktea_panel.Size = new System.Drawing.Size(492, 275);
            this.milktea_panel.TabIndex = 6;
            this.milktea_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.milktea_panel_Paint);
            // 
            // item_btn16
            // 
            this.item_btn16.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_btn16.Location = new System.Drawing.Point(370, 198);
            this.item_btn16.Name = "item_btn16";
            this.item_btn16.Size = new System.Drawing.Size(113, 56);
            this.item_btn16.TabIndex = 15;
            this.item_btn16.UseVisualStyleBackColor = true;
            this.item_btn16.Click += new System.EventHandler(this.item_btn16_Click);
            // 
            // item_btn15
            // 
            this.item_btn15.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_btn15.Location = new System.Drawing.Point(251, 198);
            this.item_btn15.Name = "item_btn15";
            this.item_btn15.Size = new System.Drawing.Size(113, 56);
            this.item_btn15.TabIndex = 14;
            this.item_btn15.UseVisualStyleBackColor = true;
            this.item_btn15.Click += new System.EventHandler(this.item_btn15_Click);
            // 
            // item_btn14
            // 
            this.item_btn14.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_btn14.Location = new System.Drawing.Point(131, 198);
            this.item_btn14.Name = "item_btn14";
            this.item_btn14.Size = new System.Drawing.Size(113, 56);
            this.item_btn14.TabIndex = 13;
            this.item_btn14.UseVisualStyleBackColor = true;
            this.item_btn14.Click += new System.EventHandler(this.item_btn14_Click);
            // 
            // item_btn13
            // 
            this.item_btn13.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_btn13.Location = new System.Drawing.Point(12, 198);
            this.item_btn13.Name = "item_btn13";
            this.item_btn13.Size = new System.Drawing.Size(113, 56);
            this.item_btn13.TabIndex = 12;
            this.item_btn13.UseVisualStyleBackColor = true;
            this.item_btn13.Click += new System.EventHandler(this.item_btn13_Click);
            // 
            // item_btn12
            // 
            this.item_btn12.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_btn12.Location = new System.Drawing.Point(370, 136);
            this.item_btn12.Name = "item_btn12";
            this.item_btn12.Size = new System.Drawing.Size(113, 56);
            this.item_btn12.TabIndex = 11;
            this.item_btn12.UseVisualStyleBackColor = true;
            this.item_btn12.Click += new System.EventHandler(this.item_btn12_Click);
            // 
            // item_btn11
            // 
            this.item_btn11.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_btn11.Location = new System.Drawing.Point(251, 136);
            this.item_btn11.Name = "item_btn11";
            this.item_btn11.Size = new System.Drawing.Size(113, 56);
            this.item_btn11.TabIndex = 10;
            this.item_btn11.UseVisualStyleBackColor = true;
            this.item_btn11.Click += new System.EventHandler(this.item_btn11_Click);
            // 
            // item_btn10
            // 
            this.item_btn10.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_btn10.Location = new System.Drawing.Point(131, 136);
            this.item_btn10.Name = "item_btn10";
            this.item_btn10.Size = new System.Drawing.Size(113, 56);
            this.item_btn10.TabIndex = 9;
            this.item_btn10.UseVisualStyleBackColor = true;
            this.item_btn10.Click += new System.EventHandler(this.item_btn10_Click);
            // 
            // item_btn9
            // 
            this.item_btn9.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_btn9.Location = new System.Drawing.Point(12, 136);
            this.item_btn9.Name = "item_btn9";
            this.item_btn9.Size = new System.Drawing.Size(113, 56);
            this.item_btn9.TabIndex = 8;
            this.item_btn9.UseVisualStyleBackColor = true;
            this.item_btn9.Click += new System.EventHandler(this.item_btn9_Click);
            // 
            // item_btn8
            // 
            this.item_btn8.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_btn8.Location = new System.Drawing.Point(370, 74);
            this.item_btn8.Name = "item_btn8";
            this.item_btn8.Size = new System.Drawing.Size(113, 56);
            this.item_btn8.TabIndex = 7;
            this.item_btn8.UseVisualStyleBackColor = true;
            this.item_btn8.Click += new System.EventHandler(this.item_btn8_Click);
            // 
            // item_btn7
            // 
            this.item_btn7.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_btn7.Location = new System.Drawing.Point(251, 74);
            this.item_btn7.Name = "item_btn7";
            this.item_btn7.Size = new System.Drawing.Size(113, 56);
            this.item_btn7.TabIndex = 6;
            this.item_btn7.UseVisualStyleBackColor = true;
            this.item_btn7.Click += new System.EventHandler(this.item_btn7_Click);
            // 
            // item_btn6
            // 
            this.item_btn6.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_btn6.Location = new System.Drawing.Point(131, 74);
            this.item_btn6.Name = "item_btn6";
            this.item_btn6.Size = new System.Drawing.Size(113, 56);
            this.item_btn6.TabIndex = 5;
            this.item_btn6.UseVisualStyleBackColor = true;
            this.item_btn6.Click += new System.EventHandler(this.item_btn6_Click);
            // 
            // item_btn5
            // 
            this.item_btn5.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_btn5.Location = new System.Drawing.Point(12, 74);
            this.item_btn5.Name = "item_btn5";
            this.item_btn5.Size = new System.Drawing.Size(113, 56);
            this.item_btn5.TabIndex = 4;
            this.item_btn5.UseVisualStyleBackColor = true;
            this.item_btn5.Click += new System.EventHandler(this.item_btn5_Click);
            // 
            // item_btn4
            // 
            this.item_btn4.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_btn4.Location = new System.Drawing.Point(370, 12);
            this.item_btn4.Name = "item_btn4";
            this.item_btn4.Size = new System.Drawing.Size(113, 56);
            this.item_btn4.TabIndex = 3;
            this.item_btn4.UseVisualStyleBackColor = true;
            this.item_btn4.Click += new System.EventHandler(this.item_btn4_Click);
            // 
            // item_btn3
            // 
            this.item_btn3.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_btn3.Location = new System.Drawing.Point(251, 12);
            this.item_btn3.Name = "item_btn3";
            this.item_btn3.Size = new System.Drawing.Size(113, 58);
            this.item_btn3.TabIndex = 2;
            this.item_btn3.UseVisualStyleBackColor = true;
            this.item_btn3.Click += new System.EventHandler(this.item_btn3_Click);
            // 
            // item_btn2
            // 
            this.item_btn2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_btn2.Location = new System.Drawing.Point(132, 12);
            this.item_btn2.Name = "item_btn2";
            this.item_btn2.Size = new System.Drawing.Size(113, 56);
            this.item_btn2.TabIndex = 1;
            this.item_btn2.UseVisualStyleBackColor = true;
            this.item_btn2.Click += new System.EventHandler(this.item_btn2_Click);
            // 
            // item_btn1
            // 
            this.item_btn1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_btn1.Location = new System.Drawing.Point(12, 12);
            this.item_btn1.Name = "item_btn1";
            this.item_btn1.Size = new System.Drawing.Size(113, 56);
            this.item_btn1.TabIndex = 0;
            this.item_btn1.UseVisualStyleBackColor = true;
            this.item_btn1.Click += new System.EventHandler(this.item_btn1_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel6.Controls.Add(this.txt_price);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.desc_bar);
            this.panel6.Controls.Add(this.reorderbut);
            this.panel6.Controls.Add(this.txt_qty);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Controls.Add(this.adorderbut);
            this.panel6.Location = new System.Drawing.Point(15, 404);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(492, 127);
            this.panel6.TabIndex = 5;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // txt_price
            // 
            this.txt_price.Enabled = false;
            this.txt_price.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_price.Location = new System.Drawing.Point(80, 75);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(110, 35);
            this.txt_price.TabIndex = 24;
            this.txt_price.Text = "0";
            this.txt_price.TextChanged += new System.EventHandler(this.textBox3_TextChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(21, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Price:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(29, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Desc:";
            // 
            // desc_bar
            // 
            this.desc_bar.Enabled = false;
            this.desc_bar.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desc_bar.Location = new System.Drawing.Point(80, 5);
            this.desc_bar.Name = "desc_bar";
            this.desc_bar.Size = new System.Drawing.Size(403, 35);
            this.desc_bar.TabIndex = 21;
            this.desc_bar.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // reorderbut
            // 
            this.reorderbut.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reorderbut.ForeColor = System.Drawing.Color.Crimson;
            this.reorderbut.Location = new System.Drawing.Point(347, 75);
            this.reorderbut.Name = "reorderbut";
            this.reorderbut.Size = new System.Drawing.Size(136, 34);
            this.reorderbut.TabIndex = 17;
            this.reorderbut.Text = "REMOVE ORDER";
            this.reorderbut.UseVisualStyleBackColor = true;
            this.reorderbut.Click += new System.EventHandler(this.reorderbut_Click);
            // 
            // txt_qty
            // 
            this.txt_qty.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_qty.Location = new System.Drawing.Point(80, 40);
            this.txt_qty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txt_qty.Name = "txt_qty";
            this.txt_qty.Size = new System.Drawing.Size(72, 35);
            this.txt_qty.TabIndex = 16;
            this.txt_qty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txt_qty.ValueChanged += new System.EventHandler(this.txt_qty_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(3, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 17);
            this.label10.TabIndex = 7;
            this.label10.Text = "Quantity:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // adorderbut
            // 
            this.adorderbut.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adorderbut.ForeColor = System.Drawing.Color.ForestGreen;
            this.adorderbut.Location = new System.Drawing.Point(347, 41);
            this.adorderbut.Name = "adorderbut";
            this.adorderbut.Size = new System.Drawing.Size(136, 34);
            this.adorderbut.TabIndex = 11;
            this.adorderbut.Text = "ADD ORDER";
            this.adorderbut.UseVisualStyleBackColor = true;
            this.adorderbut.Click += new System.EventHandler(this.adorderbut_Click);
            // 
            // btn_placeOrder
            // 
            this.btn_placeOrder.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_placeOrder.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_placeOrder.Location = new System.Drawing.Point(966, 509);
            this.btn_placeOrder.Name = "btn_placeOrder";
            this.btn_placeOrder.Size = new System.Drawing.Size(121, 34);
            this.btn_placeOrder.TabIndex = 18;
            this.btn_placeOrder.Text = "PLACE ORDER";
            this.btn_placeOrder.UseVisualStyleBackColor = true;
            this.btn_placeOrder.Click += new System.EventHandler(this.button18_Click);
            // 
            // btn_resetOrder
            // 
            this.btn_resetOrder.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_resetOrder.ForeColor = System.Drawing.Color.Crimson;
            this.btn_resetOrder.Location = new System.Drawing.Point(830, 509);
            this.btn_resetOrder.Name = "btn_resetOrder";
            this.btn_resetOrder.Size = new System.Drawing.Size(130, 34);
            this.btn_resetOrder.TabIndex = 18;
            this.btn_resetOrder.Text = "RESET ORDER";
            this.btn_resetOrder.UseVisualStyleBackColor = true;
            this.btn_resetOrder.Click += new System.EventHandler(this.button34_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 33;
            this.timer1.Tick += new System.EventHandler(this._process);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(521, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(567, 327);
            this.dataGridView1.TabIndex = 19;
            // 
            // btn_50
            // 
            this.btn_50.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_50.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_50.Location = new System.Drawing.Point(606, 431);
            this.btn_50.Name = "btn_50";
            this.btn_50.Size = new System.Drawing.Size(71, 49);
            this.btn_50.TabIndex = 20;
            this.btn_50.Text = "₱50";
            this.btn_50.UseVisualStyleBackColor = true;
            this.btn_50.Click += new System.EventHandler(this.btn_50_Click);
            // 
            // btn_100
            // 
            this.btn_100.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_100.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_100.Location = new System.Drawing.Point(683, 431);
            this.btn_100.Name = "btn_100";
            this.btn_100.Size = new System.Drawing.Size(71, 49);
            this.btn_100.TabIndex = 21;
            this.btn_100.Text = "₱100";
            this.btn_100.UseVisualStyleBackColor = true;
            this.btn_100.Click += new System.EventHandler(this.btn_100_Click);
            // 
            // btn_200
            // 
            this.btn_200.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_200.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_200.Location = new System.Drawing.Point(760, 431);
            this.btn_200.Name = "btn_200";
            this.btn_200.Size = new System.Drawing.Size(71, 49);
            this.btn_200.TabIndex = 22;
            this.btn_200.Text = "₱200";
            this.btn_200.UseVisualStyleBackColor = true;
            this.btn_200.Click += new System.EventHandler(this.btn_200_Click);
            // 
            // btn_500
            // 
            this.btn_500.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_500.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_500.Location = new System.Drawing.Point(837, 432);
            this.btn_500.Name = "btn_500";
            this.btn_500.Size = new System.Drawing.Size(71, 49);
            this.btn_500.TabIndex = 23;
            this.btn_500.Text = "₱500";
            this.btn_500.UseVisualStyleBackColor = true;
            this.btn_500.Click += new System.EventHandler(this.btn_500_Click);
            // 
            // btn_1000
            // 
            this.btn_1000.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_1000.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_1000.Location = new System.Drawing.Point(914, 431);
            this.btn_1000.Name = "btn_1000";
            this.btn_1000.Size = new System.Drawing.Size(71, 49);
            this.btn_1000.TabIndex = 24;
            this.btn_1000.Text = "₱1000";
            this.btn_1000.UseVisualStyleBackColor = true;
            this.btn_1000.Click += new System.EventHandler(this.btn_1000_Click);
            // 
            // txt_amountPay
            // 
            this.txt_amountPay.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_amountPay.Location = new System.Drawing.Point(536, 511);
            this.txt_amountPay.Name = "txt_amountPay";
            this.txt_amountPay.Size = new System.Drawing.Size(119, 35);
            this.txt_amountPay.TabIndex = 26;
            this.txt_amountPay.TextChanged += new System.EventHandler(this.txt_amountPay_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(535, 490);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "Amount to Pay:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(679, 490);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 17);
            this.label6.TabIndex = 27;
            this.label6.Text = "Change:";
            // 
            // txt_change
            // 
            this.txt_change.Enabled = false;
            this.txt_change.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_change.Location = new System.Drawing.Point(682, 510);
            this.txt_change.Name = "txt_change";
            this.txt_change.Size = new System.Drawing.Size(128, 35);
            this.txt_change.TabIndex = 28;
            this.txt_change.TextChanged += new System.EventHandler(this.txt_change_TextChanged);
            // 
            // btn_20
            // 
            this.btn_20.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_20.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_20.Location = new System.Drawing.Point(529, 431);
            this.btn_20.Name = "btn_20";
            this.btn_20.Size = new System.Drawing.Size(71, 49);
            this.btn_20.TabIndex = 29;
            this.btn_20.Text = "₱20";
            this.btn_20.UseVisualStyleBackColor = true;
            this.btn_20.Click += new System.EventHandler(this.btn_20_Click);
            // 
            // btn_clearAmount
            // 
            this.btn_clearAmount.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clearAmount.ForeColor = System.Drawing.Color.Indigo;
            this.btn_clearAmount.Location = new System.Drawing.Point(991, 431);
            this.btn_clearAmount.Name = "btn_clearAmount";
            this.btn_clearAmount.Size = new System.Drawing.Size(96, 49);
            this.btn_clearAmount.TabIndex = 30;
            this.btn_clearAmount.Text = "Clear Amount";
            this.btn_clearAmount.UseVisualStyleBackColor = true;
            this.btn_clearAmount.Click += new System.EventHandler(this.btn_clearAmount_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(528, 408);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 17);
            this.label7.TabIndex = 31;
            this.label7.Text = "Payment:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(528, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 17);
            this.label4.TabIndex = 32;
            this.label4.Text = "Customer Name:";
            // 
            // txt_customerName
            // 
            this.txt_customerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_customerName.Location = new System.Drawing.Point(531, 364);
            this.txt_customerName.Name = "txt_customerName";
            this.txt_customerName.Size = new System.Drawing.Size(300, 35);
            this.txt_customerName.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(834, 342);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 17);
            this.label8.TabIndex = 34;
            this.label8.Text = "Total Price:";
            // 
            // txt_totalPrice
            // 
            this.txt_totalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_totalPrice.Location = new System.Drawing.Point(837, 364);
            this.txt_totalPrice.Name = "txt_totalPrice";
            this.txt_totalPrice.Size = new System.Drawing.Size(250, 35);
            this.txt_totalPrice.TabIndex = 35;
            // 
            // CashierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1100, 557);
            this.Controls.Add(this.txt_totalPrice);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_customerName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_clearAmount);
            this.Controls.Add(this.btn_20);
            this.Controls.Add(this.txt_change);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_amountPay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_1000);
            this.Controls.Add(this.btn_500);
            this.Controls.Add(this.btn_200);
            this.Controls.Add(this.btn_100);
            this.Controls.Add(this.btn_50);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_resetOrder);
            this.Controls.Add(this.btn_placeOrder);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CashierForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cashier";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CashierForm_FormClosing);
            this.Load += new System.EventHandler(this.CashierForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.milktea_panel.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_qty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button adorderbut;
        private System.Windows.Forms.NumericUpDown txt_qty;
        private System.Windows.Forms.Panel milktea_panel;
        private System.Windows.Forms.Button item_btn16;
        private System.Windows.Forms.Button item_btn15;
        private System.Windows.Forms.Button item_btn14;
        private System.Windows.Forms.Button item_btn13;
        private System.Windows.Forms.Button item_btn12;
        private System.Windows.Forms.Button item_btn11;
        private System.Windows.Forms.Button item_btn10;
        private System.Windows.Forms.Button item_btn9;
        private System.Windows.Forms.Button item_btn8;
        private System.Windows.Forms.Button item_btn7;
        private System.Windows.Forms.Button item_btn6;
        private System.Windows.Forms.Button item_btn5;
        private System.Windows.Forms.Button item_btn4;
        private System.Windows.Forms.Button item_btn3;
        private System.Windows.Forms.Button item_btn2;
        private System.Windows.Forms.Button item_btn1;
        private System.Windows.Forms.Button btn_placeOrder;
        private System.Windows.Forms.Button btn_resetOrder;
        private System.Windows.Forms.TextBox desc_bar;
        private System.Windows.Forms.ComboBox itemCat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox itemVar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button reorderbut;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_50;
        private System.Windows.Forms.Button btn_100;
        private System.Windows.Forms.Button btn_200;
        private System.Windows.Forms.Button btn_500;
        private System.Windows.Forms.Button btn_1000;
        private System.Windows.Forms.TextBox txt_amountPay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_change;
        private System.Windows.Forms.Button btn_20;
        private System.Windows.Forms.Button btn_clearAmount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_customerName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_totalPrice;
    }
}