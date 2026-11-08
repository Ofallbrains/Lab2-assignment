namespace Lab2_assignment
{
    partial class MushroomForm
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
            titleLbl = new Label();
            qnLbl = new Label();
            qn1Lbl = new Label();
            yesBtn = new Button();
            noBtn = new Button();
            SuspendLayout();
            // 
            // titleLbl
            // 
            titleLbl.AutoSize = true;
            titleLbl.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLbl.ForeColor = Color.Blue;
            titleLbl.Location = new Point(197, 62);
            titleLbl.Name = "titleLbl";
            titleLbl.Size = new Size(381, 32);
            titleLbl.TabIndex = 0;
            titleLbl.Text = "Think one of the six mushrooms";
            // 
            // qnLbl
            // 
            qnLbl.AutoSize = true;
            qnLbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            qnLbl.ForeColor = SystemColors.ActiveCaptionText;
            qnLbl.Location = new Point(312, 117);
            qnLbl.Name = "qnLbl";
            qnLbl.Size = new Size(117, 21);
            qnLbl.TabIndex = 1;
            qnLbl.Text = "Question 1 of 3";
            qnLbl.Click += qnLbl_Click;
            // 
            // qn1Lbl
            // 
            qn1Lbl.AutoSize = true;
            qn1Lbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            qn1Lbl.ForeColor = SystemColors.ActiveCaptionText;
            qn1Lbl.Location = new Point(241, 174);
            qn1Lbl.Name = "qn1Lbl";
            qn1Lbl.Size = new Size(290, 21);
            qn1Lbl.TabIndex = 2;
            qn1Lbl.Text = "Does your mushroom grow in a forest ? ";
            qn1Lbl.Click += qn1Lbl_Click;
            // 
            // yesBtn
            // 
            yesBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            yesBtn.ForeColor = Color.Blue;
            yesBtn.Location = new Point(241, 229);
            yesBtn.Name = "yesBtn";
            yesBtn.Size = new Size(75, 32);
            yesBtn.TabIndex = 3;
            yesBtn.Text = "Yes";
            yesBtn.UseVisualStyleBackColor = true;
            yesBtn.Click += yesBtn_Click;
            // 
            // noBtn
            // 
            noBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            noBtn.ForeColor = Color.Red;
            noBtn.Location = new Point(424, 229);
            noBtn.Name = "noBtn";
            noBtn.Size = new Size(75, 32);
            noBtn.TabIndex = 4;
            noBtn.Text = "No";
            noBtn.UseVisualStyleBackColor = true;
            noBtn.Click += noBtn_Click;
            // 
            // MushroomForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(noBtn);
            Controls.Add(yesBtn);
            Controls.Add(qn1Lbl);
            Controls.Add(qnLbl);
            Controls.Add(titleLbl);
            Name = "MushroomForm";
            Text = "MushroomForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLbl;
        private Label qnLbl;
        private Label qn1Lbl;
        private Button yesBtn;
        private Button noBtn;
    }
}