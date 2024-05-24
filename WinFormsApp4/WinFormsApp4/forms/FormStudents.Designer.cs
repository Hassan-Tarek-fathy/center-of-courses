namespace WinFormsApp4.forms
{
    partial class FormStudents
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
            label5 = new Label();
            label8 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ActiveCaption;
            label5.Location = new Point(99, 164);
            label5.Name = "label5";
            label5.Size = new Size(75, 25);
            label5.TabIndex = 21;
            label5.Text = "Adrees";
            // 
            // label8
            // 
            label8.BackColor = SystemColors.ControlDark;
            label8.BorderStyle = BorderStyle.Fixed3D;
            label8.FlatStyle = FlatStyle.Flat;
            label8.Location = new Point(99, 212);
            label8.Name = "label8";
            label8.Size = new Size(184, 93);
            label8.TabIndex = 20;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaption;
            label2.Location = new Point(99, 46);
            label2.Name = "label2";
            label2.Size = new Size(173, 27);
            label2.TabIndex = 19;
            label2.Text = "Enter  your  name";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(299, 46);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(187, 27);
            textBox2.TabIndex = 18;
            // 
            // button1
            // 
            button1.Location = new Point(555, 40);
            button1.Name = "button1";
            button1.Size = new Size(133, 40);
            button1.TabIndex = 22;
            button1.Text = "search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(301, 164);
            label1.Name = "label1";
            label1.Size = new Size(79, 25);
            label1.TabIndex = 24;
            label1.Text = "College";
            // 
            // label3
            // 
            label3.BackColor = SystemColors.ControlDark;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Location = new Point(301, 212);
            label3.Name = "label3";
            label3.Size = new Size(184, 93);
            label3.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaption;
            label4.Location = new Point(503, 164);
            label4.Name = "label4";
            label4.Size = new Size(133, 25);
            label4.TabIndex = 26;
            label4.Text = "Specialization";
            // 
            // label6
            // 
            label6.BackColor = SystemColors.ControlDark;
            label6.BorderStyle = BorderStyle.Fixed3D;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Location = new Point(503, 212);
            label6.Name = "label6";
            label6.Size = new Size(184, 93);
            label6.TabIndex = 25;
            // 
            // FormStudents
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 74);
            ClientSize = new Size(800, 451);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label8);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Name = "FormStudents";
            Text = "FormStudents";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label8;
        private Label label2;
        private TextBox textBox2;
        private Button button1;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label6;
    }
}