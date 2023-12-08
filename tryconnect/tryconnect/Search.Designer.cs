namespace tryconnect
{
    partial class Search
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
            panel1 = new Panel();
            label9 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label1 = new Label();
            groupBox1 = new GroupBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            Searchtxt = new TextBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(42, 75, 106);
            panel1.Controls.Add(label9);
            panel1.Location = new Point(162, -23);
            panel1.Name = "panel1";
            panel1.Size = new Size(488, 94);
            panel1.TabIndex = 1;
            // 
            // label9
            // 
            label9.BackColor = Color.FromArgb(42, 75, 106);
            label9.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ControlLightLight;
            label9.Location = new Point(17, 32);
            label9.Name = "label9";
            label9.Size = new Size(454, 56);
            label9.TabIndex = 18;
            label9.Text = "Search for Data";
            label9.TextAlign = ContentAlignment.TopCenter;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(97, 36);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(117, 24);
            radioButton1.TabIndex = 2;
            radioButton1.TabStop = true;
            radioButton1.Text = "Buyer's name";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(365, 36);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(120, 24);
            radioButton2.TabIndex = 3;
            radioButton2.TabStop = true;
            radioButton2.Text = "Agent's name";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(318, 80);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 19;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(101, 97);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(615, 85);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search by:";
            // 
            // Searchtxt
            // 
            Searchtxt.ForeColor = Color.Silver;
            Searchtxt.Location = new Point(257, 197);
            Searchtxt.Name = "Searchtxt";
            Searchtxt.Size = new Size(290, 27);
            Searchtxt.TabIndex = 21;
            Searchtxt.Text = "Input Here";
            Searchtxt.TextAlign = HorizontalAlignment.Center;
            Searchtxt.Enter += textBox1_Enter;
            Searchtxt.Leave += Searchtxt_Leave;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(16, 292);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(772, 324);
            dataGridView1.TabIndex = 22;
            // 
            // button1
            // 
            button1.Location = new Point(257, 248);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 23;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(453, 248);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 24;
            button2.Text = "Return";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Search
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 228, 224);
            ClientSize = new Size(800, 628);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(Searchtxt);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Search";
            Text = "Search";
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label9;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label1;
        private GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox Searchtxt;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
    }
}