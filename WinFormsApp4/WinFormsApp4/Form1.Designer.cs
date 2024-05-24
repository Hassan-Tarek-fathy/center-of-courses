namespace WinFormsApp4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panelMenu = new Panel();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            iconButton6 = new FontAwesome.Sharp.IconButton();
            iconButton5 = new FontAwesome.Sharp.IconButton();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            panellogo = new Panel();
            btnHome = new PictureBox();
            panelTitelBar = new Panel();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            panelDeesktop = new Panel();
            pictureBox1 = new PictureBox();
            panelMenu.SuspendLayout();
            panellogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnHome).BeginInit();
            panelTitelBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            panelDeesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(31, 30, 68);
            panelMenu.Controls.Add(iconButton4);
            panelMenu.Controls.Add(iconButton6);
            panelMenu.Controls.Add(iconButton5);
            panelMenu.Controls.Add(iconButton3);
            panelMenu.Controls.Add(iconButton2);
            panelMenu.Controls.Add(iconButton1);
            panelMenu.Controls.Add(panellogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.ForeColor = SystemColors.GradientActiveCaption;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(189, 536);
            panelMenu.TabIndex = 0;
            panelMenu.Paint += panel1_Paint;
            // 
            // iconButton4
            // 
            iconButton4.Dock = DockStyle.Top;
            iconButton4.FlatStyle = FlatStyle.Flat;
            iconButton4.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton4.ForeColor = Color.Gainsboro;
            iconButton4.IconChar = FontAwesome.Sharp.IconChar.GraduationCap;
            iconButton4.IconColor = Color.Gainsboro;
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton4.IconSize = 32;
            iconButton4.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton4.Location = new Point(0, 422);
            iconButton4.Name = "iconButton4";
            iconButton4.Padding = new Padding(10, 0, 0, 0);
            iconButton4.Size = new Size(189, 60);
            iconButton4.TabIndex = 7;
            iconButton4.Text = "Instructors";
            iconButton4.TextAlign = ContentAlignment.MiddleLeft;
            iconButton4.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton4.UseVisualStyleBackColor = true;
            iconButton4.Click += iconButton4_Click;
            // 
            // iconButton6
            // 
            iconButton6.Dock = DockStyle.Top;
            iconButton6.FlatStyle = FlatStyle.Flat;
            iconButton6.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton6.ForeColor = Color.Gainsboro;
            iconButton6.IconChar = FontAwesome.Sharp.IconChar.LocationDot;
            iconButton6.IconColor = Color.Gainsboro;
            iconButton6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton6.IconSize = 32;
            iconButton6.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton6.Location = new Point(0, 362);
            iconButton6.Name = "iconButton6";
            iconButton6.Padding = new Padding(10, 0, 0, 0);
            iconButton6.Size = new Size(189, 60);
            iconButton6.TabIndex = 6;
            iconButton6.Text = "Branches";
            iconButton6.TextAlign = ContentAlignment.MiddleLeft;
            iconButton6.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton6.UseVisualStyleBackColor = true;
            iconButton6.Click += iconButton6_Click;
            // 
            // iconButton5
            // 
            iconButton5.Dock = DockStyle.Top;
            iconButton5.FlatStyle = FlatStyle.Flat;
            iconButton5.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton5.ForeColor = Color.Gainsboro;
            iconButton5.IconChar = FontAwesome.Sharp.IconChar.Buffer;
            iconButton5.IconColor = Color.Gainsboro;
            iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton5.IconSize = 32;
            iconButton5.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton5.Location = new Point(0, 302);
            iconButton5.Name = "iconButton5";
            iconButton5.Padding = new Padding(10, 0, 0, 0);
            iconButton5.Size = new Size(189, 60);
            iconButton5.TabIndex = 5;
            iconButton5.Text = "Register";
            iconButton5.TextAlign = ContentAlignment.MiddleLeft;
            iconButton5.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton5.UseVisualStyleBackColor = true;
            iconButton5.Click += iconButton5_Click;
            // 
            // iconButton3
            // 
            iconButton3.Dock = DockStyle.Top;
            iconButton3.FlatStyle = FlatStyle.Flat;
            iconButton3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton3.ForeColor = Color.Gainsboro;
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.UserGraduate;
            iconButton3.IconColor = Color.Gainsboro;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.IconSize = 32;
            iconButton3.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton3.Location = new Point(0, 242);
            iconButton3.Name = "iconButton3";
            iconButton3.Padding = new Padding(10, 0, 0, 0);
            iconButton3.Size = new Size(189, 60);
            iconButton3.TabIndex = 3;
            iconButton3.Text = "Students";
            iconButton3.TextAlign = ContentAlignment.MiddleLeft;
            iconButton3.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton3.UseVisualStyleBackColor = true;
            iconButton3.Click += iconButton3_Click;
            // 
            // iconButton2
            // 
            iconButton2.Dock = DockStyle.Top;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton2.ForeColor = Color.Gainsboro;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.GraduationCap;
            iconButton2.IconColor = Color.Gainsboro;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 32;
            iconButton2.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton2.Location = new Point(0, 182);
            iconButton2.Name = "iconButton2";
            iconButton2.Padding = new Padding(10, 0, 0, 0);
            iconButton2.Size = new Size(189, 60);
            iconButton2.TabIndex = 2;
            iconButton2.Text = "Courses";
            iconButton2.TextAlign = ContentAlignment.MiddleLeft;
            iconButton2.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton2.UseVisualStyleBackColor = true;
            iconButton2.Click += iconButton2_Click;
            // 
            // iconButton1
            // 
            iconButton1.Dock = DockStyle.Top;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton1.ForeColor = Color.Gainsboro;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Users;
            iconButton1.IconColor = Color.Gainsboro;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 32;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(0, 122);
            iconButton1.Name = "iconButton1";
            iconButton1.Padding = new Padding(10, 0, 0, 0);
            iconButton1.Size = new Size(189, 60);
            iconButton1.TabIndex = 1;
            iconButton1.Text = "Employees";
            iconButton1.TextAlign = ContentAlignment.MiddleLeft;
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // panellogo
            // 
            panellogo.Controls.Add(btnHome);
            panellogo.Dock = DockStyle.Top;
            panellogo.Location = new Point(0, 0);
            panellogo.Name = "panellogo";
            panellogo.Size = new Size(189, 122);
            panellogo.TabIndex = 0;
            panellogo.Paint += panellogo_Paint;
            // 
            // btnHome
            // 
            btnHome.Image = (Image)resources.GetObject("btnHome.Image");
            btnHome.Location = new Point(10, 12);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(173, 96);
            btnHome.SizeMode = PictureBoxSizeMode.Zoom;
            btnHome.TabIndex = 0;
            btnHome.TabStop = false;
            btnHome.Click += btnHome_Click;
            // 
            // panelTitelBar
            // 
            panelTitelBar.BackColor = Color.FromArgb(26, 25, 62);
            panelTitelBar.Controls.Add(iconPictureBox1);
            panelTitelBar.Dock = DockStyle.Top;
            panelTitelBar.Location = new Point(189, 0);
            panelTitelBar.Name = "panelTitelBar";
            panelTitelBar.Size = new Size(756, 80);
            panelTitelBar.TabIndex = 1;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.FromArgb(26, 25, 62);
            iconPictureBox1.ForeColor = Color.MediumPurple;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            iconPictureBox1.IconColor = Color.MediumPurple;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 37;
            iconPictureBox1.Location = new Point(15, 22);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(41, 37);
            iconPictureBox1.TabIndex = 0;
            iconPictureBox1.TabStop = false;
            // 
            // panelDeesktop
            // 
            panelDeesktop.BackColor = Color.FromArgb(34, 33, 74);
            panelDeesktop.Controls.Add(pictureBox1);
            panelDeesktop.Dock = DockStyle.Fill;
            panelDeesktop.Location = new Point(189, 80);
            panelDeesktop.Name = "panelDeesktop";
            panelDeesktop.Size = new Size(756, 456);
            panelDeesktop.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(101, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(576, 421);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(945, 536);
            Controls.Add(panelDeesktop);
            Controls.Add(panelTitelBar);
            Controls.Add(panelMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Form1_Load;
            panelMenu.ResumeLayout(false);
            panellogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnHome).EndInit();
            panelTitelBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            panelDeesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private FontAwesome.Sharp.IconButton iconButton6;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Panel panellogo;
        private PictureBox btnHome;
        private Panel panelTitelBar;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Panel panelDeesktop;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton iconButton4;
    }
}