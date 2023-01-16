namespace HousingApp
{
    partial class SignUpForm
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
            this.FirstNameTB = new System.Windows.Forms.TextBox();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.ConformPasswordTB = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TermsCB = new System.Windows.Forms.CheckBox();
            this.BackToLoginBT = new System.Windows.Forms.Button();
            this.SubmitBT = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.LastNameTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.UserNameTB = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.HouseCB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(98, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome !";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FirstNameTB
            // 
            this.FirstNameTB.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FirstNameTB.Location = new System.Drawing.Point(49, 129);
            this.FirstNameTB.Name = "FirstNameTB";
            this.FirstNameTB.Size = new System.Drawing.Size(171, 31);
            this.FirstNameTB.TabIndex = 2;
            // 
            // PasswordTB
            // 
            this.PasswordTB.Location = new System.Drawing.Point(49, 351);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.Size = new System.Drawing.Size(380, 31);
            this.PasswordTB.TabIndex = 2;
            // 
            // ConformPasswordTB
            // 
            this.ConformPasswordTB.Location = new System.Drawing.Point(49, 480);
            this.ConformPasswordTB.Name = "ConformPasswordTB";
            this.ConformPasswordTB.Size = new System.Drawing.Size(380, 31);
            this.ConformPasswordTB.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(52, 179);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 1);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(49, 410);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(380, 1);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(52, 613);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(380, 1);
            this.panel3.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(49, 318);
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
            this.label4.Location = new System.Drawing.Point(49, 429);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 30);
            this.label4.TabIndex = 1;
            this.label4.Text = "Confirm Password";
            // 
            // TermsCB
            // 
            this.TermsCB.AutoSize = true;
            this.TermsCB.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TermsCB.Location = new System.Drawing.Point(49, 636);
            this.TermsCB.Name = "TermsCB";
            this.TermsCB.Size = new System.Drawing.Size(118, 25);
            this.TermsCB.TabIndex = 4;
            this.TermsCB.Text = "I accept the ";
            this.TermsCB.UseVisualStyleBackColor = true;
            this.TermsCB.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // BackToLoginBT
            // 
            this.BackToLoginBT.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackToLoginBT.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BackToLoginBT.ForeColor = System.Drawing.Color.White;
            this.BackToLoginBT.Location = new System.Drawing.Point(49, 779);
            this.BackToLoginBT.Name = "BackToLoginBT";
            this.BackToLoginBT.Size = new System.Drawing.Size(380, 51);
            this.BackToLoginBT.TabIndex = 5;
            this.BackToLoginBT.Text = "BACK TO LOGIN PAGE";
            this.BackToLoginBT.UseVisualStyleBackColor = false;
            this.BackToLoginBT.Click += new System.EventHandler(this.BackToLoginBT_Click);
            // 
            // SubmitBT
            // 
            this.SubmitBT.BackColor = System.Drawing.Color.White;
            this.SubmitBT.Enabled = false;
            this.SubmitBT.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SubmitBT.Location = new System.Drawing.Point(49, 682);
            this.SubmitBT.Name = "SubmitBT";
            this.SubmitBT.Size = new System.Drawing.Size(380, 51);
            this.SubmitBT.TabIndex = 5;
            this.SubmitBT.Text = "SUBMIT";
            this.SubmitBT.UseVisualStyleBackColor = false;
            this.SubmitBT.Click += new System.EventHandler(this.SubmitBT_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(61, 757);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(348, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "If you already have an account / just made one, click on";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label6.Location = new System.Drawing.Point(49, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 30);
            this.label6.TabIndex = 1;
            this.label6.Text = "First Name";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Location = new System.Drawing.Point(52, 63);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(380, 1);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel5.Location = new System.Drawing.Point(49, 299);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(380, 1);
            this.panel5.TabIndex = 3;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabel1.Location = new System.Drawing.Point(158, 637);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(251, 21);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Terms of Service and Privacy Policy";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // LastNameTB
            // 
            this.LastNameTB.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LastNameTB.Location = new System.Drawing.Point(252, 129);
            this.LastNameTB.Name = "LastNameTB";
            this.LastNameTB.Size = new System.Drawing.Size(171, 31);
            this.LastNameTB.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label7.Location = new System.Drawing.Point(263, 83);
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
            this.label8.Location = new System.Drawing.Point(52, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 30);
            this.label8.TabIndex = 9;
            this.label8.Text = "User Name";
            // 
            // UserNameTB
            // 
            this.UserNameTB.Location = new System.Drawing.Point(52, 231);
            this.UserNameTB.Name = "UserNameTB";
            this.UserNameTB.Size = new System.Drawing.Size(380, 31);
            this.UserNameTB.TabIndex = 11;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel7.Location = new System.Drawing.Point(49, 539);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(380, 1);
            this.panel7.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label9.Location = new System.Drawing.Point(49, 559);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 30);
            this.label9.TabIndex = 13;
            this.label9.Text = "House";
            // 
            // HouseCB
            // 
            this.HouseCB.FormattingEnabled = true;
            this.HouseCB.Location = new System.Drawing.Point(158, 560);
            this.HouseCB.Name = "HouseCB";
            this.HouseCB.Size = new System.Drawing.Size(178, 33);
            this.HouseCB.TabIndex = 14;
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 837);
            this.Controls.Add(this.HouseCB);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.UserNameTB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SubmitBT);
            this.Controls.Add(this.BackToLoginBT);
            this.Controls.Add(this.TermsCB);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ConformPasswordTB);
            this.Controls.Add(this.PasswordTB);
            this.Controls.Add(this.LastNameTB);
            this.Controls.Add(this.FirstNameTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SignUpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUpForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SignUpForm_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox FirstNameTB;
        private TextBox PasswordTB;
        private TextBox ConformPasswordTB;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label3;
        private Label label4;
        private CheckBox TermsCB;
        private Button BackToLoginBT;
        private Button SubmitBT;
        private Label label5;
        private Label label6;
        private Panel panel4;
        private Panel panel5;
        private LinkLabel linkLabel1;
        private TextBox LastNameTB;
        private Label label7;
        private Label label8;
        private TextBox UserNameTB;
        private Panel panel7;
        private Label label9;
        private ComboBox HouseCB;
    }
}