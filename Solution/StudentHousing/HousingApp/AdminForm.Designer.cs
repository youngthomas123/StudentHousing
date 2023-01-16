namespace HousingApp
{
    partial class AdminForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TaskForTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.HouseMembersLB = new System.Windows.Forms.ListBox();
            this.CreateTaskBT = new System.Windows.Forms.Button();
            this.TaskDateTB = new System.Windows.Forms.TextBox();
            this.TaskDescriptionRTB = new System.Windows.Forms.RichTextBox();
            this.TaskTitleRTB = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ViewComplaintBT = new System.Windows.Forms.Button();
            this.ComplaintsLB = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.SetRentBT = new System.Windows.Forms.Button();
            this.SetRentTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.RentLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.RentLB = new System.Windows.Forms.ListBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SendMessageBT = new System.Windows.Forms.Button();
            this.PersonCB = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.MessageBodyRTB = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.MessageTitleRTB = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ViewMessageBT = new System.Windows.Forms.Button();
            this.MessagesLB = new System.Windows.Forms.ListBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.ShowAllTaskBT = new System.Windows.Forms.Button();
            this.DeleteTaskBT = new System.Windows.Forms.Button();
            this.UpdateDateBT = new System.Windows.Forms.Button();
            this.UpdateDateTB = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.UpdateForBT = new System.Windows.Forms.Button();
            this.UpdateForTB = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.SearchTaskBT = new System.Windows.Forms.Button();
            this.ViewUpdateTaskBT = new System.Windows.Forms.Button();
            this.SearchTaskTB = new System.Windows.Forms.TextBox();
            this.UpdateTaskLB = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(-1, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(848, 613);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(840, 575);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Task";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TaskForTB);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.HouseMembersLB);
            this.groupBox1.Controls.Add(this.CreateTaskBT);
            this.groupBox1.Controls.Add(this.TaskDateTB);
            this.groupBox1.Controls.Add(this.TaskDescriptionRTB);
            this.groupBox1.Controls.Add(this.TaskTitleRTB);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(824, 566);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create";
            // 
            // TaskForTB
            // 
            this.TaskForTB.Location = new System.Drawing.Point(36, 322);
            this.TaskForTB.Name = "TaskForTB";
            this.TaskForTB.Size = new System.Drawing.Size(150, 31);
            this.TaskForTB.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "For (name of member)";
            // 
            // HouseMembersLB
            // 
            this.HouseMembersLB.FormattingEnabled = true;
            this.HouseMembersLB.ItemHeight = 25;
            this.HouseMembersLB.Location = new System.Drawing.Point(433, 280);
            this.HouseMembersLB.Name = "HouseMembersLB";
            this.HouseMembersLB.Size = new System.Drawing.Size(369, 254);
            this.HouseMembersLB.TabIndex = 7;
            // 
            // CreateTaskBT
            // 
            this.CreateTaskBT.Location = new System.Drawing.Point(151, 500);
            this.CreateTaskBT.Name = "CreateTaskBT";
            this.CreateTaskBT.Size = new System.Drawing.Size(112, 34);
            this.CreateTaskBT.TabIndex = 6;
            this.CreateTaskBT.Text = "Create";
            this.CreateTaskBT.UseVisualStyleBackColor = true;
            this.CreateTaskBT.Click += new System.EventHandler(this.CreateTaskBT_Click);
            // 
            // TaskDateTB
            // 
            this.TaskDateTB.Location = new System.Drawing.Point(36, 419);
            this.TaskDateTB.Name = "TaskDateTB";
            this.TaskDateTB.Size = new System.Drawing.Size(164, 31);
            this.TaskDateTB.TabIndex = 5;
            // 
            // TaskDescriptionRTB
            // 
            this.TaskDescriptionRTB.Location = new System.Drawing.Point(36, 176);
            this.TaskDescriptionRTB.Name = "TaskDescriptionRTB";
            this.TaskDescriptionRTB.Size = new System.Drawing.Size(766, 81);
            this.TaskDescriptionRTB.TabIndex = 4;
            this.TaskDescriptionRTB.Text = "";
            // 
            // TaskTitleRTB
            // 
            this.TaskTitleRTB.Location = new System.Drawing.Point(36, 78);
            this.TaskTitleRTB.Name = "TaskTitleRTB";
            this.TaskTitleRTB.Size = new System.Drawing.Size(766, 42);
            this.TaskTitleRTB.TabIndex = 3;
            this.TaskTitleRTB.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 371);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ViewComplaintBT);
            this.tabPage2.Controls.Add(this.ComplaintsLB);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(840, 575);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Complaint";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ViewComplaintBT
            // 
            this.ViewComplaintBT.Location = new System.Drawing.Point(356, 514);
            this.ViewComplaintBT.Name = "ViewComplaintBT";
            this.ViewComplaintBT.Size = new System.Drawing.Size(112, 34);
            this.ViewComplaintBT.TabIndex = 1;
            this.ViewComplaintBT.Text = "View";
            this.ViewComplaintBT.UseVisualStyleBackColor = true;
            this.ViewComplaintBT.Click += new System.EventHandler(this.ViewComplaintBT_Click);
            // 
            // ComplaintsLB
            // 
            this.ComplaintsLB.FormattingEnabled = true;
            this.ComplaintsLB.ItemHeight = 25;
            this.ComplaintsLB.Location = new System.Drawing.Point(29, 33);
            this.ComplaintsLB.Name = "ComplaintsLB";
            this.ComplaintsLB.Size = new System.Drawing.Size(787, 454);
            this.ComplaintsLB.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.SetRentBT);
            this.tabPage3.Controls.Add(this.SetRentTB);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.RentLabel);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.RentLB);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(840, 575);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Rent";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // SetRentBT
            // 
            this.SetRentBT.Location = new System.Drawing.Point(172, 389);
            this.SetRentBT.Name = "SetRentBT";
            this.SetRentBT.Size = new System.Drawing.Size(112, 34);
            this.SetRentBT.TabIndex = 5;
            this.SetRentBT.Text = "OK";
            this.SetRentBT.UseVisualStyleBackColor = true;
            this.SetRentBT.Click += new System.EventHandler(this.SetRentBT_Click);
            // 
            // SetRentTB
            // 
            this.SetRentTB.Location = new System.Drawing.Point(172, 231);
            this.SetRentTB.Name = "SetRentTB";
            this.SetRentTB.Size = new System.Drawing.Size(150, 31);
            this.SetRentTB.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "Set new rent";
            // 
            // RentLabel
            // 
            this.RentLabel.AutoSize = true;
            this.RentLabel.Location = new System.Drawing.Point(186, 139);
            this.RentLabel.Name = "RentLabel";
            this.RentLabel.Size = new System.Drawing.Size(59, 25);
            this.RentLabel.TabIndex = 2;
            this.RentLabel.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Current Rent : ";
            // 
            // RentLB
            // 
            this.RentLB.FormattingEnabled = true;
            this.RentLB.ItemHeight = 25;
            this.RentLB.Location = new System.Drawing.Point(497, 119);
            this.RentLB.Name = "RentLB";
            this.RentLB.Size = new System.Drawing.Size(302, 304);
            this.RentLB.TabIndex = 0;
            this.RentLB.SelectedIndexChanged += new System.EventHandler(this.RentLB_SelectedIndexChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Controls.Add(this.groupBox2);
            this.tabPage4.Controls.Add(this.ViewMessageBT);
            this.tabPage4.Controls.Add(this.MessagesLB);
            this.tabPage4.Location = new System.Drawing.Point(4, 34);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(840, 575);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Message";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(563, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(164, 25);
            this.label11.TabIndex = 3;
            this.label11.Text = "Received Messages";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SendMessageBT);
            this.groupBox2.Controls.Add(this.PersonCB);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.MessageBodyRTB);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.MessageTitleRTB);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(26, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(426, 527);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Send message";
            // 
            // SendMessageBT
            // 
            this.SendMessageBT.Location = new System.Drawing.Point(92, 475);
            this.SendMessageBT.Name = "SendMessageBT";
            this.SendMessageBT.Size = new System.Drawing.Size(112, 34);
            this.SendMessageBT.TabIndex = 6;
            this.SendMessageBT.Text = "Send";
            this.SendMessageBT.UseVisualStyleBackColor = true;
            this.SendMessageBT.Click += new System.EventHandler(this.SendMessageBT_Click);
            // 
            // PersonCB
            // 
            this.PersonCB.FormattingEnabled = true;
            this.PersonCB.Location = new System.Drawing.Point(22, 371);
            this.PersonCB.Name = "PersonCB";
            this.PersonCB.Size = new System.Drawing.Size(182, 33);
            this.PersonCB.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 330);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 25);
            this.label9.TabIndex = 4;
            this.label9.Text = "Person";
            // 
            // MessageBodyRTB
            // 
            this.MessageBodyRTB.Location = new System.Drawing.Point(22, 194);
            this.MessageBodyRTB.Name = "MessageBodyRTB";
            this.MessageBodyRTB.Size = new System.Drawing.Size(382, 113);
            this.MessageBodyRTB.TabIndex = 3;
            this.MessageBodyRTB.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 25);
            this.label8.TabIndex = 2;
            this.label8.Text = "Message";
            // 
            // MessageTitleRTB
            // 
            this.MessageTitleRTB.Location = new System.Drawing.Point(22, 91);
            this.MessageTitleRTB.Name = "MessageTitleRTB";
            this.MessageTitleRTB.Size = new System.Drawing.Size(382, 44);
            this.MessageTitleRTB.TabIndex = 1;
            this.MessageTitleRTB.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Subject";
            // 
            // ViewMessageBT
            // 
            this.ViewMessageBT.Location = new System.Drawing.Point(597, 524);
            this.ViewMessageBT.Name = "ViewMessageBT";
            this.ViewMessageBT.Size = new System.Drawing.Size(112, 34);
            this.ViewMessageBT.TabIndex = 1;
            this.ViewMessageBT.Text = "View";
            this.ViewMessageBT.UseVisualStyleBackColor = true;
            this.ViewMessageBT.Click += new System.EventHandler(this.ViewMessageBT_Click);
            // 
            // MessagesLB
            // 
            this.MessagesLB.FormattingEnabled = true;
            this.MessagesLB.ItemHeight = 25;
            this.MessagesLB.Location = new System.Drawing.Point(477, 54);
            this.MessagesLB.Name = "MessagesLB";
            this.MessagesLB.Size = new System.Drawing.Size(346, 454);
            this.MessagesLB.TabIndex = 0;
            this.MessagesLB.SelectedIndexChanged += new System.EventHandler(this.MessagesLB_SelectedIndexChanged);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.ShowAllTaskBT);
            this.tabPage5.Controls.Add(this.DeleteTaskBT);
            this.tabPage5.Controls.Add(this.UpdateDateBT);
            this.tabPage5.Controls.Add(this.UpdateDateTB);
            this.tabPage5.Controls.Add(this.label10);
            this.tabPage5.Controls.Add(this.UpdateForBT);
            this.tabPage5.Controls.Add(this.UpdateForTB);
            this.tabPage5.Controls.Add(this.label12);
            this.tabPage5.Controls.Add(this.SearchTaskBT);
            this.tabPage5.Controls.Add(this.ViewUpdateTaskBT);
            this.tabPage5.Controls.Add(this.SearchTaskTB);
            this.tabPage5.Controls.Add(this.UpdateTaskLB);
            this.tabPage5.Location = new System.Drawing.Point(4, 34);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(840, 575);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Update Task";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // ShowAllTaskBT
            // 
            this.ShowAllTaskBT.Location = new System.Drawing.Point(687, 523);
            this.ShowAllTaskBT.Name = "ShowAllTaskBT";
            this.ShowAllTaskBT.Size = new System.Drawing.Size(112, 34);
            this.ShowAllTaskBT.TabIndex = 16;
            this.ShowAllTaskBT.Text = "Show all";
            this.ShowAllTaskBT.UseVisualStyleBackColor = true;
            this.ShowAllTaskBT.Click += new System.EventHandler(this.ShowAllTaskBT_Click);
            // 
            // DeleteTaskBT
            // 
            this.DeleteTaskBT.Location = new System.Drawing.Point(166, 523);
            this.DeleteTaskBT.Name = "DeleteTaskBT";
            this.DeleteTaskBT.Size = new System.Drawing.Size(112, 34);
            this.DeleteTaskBT.TabIndex = 15;
            this.DeleteTaskBT.Text = "Delete";
            this.DeleteTaskBT.UseVisualStyleBackColor = true;
            this.DeleteTaskBT.Click += new System.EventHandler(this.DeleteTaskBT_Click);
            // 
            // UpdateDateBT
            // 
            this.UpdateDateBT.Location = new System.Drawing.Point(206, 175);
            this.UpdateDateBT.Name = "UpdateDateBT";
            this.UpdateDateBT.Size = new System.Drawing.Size(112, 34);
            this.UpdateDateBT.TabIndex = 14;
            this.UpdateDateBT.Text = "Update";
            this.UpdateDateBT.UseVisualStyleBackColor = true;
            this.UpdateDateBT.Click += new System.EventHandler(this.UpdateDateBT_Click);
            // 
            // UpdateDateTB
            // 
            this.UpdateDateTB.Location = new System.Drawing.Point(35, 175);
            this.UpdateDateTB.Name = "UpdateDateTB";
            this.UpdateDateTB.Size = new System.Drawing.Size(150, 31);
            this.UpdateDateTB.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(35, 136);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 25);
            this.label10.TabIndex = 12;
            this.label10.Text = "Date";
            // 
            // UpdateForBT
            // 
            this.UpdateForBT.Location = new System.Drawing.Point(239, 335);
            this.UpdateForBT.Name = "UpdateForBT";
            this.UpdateForBT.Size = new System.Drawing.Size(112, 34);
            this.UpdateForBT.TabIndex = 11;
            this.UpdateForBT.Text = "Update";
            this.UpdateForBT.UseVisualStyleBackColor = true;
            this.UpdateForBT.Click += new System.EventHandler(this.UpdateForBT_Click);
            // 
            // UpdateForTB
            // 
            this.UpdateForTB.Location = new System.Drawing.Point(35, 335);
            this.UpdateForTB.Name = "UpdateForTB";
            this.UpdateForTB.Size = new System.Drawing.Size(177, 31);
            this.UpdateForTB.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(35, 295);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(194, 25);
            this.label12.TabIndex = 9;
            this.label12.Text = "For (Name of member)";
            // 
            // SearchTaskBT
            // 
            this.SearchTaskBT.Location = new System.Drawing.Point(708, 52);
            this.SearchTaskBT.Name = "SearchTaskBT";
            this.SearchTaskBT.Size = new System.Drawing.Size(112, 34);
            this.SearchTaskBT.TabIndex = 4;
            this.SearchTaskBT.Text = "Search";
            this.SearchTaskBT.UseVisualStyleBackColor = true;
            this.SearchTaskBT.Click += new System.EventHandler(this.SearchTaskBT_Click);
            // 
            // ViewUpdateTaskBT
            // 
            this.ViewUpdateTaskBT.Location = new System.Drawing.Point(539, 523);
            this.ViewUpdateTaskBT.Name = "ViewUpdateTaskBT";
            this.ViewUpdateTaskBT.Size = new System.Drawing.Size(112, 34);
            this.ViewUpdateTaskBT.TabIndex = 3;
            this.ViewUpdateTaskBT.Text = "View";
            this.ViewUpdateTaskBT.UseVisualStyleBackColor = true;
            this.ViewUpdateTaskBT.Click += new System.EventHandler(this.ViewUpdateTaskBT_Click);
            // 
            // SearchTaskTB
            // 
            this.SearchTaskTB.Location = new System.Drawing.Point(458, 55);
            this.SearchTaskTB.Name = "SearchTaskTB";
            this.SearchTaskTB.Size = new System.Drawing.Size(236, 31);
            this.SearchTaskTB.TabIndex = 2;
            // 
            // UpdateTaskLB
            // 
            this.UpdateTaskLB.FormattingEnabled = true;
            this.UpdateTaskLB.ItemHeight = 25;
            this.UpdateTaskLB.Location = new System.Drawing.Point(458, 113);
            this.UpdateTaskLB.Name = "UpdateTaskLB";
            this.UpdateTaskLB.Size = new System.Drawing.Size(375, 404);
            this.UpdateTaskLB.TabIndex = 0;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 624);
            this.Controls.Add(this.tabControl1);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminForm_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private GroupBox groupBox1;
        private ListBox HouseMembersLB;
        private Button CreateTaskBT;
        private TextBox TaskDateTB;
        private RichTextBox TaskDescriptionRTB;
        private RichTextBox TaskTitleRTB;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox TaskForTB;
        private Label label4;
        private Button ViewComplaintBT;
        private ListBox ComplaintsLB;
        private Button SetRentBT;
        private TextBox SetRentTB;
        private Label label6;
        private Label RentLabel;
        private Label label5;
        private ListBox RentLB;
        private ListBox MessagesLB;
        private GroupBox groupBox2;
        private Label label7;
        private Button ViewMessageBT;
        private Button SendMessageBT;
        private ComboBox PersonCB;
        private Label label9;
        private RichTextBox MessageBodyRTB;
        private Label label8;
        private RichTextBox MessageTitleRTB;
        private TabPage tabPage5;
        private Button ShowAllTaskBT;
        private Button DeleteTaskBT;
        private Button UpdateDateBT;
        private TextBox UpdateDateTB;
        private Label label10;
        private Button UpdateForBT;
        private TextBox UpdateForTB;
        private Label label12;
        private Button SearchTaskBT;
        private Button ViewUpdateTaskBT;
        private TextBox SearchTaskTB;
        private ListBox UpdateTaskLB;
        private Label label11;
    }
}