namespace tryconnect
{
    partial class agents
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
            mainmenubttn4 = new Button();
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
            panel1.Controls.Add(mainmenubttn4);
            panel1.Controls.Add(deletepropertybttn);
            panel1.Controls.Add(Addpropertybttn);
            panel1.Controls.Add(label9);
            panel1.Location = new Point(0, -5);
            panel1.Name = "panel1";
            panel1.Size = new Size(256, 507);
            panel1.TabIndex = 17;
            // 
            // mainmenubttn4
            // 
            mainmenubttn4.BackColor = Color.FromArgb(230, 228, 224);
            mainmenubttn4.BackgroundImageLayout = ImageLayout.Stretch;
            mainmenubttn4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            mainmenubttn4.ForeColor = Color.FromArgb(42, 75, 106);
            mainmenubttn4.Location = new Point(60, 337);
            mainmenubttn4.Name = "mainmenubttn4";
            mainmenubttn4.Size = new Size(136, 59);
            mainmenubttn4.TabIndex = 20;
            mainmenubttn4.Text = "Main Menu";
            mainmenubttn4.UseVisualStyleBackColor = false;
            mainmenubttn4.Click += mainmenubttn4_Click;
            // 
            // deletepropertybttn
            // 
            deletepropertybttn.BackColor = Color.FromArgb(230, 228, 224);
            deletepropertybttn.BackgroundImageLayout = ImageLayout.Stretch;
            deletepropertybttn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            deletepropertybttn.ForeColor = Color.FromArgb(42, 75, 106);
            deletepropertybttn.Location = new Point(60, 245);
            deletepropertybttn.Name = "deletepropertybttn";
            deletepropertybttn.Size = new Size(136, 59);
            deletepropertybttn.TabIndex = 19;
            deletepropertybttn.Text = "Delete Agent";
            deletepropertybttn.UseVisualStyleBackColor = false;
            deletepropertybttn.Click += deletepropertybttn_Click;
            // 
            // Addpropertybttn
            // 
            Addpropertybttn.BackColor = Color.FromArgb(230, 228, 224);
            Addpropertybttn.BackgroundImageLayout = ImageLayout.Stretch;
            Addpropertybttn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Addpropertybttn.ForeColor = Color.FromArgb(42, 75, 106);
            Addpropertybttn.Location = new Point(60, 155);
            Addpropertybttn.Name = "Addpropertybttn";
            Addpropertybttn.Size = new Size(136, 59);
            Addpropertybttn.TabIndex = 18;
            Addpropertybttn.Text = "Edit Agent";
            Addpropertybttn.UseVisualStyleBackColor = false;
            Addpropertybttn.Click += Addpropertybttn_Click;
            // 
            // label9
            // 
            label9.BackColor = Color.FromArgb(42, 75, 106);
            label9.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(230, 228, 224);
            label9.Location = new Point(47, 47);
            label9.Name = "label9";
            label9.Size = new Size(161, 75);
            label9.TabIndex = 17;
            label9.Text = "Agents";
            label9.TextAlign = ContentAlignment.TopCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(278, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1182, 470);
            dataGridView1.TabIndex = 18;
            // 
            // agents
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 228, 224);
            ClientSize = new Size(1476, 494);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "agents";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "agents";
            Load += agents_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button mainmenubttn4;
        private Button deletepropertybttn;
        private Button Addpropertybttn;
        private Label label9;
        private DataGridView dataGridView1;
    }
}