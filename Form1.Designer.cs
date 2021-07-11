
namespace money_calc
{
    partial class Form1
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
            this.TimeFrame = new System.Windows.Forms.ComboBox();
            this.Calculate = new System.Windows.Forms.Button();
            this.MoneyGot = new System.Windows.Forms.TextBox();
            this.TimeTotal = new System.Windows.Forms.TextBox();
            this.MoneyTotal = new System.Windows.Forms.TextBox();
            this.TimeGot = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TimeFrameTotal = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TimeNeed = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.MoneyWant = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TimeFrame
            // 
            this.TimeFrame.FormattingEnabled = true;
            this.TimeFrame.Items.AddRange(new object[] {
            "Day(s)",
            "Week(s)",
            "Month(s)",
            "Year(s)"});
            this.TimeFrame.Location = new System.Drawing.Point(443, 68);
            this.TimeFrame.Name = "TimeFrame";
            this.TimeFrame.Size = new System.Drawing.Size(75, 21);
            this.TimeFrame.TabIndex = 0;
            this.TimeFrame.Text = "Day(s)";
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(9, 250);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(100, 23);
            this.Calculate.TabIndex = 5;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // MoneyGot
            // 
            this.MoneyGot.Location = new System.Drawing.Point(9, 29);
            this.MoneyGot.Name = "MoneyGot";
            this.MoneyGot.Size = new System.Drawing.Size(100, 20);
            this.MoneyGot.TabIndex = 1;
            // 
            // TimeTotal
            // 
            this.TimeTotal.Location = new System.Drawing.Point(9, 107);
            this.TimeTotal.Name = "TimeTotal";
            this.TimeTotal.Size = new System.Drawing.Size(100, 20);
            this.TimeTotal.TabIndex = 3;
            // 
            // MoneyTotal
            // 
            this.MoneyTotal.Location = new System.Drawing.Point(8, 146);
            this.MoneyTotal.Name = "MoneyTotal";
            this.MoneyTotal.ReadOnly = true;
            this.MoneyTotal.Size = new System.Drawing.Size(100, 20);
            this.MoneyTotal.TabIndex = 6;
            // 
            // TimeGot
            // 
            this.TimeGot.Location = new System.Drawing.Point(9, 68);
            this.TimeGot.Name = "TimeGot";
            this.TimeGot.Size = new System.Drawing.Size(100, 20);
            this.TimeGot.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Money Recieved";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Every";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "For";
            // 
            // TimeFrameTotal
            // 
            this.TimeFrameTotal.FormattingEnabled = true;
            this.TimeFrameTotal.Items.AddRange(new object[] {
            "Day(s)",
            "Week(s)",
            "Month(s)",
            "Year(s)"});
            this.TimeFrameTotal.Location = new System.Drawing.Point(443, 112);
            this.TimeFrameTotal.Name = "TimeFrameTotal";
            this.TimeFrameTotal.Size = new System.Drawing.Size(75, 21);
            this.TimeFrameTotal.TabIndex = 9;
            this.TimeFrameTotal.Text = "Day(s)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Days to get amount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Amount wanted";
            // 
            // TimeNeed
            // 
            this.TimeNeed.Location = new System.Drawing.Point(9, 224);
            this.TimeNeed.Name = "TimeNeed";
            this.TimeNeed.ReadOnly = true;
            this.TimeNeed.Size = new System.Drawing.Size(100, 20);
            this.TimeNeed.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(78, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Days";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(78, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Days";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Totals";
            // 
            // MoneyWant
            // 
            this.MoneyWant.Location = new System.Drawing.Point(8, 185);
            this.MoneyWant.Name = "MoneyWant";
            this.MoneyWant.Size = new System.Drawing.Size(100, 20);
            this.MoneyWant.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(132, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Salary Calculator";
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Location = new System.Drawing.Point(104, 0);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(14, 13);
            this.exit.TabIndex = 18;
            this.exit.Text = "X";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(-1, 0);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(13, 13);
            this.info.TabIndex = 19;
            this.info.Text = "?";
            this.info.Click += new System.EventHandler(this.info_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(121, 280);
            this.ControlBox = false;
            this.Controls.Add(this.info);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.MoneyWant);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TimeNeed);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TimeFrameTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TimeGot);
            this.Controls.Add(this.MoneyTotal);
            this.Controls.Add(this.TimeTotal);
            this.Controls.Add(this.MoneyGot);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.TimeFrame);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Salary Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox TimeFrame;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.TextBox MoneyGot;
        private System.Windows.Forms.TextBox TimeTotal;
        private System.Windows.Forms.TextBox MoneyTotal;
        private System.Windows.Forms.TextBox TimeGot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox TimeFrameTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TimeNeed;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox MoneyWant;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Label info;
    }
}

