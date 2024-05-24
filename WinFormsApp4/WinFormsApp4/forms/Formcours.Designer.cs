namespace WinFormsApp4.forms
{
    partial class Formcours
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
            comboBox1 = new ComboBox();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(229, 72);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(206, 28);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(54, 72);
            label1.Name = "label1";
            label1.Size = new Size(177, 25);
            label1.TabIndex = 3;
            label1.Text = "Chose your course";
            // 
            // label4
            // 
            label4.BackColor = SystemColors.ControlDark;
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Location = new Point(201, 241);
            label4.Name = "label4";
            label4.Size = new Size(184, 93);
            label4.TabIndex = 6;
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ActiveCaption;
            label5.Location = new Point(201, 203);
            label5.Name = "label5";
            label5.Size = new Size(115, 25);
            label5.TabIndex = 7;
            label5.Text = "Technology";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ActiveCaption;
            label6.Location = new Point(435, 203);
            label6.Name = "label6";
            label6.Size = new Size(72, 25);
            label6.TabIndex = 8;
            label6.Text = "Career";
            // 
            // label2
            // 
            label2.BackColor = SystemColors.ControlDark;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Location = new Point(435, 241);
            label2.Name = "label2";
            label2.Size = new Size(184, 93);
            label2.TabIndex = 10;
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(487, 65);
            button1.Name = "button1";
            button1.Size = new Size(132, 40);
            button1.TabIndex = 19;
            button1.Text = "search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Formcours
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 74);
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Name = "Formcours";
            Text = "Formcours";
            Load += Formcours_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label2;
        private Button button1;
    }
}