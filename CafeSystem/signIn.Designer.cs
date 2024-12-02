namespace CafeSystem
{
    partial class signIn
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
            this.panel6 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pwBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.emBox = new System.Windows.Forms.TextBox();
            this.button19 = new System.Windows.Forms.Button();
            this.btn_showpass = new System.Windows.Forms.Button();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel6.Controls.Add(this.btn_showpass);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.pwBox);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.emBox);
            this.panel6.Controls.Add(this.button19);
            this.panel6.Location = new System.Drawing.Point(224, 129);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(661, 261);
            this.panel6.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(25, 123);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "PASSWORD";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pwBox
            // 
            this.pwBox.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwBox.Location = new System.Drawing.Point(118, 111);
            this.pwBox.Name = "pwBox";
            this.pwBox.PasswordChar = '*';
            this.pwBox.Size = new System.Drawing.Size(528, 35);
            this.pwBox.TabIndex = 23;
            this.pwBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(25, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "EMAIL";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // emBox
            // 
            this.emBox.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emBox.Location = new System.Drawing.Point(118, 70);
            this.emBox.Name = "emBox";
            this.emBox.Size = new System.Drawing.Size(528, 35);
            this.emBox.TabIndex = 21;
            this.emBox.TextChanged += new System.EventHandler(this.txt_price_TextChanged);
            // 
            // button19
            // 
            this.button19.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button19.ForeColor = System.Drawing.Color.ForestGreen;
            this.button19.Location = new System.Drawing.Point(258, 212);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(136, 34);
            this.button19.TabIndex = 11;
            this.button19.Text = "SIGN IN";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // btn_showpass
            // 
            this.btn_showpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_showpass.Location = new System.Drawing.Point(609, 111);
            this.btn_showpass.Name = "btn_showpass";
            this.btn_showpass.Size = new System.Drawing.Size(37, 35);
            this.btn_showpass.TabIndex = 25;
            this.btn_showpass.Text = "👁️";
            this.btn_showpass.UseVisualStyleBackColor = true;
            this.btn_showpass.Click += new System.EventHandler(this.btn_showpass_Click);
            // 
            // signIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 557);
            this.Controls.Add(this.panel6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "signIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "signIn";
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pwBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox emBox;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button btn_showpass;
    }
}