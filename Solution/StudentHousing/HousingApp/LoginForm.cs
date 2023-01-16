namespace HousingApp
{
    public partial class LoginForm : Form
    {
        
        private  Building building;
       
       
        FileManager fileManager = new FileManager();
       

        public LoginForm(Building building)
        {
            InitializeComponent();
            this.building = building;
        }

        private void LoginBT_Click(object sender, EventArgs e) 
        {
           

            foreach(Admin admin in building.GetAdmins())
            {
                if(admin.Username == UserNameTB.Text && admin.Password == PasswordTB.Text)
                {
                   
                    FormManager.admin = admin;
                    FormManager.adminForm.Show();
                    this.Hide();
                    break;
                }
            }

            foreach (Student student in building.GetStudents())
            {
                if (student.Username == UserNameTB.Text && student.Password == PasswordTB.Text)
                {

                    FormManager.Student = student;
                    FormManager.MenuForm.Show();
                    this.Hide();
                    break;
                }

            }

        }

        private void SignUpBT_Click(object sender, EventArgs e)
        {
            new SignUpForm(building).Show();
            this.Hide();    
            
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            Building LoadedBuilding = fileManager.LoadFromFile();
            if(LoadedBuilding != null)
            {
                LoadedBuilding.Repair();
                this.building = LoadedBuilding;
                FormManager.building = LoadedBuilding;
            }
        }

        private void ShowPasswordCB_CheckedChanged(object sender, EventArgs e)
        {
            bool ShowPassword = ShowPasswordCB.Checked;
            if(ShowPassword == true)
            { 
                PasswordTB.UseSystemPasswordChar= false; 
            }
            else
            {
                PasswordTB.UseSystemPasswordChar = true;
            }
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            fileManager.SaveToFile(building);
        }
    }
}