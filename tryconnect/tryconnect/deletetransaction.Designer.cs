namespace tryconnect
{
    partial class deletetransaction
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
            deletetr = new Button();
            returnpropertyedit = new Button();
            transactionsidtxtdelete = new TextBox();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(42, 75, 106);
            panel1.Controls.Add(label9);
            panel1.Location = new Point(187, -19);
            panel1.Name = "panel1";
            panel1.Size = new Size(424, 94);
            panel1.TabIndex = 88;
            // 
            // label9
            // 
            label9.BackColor = Color.FromArgb(42, 75, 106);
            label9.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(230, 228, 224);
            label9.Location = new Point(16, 25);
            label9.Name = "label9";
            label9.Size = new Size(405, 56);
            label9.TabIndex = 18;
            label9.Text = "Delete a Transactions";
            label9.TextAlign = ContentAlignment.TopCenter;
            // 
            // deletetr
            // 
            deletetr.BackColor = Color.FromArgb(42, 75, 106);
            deletetr.ForeColor = Color.FromArgb(230, 228, 224);
            deletetr.Location = new Point(197, 449);
            deletetr.Name = "deletetr";
            deletetr.Size = new Size(102, 41);
            deletetr.TabIndex = 100;
            deletetr.Text = "delete";
            deletetr.UseVisualStyleBackColor = false;
            deletetr.Click += deletetr_Click;
            // 
            // returnpropertyedit
            // 
            returnpropertyedit.BackColor = Color.FromArgb(42, 75, 106);
            returnpropertyedit.ForeColor = Color.FromArgb(230, 228, 224);
            returnpropertyedit.Location = new Point(503, 449);
            returnpropertyedit.Name = "returnpropertyedit";
            returnpropertyedit.Size = new Size(102, 41);
            returnpropertyedit.TabIndex = 101;
            returnpropertyedit.Text = "Return";
            returnpropertyedit.UseVisualStyleBackColor = false;
            returnpropertyedit.Click += returnpropertyedit_Click;
            // 
            // transactionsidtxtdelete
            // 
            transactionsidtxtdelete.Location = new Point(443, 110);
            transactionsidtxtdelete.Name = "transactionsidtxtdelete";
            transactionsidtxtdelete.Size = new Size(80, 27);
            transactionsidtxtdelete.TabIndex = 95;
            transactionsidtxtdelete.TextAlign = HorizontalAlignment.Center;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(15, 163);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(770, 269);
            dataGridView1.TabIndex = 94;
            dataGridView1.RowHeaderMouseClick += dataGridView1_RowHeaderMouseClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(42, 75, 106);
            label1.Location = new Point(237, 106);
            label1.Name = "label1";
            label1.Size = new Size(160, 28);
            label1.TabIndex = 89;
            label1.Text = "Transactions ID :";
            // 
            // deletetransaction
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 228, 224);
            ClientSize = new Size(800, 502);
            Controls.Add(panel1);
            Controls.Add(deletetr);
            Controls.Add(returnpropertyedit);
            Controls.Add(transactionsidtxtdelete);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "deletetransaction";
            Text = "deletetransaction";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Label label9;
        private Button deletetr;
        private Button returnpropertyedit;
        private TextBox transactionsidtxtdelete;
        private DataGridView dataGridView1;
        private Label label1;
    }
}