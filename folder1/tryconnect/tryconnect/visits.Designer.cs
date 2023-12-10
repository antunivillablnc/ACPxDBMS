namespace tryconnect
{
    partial class visits
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
            mainmenu5 = new Button();
            updatevisitrecordsbttn = new Button();
            deletecontractbttn = new Button();
            addcontractbttn = new Button();
            label9 = new Label();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(42, 75, 106);
            panel1.Controls.Add(mainmenu5);
            panel1.Controls.Add(updatevisitrecordsbttn);
            panel1.Controls.Add(deletecontractbttn);
            panel1.Controls.Add(addcontractbttn);
            panel1.Controls.Add(label9);
            panel1.Location = new Point(-1, -5);
            panel1.Name = "panel1";
            panel1.Size = new Size(256, 461);
            panel1.TabIndex = 19;
            // 
            // mainmenu5
            // 
            mainmenu5.BackColor = Color.FromArgb(230, 228, 224);
            mainmenu5.BackgroundImageLayout = ImageLayout.Stretch;
            mainmenu5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            mainmenu5.ForeColor = Color.FromArgb(42, 75, 106);
            mainmenu5.Location = new Point(60, 366);
            mainmenu5.Name = "mainmenu5";
            mainmenu5.Size = new Size(136, 59);
            mainmenu5.TabIndex = 21;
            mainmenu5.Text = "Main Menu";
            mainmenu5.UseVisualStyleBackColor = false;
            mainmenu5.Click += mainmenu5_Click;
            // 
            // updatevisitrecordsbttn
            // 
            updatevisitrecordsbttn.BackColor = Color.FromArgb(230, 228, 224);
            updatevisitrecordsbttn.BackgroundImageLayout = ImageLayout.Stretch;
            updatevisitrecordsbttn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            updatevisitrecordsbttn.ForeColor = Color.FromArgb(42, 75, 106);
            updatevisitrecordsbttn.Location = new Point(60, 205);
            updatevisitrecordsbttn.Name = "updatevisitrecordsbttn";
            updatevisitrecordsbttn.Size = new Size(136, 59);
            updatevisitrecordsbttn.TabIndex = 20;
            updatevisitrecordsbttn.Text = "Edit visit records";
            updatevisitrecordsbttn.UseVisualStyleBackColor = false;
            updatevisitrecordsbttn.Click += updatevisitrecordsbttn_Click;
            // 
            // deletecontractbttn
            // 
            deletecontractbttn.BackColor = Color.FromArgb(230, 228, 224);
            deletecontractbttn.BackgroundImageLayout = ImageLayout.Stretch;
            deletecontractbttn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            deletecontractbttn.ForeColor = Color.FromArgb(42, 75, 106);
            deletecontractbttn.Location = new Point(60, 286);
            deletecontractbttn.Name = "deletecontractbttn";
            deletecontractbttn.Size = new Size(136, 59);
            deletecontractbttn.TabIndex = 19;
            deletecontractbttn.Text = "Delete visit records";
            deletecontractbttn.UseVisualStyleBackColor = false;
            deletecontractbttn.Click += deletecontractbttn_Click;
            // 
            // addcontractbttn
            // 
            addcontractbttn.BackColor = Color.FromArgb(230, 228, 224);
            addcontractbttn.BackgroundImageLayout = ImageLayout.Stretch;
            addcontractbttn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            addcontractbttn.ForeColor = Color.FromArgb(42, 75, 106);
            addcontractbttn.Location = new Point(60, 118);
            addcontractbttn.Name = "addcontractbttn";
            addcontractbttn.Size = new Size(136, 59);
            addcontractbttn.TabIndex = 18;
            addcontractbttn.Text = "Add visit records";
            addcontractbttn.UseVisualStyleBackColor = false;
            addcontractbttn.Click += addcontractbttn_Click;
            // 
            // label9
            // 
            label9.BackColor = Color.FromArgb(42, 75, 106);
            label9.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(230, 228, 224);
            label9.Location = new Point(20, 8);
            label9.Name = "label9";
            label9.Size = new Size(220, 115);
            label9.TabIndex = 17;
            label9.Text = "Visit Records";
            label9.TextAlign = ContentAlignment.TopCenter;
            label9.Click += label9_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(277, 10);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(813, 430);
            dataGridView1.TabIndex = 20;
            // 
            // visits
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 228, 224);
            ClientSize = new Size(1101, 450);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "visits";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "visits";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button mainmenu5;
        private Button updatevisitrecordsbttn;
        private Button deletecontractbttn;
        private Button addcontractbttn;
        private Label label9;
        private DataGridView dataGridView1;
    }
}