using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace HousingApp
{
    public partial class SignUpForm : Form
    {
        private readonly Building building;

        public SignUpForm(Building building)
        {
            InitializeComponent();
            this.building = building;
            foreach(House house in building.GetHouse())
            {
                HouseCB.Items.Add(house);   
            }
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            SubmitBT.Enabled = TermsCB.Checked; 
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Other than the content you own, under these Terms, STUDENTHOUSING and/or its licensors own all the intellectual property rights and materials contained in this application.\r\n\r\nYou are granted limited license only for purposes of viewing the material contained on this Website.You are specifically restricted from all of the following:\r\n\r\npublishing any Website material in any other media;\r\nselling, sublicensing and/or otherwise commercializing any Website material;\r\npublicly performing and/or showing any Website material;\r\nusing this Website in any way that is or may be damaging to this Website;\r\nusing this Website in any way that impacts user access to this Website;\r\nusing this Website contrary to applicable laws and regulations, or in any way may cause harm to the Website, or to any person or business entity;\r\nengaging in any data mining, data harvesting, data extracting or any other similar activity in relation to this Website;\r\nusing this Website to engage in any advertising or marketing.\r\nCertain areas of this Website are restricted from being access by you and STUDENTHOUSING may further restrict access by you to any areas of this Website, at any time, in absolute discretion. Any user ID and password you may have for this Website are confidential and you must maintain confidentiality as well.\r\n\r\nYour Content\r\nIn these Website Standard Terms and Conditions, \"Your Content\" shall mean any audio, video text, images or other material you choose to display on this Website. By displaying Your Content, you grant STUDENTHOUSING a non-exclusive, worldwide irrevocable, sub licensable license to use, reproduce, adapt, publish, translate and distribute it in any and all media.\r\n\r\nYour Content must be your own and must not be invading any third-party’s rights. STUDENTHOUSING reserves the right to remove any of Your Content from this Website at any time without notice.\r\n\r\nYour Privacy\r\nPlease read Privacy Policy.\r\n\r\nNo warranties\r\nThis Website is provided \"as is,\" with all faults, and STUDENTHOUSING express no representations or warranties, of any kind related to this Website or the materials contained on this Website. Also, nothing contained on this Website shall be interpreted as advising you.\r\n\r\nLimitation of liability\r\nIn no event shall STUDENTHOUSING, nor any of its officers, directors and employees, shall be held liable for anything arising out of or in any way connected with your use of this Website whether such liability is under contract.  STUDENTHOUSING, including its officers, directors and employees shall not be held liable for any indirect, consequential or special liability arising out of or in any way related to your use of this Website.\r\n\r\nIndemnification\r\nYou hereby indemnify to the fullest extent STUDENTHOUSING from and against any and/or all liabilities, costs, demands, causes of action, damages and expenses arising in any way related to your breach of any of the provisions of these Terms.\r\n\r\nSeverability\r\nIf any provision of these Terms is found to be invalid under any applicable law, such provisions shall be deleted without affecting the remaining provisions herein.\r\n\r\nVariation of Terms\r\nSTUDENTHOUSING is permitted to revise these Terms at any time as it sees fit, and by using this Website you are expected to review these Terms on a regular basis.\r\n\r\nAssignment\r\nThe STUDENTHOUSING is allowed to assign, transfer, and subcontract its rights and/or obligations under these Terms without any notification. However, you are not allowed to assign, transfer, or subcontract any of your rights and/or obligations under these Terms.\r\n\r\nEntire Agreement\r\nThese Terms constitute the entire agreement between STUDENTHOUSING and you in relation to your use of this Website, and supersede all prior agreements and understandings.\r\n\r\nGoverning Law & Jurisdiction\r\nThese Terms will be governed by and interpreted in accordance with the laws of the State of nl, and you submit to the non-exclusive jurisdiction of the state and federal courts located in nl for the resolution of any disputes."); 
            
        }

        private void label6_Click(object sender, EventArgs e)
        {
            
        }

        private void SubmitBT_Click(object sender, EventArgs e)  
        {
            if (UserNameTB.Text != "" && PasswordTB.Text != "" && FirstNameTB.Text != "" && LastNameTB.Text != "" && ConformPasswordTB.Text !="" && HouseCB != null && PasswordTB.Text == ConformPasswordTB.Text)
            {
                bool CheckIfUnique = true;
                foreach(Student stu in building.GetStudents())
                {
                    if(stu.Username == UserNameTB.Text && stu.Password == PasswordTB.Text)
                    {
                        CheckIfUnique = false;
                        break;
                    }
                }
                if (CheckIfUnique == true)
                {
                    Student student = new Student(FirstNameTB.Text, LastNameTB.Text, UserNameTB.Text, PasswordTB.Text, (House)HouseCB.SelectedItem);
                    building.AddStudent(student);
                }
                else
                {
                    MessageBox.Show("Enter a different Username or password");
                }
                
            }
            else
            {
                MessageBox.Show("Invalid Input");
            }
            
            
        }

        private void BackToLoginBT_Click(object sender, EventArgs e)
        {
            FormManager.loginForm.Show();
            this.Hide();
            
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       

        

        private void SignUpForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormManager.signUpForm = null;
            FormManager.loginForm.Show();
        }
    }
}
