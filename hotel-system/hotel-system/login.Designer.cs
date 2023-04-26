namespace hotel_system
{
    partial class loginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            loginPanel = new Panel();
            loginButton = new Button();
            passwordText = new TextBox();
            userText = new TextBox();
            loginPanel.SuspendLayout();
            SuspendLayout();
            // 
            // loginPanel
            // 
            loginPanel.BackColor = Color.Transparent;
            loginPanel.BackgroundImage = (Image)resources.GetObject("loginPanel.BackgroundImage");
            loginPanel.Controls.Add(loginButton);
            loginPanel.Controls.Add(passwordText);
            loginPanel.Controls.Add(userText);
            loginPanel.Location = new Point(66, 57);
            loginPanel.Name = "loginPanel";
            loginPanel.Size = new Size(237, 333);
            loginPanel.TabIndex = 0;
            // 
            // loginButton
            // 
            loginButton.Cursor = Cursors.Hand;
            loginButton.FlatAppearance.BorderSize = 0;
            loginButton.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            loginButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.Location = new Point(1, 218);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(209, 53);
            loginButton.TabIndex = 2;
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // passwordText
            // 
            passwordText.BackColor = Color.FromArgb(224, 224, 224);
            passwordText.BorderStyle = BorderStyle.None;
            passwordText.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point);
            passwordText.Location = new Point(92, 182);
            passwordText.Name = "passwordText";
            passwordText.PasswordChar = '•';
            passwordText.Size = new Size(105, 16);
            passwordText.TabIndex = 1;
            // 
            // userText
            // 
            userText.BackColor = Color.FromArgb(224, 224, 224);
            userText.BorderStyle = BorderStyle.None;
            userText.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point);
            userText.Location = new Point(92, 136);
            userText.Name = "userText";
            userText.Size = new Size(105, 16);
            userText.TabIndex = 0;
            // 
            // loginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(loginPanel);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            Name = "loginForm";
            Text = "Login";
            Load += loginForm_Load;
            KeyDown += loginForm_KeyDown;
            Resize += loginForm_Resize;
            loginPanel.ResumeLayout(false);
            loginPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel loginPanel;
        private TextBox userText;
        private TextBox passwordText;
        private Button loginButton;
    }
}