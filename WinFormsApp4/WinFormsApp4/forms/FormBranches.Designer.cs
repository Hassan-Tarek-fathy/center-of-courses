namespace WinFormsApp4.forms
{
    partial class FormBranches
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
            label8 = new Label();
            button1 = new Button();
            textBox2 = new TextBox();
            label5 = new Label();
            label2 = new Label();
            label3 = new Label();
            label7 = new Label();
            label9 = new Label();
            SuspendLayout();
            // 
            // label4
            // 
            label4.BackColor = SystemColors.ControlDark;
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.FlatStyle = FlatStyle.Flat;
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(448, 152);
            label4.Name = "label4";
            label4.Size = new Size(184, 93);
            label4.TabIndex = 38;
            // 
            // label6
            // 
            label6.BackColor = SystemColors.ControlDark;
            label6.BorderStyle = BorderStyle.Fixed3D;
            label6.FlatStyle = FlatStyle.Flat;
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(240, 152);
            label6.Name = "label6";
            label6.Size = new Size(184, 93);
            label6.TabIndex = 37;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ControlDark;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.FlatStyle = FlatStyle.Flat;
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(446, 293);
            label1.Name = "label1";
            label1.Size = new Size(184, 93);
            label1.TabIndex = 35;
            // 
            // label8
            // 
            label8.BackColor = SystemColors.ControlDark;
            label8.BorderStyle = BorderStyle.Fixed3D;
            label8.FlatStyle = FlatStyle.Flat;
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(240, 293);
            label8.Name = "label8";
            label8.Size = new Size(184, 93);
            label8.TabIndex = 33;
            // 
            // button1
            // 
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(500, 47);
            button1.Name = "button1";
            button1.Size = new Size(132, 40);
            button1.TabIndex = 41;
            button1.Text = "search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(241, 47);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(187, 27);
            textBox2.TabIndex = 40;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ActiveCaption;
            label5.Location = new Point(53, 47);
            label5.Name = "label5";
            label5.Size = new Size(173, 29);
            label5.TabIndex = 39;
            label5.Text = "Branche Name";
            label5.Click += label5_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaption;
            label2.Location = new Point(240, 123);
            label2.Name = "label2";
            label2.Size = new Size(145, 29);
            label2.TabIndex = 42;
            label2.Text = "Num.Branch";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaption;
            label3.Location = new Point(446, 123);
            label3.Name = "label3";
            label3.Size = new Size(94, 29);
            label3.TabIndex = 43;
            label3.Text = "Service";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ActiveCaption;
            label7.Location = new Point(241, 264);
            label7.Name = "label7";
            label7.Size = new Size(77, 29);
            label7.TabIndex = 44;
            label7.Text = "Street";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ActiveCaption;
            label9.Location = new Point(446, 264);
            label9.Name = "label9";
            label9.Size = new Size(53, 29);
            label9.TabIndex = 45;
            label9.Text = "City";
            // 
            // FormBranches
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 74);
            ClientSize = new Size(763, 450);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(label8);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "FormBranches";
            Text = "FormBranches";
            Load += FormBranches_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label4;
        private Label label6;
        private Label label1;
        private Label label8;
        private Button button1;
        private TextBox textBox2;
        private Label label5;
        private Label label2;
        private Label label3;
        private Label label7;
        private Label label9;
    }
}