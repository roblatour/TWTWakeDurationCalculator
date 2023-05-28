namespace WiFi6TWTCalculator
{
    partial class Form1
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
            label1 = new Label();
            tbDays = new TextBox();
            tbHours = new TextBox();
            Label2 = new Label();
            tbMinutes = new TextBox();
            label3 = new Label();
            tbSeconds = new TextBox();
            label4 = new Label();
            tbMicroseconds = new TextBox();
            label5 = new Label();
            groupBox1 = new GroupBox();
            label15 = new Label();
            tbMilliseconds = new TextBox();
            label7 = new Label();
            label6 = new Label();
            tbTotalMicroseconds = new TextBox();
            btnCalculate = new Button();
            gbResults = new GroupBox();
            gbUnder = new GroupBox();
            tbWakeIntervalExponentUnder = new TextBox();
            label11 = new Label();
            tbMantissaUnder = new TextBox();
            label12 = new Label();
            gbOver = new GroupBox();
            tbWakeIntervalExponentOver = new TextBox();
            label10 = new Label();
            tbMantissaOver = new TextBox();
            label9 = new Label();
            gbExact = new GroupBox();
            tbWakeIntervalExponentExact = new TextBox();
            label13 = new Label();
            tbMantissaExact = new TextBox();
            label14 = new Label();
            btnClear = new Button();
            btnAbout = new Button();
            groupBox1.SuspendLayout();
            gbResults.SuspendLayout();
            gbUnder.SuspendLayout();
            gbOver.SuspendLayout();
            gbExact.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 60);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 0;
            label1.Text = "Days";
            // 
            // tbDays
            // 
            tbDays.Location = new Point(14, 34);
            tbDays.Name = "tbDays";
            tbDays.Size = new Size(51, 23);
            tbDays.TabIndex = 0;
            tbDays.TextAlign = HorizontalAlignment.Right;
            tbDays.TextChanged += tbDays_TextChanged;
            // 
            // tbHours
            // 
            tbHours.Location = new Point(81, 34);
            tbHours.Name = "tbHours";
            tbHours.Size = new Size(51, 23);
            tbHours.TabIndex = 1;
            tbHours.TextAlign = HorizontalAlignment.Right;
            tbHours.TextChanged += tbHours_TextChanged;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Location = new Point(86, 60);
            Label2.Name = "Label2";
            Label2.Size = new Size(39, 15);
            Label2.TabIndex = 2;
            Label2.Text = "Hours";
            // 
            // tbMinutes
            // 
            tbMinutes.Location = new Point(148, 34);
            tbMinutes.Name = "tbMinutes";
            tbMinutes.Size = new Size(51, 23);
            tbMinutes.TabIndex = 2;
            tbMinutes.TextAlign = HorizontalAlignment.Right;
            tbMinutes.TextChanged += tbMinutes_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(149, 60);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 4;
            label3.Text = "Minutes";
            // 
            // tbSeconds
            // 
            tbSeconds.Location = new Point(215, 34);
            tbSeconds.Name = "tbSeconds";
            tbSeconds.Size = new Size(51, 23);
            tbSeconds.TabIndex = 3;
            tbSeconds.TextAlign = HorizontalAlignment.Right;
            tbSeconds.TextChanged += tbSeconds_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(215, 60);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 6;
            label4.Text = "Seconds";
            // 
            // tbMicroseconds
            // 
            tbMicroseconds.Location = new Point(371, 34);
            tbMicroseconds.Name = "tbMicroseconds";
            tbMicroseconds.Size = new Size(73, 23);
            tbMicroseconds.TabIndex = 5;
            tbMicroseconds.TextAlign = HorizontalAlignment.Right;
            tbMicroseconds.TextChanged += tbMicroseconds_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(373, 61);
            label5.Name = "label5";
            label5.Size = new Size(81, 15);
            label5.TabIndex = 8;
            label5.Text = "Microseconds";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(tbMilliseconds);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(tbTotalMicroseconds);
            groupBox1.Controls.Add(tbMicroseconds);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(tbDays);
            groupBox1.Controls.Add(tbSeconds);
            groupBox1.Controls.Add(Label2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(tbHours);
            groupBox1.Controls.Add(tbMinutes);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(8, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(729, 93);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Desired TWT Wake Duration";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(283, 61);
            label15.Name = "label15";
            label15.Size = new Size(73, 15);
            label15.TabIndex = 14;
            label15.Text = "Milliseconds";
            // 
            // tbMilliseconds
            // 
            tbMilliseconds.Location = new Point(282, 34);
            tbMilliseconds.Name = "tbMilliseconds";
            tbMilliseconds.Size = new Size(73, 23);
            tbMilliseconds.TabIndex = 4;
            tbMilliseconds.TextAlign = HorizontalAlignment.Right;
            tbMilliseconds.TextChanged += tbMilliseconds_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(450, 38);
            label7.Name = "label7";
            label7.Size = new Size(15, 15);
            label7.TabIndex = 12;
            label7.Text = ">";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(472, 60);
            label6.Name = "label6";
            label6.Size = new Size(238, 15);
            label6.TabIndex = 11;
            label6.Text = "Desired TWT Wake Duration (Microseconds)";
            // 
            // tbTotalMicroseconds
            // 
            tbTotalMicroseconds.Location = new Point(472, 34);
            tbTotalMicroseconds.Name = "tbTotalMicroseconds";
            tbTotalMicroseconds.ReadOnly = true;
            tbTotalMicroseconds.Size = new Size(243, 23);
            tbTotalMicroseconds.TabIndex = 10;
            tbTotalMicroseconds.TabStop = false;
            tbTotalMicroseconds.TextAlign = HorizontalAlignment.Right;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(8, 111);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(498, 23);
            btnCalculate.TabIndex = 2;
            btnCalculate.Text = "Calculate Mantissa and Exponent";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // gbResults
            // 
            gbResults.Controls.Add(gbUnder);
            gbResults.Controls.Add(gbOver);
            gbResults.Controls.Add(gbExact);
            gbResults.Location = new Point(8, 140);
            gbResults.Name = "gbResults";
            gbResults.Size = new Size(729, 128);
            gbResults.TabIndex = 13;
            gbResults.TabStop = false;
            gbResults.Text = "TWT Wake Duration = Wake Interval Mantissa * 2^Wake Interval Exponent";
            gbResults.Visible = false;
            // 
            // gbUnder
            // 
            gbUnder.Controls.Add(tbWakeIntervalExponentUnder);
            gbUnder.Controls.Add(label11);
            gbUnder.Controls.Add(tbMantissaUnder);
            gbUnder.Controls.Add(label12);
            gbUnder.Location = new Point(6, 36);
            gbUnder.Name = "gbUnder";
            gbUnder.Size = new Size(339, 79);
            gbUnder.TabIndex = 16;
            gbUnder.TabStop = false;
            gbUnder.Text = "Best possible result but under by $ microseconds";
            // 
            // tbWakeIntervalExponentUnder
            // 
            tbWakeIntervalExponentUnder.Location = new Point(201, 22);
            tbWakeIntervalExponentUnder.Name = "tbWakeIntervalExponentUnder";
            tbWakeIntervalExponentUnder.ReadOnly = true;
            tbWakeIntervalExponentUnder.Size = new Size(60, 23);
            tbWakeIntervalExponentUnder.TabIndex = 7;
            tbWakeIntervalExponentUnder.TabStop = false;
            tbWakeIntervalExponentUnder.TextAlign = HorizontalAlignment.Right;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(10, 48);
            label11.Name = "label11";
            label11.Size = new Size(128, 15);
            label11.TabIndex = 14;
            label11.Text = "Wake Interval Mantissa";
            // 
            // tbMantissaUnder
            // 
            tbMantissaUnder.Location = new Point(41, 22);
            tbMantissaUnder.Name = "tbMantissaUnder";
            tbMantissaUnder.ReadOnly = true;
            tbMantissaUnder.Size = new Size(51, 23);
            tbMantissaUnder.TabIndex = 5;
            tbMantissaUnder.TabStop = false;
            tbMantissaUnder.TextAlign = HorizontalAlignment.Right;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(164, 48);
            label12.Name = "label12";
            label12.Size = new Size(134, 15);
            label12.TabIndex = 13;
            label12.Text = "Wake Interval Exponent ";
            // 
            // gbOver
            // 
            gbOver.Controls.Add(tbWakeIntervalExponentOver);
            gbOver.Controls.Add(label10);
            gbOver.Controls.Add(tbMantissaOver);
            gbOver.Controls.Add(label9);
            gbOver.Location = new Point(371, 36);
            gbOver.Name = "gbOver";
            gbOver.Size = new Size(339, 79);
            gbOver.TabIndex = 15;
            gbOver.TabStop = false;
            gbOver.Text = "Best possible result but over $ microseconds";
            // 
            // tbWakeIntervalExponentOver
            // 
            tbWakeIntervalExponentOver.Location = new Point(201, 22);
            tbWakeIntervalExponentOver.Name = "tbWakeIntervalExponentOver";
            tbWakeIntervalExponentOver.ReadOnly = true;
            tbWakeIntervalExponentOver.Size = new Size(60, 23);
            tbWakeIntervalExponentOver.TabIndex = 7;
            tbWakeIntervalExponentOver.TabStop = false;
            tbWakeIntervalExponentOver.TextAlign = HorizontalAlignment.Right;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(10, 48);
            label10.Name = "label10";
            label10.Size = new Size(128, 15);
            label10.TabIndex = 14;
            label10.Text = "Wake Interval Mantissa";
            // 
            // tbMantissaOver
            // 
            tbMantissaOver.Location = new Point(41, 22);
            tbMantissaOver.Name = "tbMantissaOver";
            tbMantissaOver.ReadOnly = true;
            tbMantissaOver.Size = new Size(51, 23);
            tbMantissaOver.TabIndex = 5;
            tbMantissaOver.TabStop = false;
            tbMantissaOver.TextAlign = HorizontalAlignment.Right;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(164, 48);
            label9.Name = "label9";
            label9.Size = new Size(134, 15);
            label9.TabIndex = 13;
            label9.Text = "Wake Interval Exponent ";
            // 
            // gbExact
            // 
            gbExact.Controls.Add(tbWakeIntervalExponentExact);
            gbExact.Controls.Add(label13);
            gbExact.Controls.Add(tbMantissaExact);
            gbExact.Controls.Add(label14);
            gbExact.Location = new Point(4, 36);
            gbExact.Name = "gbExact";
            gbExact.Size = new Size(710, 79);
            gbExact.TabIndex = 16;
            gbExact.TabStop = false;
            gbExact.Text = "Exact values";
            // 
            // tbWakeIntervalExponentExact
            // 
            tbWakeIntervalExponentExact.Location = new Point(201, 22);
            tbWakeIntervalExponentExact.Name = "tbWakeIntervalExponentExact";
            tbWakeIntervalExponentExact.ReadOnly = true;
            tbWakeIntervalExponentExact.Size = new Size(60, 23);
            tbWakeIntervalExponentExact.TabIndex = 7;
            tbWakeIntervalExponentExact.TabStop = false;
            tbWakeIntervalExponentExact.TextAlign = HorizontalAlignment.Right;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(10, 48);
            label13.Name = "label13";
            label13.Size = new Size(128, 15);
            label13.TabIndex = 14;
            label13.Text = "Wake Interval Mantissa";
            // 
            // tbMantissaExact
            // 
            tbMantissaExact.Location = new Point(41, 22);
            tbMantissaExact.Name = "tbMantissaExact";
            tbMantissaExact.ReadOnly = true;
            tbMantissaExact.Size = new Size(51, 23);
            tbMantissaExact.TabIndex = 5;
            tbMantissaExact.TabStop = false;
            tbMantissaExact.TextAlign = HorizontalAlignment.Right;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(164, 48);
            label14.Name = "label14";
            label14.Size = new Size(134, 15);
            label14.TabIndex = 13;
            label14.Text = "Wake Interval Exponent ";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(512, 111);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(200, 23);
            btnClear.TabIndex = 14;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnAbout
            // 
            btnAbout.Location = new Point(478, 111);
            btnAbout.Name = "btnAbout";
            btnAbout.Size = new Size(28, 23);
            btnAbout.TabIndex = 15;
            btnAbout.Text = "?";
            btnAbout.UseVisualStyleBackColor = true;
            btnAbout.Click += btnAbout_Click;
            // 
            // Form1
            // 
            AcceptButton = btnCalculate;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClear;
            ClientSize = new Size(743, 280);
            Controls.Add(btnAbout);
            Controls.Add(btnClear);
            Controls.Add(gbResults);
            Controls.Add(btnCalculate);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            HelpButton = true;
            MaximizeBox = false;
            Name = "Form1";
            Text = "TWT Wake Duration Calculator";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            gbResults.ResumeLayout(false);
            gbUnder.ResumeLayout(false);
            gbUnder.PerformLayout();
            gbOver.ResumeLayout(false);
            gbOver.PerformLayout();
            gbExact.ResumeLayout(false);
            gbExact.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox tbDays;
        private TextBox tbHours;
        private Label Label2;
        private TextBox tbMinutes;
        private Label label3;
        private TextBox tbSeconds;
        private Label label4;
        private TextBox tbMicroseconds;
        private Label label5;
        private GroupBox groupBox1;
        private TextBox tbTotalMicroseconds;
        private Label label7;
        private Label label6;
        private Button btnCalculate;
        private GroupBox gbResults;
        private TextBox tbWakeIntervalExponentOver;
        private TextBox tbMantissaOver;
        private GroupBox gbOver;
        private Label label10;
        private Label label9;
        private GroupBox gbExact;
        private TextBox tbWakeIntervalExponentExact;
        private Label label13;
        private TextBox tbMantissaExact;
        private Label label14;
        private GroupBox gbUnder;
        private TextBox tbWakeIntervalExponentUnder;
        private Label label11;
        private TextBox tbMantissaUnder;
        private Label label12;
        private Label label15;
        private TextBox tbMilliseconds;
        private Button btnClear;
        private Button btnAbout;
    }
}