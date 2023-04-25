namespace hotel_system
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void loginForm_Load(object sender, EventArgs e)
        {
            loginPanel.Location = new Point(this.Width / 4 - 135, this.Height / 2 - 185);

        }
    }
}