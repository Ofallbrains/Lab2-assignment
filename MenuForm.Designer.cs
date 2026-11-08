namespace Lab2_assignment
{
    partial class MenuForm
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
            menuLbl = new Label();
            bicycleBtn = new Button();
            mushroomBtn = new Button();
            logoutBtn = new Button();
            SuspendLayout();
            // 
            // menuLbl
            // 
            menuLbl.AutoSize = true;
            menuLbl.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuLbl.ForeColor = Color.Blue;
            menuLbl.Location = new Point(271, 58);
            menuLbl.Name = "menuLbl";
            menuLbl.Size = new Size(222, 32);
            menuLbl.TabIndex = 0;
            menuLbl.Text = "Choose an activity";
            // 
            // bicycleBtn
            // 
            bicycleBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bicycleBtn.Location = new Point(195, 150);
            bicycleBtn.Name = "bicycleBtn";
            bicycleBtn.Size = new Size(126, 45);
            bicycleBtn.TabIndex = 1;
            bicycleBtn.Text = "Bicycle Rental";
            bicycleBtn.UseVisualStyleBackColor = true;
            bicycleBtn.Click += bicycleBtn_Click;
            // 
            // mushroomBtn
            // 
            mushroomBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mushroomBtn.Location = new Point(400, 150);
            mushroomBtn.Name = "mushroomBtn";
            mushroomBtn.Size = new Size(126, 45);
            mushroomBtn.TabIndex = 2;
            mushroomBtn.Text = "Mushroom";
            mushroomBtn.UseVisualStyleBackColor = true;
            mushroomBtn.Click += mushroomBtn_Click;
            // 
            // logoutBtn
            // 
            logoutBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logoutBtn.ForeColor = Color.Blue;
            logoutBtn.Location = new Point(302, 242);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Size = new Size(126, 45);
            logoutBtn.TabIndex = 3;
            logoutBtn.Text = "Logout";
            logoutBtn.UseVisualStyleBackColor = true;
            logoutBtn.Click += logoutBtn_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(logoutBtn);
            Controls.Add(mushroomBtn);
            Controls.Add(bicycleBtn);
            Controls.Add(menuLbl);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "MenuForm";
            Text = "MenuForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label menuLbl;
        private Button bicycleBtn;
        private Button mushroomBtn;
        private Button logoutBtn;
    }
}