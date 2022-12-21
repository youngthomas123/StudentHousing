namespace HousingApp
{
    public partial class Form1 : Form
    {
        //public static Building abc = new Building();
        private readonly Building building;

        public Form1(Building building)
        {
            InitializeComponent();
            this.building = building;
        }

        private void button1_Click(object sender, EventArgs e) 
        {

            new Form2(building).Show();

        }
    }
}