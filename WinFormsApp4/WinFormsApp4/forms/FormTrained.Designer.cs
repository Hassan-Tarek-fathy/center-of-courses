namespace WinFormsApp4.forms
{
    partial class FormTrained
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
            label4 = new Label();
            label6 = new Label();
            label1 = new Label();
            label3 = new Label();
            button1 = new Button();
            label5 = new Label();
            label8 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaption;
            label4.Location = new Point(510, 171);
            label4.Name = "label4";
            label4.Size = new Size(133, 25);
            label4.TabIndex = 44;
            label4.Text = "Specialization";
            // 
            // label6
            // 
            label6.BackColor = SystemColors.ControlDark;
            label6.BorderStyle = BorderStyle.Fixed3D;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Location = new Point(510, 218);
            label6.Name = "label6";
            label6.Size = new Size(184, 93);
            label6.TabIndex = 43;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(308, 171);
            label1.Name = "label1";
            label1.Size = new Size(85, 25);
            label1.TabIndex = 42;
            label1.Text = "Address";
            // 
            // label3
            // 
            label3.BackColor = SystemColors.ControlDark;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Location = new Point(308, 218);
            label3.Name = "label3";
            label3.Size = new Size(184, 93);
            label3.TabIndex = 41;
            // 
            // button1
            // 
            button1.Location = new Point(562, 47);
            button1.Name = "button1";
            button1.Size = new Size(132, 40);
            button1.TabIndex = 40;
            button1.Text = "search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ActiveCaption;
            label5.Location = new Point(106, 171);
            label5.Name = "label5";
            label5.Size = new Size(48, 25);
            label5.TabIndex = 39;
            label5.Text = "Age";
            // 
            // label8
            // 
            label8.BackColor = SystemColors.ControlDark;
            label8.BorderStyle = BorderStyle.Fixed3D;
            label8.FlatStyle = FlatStyle.Flat;
            label8.Location = new Point(106, 218);
            label8.Name = "label8";
            label8.Size = new Size(184, 93);
            label8.TabIndex = 38;
            label8.Click += label8_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaption;
            label2.Location = new Point(106, 53);
            label2.Name = "label2";
            label2.Size = new Size(193, 27);
            label2.TabIndex = 37;
            label2.Text = "Enter  trained  name";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(305, 54);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(187, 27);
            textBox2.TabIndex = 36;
            // 
            // FormTrained
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 74);
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label8);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Name = "FormTrained";
            Text = "FormTrained";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label6;
        private Label label1;
        private Label label3;
        private Button button1;
        private Label label5;
        private Label label8;
        private Label label2;
        private TextBox textBox2;
    }
}