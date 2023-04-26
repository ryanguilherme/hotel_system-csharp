namespace hotel_system
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
            loginPanel.Visible = false;
        }

        private void loginForm_Load(object sender, EventArgs e)
        {
            loginPanel.Location = new Point(this.Width / 4 - 135, this.Height / 2 - 185);
            loginPanel.Visible = true;
            //loginButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(143, 203, 123);
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            LoginCall();
        }

        private void loginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginCall();
            }
        }

        private void LoginCall()
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
            //this.Hide();
            Clear();
            form.Show();

        }

        private void Clear()
        {
            userText.Text = "";
            passwordText.Text = "";
            userText.Focus();
        }

        private void loginForm_Resize(object sender, EventArgs e)
        {
            loginPanel.Location = new Point(this.Width / 4 - 135, this.Height / 2 - 185);
        }
    }
}