namespace Lab2_assignment
{
    partial class form1
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
            usernameLbl = new Label();
            passwordLbl = new Label();
            usernametxt = new TextBox();
            titleLbl = new Label();
            passwordtxt = new TextBox();
            loginBtn = new Button();
            SuspendLayout();
            // 
            // usernameLbl
            // 
            usernameLbl.AutoSize = true;
            usernameLbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameLbl.Location = new Point(102, 139);
            usernameLbl.Name = "usernameLbl";
            usernameLbl.Size = new Size(81, 21);
            usernameLbl.TabIndex = 1;
            usernameLbl.Text = "Username";
            // 
            // passwordLbl
            // 
            passwordLbl.AutoSize = true;
            passwordLbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordLbl.Location = new Point(102, 195);
            passwordLbl.Name = "passwordLbl";
            passwordLbl.Size = new Size(76, 21);
            passwordLbl.TabIndex = 2;
            passwordLbl.Text = "Password";
            // 
            // usernametxt
            // 
            usernametxt.Location = new Point(198, 141);
            usernametxt.Name = "usernametxt";
            usernametxt.Size = new Size(164, 23);
            usernametxt.TabIndex = 3;
            usernametxt.TextChanged += usernametxt_TextChanged;
            // 
            // titleLbl
            // 
            titleLbl.AutoSize = true;
            titleLbl.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLbl.ForeColor = Color.Blue;
            titleLbl.Location = new Point(186, 48);
            titleLbl.Name = "titleLbl";
            titleLbl.Size = new Size(415, 32);
            titleLbl.TabIndex = 4;
            titleLbl.Text = "Bicycle Rental and Mushroom  App";
            // 
            // passwordtxt
            // 
            passwordtxt.Location = new Point(198, 195);
            passwordtxt.Name = "passwordtxt";
            passwordtxt.Size = new Size(164, 23);
            passwordtxt.TabIndex = 5;
            passwordtxt.TextChanged += passwordtxt_TextChanged;
            // 
            // loginBtn
            // 
            loginBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginBtn.ForeColor = Color.Blue;
            loginBtn.Location = new Point(221, 271);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(102, 37);
            loginBtn.TabIndex = 6;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += loginBtn_Click;
            // 
            // form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(loginBtn);
            Controls.Add(passwordtxt);
            Controls.Add(titleLbl);
            Controls.Add(usernametxt);
            Controls.Add(passwordLbl);
            Controls.Add(usernameLbl);
            Name = "form1";
            Text = "Login Form";
            Load += form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label usernameLbl;
        private Label passwordLbl;
        private TextBox usernametxt;
        private Label titleLbl;
        private TextBox passwordtxt;
        private Button loginBtn;
    }
}
