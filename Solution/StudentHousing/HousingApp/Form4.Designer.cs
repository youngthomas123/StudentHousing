namespace HousingApp
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Tabpage1 = new System.Windows.Forms.TabPage();
            this.FinishTaskButton = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.CreateTaskButton = new System.Windows.Forms.Button();
            this.EndDateBox = new System.Windows.Forms.TextBox();
            this.StartDateBox = new System.Windows.Forms.TextBox();
            this.TaskDescriptionBox = new System.Windows.Forms.TextBox();
            this.TaskNameBox = new System.Windows.Forms.TextBox();
            this.TEndDateLabel = new System.Windows.Forms.Label();
            this.TStartDateLabel = new System.Windows.Forms.Label();
            this.TDescriptionLabel = new System.Windows.Forms.Label();
            this.TaskNameLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.Tabpage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1612, 135);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(35, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(642, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 70);
            this.label1.TabIndex = 0;
            this.label1.Text = "TASK PAGE";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(2, 135);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(301, 668);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(274, 238);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel3.Location = new System.Drawing.Point(1312, 135);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(301, 668);
            this.panel3.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Tabpage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(306, 135);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1006, 668);
            this.tabControl1.TabIndex = 2;
            // 
            // Tabpage1
            // 
            this.Tabpage1.Controls.Add(this.FinishTaskButton);
            this.Tabpage1.Controls.Add(this.listBox2);
            this.Tabpage1.Location = new System.Drawing.Point(4, 34);
            this.Tabpage1.Name = "Tabpage1";
            this.Tabpage1.Padding = new System.Windows.Forms.Padding(3);
            this.Tabpage1.Size = new System.Drawing.Size(998, 630);
            this.Tabpage1.TabIndex = 0;
            this.Tabpage1.Text = "View";
            this.Tabpage1.UseVisualStyleBackColor = true;
            // 
            // FinishTaskButton
            // 
            this.FinishTaskButton.Location = new System.Drawing.Point(811, 509);
            this.FinishTaskButton.Name = "FinishTaskButton";
            this.FinishTaskButton.Size = new System.Drawing.Size(173, 55);
            this.FinishTaskButton.TabIndex = 1;
            this.FinishTaskButton.Text = "Finish Task";
            this.FinishTaskButton.UseVisualStyleBackColor = true;
            this.FinishTaskButton.Click += new System.EventHandler(this.FinishTaskButton_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 25;
            this.listBox2.Location = new System.Drawing.Point(6, 9);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(786, 604);
            this.listBox2.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.CreateTaskButton);
            this.tabPage2.Controls.Add(this.EndDateBox);
            this.tabPage2.Controls.Add(this.StartDateBox);
            this.tabPage2.Controls.Add(this.TaskDescriptionBox);
            this.tabPage2.Controls.Add(this.TaskNameBox);
            this.tabPage2.Controls.Add(this.TEndDateLabel);
            this.tabPage2.Controls.Add(this.TStartDateLabel);
            this.tabPage2.Controls.Add(this.TDescriptionLabel);
            this.tabPage2.Controls.Add(this.TaskNameLabel);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(998, 630);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Create";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // CreateTaskButton
            // 
            this.CreateTaskButton.Location = new System.Drawing.Point(333, 343);
            this.CreateTaskButton.Name = "CreateTaskButton";
            this.CreateTaskButton.Size = new System.Drawing.Size(357, 59);
            this.CreateTaskButton.TabIndex = 8;
            this.CreateTaskButton.Text = "Create Task";
            this.CreateTaskButton.UseVisualStyleBackColor = true;
            this.CreateTaskButton.Click += new System.EventHandler(this.CreateTaskButton_Click);
            // 
            // EndDateBox
            // 
            this.EndDateBox.Location = new System.Drawing.Point(333, 264);
            this.EndDateBox.Name = "EndDateBox";
            this.EndDateBox.Size = new System.Drawing.Size(357, 31);
            this.EndDateBox.TabIndex = 7;
            // 
            // StartDateBox
            // 
            this.StartDateBox.Location = new System.Drawing.Point(333, 208);
            this.StartDateBox.Name = "StartDateBox";
            this.StartDateBox.Size = new System.Drawing.Size(357, 31);
            this.StartDateBox.TabIndex = 6;
            // 
            // TaskDescriptionBox
            // 
            this.TaskDescriptionBox.Location = new System.Drawing.Point(333, 149);
            this.TaskDescriptionBox.Name = "TaskDescriptionBox";
            this.TaskDescriptionBox.Size = new System.Drawing.Size(357, 31);
            this.TaskDescriptionBox.TabIndex = 5;
            // 
            // TaskNameBox
            // 
            this.TaskNameBox.Location = new System.Drawing.Point(333, 94);
            this.TaskNameBox.Name = "TaskNameBox";
            this.TaskNameBox.Size = new System.Drawing.Size(357, 31);
            this.TaskNameBox.TabIndex = 4;
            // 
            // TEndDateLabel
            // 
            this.TEndDateLabel.AutoSize = true;
            this.TEndDateLabel.Location = new System.Drawing.Point(172, 270);
            this.TEndDateLabel.Name = "TEndDateLabel";
            this.TEndDateLabel.Size = new System.Drawing.Size(84, 25);
            this.TEndDateLabel.TabIndex = 3;
            this.TEndDateLabel.Text = "End Date";
            // 
            // TStartDateLabel
            // 
            this.TStartDateLabel.AutoSize = true;
            this.TStartDateLabel.Location = new System.Drawing.Point(172, 214);
            this.TStartDateLabel.Name = "TStartDateLabel";
            this.TStartDateLabel.Size = new System.Drawing.Size(90, 25);
            this.TStartDateLabel.TabIndex = 2;
            this.TStartDateLabel.Text = "Start Date";
            // 
            // TDescriptionLabel
            // 
            this.TDescriptionLabel.AutoSize = true;
            this.TDescriptionLabel.Location = new System.Drawing.Point(172, 155);
            this.TDescriptionLabel.Name = "TDescriptionLabel";
            this.TDescriptionLabel.Size = new System.Drawing.Size(140, 25);
            this.TDescriptionLabel.TabIndex = 1;
            this.TDescriptionLabel.Text = "Task Description";
            // 
            // TaskNameLabel
            // 
            this.TaskNameLabel.AutoSize = true;
            this.TaskNameLabel.Location = new System.Drawing.Point(172, 100);
            this.TaskNameLabel.Name = "TaskNameLabel";
            this.TaskNameLabel.Size = new System.Drawing.Size(97, 25);
            this.TaskNameLabel.TabIndex = 0;
            this.TaskNameLabel.Text = "Task Name";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1615, 803);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.Tabpage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private TabControl tabControl1;
        private TabPage Tabpage1;
        private TabPage tabPage2;
        private PictureBox pictureBox1;
        private ListBox listBox2;
        private PictureBox pictureBox2;
        private Label TDescriptionLabel;
        private Label TaskNameLabel;
        private Label TStartDateLabel;
        private Label TEndDateLabel;
        private Button CreateTaskButton;
        private TextBox EndDateBox;
        private TextBox StartDateBox;
        private TextBox TaskDescriptionBox;
        private TextBox TaskNameBox;
        private Button FinishTaskButton;
    }
}