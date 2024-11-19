﻿namespace CafeSystem
{
    partial class LoginForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backbutton = new System.Windows.Forms.ToolStripMenuItem();
            this.homeTab = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryTab = new System.Windows.Forms.ToolStripMenuItem();
            this.adminTab = new System.Windows.Forms.ToolStripMenuItem();
            this.cashierTab = new System.Windows.Forms.ToolStripMenuItem();
            this.process = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cashier_position = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cashier_name = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.physics_process = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.BurlyWood;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backbutton,
            this.homeTab,
            this.inventoryTab,
            this.adminTab,
            this.cashierTab});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1267, 105);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // backbutton
            // 
            this.backbutton.AutoSize = false;
            this.backbutton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.backbutton.Font = new System.Drawing.Font("0ArameNumbersHeavy", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbutton.ForeColor = System.Drawing.Color.Lime;
            this.backbutton.Margin = new System.Windows.Forms.Padding(3);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(122, 41);
            this.backbutton.Text = "BACK";
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // homeTab
            // 
            this.homeTab.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.homeTab.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeTab.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.homeTab.Margin = new System.Windows.Forms.Padding(2);
            this.homeTab.Name = "homeTab";
            this.homeTab.Size = new System.Drawing.Size(101, 97);
            this.homeTab.Text = "Home";
            this.homeTab.Click += new System.EventHandler(this.inventoryToolStripMenuItem_Click);
            // 
            // inventoryTab
            // 
            this.inventoryTab.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.inventoryTab.Enabled = false;
            this.inventoryTab.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryTab.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.inventoryTab.Margin = new System.Windows.Forms.Padding(2);
            this.inventoryTab.Name = "inventoryTab";
            this.inventoryTab.Size = new System.Drawing.Size(140, 97);
            this.inventoryTab.Text = "Inventory";
            this.inventoryTab.Click += new System.EventHandler(this.cashierToolStripMenuItem1_Click);
            // 
            // adminTab
            // 
            this.adminTab.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.adminTab.Enabled = false;
            this.adminTab.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminTab.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.adminTab.Margin = new System.Windows.Forms.Padding(2);
            this.adminTab.Name = "adminTab";
            this.adminTab.Size = new System.Drawing.Size(107, 97);
            this.adminTab.Text = "Admin";
            this.adminTab.Click += new System.EventHandler(this.adminTab_Click);
            // 
            // cashierTab
            // 
            this.cashierTab.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cashierTab.Enabled = false;
            this.cashierTab.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierTab.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cashierTab.Margin = new System.Windows.Forms.Padding(2);
            this.cashierTab.Name = "cashierTab";
            this.cashierTab.Size = new System.Drawing.Size(116, 97);
            this.cashierTab.Text = "Cashier";
            this.cashierTab.Click += new System.EventHandler(this.cashierToolStripMenuItem2_Click);
            // 
            // process
            // 
            this.process.Enabled = true;
            this.process.Interval = 33;
            this.process.Tick += new System.EventHandler(this._process);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.cashier_position);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.cashier_name);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(621, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(646, 105);
            this.panel3.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumBlue;
            this.label3.Location = new System.Drawing.Point(444, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "00:00:00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(320, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Date Time:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // cashier_position
            // 
            this.cashier_position.AutoSize = true;
            this.cashier_position.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashier_position.ForeColor = System.Drawing.Color.MediumBlue;
            this.cashier_position.Location = new System.Drawing.Point(444, 28);
            this.cashier_position.Name = "cashier_position";
            this.cashier_position.Size = new System.Drawing.Size(26, 25);
            this.cashier_position.TabIndex = 13;
            this.cashier_position.Text = "--";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(339, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Position:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.MediumBlue;
            this.label13.Location = new System.Drawing.Point(444, 53);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 25);
            this.label13.TabIndex = 11;
            this.label13.Text = "00:00:00";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(311, 53);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(127, 25);
            this.label14.TabIndex = 10;
            this.label14.Text = "Checked-in:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox2.Image = global::CafeSystem.Properties.Resources.blank_dp;
            this.pictureBox2.Location = new System.Drawing.Point(175, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(105, 99);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // cashier_name
            // 
            this.cashier_name.AutoSize = true;
            this.cashier_name.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashier_name.ForeColor = System.Drawing.Color.MediumBlue;
            this.cashier_name.Location = new System.Drawing.Point(444, 3);
            this.cashier_name.Name = "cashier_name";
            this.cashier_name.Size = new System.Drawing.Size(26, 25);
            this.cashier_name.TabIndex = 6;
            this.cashier_name.Text = "--";
            this.cashier_name.Click += new System.EventHandler(this.label7_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox1.Image = global::CafeSystem.Properties.Resources.beginnings_cafe;
            this.pictureBox1.Location = new System.Drawing.Point(4, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(286, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Cashier Name:";
            // 
            // physics_process
            // 
            this.physics_process.Enabled = true;
            this.physics_process.Interval = 1000;
            this.physics_process.Tick += new System.EventHandler(this._physics_process);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1267, 694);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "LoginForm";
            this.Text = "Cafe System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backbutton;
        private System.Windows.Forms.ToolStripMenuItem homeTab;
        private System.Windows.Forms.ToolStripMenuItem inventoryTab;
        private System.Windows.Forms.ToolStripMenuItem adminTab;
        private System.Windows.Forms.ToolStripMenuItem cashierTab;
        private System.Windows.Forms.Timer process;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label cashier_name;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label cashier_position;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer physics_process;
    }
}

