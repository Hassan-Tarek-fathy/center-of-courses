namespace WinFormsApp4.forms
{
    partial class FormRegister
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
            label3 = new Label();
            label4 = new Label();
            textBox4 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            label5 = new Label();
            textBox6 = new TextBox();
            label6 = new Label();
            comboBox2 = new ComboBox();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(283, 229);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(206, 28);
            comboBox1.TabIndex = 20;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaption;
            label3.Location = new Point(43, 230);
            label3.Name = "label3";
            label3.Size = new Size(234, 27);
            label3.TabIndex = 19;
            label3.Text = "Enter your specialization";
            // 
            // label4
            // 
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaption;
            label4.Location = new Point(43, 134);
            label4.Name = "label4";
            label4.Size = new Size(187, 27);
            label4.TabIndex = 18;
            label4.Text = "Enter your adddress";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(283, 134);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(319, 27);
            textBox4.TabIndex = 17;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaption;
            label2.Location = new Point(43, 86);
            label2.Name = "label2";
            label2.Size = new Size(176, 27);
            label2.TabIndex = 16;
            label2.Text = "Enter your name";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(283, 86);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(319, 27);
            textBox2.TabIndex = 15;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(43, 34);
            label1.Name = "label1";
            label1.Size = new Size(176, 27);
            label1.TabIndex = 14;
            label1.Text = "Enter your id";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(283, 34);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(319, 27);
            textBox1.TabIndex = 13;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(323, 345);
            button1.Name = "button1";
            button1.Size = new Size(132, 40);
            button1.TabIndex = 21;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ActiveCaption;
            label5.Location = new Point(43, 181);
            label5.Name = "label5";
            label5.Size = new Size(187, 27);
            label5.TabIndex = 23;
            label5.Text = "Enter your college";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(283, 182);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(319, 27);
            textBox6.TabIndex = 22;
            // 
            // label6
            // 
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ActiveCaption;
            label6.Location = new Point(43, 279);
            label6.Name = "label6";
            label6.Size = new Size(187, 27);
            label6.TabIndex = 25;
            label6.Text = "Enter your course";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(283, 278);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(206, 28);
            comboBox2.TabIndex = 26;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // FormRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 74);
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox6);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "FormRegister";
            Text = "FormDepartments";
            Load += FormDepartments_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label3;
        private Label label4;
        private TextBox textBox4;
        private Label label2;
        private TextBox textBox2;
        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Label label5;
        private TextBox textBox6;
        private Label label6;
        private ComboBox comboBox2;
    }
}