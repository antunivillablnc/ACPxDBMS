namespace tryconnect
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
            pictureBox1 = new PictureBox();
            usernametxt1 = new TextBox();
            Passwordtxt = new TextBox();
            button1 = new Button();
            button2 = new Button();
            show_password = new CheckBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(250, -43);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(304, 253);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // usernametxt1
            // 
            usernametxt1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            usernametxt1.ForeColor = Color.Silver;
            usernametxt1.Location = new Point(208, 201);
            usernametxt1.Name = "usernametxt1";
            usernametxt1.Size = new Size(397, 27);
            usernametxt1.TabIndex = 1;
            usernametxt1.Text = "Username";
            usernametxt1.TextAlign = HorizontalAlignment.Center;
            usernametxt1.Enter += textBox1_Enter;
            usernametxt1.Leave += textBox1_Leave;
            // 
            // Passwordtxt
            // 
            Passwordtxt.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Passwordtxt.ForeColor = Color.Silver;
            Passwordtxt.Location = new Point(208, 266);
            Passwordtxt.Name = "Passwordtxt";
            Passwordtxt.Size = new Size(397, 27);
            Passwordtxt.TabIndex = 2;
            Passwordtxt.Text = "Password";
            Passwordtxt.TextAlign = HorizontalAlignment.Center;
            Passwordtxt.Enter += Passwordtxt_Enter;
            Passwordtxt.Leave += Passwordtxt_Leave;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(42, 75, 106);
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(230, 228, 224);
            button1.Location = new Point(226, 345);
            button1.Name = "button1";
            button1.Size = new Size(136, 59);
            button1.TabIndex = 3;
            button1.Text = "Log in";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(42, 75, 106);
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.FromArgb(230, 228, 224);
            button2.Location = new Point(436, 345);
            button2.Name = "button2";
            button2.Size = new Size(136, 59);
            button2.TabIndex = 4;
            button2.Text = "Register";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // show_password
            // 
            show_password.AutoSize = true;
            show_password.Location = new Point(616, 271);
            show_password.Name = "show_password";
            show_password.Size = new Size(18, 17);
            show_password.TabIndex = 6;
            show_password.UseVisualStyleBackColor = true;
            show_password.CheckedChanged += show_password_CheckedChanged;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(42, 75, 106);
            label1.Location = new Point(-3, -3);
            label1.Name = "label1";
            label1.Size = new Size(196, 30);
            label1.TabIndex = 7;
            label1.Text = "DATE AND TIME";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 228, 224);
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(show_password);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Passwordtxt);
            Controls.Add(usernametxt1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HomeSeeker";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox usernametxt1;
        private TextBox Passwordtxt;
        private Button button1;
        private Button button2;
        private CheckBox show_password;
        private Label label1;
    }
}