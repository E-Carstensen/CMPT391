namespace CMPT391Project
{
    partial class LogIn
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
            this.logInPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.enrolledClasses1 = new CMPT391Project.EnrolledClasses();
            this.classSearch1 = new CMPT391Project.ClassSearch();
            this.cartPage1 = new CMPT391Project.CartPage();
            this.profilePage1 = new CMPT391Project.ProfilePage();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.userName = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.profileButton = new System.Windows.Forms.Button();
            this.classSearchButton = new System.Windows.Forms.Button();
            this.cartButton = new System.Windows.Forms.Button();
            this.enrolledClassesButton = new System.Windows.Forms.Button();
            this.logOutButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.logInPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // logInPanel
            // 
            this.logInPanel.Controls.Add(this.panel1);
            this.logInPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logInPanel.Location = new System.Drawing.Point(0, 0);
            this.logInPanel.Name = "logInPanel";
            this.logInPanel.Size = new System.Drawing.Size(1026, 666);
            this.logInPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.usernameLabel);
            this.panel1.Controls.Add(this.passwordLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1026, 666);
            this.panel1.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.enrolledClasses1);
            this.panel3.Controls.Add(this.classSearch1);
            this.panel3.Controls.Add(this.cartPage1);
            this.panel3.Controls.Add(this.profilePage1);
            this.panel3.Controls.Add(this.LoginLabel);
            this.panel3.Controls.Add(this.loginButton);
            this.panel3.Controls.Add(this.password);
            this.panel3.Controls.Add(this.userName);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(218, 65);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(808, 601);
            this.panel3.TabIndex = 6;
            // 
            // enrolledClasses1
            // 
            this.enrolledClasses1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.enrolledClasses1.Location = new System.Drawing.Point(0, 0);
            this.enrolledClasses1.Name = "enrolledClasses1";
            this.enrolledClasses1.Size = new System.Drawing.Size(808, 601);
            this.enrolledClasses1.TabIndex = 9;
            this.enrolledClasses1.Load += new System.EventHandler(this.enrolledClasses1_Load);
            // 
            // classSearch1
            // 
            this.classSearch1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.classSearch1.Location = new System.Drawing.Point(0, 0);
            this.classSearch1.Name = "classSearch1";
            this.classSearch1.Size = new System.Drawing.Size(808, 601);
            this.classSearch1.TabIndex = 8;
            // 
            // cartPage1
            // 
            this.cartPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cartPage1.Location = new System.Drawing.Point(0, 0);
            this.cartPage1.Name = "cartPage1";
            this.cartPage1.Size = new System.Drawing.Size(808, 601);
            this.cartPage1.TabIndex = 7;
            this.cartPage1.Load += new System.EventHandler(this.cartPage1_Load);
            // 
            // profilePage1
            // 
            this.profilePage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profilePage1.Location = new System.Drawing.Point(0, 0);
            this.profilePage1.Name = "profilePage1";
            this.profilePage1.Size = new System.Drawing.Size(808, 601);
            this.profilePage1.TabIndex = 6;
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginLabel.Location = new System.Drawing.Point(131, 68);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(110, 42);
            this.LoginLabel.TabIndex = 5;
            this.LoginLabel.Text = "Login";
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(103, 318);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(152, 43);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(72, 241);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(224, 20);
            this.password.TabIndex = 0;
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(72, 170);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(224, 20);
            this.userName.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.flowLayoutPanel1.Controls.Add(this.profileButton);
            this.flowLayoutPanel1.Controls.Add(this.classSearchButton);
            this.flowLayoutPanel1.Controls.Add(this.cartButton);
            this.flowLayoutPanel1.Controls.Add(this.enrolledClassesButton);
            this.flowLayoutPanel1.Controls.Add(this.logOutButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 65);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(218, 601);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // profileButton
            // 
            this.profileButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.profileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profileButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.profileButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.profileButton.Location = new System.Drawing.Point(3, 3);
            this.profileButton.Name = "profileButton";
            this.profileButton.Size = new System.Drawing.Size(215, 48);
            this.profileButton.TabIndex = 6;
            this.profileButton.Text = "Profile";
            this.profileButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.profileButton.UseVisualStyleBackColor = false;
            this.profileButton.Click += new System.EventHandler(this.profileButton_Click);
            // 
            // classSearchButton
            // 
            this.classSearchButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.classSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.classSearchButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.classSearchButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.classSearchButton.Location = new System.Drawing.Point(3, 57);
            this.classSearchButton.Name = "classSearchButton";
            this.classSearchButton.Size = new System.Drawing.Size(215, 48);
            this.classSearchButton.TabIndex = 6;
            this.classSearchButton.Text = "Class Search";
            this.classSearchButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.classSearchButton.UseVisualStyleBackColor = false;
            this.classSearchButton.Click += new System.EventHandler(this.classSearchButton_Click);
            // 
            // cartButton
            // 
            this.cartButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cartButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cartButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cartButton.Location = new System.Drawing.Point(3, 111);
            this.cartButton.Name = "cartButton";
            this.cartButton.Size = new System.Drawing.Size(215, 48);
            this.cartButton.TabIndex = 6;
            this.cartButton.Text = "Cart";
            this.cartButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cartButton.UseVisualStyleBackColor = false;
            this.cartButton.Click += new System.EventHandler(this.cartButton_Click);
            // 
            // enrolledClassesButton
            // 
            this.enrolledClassesButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.enrolledClassesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enrolledClassesButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.enrolledClassesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.enrolledClassesButton.Location = new System.Drawing.Point(3, 165);
            this.enrolledClassesButton.Name = "enrolledClassesButton";
            this.enrolledClassesButton.Size = new System.Drawing.Size(215, 48);
            this.enrolledClassesButton.TabIndex = 6;
            this.enrolledClassesButton.Text = "Enrolled Classes";
            this.enrolledClassesButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.enrolledClassesButton.UseVisualStyleBackColor = false;
            this.enrolledClassesButton.Click += new System.EventHandler(this.enrolledClassesButton_Click);
            // 
            // logOutButton
            // 
            this.logOutButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.logOutButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOutButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logOutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logOutButton.Location = new System.Drawing.Point(3, 219);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(215, 48);
            this.logOutButton.TabIndex = 6;
            this.logOutButton.Text = "LOG OUT";
            this.logOutButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logOutButton.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.exitButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1026, 65);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // exitButton
            // 
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.exitButton.Location = new System.Drawing.Point(939, 12);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(327, 309);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(55, 13);
            this.usernameLabel.TabIndex = 1;
            this.usernameLabel.Text = "StudentID";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(327, 384);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(53, 13);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "Password";
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 666);
            this.Controls.Add(this.logInPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LogIn";
            this.Text = "Login Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.logInPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel logInPanel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Button profileButton;
        private System.Windows.Forms.Button classSearchButton;
        private System.Windows.Forms.Button cartButton;
        private System.Windows.Forms.Button enrolledClassesButton;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Panel panel3;
        private CartPage cartPage1;
        private ProfilePage profilePage1;
        private ClassSearch classSearch1;
        private EnrolledClasses enrolledClasses1;
    }
}

