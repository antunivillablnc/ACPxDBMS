namespace tryconnect
{
    partial class transactions
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
            button1 = new Button();
            mainmenubttn3 = new Button();
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
            panel1.Controls.Add(button1);
            panel1.Controls.Add(mainmenubttn3);
            panel1.Controls.Add(deletepropertybttn);
            panel1.Controls.Add(Addpropertybttn);
            panel1.Controls.Add(label9);
            panel1.Location = new Point(-1, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(256, 472);
            panel1.TabIndex = 17;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(230, 228, 224);
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(42, 75, 106);
            button1.Location = new Point(60, 207);
            button1.Name = "button1";
            button1.Size = new Size(136, 59);
            button1.TabIndex = 21;
            button1.Text = "Edit Transactions";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // mainmenubttn3
            // 
            mainmenubttn3.BackColor = Color.FromArgb(230, 228, 224);
            mainmenubttn3.BackgroundImageLayout = ImageLayout.Stretch;
            mainmenubttn3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            mainmenubttn3.ForeColor = Color.FromArgb(42, 75, 106);
            mainmenubttn3.Location = new Point(60, 360);
            mainmenubttn3.Name = "mainmenubttn3";
            mainmenubttn3.Size = new Size(136, 59);
            mainmenubttn3.TabIndex = 20;
            mainmenubttn3.Text = "Main Menu";
            mainmenubttn3.UseVisualStyleBackColor = false;
            mainmenubttn3.Click += mainmenubttn3_Click;
            // 
            // deletepropertybttn
            // 
            deletepropertybttn.BackColor = Color.FromArgb(230, 228, 224);
            deletepropertybttn.BackgroundImageLayout = ImageLayout.Stretch;
            deletepropertybttn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            deletepropertybttn.ForeColor = Color.FromArgb(42, 75, 106);
            deletepropertybttn.Location = new Point(60, 285);
            deletepropertybttn.Name = "deletepropertybttn";
            deletepropertybttn.Size = new Size(136, 59);
            deletepropertybttn.TabIndex = 19;
            deletepropertybttn.Text = "Delete Transactions";
            deletepropertybttn.UseVisualStyleBackColor = false;
            deletepropertybttn.Click += deletepropertybttn_Click;
            // 
            // Addpropertybttn
            // 
            Addpropertybttn.BackColor = Color.FromArgb(230, 228, 224);
            Addpropertybttn.BackgroundImageLayout = ImageLayout.Stretch;
            Addpropertybttn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Addpropertybttn.ForeColor = Color.FromArgb(42, 75, 106);
            Addpropertybttn.Location = new Point(60, 127);
            Addpropertybttn.Name = "Addpropertybttn";
            Addpropertybttn.Size = new Size(136, 59);
            Addpropertybttn.TabIndex = 18;
            Addpropertybttn.Text = "Add Transactions";
            Addpropertybttn.UseVisualStyleBackColor = false;
            Addpropertybttn.Click += Addpropertybttn_Click;
            // 
            // label9
            // 
            label9.BackColor = Color.FromArgb(42, 75, 106);
            label9.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(230, 228, 224);
            label9.Location = new Point(6, 32);
            label9.Name = "label9";
            label9.Size = new Size(250, 115);
            label9.TabIndex = 17;
            label9.Text = "Transactions";
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
            dataGridView1.Size = new Size(794, 426);
            dataGridView1.TabIndex = 18;
            // 
            // transactions
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 228, 224);
            ClientSize = new Size(1078, 450);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "transactions";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "transactions";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button mainmenubttn3;
        private Button deletepropertybttn;
        private Button Addpropertybttn;
        private Label label9;
        private DataGridView dataGridView1;
        private Button button1;
    }
}