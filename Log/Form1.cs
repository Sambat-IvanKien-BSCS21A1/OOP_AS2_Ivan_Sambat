namespace Log
{

    public partial class Form1 : Form
    {
        private User userData;
        private string path;
        public Form1()
        {
            InitializeComponent();
            userData = new User();
            path = userData.filePath;
            label2.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            

            if (userData.IsValid(username, password))
            {
                label2.Text = "Login Successful!";
                label2.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                label2.Text = "Invalid username/password.";
                label2.ForeColor = System.Drawing.Color.Red;
            }
            label2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            userData.LoadUsersFromJson(path);

        }
    }
}
