namespace HousingApp
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.ConformPasswordTB = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.MaleRB = new System.Windows.Forms.RadioButton();
            this.FemaleRB = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.UserNameTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(121, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome !";
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox1.Location = new System.Drawing.Point(52, 169);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(171, 31);
            this.textBox1.TabIndex = 2;
            // 
            // PasswordTB
            // 
            this.PasswordTB.Location = new System.Drawing.Point(49, 473);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.Size = new System.Drawing.Size(380, 31);
            this.PasswordTB.TabIndex = 2;
            // 
            // ConformPasswordTB
            // 
            this.ConformPasswordTB.Location = new System.Drawing.Point(46, 592);
            this.ConformPasswordTB.Name = "ConformPasswordTB";
            this.ConformPasswordTB.Size = new System.Drawing.Size(380, 31);
            this.ConformPasswordTB.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(52, 225);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 1);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(52, 537);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(380, 1);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(49, 687);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(380, 1);
            this.panel3.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(49, 440);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 30);
            this.label3.TabIndex = 1;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Location = new System.Drawing.Point(46, 550);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 30);
            this.label4.TabIndex = 1;
            this.label4.Text = "Confirm Password";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox1.Location = new System.Drawing.Point(46, 643);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(118, 25);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "I accept the ";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(49, 804);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(380, 51);
            this.button1.TabIndex = 5;
            this.button1.Text = "BACK TO LOGIN PAGE";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Enabled = false;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(49, 706);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(380, 51);
            this.button2.TabIndex = 5;
            this.button2.Text = "SUBMIT";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(61, 773);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(348, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "If you already have an account / just made one, click on";
            // 
            // MaleRB
            // 
            this.MaleRB.AutoSize = true;
            this.MaleRB.Location = new System.Drawing.Point(89, 270);
            this.MaleRB.Name = "MaleRB";
            this.MaleRB.Size = new System.Drawing.Size(75, 29);
            this.MaleRB.TabIndex = 7;
            this.MaleRB.TabStop = true;
            this.MaleRB.Text = "Male";
            this.MaleRB.UseVisualStyleBackColor = true;
            // 
            // FemaleRB
            // 
            this.FemaleRB.AutoSize = true;
            this.FemaleRB.Location = new System.Drawing.Point(255, 270);
            this.FemaleRB.Name = "FemaleRB";
            this.FemaleRB.Size = new System.Drawing.Size(93, 29);
            this.FemaleRB.TabIndex = 7;
            this.FemaleRB.TabStop = true;
            this.FemaleRB.Text = "Female";
            this.FemaleRB.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label6.Location = new System.Drawing.Point(49, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 30);
            this.label6.TabIndex = 1;
            this.label6.Text = "First Name";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(170, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gender";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Location = new System.Drawing.Point(52, 80);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(380, 1);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel5.Location = new System.Drawing.Point(52, 427);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(380, 1);
            this.panel5.TabIndex = 3;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabel1.Location = new System.Drawing.Point(158, 644);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(251, 21);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Terms of Service and Privacy Policy";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // textBox4
            // 
            this.textBox4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox4.Location = new System.Drawing.Point(255, 169);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(171, 31);
            this.textBox4.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label7.Location = new System.Drawing.Point(258, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 30);
            this.label7.TabIndex = 1;
            this.label7.Text = "Last Name";
            this.label7.Click += new System.EventHandler(this.label6_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label8.Location = new System.Drawing.Point(49, 334);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 30);
            this.label8.TabIndex = 9;
            this.label8.Text = "User Name";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel6.Location = new System.Drawing.Point(52, 323);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(380, 1);
            this.panel6.TabIndex = 10;
            // 
            // UserNameTB
            // 
            this.UserNameTB.Location = new System.Drawing.Point(49, 379);
            this.UserNameTB.Name = "UserNameTB";
            this.UserNameTB.Size = new System.Drawing.Size(380, 31);
            this.UserNameTB.TabIndex = 11;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 867);
            this.Controls.Add(this.UserNameTB);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.FemaleRB);
            this.Controls.Add(this.MaleRB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ConformPasswordTB);
            this.Controls.Add(this.PasswordTB);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox PasswordTB;
        private TextBox ConformPasswordTB;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label3;
        private Label label4;
        private CheckBox checkBox1;
        private Button button1;
        private Button button2;
        private Label label5;
        private RadioButton MaleRB;
        private RadioButton FemaleRB;
        private Label label6;
        private Label label2;
        private Panel panel4;
        private Panel panel5;
        private LinkLabel linkLabel1;
        private TextBox textBox4;
        private Label label7;
        private Label label8;
        private Panel panel6;
        private TextBox UserNameTB;
    }
}