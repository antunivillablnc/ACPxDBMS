namespace tryconnect
{
    partial class buyers
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
            mainmenu2 = new Button();
            mainmenubttn1 = new Button();
            deletepropertybttn = new Button();
            Addpropertybttn = new Button();
            label9 = new Label();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(42, 75, 106);
            panel1.Controls.Add(mainmenu2);
            panel1.Controls.Add(mainmenubttn1);
            panel1.Controls.Add(deletepropertybttn);
            panel1.Controls.Add(Addpropertybttn);
            panel1.Controls.Add(label9);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(256, 461);
            panel1.TabIndex = 17;
            // 
            // mainmenu2
            // 
            mainmenu2.BackColor = Color.FromArgb(230, 228, 224);
            mainmenu2.BackgroundImageLayout = ImageLayout.Stretch;
            mainmenu2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            mainmenu2.ForeColor = Color.FromArgb(42, 75, 106);
            mainmenu2.Location = new Point(60, 366);
            mainmenu2.Name = "mainmenu2";
            mainmenu2.Size = new Size(136, 59);
            mainmenu2.TabIndex = 21;
            mainmenu2.Text = "Main Menu";
            mainmenu2.UseVisualStyleBackColor = false;
            mainmenu2.Click += mainmenu2_Click;
            // 
            // mainmenubttn1
            // 
            mainmenubttn1.BackColor = Color.FromArgb(230, 228, 224);
            mainmenubttn1.BackgroundImageLayout = ImageLayout.Stretch;
            mainmenubttn1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            mainmenubttn1.ForeColor = Color.FromArgb(42, 75, 106);
            mainmenubttn1.Location = new Point(60, 193);
            mainmenubttn1.Name = "mainmenubttn1";
            mainmenubttn1.Size = new Size(136, 59);
            mainmenubttn1.TabIndex = 20;
            mainmenubttn1.Text = "Update Buyers\r\n";
            mainmenubttn1.UseVisualStyleBackColor = false;
            mainmenubttn1.Click += mainmenubttn1_Click;
            // 
            // deletepropertybttn
            // 
            deletepropertybttn.BackColor = Color.FromArgb(230, 228, 224);
            deletepropertybttn.BackgroundImageLayout = ImageLayout.Stretch;
            deletepropertybttn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            deletepropertybttn.ForeColor = Color.FromArgb(42, 75, 106);
            deletepropertybttn.Location = new Point(60, 272);
            deletepropertybttn.Name = "deletepropertybttn";
            deletepropertybttn.Size = new Size(136, 59);
            deletepropertybttn.TabIndex = 19;
            deletepropertybttn.Text = "Delete Buyers\r\n";
            deletepropertybttn.UseVisualStyleBackColor = false;
            deletepropertybttn.Click += deletepropertybttn_Click;
            // 
            // Addpropertybttn
            // 
            Addpropertybttn.BackColor = Color.FromArgb(230, 228, 224);
            Addpropertybttn.BackgroundImageLayout = ImageLayout.Stretch;
            Addpropertybttn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Addpropertybttn.ForeColor = Color.FromArgb(42, 75, 106);
            Addpropertybttn.Location = new Point(60, 118);
            Addpropertybttn.Name = "Addpropertybttn";
            Addpropertybttn.Size = new Size(136, 59);
            Addpropertybttn.TabIndex = 18;
            Addpropertybttn.Text = "Add Buyers";
            Addpropertybttn.UseVisualStyleBackColor = false;
            Addpropertybttn.Click += Addpropertybttn_Click;
            // 
            // label9
            // 
            label9.BackColor = Color.FromArgb(42, 75, 106);
            label9.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(230, 228, 224);
            label9.Location = new Point(20, 0);
            label9.Name = "label9";
            label9.Size = new Size(220, 115);
            label9.TabIndex = 17;
            label9.Text = "Listed Buyers";
            label9.TextAlign = ContentAlignment.TopCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(274, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(678, 426);
            dataGridView1.TabIndex = 18;
            // 
            // buyers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 228, 224);
            ClientSize = new Size(964, 450);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "buyers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "buyers";
            Load += buyers_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button mainmenubttn1;
        private Button deletepropertybttn;
        private Button Addpropertybttn;
        private Label label9;
        private DataGridView dataGridView1;
        private Button mainmenu2;
    }
}