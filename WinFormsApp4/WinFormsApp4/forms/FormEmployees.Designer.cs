namespace WinFormsApp4.forms
{
    partial class FormEmployees
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
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label8 = new Label();
            button1 = new Button();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(262, 40);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(187, 27);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(79, 40);
            label1.Name = "label1";
            label1.Size = new Size(176, 27);
            label1.TabIndex = 1;
            label1.Text = "Enter your F.name";
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaption;
            label2.Location = new Point(79, 92);
            label2.Name = "label2";
            label2.Size = new Size(176, 27);
            label2.TabIndex = 3;
            label2.Text = "Enter your L.name";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(262, 92);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(187, 27);
            textBox2.TabIndex = 2;
            // 
            // label3
            // 
            label3.BackColor = SystemColors.ControlDark;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Location = new Point(489, 193);
            label3.Name = "label3";
            label3.Size = new Size(184, 93);
            label3.TabIndex = 17;
            // 
            // label4
            // 
            label4.BackColor = SystemColors.ControlDark;
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Location = new Point(285, 193);
            label4.Name = "label4";
            label4.Size = new Size(184, 93);
            label4.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ActiveCaption;
            label7.Location = new Point(489, 155);
            label7.Name = "label7";
            label7.Size = new Size(69, 25);
            label7.TabIndex = 15;
            label7.Text = "Phone";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ActiveCaption;
            label6.Location = new Point(285, 155);
            label6.Name = "label6";
            label6.Size = new Size(68, 25);
            label6.TabIndex = 14;
            label6.Text = "Salary";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ActiveCaption;
            label5.Location = new Point(84, 155);
            label5.Name = "label5";
            label5.Size = new Size(48, 25);
            label5.TabIndex = 13;
            label5.Text = "Age";
            // 
            // label8
            // 
            label8.BackColor = SystemColors.ControlDark;
            label8.BorderStyle = BorderStyle.Fixed3D;
            label8.FlatStyle = FlatStyle.Flat;
            label8.Location = new Point(84, 193);
            label8.Name = "label8";
            label8.Size = new Size(184, 93);
            label8.TabIndex = 12;
            // 
            // button1
            // 
            button1.Location = new Point(543, 80);
            button1.Name = "button1";
            button1.Size = new Size(133, 40);
            button1.TabIndex = 18;
            button1.Text = "search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ActiveCaption;
            label9.Location = new Point(169, 300);
            label9.Name = "label9";
            label9.Size = new Size(53, 29);
            label9.TabIndex = 49;
            label9.Text = "City";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.ActiveCaption;
            label10.Location = new Point(393, 300);
            label10.Name = "label10";
            label10.Size = new Size(77, 29);
            label10.TabIndex = 48;
            label10.Text = "Street";
            // 
            // label11
            // 
            label11.BackColor = SystemColors.ControlDark;
            label11.BorderStyle = BorderStyle.Fixed3D;
            label11.FlatStyle = FlatStyle.Flat;
            label11.ForeColor = SystemColors.ActiveCaptionText;
            label11.Location = new Point(169, 329);
            label11.Name = "label11";
            label11.Size = new Size(184, 93);
            label11.TabIndex = 47;
            // 
            // label12
            // 
            label12.BackColor = SystemColors.ControlDark;
            label12.BorderStyle = BorderStyle.Fixed3D;
            label12.FlatStyle = FlatStyle.Flat;
            label12.ForeColor = SystemColors.ActiveCaptionText;
            label12.Location = new Point(392, 329);
            label12.Name = "label12";
            label12.Size = new Size(184, 93);
            label12.TabIndex = 46;
            // 
            // FormEmployees
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 74);
            ClientSize = new Size(800, 451);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label8);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "FormEmployees";
            Text = "FormEmployees";
            Load += FormEmployees_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private Label label4;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label8;
        private Button button1;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
    }
}