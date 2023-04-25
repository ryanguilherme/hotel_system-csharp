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
            //loginButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(143, 203, 123);
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (userText.Text == "")
            {
                MessageBox.Show("     Preencha o Usuário");
                userText.Focus();
                return;
            }
            if (passwordText.Text == "")
            {
                MessageBox.Show("     Preencha a Senha");
                passwordText.Focus(); 
                return;
            }

            //AÇÃO DE LOGIN

            menuForm form = new menuForm();
            this.Hide();
            form.Show();
        }
    }
}