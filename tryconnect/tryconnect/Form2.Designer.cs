namespace tryconnect
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            button1 = new Button();
            visitbttn = new Button();
            contractsbttn = new Button();
            transactionsbttn = new Button();
            buyersbttn = new Button();
            agentsbttn = new Button();
            propertiesnbttn = new Button();
            panel1 = new Panel();
            label9 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(658, 389);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Log out";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // visitbttn
            // 
            visitbttn.Location = new Point(524, 266);
            visitbttn.Name = "visitbttn";
            visitbttn.Size = new Size(178, 69);
            visitbttn.TabIndex = 1;
            visitbttn.Text = "Visits";
            visitbttn.UseVisualStyleBackColor = true;
            visitbttn.Click += visitbttn_Click;
            // 
            // contractsbttn
            // 
            contractsbttn.Location = new Point(305, 266);
            contractsbttn.Name = "contractsbttn";
            contractsbttn.Size = new Size(178, 69);
            contractsbttn.TabIndex = 2;
            contractsbttn.Text = "Contracts";
            contractsbttn.UseVisualStyleBackColor = true;
            contractsbttn.Click += contractsbttn_Click;
            // 
            // transactionsbttn
            // 
            transactionsbttn.Location = new Point(524, 164);
            transactionsbttn.Name = "transactionsbttn";
            transactionsbttn.Size = new Size(178, 69);
            transactionsbttn.TabIndex = 3;
            transactionsbttn.Text = "Transactions";
            transactionsbttn.UseVisualStyleBackColor = true;
            transactionsbttn.Click += transactionsbttn_Click;
            // 
            // buyersbttn
            // 
            buyersbttn.Location = new Point(305, 164);
            buyersbttn.Name = "buyersbttn";
            buyersbttn.Size = new Size(178, 69);
            buyersbttn.TabIndex = 4;
            buyersbttn.Text = "Buyers";
            buyersbttn.UseVisualStyleBackColor = true;
            buyersbttn.Click += buyersbttn_Click;
            // 
            // agentsbttn
            // 
            agentsbttn.Location = new Point(97, 266);
            agentsbttn.Name = "agentsbttn";
            agentsbttn.Size = new Size(178, 69);
            agentsbttn.TabIndex = 5;
            agentsbttn.Text = "Agents";
            agentsbttn.UseVisualStyleBackColor = true;
            agentsbttn.Click += agentsbttn_Click;
            // 
            // propertiesnbttn
            // 
            propertiesnbttn.Location = new Point(97, 164);
            propertiesnbttn.Name = "propertiesnbttn";
            propertiesnbttn.Size = new Size(178, 69);
            propertiesnbttn.TabIndex = 6;
            propertiesnbttn.Text = "Properties";
            propertiesnbttn.UseVisualStyleBackColor = true;
            propertiesnbttn.Click += button7_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(42, 75, 106);
            panel1.Controls.Add(label9);
            panel1.Location = new Point(-50, -21);
            panel1.Name = "panel1";
            panel1.Size = new Size(926, 128);
            panel1.TabIndex = 7;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(42, 75, 106);
            label9.Font = new Font("Century Gothic", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(230, 228, 224);
            label9.Location = new Point(219, 30);
            label9.Name = "label9";
            label9.Size = new Size(473, 93);
            label9.TabIndex = 17;
            label9.Text = "Main Menu";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, 341);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(145, 114);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 105;
            pictureBox1.TabStop = false;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 228, 224);
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(propertiesnbttn);
            Controls.Add(agentsbttn);
            Controls.Add(buyersbttn);
            Controls.Add(transactionsbttn);
            Controls.Add(contractsbttn);
            Controls.Add(visitbttn);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainMenu";
            Load += MainMenu_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button visitbttn;
        private Button contractsbttn;
        private Button transactionsbttn;
        private Button buyersbttn;
        private Button agentsbttn;
        private Button propertiesnbttn;
        private Panel panel1;
        private Label label9;
        private PictureBox pictureBox1;
    }
}