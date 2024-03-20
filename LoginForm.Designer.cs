namespace Project
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            btnLogin = new Button();
            btnRegister = new Button();
            lbUsername = new Label();
            lbPassword = new Label();
            tbUsername = new TextBox();
            tbPassword = new TextBox();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.Location = new Point(52, 284);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegister.Location = new Point(52, 335);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(94, 29);
            btnRegister.TabIndex = 1;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.BackColor = Color.MistyRose;
            lbUsername.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbUsername.Location = new Point(52, 81);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(80, 20);
            lbUsername.TabIndex = 3;
            lbUsername.Text = "Username";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.BackColor = Color.MistyRose;
            lbPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbPassword.Location = new Point(52, 172);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(76, 20);
            lbPassword.TabIndex = 4;
            lbPassword.Text = "Password";
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(618, 81);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(177, 27);
            tbUsername.TabIndex = 5;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(618, 165);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.Size = new Size(177, 27);
            tbPassword.TabIndex = 6;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(821, 450);
            Controls.Add(tbPassword);
            Controls.Add(tbUsername);
            Controls.Add(lbPassword);
            Controls.Add(lbUsername);
            Controls.Add(btnRegister);
            Controls.Add(btnLogin);
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private Button btnRegister;
        private Label lbUsername;
        private Label lbPassword;
        private TextBox tbUsername;
        private TextBox tbPassword;
    }
}