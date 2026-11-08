namespace Lab2_assignment
{
    partial class BicycleRentalForm
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
            bicycleLbl = new Label();
            label1 = new Label();
            startingLbl = new Label();
            endingLbl = new Label();
            startingTxt = new TextBox();
            endingTxt = new TextBox();
            calculateBtn = new Button();
            totalLbl = new Label();
            totalTxt = new TextBox();
            SuspendLayout();
            // 
            // bicycleLbl
            // 
            bicycleLbl.AutoSize = true;
            bicycleLbl.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bicycleLbl.ForeColor = Color.Blue;
            bicycleLbl.Location = new Point(243, 48);
            bicycleLbl.Name = "bicycleLbl";
            bicycleLbl.Size = new Size(283, 32);
            bicycleLbl.TabIndex = 0;
            bicycleLbl.Text = "Bicycle Rental Calculate";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(215, 92);
            label1.Name = "label1";
            label1.Size = new Size(326, 21);
            label1.TabIndex = 1;
            label1.Text = "Starting Hours : 0-23 and Ending Hours : 1-24";
            // 
            // startingLbl
            // 
            startingLbl.AutoSize = true;
            startingLbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            startingLbl.Location = new Point(44, 141);
            startingLbl.Name = "startingLbl";
            startingLbl.Size = new Size(110, 21);
            startingLbl.TabIndex = 2;
            startingLbl.Text = "Starting Hour :";
            // 
            // endingLbl
            // 
            endingLbl.AutoSize = true;
            endingLbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            endingLbl.Location = new Point(44, 192);
            endingLbl.Name = "endingLbl";
            endingLbl.Size = new Size(104, 21);
            endingLbl.TabIndex = 3;
            endingLbl.Text = "Ending Hour :";
            // 
            // startingTxt
            // 
            startingTxt.Location = new Point(215, 143);
            startingTxt.Name = "startingTxt";
            startingTxt.Size = new Size(110, 23);
            startingTxt.TabIndex = 4;
            startingTxt.TextChanged += startingTxt_TextChanged;
            // 
            // endingTxt
            // 
            endingTxt.Location = new Point(215, 194);
            endingTxt.Name = "endingTxt";
            endingTxt.Size = new Size(110, 23);
            endingTxt.TabIndex = 5;
            endingTxt.TextChanged += endingTxt_TextChanged;
            // 
            // calculateBtn
            // 
            calculateBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            calculateBtn.ForeColor = Color.Blue;
            calculateBtn.Location = new Point(215, 244);
            calculateBtn.Name = "calculateBtn";
            calculateBtn.Size = new Size(171, 54);
            calculateBtn.TabIndex = 6;
            calculateBtn.Text = "Calculate Total";
            calculateBtn.UseVisualStyleBackColor = true;
            calculateBtn.Click += calculateBtn_Click;
            // 
            // totalLbl
            // 
            totalLbl.AutoSize = true;
            totalLbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            totalLbl.Location = new Point(44, 327);
            totalLbl.Name = "totalLbl";
            totalLbl.Size = new Size(150, 21);
            totalLbl.TabIndex = 7;
            totalLbl.Text = "The total amount is :";
            totalLbl.Click += label2_Click;
            // 
            // totalTxt
            // 
            totalTxt.Location = new Point(215, 325);
            totalTxt.Name = "totalTxt";
            totalTxt.Size = new Size(110, 23);
            totalTxt.TabIndex = 8;
            totalTxt.TextChanged += totalTxt_TextChanged;
            // 
            // BicycleRentalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(totalTxt);
            Controls.Add(totalLbl);
            Controls.Add(calculateBtn);
            Controls.Add(endingTxt);
            Controls.Add(startingTxt);
            Controls.Add(endingLbl);
            Controls.Add(startingLbl);
            Controls.Add(label1);
            Controls.Add(bicycleLbl);
            Name = "BicycleRentalForm";
            Text = "BicycleRentalForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label bicycleLbl;
        private Label label1;
        private Label startingLbl;
        private Label endingLbl;
        private TextBox startingTxt;
        private TextBox endingTxt;
        private Button calculateBtn;
        private Label totalLbl;
        private TextBox totalTxt;
    }
}