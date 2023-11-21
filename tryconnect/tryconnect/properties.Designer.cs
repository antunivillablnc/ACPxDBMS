namespace tryconnect
{
    partial class properties
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
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            button1 = new Button();
            mainmenubttn1 = new Button();
            deletepropertybttn = new Button();
            Addpropertybttn = new Button();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(267, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(638, 426);
            dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(42, 75, 106);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(mainmenubttn1);
            panel1.Controls.Add(deletepropertybttn);
            panel1.Controls.Add(Addpropertybttn);
            panel1.Controls.Add(label9);
            panel1.Location = new Point(-8, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(256, 466);
            panel1.TabIndex = 16;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(230, 228, 224);
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(42, 75, 106);
            button1.Location = new Point(60, 214);
            button1.Name = "button1";
            button1.Size = new Size(136, 59);
            button1.TabIndex = 21;
            button1.Text = "Edit Property";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // mainmenubttn1
            // 
            mainmenubttn1.BackColor = Color.FromArgb(230, 228, 224);
            mainmenubttn1.BackgroundImageLayout = ImageLayout.Stretch;
            mainmenubttn1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            mainmenubttn1.ForeColor = Color.FromArgb(42, 75, 106);
            mainmenubttn1.Location = new Point(60, 366);
            mainmenubttn1.Name = "mainmenubttn1";
            mainmenubttn1.Size = new Size(136, 59);
            mainmenubttn1.TabIndex = 20;
            mainmenubttn1.Text = "Main Menu";
            mainmenubttn1.UseVisualStyleBackColor = false;
            mainmenubttn1.Click += mainmenubttn1_Click;
            // 
            // deletepropertybttn
            // 
            deletepropertybttn.BackColor = Color.FromArgb(230, 228, 224);
            deletepropertybttn.BackgroundImageLayout = ImageLayout.Stretch;
            deletepropertybttn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            deletepropertybttn.ForeColor = Color.FromArgb(42, 75, 106);
            deletepropertybttn.Location = new Point(60, 290);
            deletepropertybttn.Name = "deletepropertybttn";
            deletepropertybttn.Size = new Size(136, 59);
            deletepropertybttn.TabIndex = 19;
            deletepropertybttn.Text = "Delete Property";
            deletepropertybttn.UseVisualStyleBackColor = false;
            deletepropertybttn.Click += deletepropertybttn_Click;
            // 
            // Addpropertybttn
            // 
            Addpropertybttn.BackColor = Color.FromArgb(230, 228, 224);
            Addpropertybttn.BackgroundImageLayout = ImageLayout.Stretch;
            Addpropertybttn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Addpropertybttn.ForeColor = Color.FromArgb(42, 75, 106);
            Addpropertybttn.Location = new Point(60, 135);
            Addpropertybttn.Name = "Addpropertybttn";
            Addpropertybttn.Size = new Size(136, 59);
            Addpropertybttn.TabIndex = 18;
            Addpropertybttn.Text = "Add Property";
            Addpropertybttn.UseVisualStyleBackColor = false;
            Addpropertybttn.Click += Addpropertybttn_Click;
            // 
            // label9
            // 
            label9.BackColor = Color.FromArgb(42, 75, 106);
            label9.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ControlLightLight;
            label9.Location = new Point(20, 14);
            label9.Name = "label9";
            label9.Size = new Size(220, 115);
            label9.TabIndex = 17;
            label9.Text = "Listed Properties";
            label9.TextAlign = ContentAlignment.TopCenter;
            // 
            // properties
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 228, 224);
            ClientSize = new Size(917, 460);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "properties";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "properties";
            Load += properties_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel1;
        private Label label9;
        private Button mainmenubttn1;
        private Button deletepropertybttn;
        private Button Addpropertybttn;
        private Button button1;
    }
}