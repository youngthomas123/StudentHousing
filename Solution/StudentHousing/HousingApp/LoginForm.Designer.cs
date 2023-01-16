namespace HousingApp
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.UserNameTB = new System.Windows.Forms.TextBox();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.ShowPasswordCB = new System.Windows.Forms.CheckBox();
            this.LoginBT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SignUpBT = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(147, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 206);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(34, 379);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(42, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(34, 445);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(42, 37);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // UserNameTB
            // 
            this.UserNameTB.ForeColor = System.Drawing.Color.DarkGray;
            this.UserNameTB.Location = new System.Drawing.Point(82, 385);
            this.UserNameTB.Name = "UserNameTB";
            this.UserNameTB.Size = new System.Drawing.Size(332, 31);
            this.UserNameTB.TabIndex = 1;
            // 
            // PasswordTB
            // 
            this.PasswordTB.ForeColor = System.Drawing.Color.DarkGray;
            this.PasswordTB.Location = new System.Drawing.Point(82, 451);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.Size = new System.Drawing.Size(332, 31);
            this.PasswordTB.TabIndex = 1;
            this.PasswordTB.UseSystemPasswordChar = true;
            // 
            // ShowPasswordCB
            // 
            this.ShowPasswordCB.AutoSize = true;
            this.ShowPasswordCB.Location = new System.Drawing.Point(167, 497);
            this.ShowPasswordCB.Name = "ShowPasswordCB";
            this.ShowPasswordCB.Size = new System.Drawing.Size(162, 29);
            this.ShowPasswordCB.TabIndex = 2;
            this.ShowPasswordCB.Text = "Show Password";
            this.ShowPasswordCB.UseVisualStyleBackColor = true;
            this.ShowPasswordCB.CheckedChanged += new System.EventHandler(this.ShowPasswordCB_CheckedChanged);
            // 
            // LoginBT
            // 
            this.LoginBT.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LoginBT.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoginBT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LoginBT.Location = new System.Drawing.Point(50, 532);
            this.LoginBT.Name = "LoginBT";
            this.LoginBT.Size = new System.Drawing.Size(380, 48);
            this.LoginBT.TabIndex = 3;
            this.LoginBT.Text = "Login";
            this.LoginBT.UseVisualStyleBackColor = false;
            this.LoginBT.Click += new System.EventHandler(this.LoginBT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(181, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 48);
            this.label1.TabIndex = 4;
            this.label1.Text = "LOG IN";
            // 
            // SignUpBT
            // 
            this.SignUpBT.BackColor = System.Drawing.Color.White;
            this.SignUpBT.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SignUpBT.Location = new System.Drawing.Point(50, 635);
            this.SignUpBT.Name = "SignUpBT";
            this.SignUpBT.Size = new System.Drawing.Size(380, 48);
            this.SignUpBT.TabIndex = 5;
            this.SignUpBT.Text = "Make a new account";
            this.SignUpBT.UseVisualStyleBackColor = false;
            this.SignUpBT.Click += new System.EventHandler(this.SignUpBT_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 607);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Have no account ?";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(483, 712);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SignUpBT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoginBT);
            this.Controls.Add(this.ShowPasswordCB);
            this.Controls.Add(this.PasswordTB);
            this.Controls.Add(this.UserNameTB);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private TextBox UserNameTB;
        private TextBox PasswordTB;
        private CheckBox ShowPasswordCB;
        private Button LoginBT;
        private Label label1;
        private Button SignUpBT;
        private Label label2;
    }
}