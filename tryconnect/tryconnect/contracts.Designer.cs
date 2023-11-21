namespace tryconnect
{
    partial class contracts
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
            updatecontractbttn = new Button();
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
            panel1.Controls.Add(updatecontractbttn);
            panel1.Controls.Add(deletecontractbttn);
            panel1.Controls.Add(addcontractbttn);
            panel1.Controls.Add(label9);
            panel1.Location = new Point(-1, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(256, 461);
            panel1.TabIndex = 18;
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
            // updatecontractbttn
            // 
            updatecontractbttn.BackColor = Color.FromArgb(230, 228, 224);
            updatecontractbttn.BackgroundImageLayout = ImageLayout.Stretch;
            updatecontractbttn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            updatecontractbttn.ForeColor = Color.FromArgb(42, 75, 106);
            updatecontractbttn.Location = new Point(60, 202);
            updatecontractbttn.Name = "updatecontractbttn";
            updatecontractbttn.Size = new Size(136, 59);
            updatecontractbttn.TabIndex = 20;
            updatecontractbttn.Text = "Edit Contract";
            updatecontractbttn.UseVisualStyleBackColor = false;
            updatecontractbttn.Click += updatecontractbttn_Click;
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
            deletecontractbttn.Text = "Delete Contract";
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
            addcontractbttn.Text = "Add Contract";
            addcontractbttn.UseVisualStyleBackColor = false;
            addcontractbttn.Click += addcontractbttn_Click;
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
            label9.Text = "Listed Contracts";
            label9.TextAlign = ContentAlignment.TopCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(272, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(433, 426);
            dataGridView1.TabIndex = 19;
            // 
            // contracts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(230, 228, 224);
            ClientSize = new Size(717, 450);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "contracts";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "contracts";
            Load += contracts_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button mainmenu5;
        private Button updatecontractbttn;
        private Button deletecontractbttn;
        private Button addcontractbttn;
        private Label label9;
        private DataGridView dataGridView1;
    }
}