namespace CafeSystem
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
            this.frontbutton = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cashierToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cashierToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.BurlyWood;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backbutton,
            this.frontbutton,
            this.inventoryToolStripMenuItem,
            this.cashierToolStripMenuItem1,
            this.adminToolStripMenuItem,
            this.cashierToolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1163, 42);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backbutton
            // 
            this.backbutton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.backbutton.Font = new System.Drawing.Font("0ArameNumbersHeavy", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbutton.ForeColor = System.Drawing.Color.Lime;
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(41, 38);
            this.backbutton.Text = "<";
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // frontbutton
            // 
            this.frontbutton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.frontbutton.Font = new System.Drawing.Font("0ArameNumbersHeavy", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frontbutton.ForeColor = System.Drawing.Color.Lime;
            this.frontbutton.Name = "frontbutton";
            this.frontbutton.Size = new System.Drawing.Size(41, 38);
            this.frontbutton.Text = ">";
            this.frontbutton.Click += new System.EventHandler(this.frontbutton_Click);
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.inventoryToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(64, 38);
            this.inventoryToolStripMenuItem.Text = "Home";
            this.inventoryToolStripMenuItem.Click += new System.EventHandler(this.inventoryToolStripMenuItem_Click);
            // 
            // cashierToolStripMenuItem1
            // 
            this.cashierToolStripMenuItem1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cashierToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cashierToolStripMenuItem1.Name = "cashierToolStripMenuItem1";
            this.cashierToolStripMenuItem1.Size = new System.Drawing.Size(88, 38);
            this.cashierToolStripMenuItem1.Text = "Inventory";
            this.cashierToolStripMenuItem1.Click += new System.EventHandler(this.cashierToolStripMenuItem1_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.adminToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(68, 38);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // cashierToolStripMenuItem2
            // 
            this.cashierToolStripMenuItem2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cashierToolStripMenuItem2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierToolStripMenuItem2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cashierToolStripMenuItem2.Name = "cashierToolStripMenuItem2";
            this.cashierToolStripMenuItem2.Size = new System.Drawing.Size(74, 38);
            this.cashierToolStripMenuItem2.Text = "Cashier";
            this.cashierToolStripMenuItem2.Click += new System.EventHandler(this.cashierToolStripMenuItem2_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 16;
            this.timer1.Tick += new System.EventHandler(this._process);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 563);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "LoginForm";
            this.Text = "Cafe System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backbutton;
        private System.Windows.Forms.ToolStripMenuItem frontbutton;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cashierToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cashierToolStripMenuItem2;
        private System.Windows.Forms.Timer timer1;
    }
}

