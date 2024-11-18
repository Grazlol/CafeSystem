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
            this.item_btn09 = new System.Windows.Forms.Button();
            this.item_btn08 = new System.Windows.Forms.Button();
            this.item_btn07 = new System.Windows.Forms.Button();
            this.item_btn06 = new System.Windows.Forms.Button();
            this.item_btn05 = new System.Windows.Forms.Button();
            this.item_btn04 = new System.Windows.Forms.Button();
            this.item_btn03 = new System.Windows.Forms.Button();
            this.item_btn02 = new System.Windows.Forms.Button();
            this.item_btn01 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.button17 = new System.Windows.Forms.Button();
            this.txt_qty = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.button19 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button34 = new System.Windows.Forms.Button();
            this.itemreceipt = new System.Windows.Forms.DataGridView();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.milktea_panel.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_qty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemreceipt)).BeginInit();
            this.panel4.SuspendLayout();
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
            this.label11.Location = new System.Drawing.Point(266, 33);
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
            this.label3.Location = new System.Drawing.Point(9, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 34);
            this.label3.TabIndex = 25;
            this.label3.Text = "Category";
            // 
            // itemVar
            // 
            this.itemVar.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemVar.FormattingEnabled = true;
            this.itemVar.Location = new System.Drawing.Point(267, 83);
            this.itemVar.Name = "itemVar";
            this.itemVar.Size = new System.Drawing.Size(238, 39);
            this.itemVar.TabIndex = 8;
            // 
            // itemCat
            // 
            this.itemCat.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemCat.FormattingEnabled = true;
            this.itemCat.Location = new System.Drawing.Point(4, 84);
            this.itemCat.Name = "itemCat";
            this.itemCat.Size = new System.Drawing.Size(257, 39);
            this.itemCat.TabIndex = 7;
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
            this.milktea_panel.Controls.Add(this.item_btn09);
            this.milktea_panel.Controls.Add(this.item_btn08);
            this.milktea_panel.Controls.Add(this.item_btn07);
            this.milktea_panel.Controls.Add(this.item_btn06);
            this.milktea_panel.Controls.Add(this.item_btn05);
            this.milktea_panel.Controls.Add(this.item_btn04);
            this.milktea_panel.Controls.Add(this.item_btn03);
            this.milktea_panel.Controls.Add(this.item_btn02);
            this.milktea_panel.Controls.Add(this.item_btn01);
            this.milktea_panel.Location = new System.Drawing.Point(16, 145);
            this.milktea_panel.Name = "milktea_panel";
            this.milktea_panel.Size = new System.Drawing.Size(492, 275);
            this.milktea_panel.TabIndex = 6;
            this.milktea_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.milktea_panel_Paint);
            // 
            // item_btn16
            // 
            this.item_btn16.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_btn16.Location = new System.Drawing.Point(370, 187);
            this.item_btn16.Name = "item_btn16";
            this.item_btn16.Size = new System.Drawing.Size(113, 56);
            this.item_btn16.TabIndex = 15;
            this.item_btn16.UseVisualStyleBackColor = true;
            // 
            // item_btn15
            // 
            this.item_btn15.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_btn15.Location = new System.Drawing.Point(251, 187);
            this.item_btn15.Name = "item_btn15";
            this.item_btn15.Size = new System.Drawing.Size(113, 56);
            this.item_btn15.TabIndex = 14;
            this.item_btn15.UseVisualStyleBackColor = true;
            // 
            // item_btn14
            // 
            this.item_btn14.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_btn14.Location = new System.Drawing.Point(131, 187);
            this.item_btn14.Name = "item_btn14";
            this.item_btn14.Size = new System.Drawing.Size(113, 56);
            this.item_btn14.TabIndex = 13;
            this.item_btn14.UseVisualStyleBackColor = true;
            // 
            // item_btn13
            // 
            this.item_btn13.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_btn13.Location = new System.Drawing.Point(12, 187);
            this.item_btn13.Name = "item_btn13";
            this.item_btn13.Size = new System.Drawing.Size(113, 56);
            this.item_btn13.TabIndex = 12;
            this.item_btn13.UseVisualStyleBackColor = true;
            // 
            // item_btn12
            // 
            this.item_btn12.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_btn12.Location = new System.Drawing.Point(370, 125);
            this.item_btn12.Name = "item_btn12";
            this.item_btn12.Size = new System.Drawing.Size(113, 56);
            this.item_btn12.TabIndex = 11;
            this.item_btn12.UseVisualStyleBackColor = true;
            // 
            // item_btn11
            // 
            this.item_btn11.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_btn11.Location = new System.Drawing.Point(251, 125);
            this.item_btn11.Name = "item_btn11";
            this.item_btn11.Size = new System.Drawing.Size(113, 56);
            this.item_btn11.TabIndex = 10;
            this.item_btn11.UseVisualStyleBackColor = true;
            // 
            // item_btn10
            // 
            this.item_btn10.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_btn10.Location = new System.Drawing.Point(131, 125);
            this.item_btn10.Name = "item_btn10";
            this.item_btn10.Size = new System.Drawing.Size(113, 56);
            this.item_btn10.TabIndex = 9;
            this.item_btn10.UseVisualStyleBackColor = true;
            // 
            // item_btn09
            // 
            this.item_btn09.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_btn09.Location = new System.Drawing.Point(12, 125);
            this.item_btn09.Name = "item_btn09";
            this.item_btn09.Size = new System.Drawing.Size(113, 56);
            this.item_btn09.TabIndex = 8;
            this.item_btn09.UseVisualStyleBackColor = true;
            // 
            // item_btn08
            // 
            this.item_btn08.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_btn08.Location = new System.Drawing.Point(370, 63);
            this.item_btn08.Name = "item_btn08";
            this.item_btn08.Size = new System.Drawing.Size(113, 56);
            this.item_btn08.TabIndex = 7;
            this.item_btn08.UseVisualStyleBackColor = true;
            // 
            // item_btn07
            // 
            this.item_btn07.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_btn07.Location = new System.Drawing.Point(251, 63);
            this.item_btn07.Name = "item_btn07";
            this.item_btn07.Size = new System.Drawing.Size(113, 56);
            this.item_btn07.TabIndex = 6;
            this.item_btn07.UseVisualStyleBackColor = true;
            // 
            // item_btn06
            // 
            this.item_btn06.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_btn06.Location = new System.Drawing.Point(131, 63);
            this.item_btn06.Name = "item_btn06";
            this.item_btn06.Size = new System.Drawing.Size(113, 56);
            this.item_btn06.TabIndex = 5;
            this.item_btn06.UseVisualStyleBackColor = true;
            // 
            // item_btn05
            // 
            this.item_btn05.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_btn05.Location = new System.Drawing.Point(12, 63);
            this.item_btn05.Name = "item_btn05";
            this.item_btn05.Size = new System.Drawing.Size(113, 56);
            this.item_btn05.TabIndex = 4;
            this.item_btn05.UseVisualStyleBackColor = true;
            // 
            // item_btn04
            // 
            this.item_btn04.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_btn04.Location = new System.Drawing.Point(370, 1);
            this.item_btn04.Name = "item_btn04";
            this.item_btn04.Size = new System.Drawing.Size(113, 56);
            this.item_btn04.TabIndex = 3;
            this.item_btn04.UseVisualStyleBackColor = true;
            // 
            // item_btn03
            // 
            this.item_btn03.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_btn03.Location = new System.Drawing.Point(251, 1);
            this.item_btn03.Name = "item_btn03";
            this.item_btn03.Size = new System.Drawing.Size(113, 56);
            this.item_btn03.TabIndex = 2;
            this.item_btn03.UseVisualStyleBackColor = true;
            // 
            // item_btn02
            // 
            this.item_btn02.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_btn02.Location = new System.Drawing.Point(132, 1);
            this.item_btn02.Name = "item_btn02";
            this.item_btn02.Size = new System.Drawing.Size(113, 56);
            this.item_btn02.TabIndex = 1;
            this.item_btn02.UseVisualStyleBackColor = true;
            // 
            // item_btn01
            // 
            this.item_btn01.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_btn01.Location = new System.Drawing.Point(12, 1);
            this.item_btn01.Name = "item_btn01";
            this.item_btn01.Size = new System.Drawing.Size(113, 56);
            this.item_btn01.TabIndex = 0;
            this.item_btn01.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel6.Controls.Add(this.textBox3);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.txt_price);
            this.panel6.Controls.Add(this.button17);
            this.panel6.Controls.Add(this.txt_qty);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Controls.Add(this.button19);
            this.panel6.Location = new System.Drawing.Point(13, 426);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(492, 114);
            this.panel6.TabIndex = 5;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(80, 75);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(110, 35);
            this.textBox3.TabIndex = 24;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged_1);
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
            // txt_price
            // 
            this.txt_price.Enabled = false;
            this.txt_price.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_price.Location = new System.Drawing.Point(80, 5);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(403, 35);
            this.txt_price.TabIndex = 21;
            this.txt_price.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // button17
            // 
            this.button17.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button17.ForeColor = System.Drawing.Color.Crimson;
            this.button17.Location = new System.Drawing.Point(347, 73);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(136, 34);
            this.button17.TabIndex = 17;
            this.button17.Text = "REMOVE ORDER";
            this.button17.UseVisualStyleBackColor = true;
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
            // button19
            // 
            this.button19.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button19.ForeColor = System.Drawing.Color.ForestGreen;
            this.button19.Location = new System.Drawing.Point(347, 41);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(136, 34);
            this.button19.TabIndex = 11;
            this.button19.Text = "ADD ORDER";
            this.button19.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            this.button18.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button18.ForeColor = System.Drawing.Color.RoyalBlue;
            this.button18.Location = new System.Drawing.Point(657, 519);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(121, 34);
            this.button18.TabIndex = 18;
            this.button18.Text = "PLACE ORDER";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button34
            // 
            this.button34.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button34.ForeColor = System.Drawing.Color.Crimson;
            this.button34.Location = new System.Drawing.Point(521, 519);
            this.button34.Name = "button34";
            this.button34.Size = new System.Drawing.Size(130, 34);
            this.button34.TabIndex = 18;
            this.button34.Text = "CANCEL ORDER";
            this.button34.UseVisualStyleBackColor = true;
            // 
            // itemreceipt
            // 
            this.itemreceipt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemreceipt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Quantity,
            this.Description,
            this.Price});
            this.itemreceipt.Location = new System.Drawing.Point(521, 78);
            this.itemreceipt.Name = "itemreceipt";
            this.itemreceipt.Size = new System.Drawing.Size(567, 434);
            this.itemreceipt.TabIndex = 19;
            this.itemreceipt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Quantity.Frozen = true;
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 71;
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Description.Frozen = true;
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.Width = 85;
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 33;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBox1.Location = new System.Drawing.Point(134, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(233, 24);
            this.textBox1.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(7, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Customer No.:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBox2.Location = new System.Drawing.Point(134, 39);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(233, 24);
            this.textBox2.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(7, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Customer Name:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.textBox2);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.textBox1);
            this.panel4.Location = new System.Drawing.Point(521, -1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(584, 73);
            this.panel4.TabIndex = 7;
            // 
            // CashierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1100, 557);
            this.Controls.Add(this.itemreceipt);
            this.Controls.Add(this.button34);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CashierForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cashier";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CashierForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.milktea_panel.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_qty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemreceipt)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.NumericUpDown txt_qty;
        private System.Windows.Forms.Panel milktea_panel;
        private System.Windows.Forms.Button item_btn16;
        private System.Windows.Forms.Button item_btn15;
        private System.Windows.Forms.Button item_btn14;
        private System.Windows.Forms.Button item_btn13;
        private System.Windows.Forms.Button item_btn12;
        private System.Windows.Forms.Button item_btn11;
        private System.Windows.Forms.Button item_btn10;
        private System.Windows.Forms.Button item_btn09;
        private System.Windows.Forms.Button item_btn08;
        private System.Windows.Forms.Button item_btn07;
        private System.Windows.Forms.Button item_btn06;
        private System.Windows.Forms.Button item_btn05;
        private System.Windows.Forms.Button item_btn04;
        private System.Windows.Forms.Button item_btn03;
        private System.Windows.Forms.Button item_btn02;
        private System.Windows.Forms.Button item_btn01;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button34;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.DataGridView itemreceipt;
        private System.Windows.Forms.ComboBox itemCat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox itemVar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
    }
}