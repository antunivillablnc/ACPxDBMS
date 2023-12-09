namespace tryconnect
{
    partial class deletecontract
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
            returnbttneditcontract = new Button();
            deletecontractbttn = new Button();
            contractIDdeletetxt = new TextBox();
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
            panel1.Location = new Point(116, -27);
            panel1.Name = "panel1";
            panel1.Size = new Size(463, 94);
            panel1.TabIndex = 68;
            // 
            // label9
            // 
            label9.BackColor = Color.FromArgb(42, 75, 106);
            label9.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(230, 228, 224);
            label9.Location = new Point(60, 35);
            label9.Name = "label9";
            label9.Size = new Size(349, 56);
            label9.TabIndex = 18;
            label9.Text = "Delete Contract";
            label9.TextAlign = ContentAlignment.TopCenter;
            // 
            // returnbttneditcontract
            // 
            returnbttneditcontract.BackColor = Color.FromArgb(42, 75, 106);
            returnbttneditcontract.ForeColor = Color.FromArgb(230, 228, 224);
            returnbttneditcontract.Location = new Point(423, 490);
            returnbttneditcontract.Name = "returnbttneditcontract";
            returnbttneditcontract.Size = new Size(102, 41);
            returnbttneditcontract.TabIndex = 75;
            returnbttneditcontract.Text = "Return";
            returnbttneditcontract.UseVisualStyleBackColor = false;
            returnbttneditcontract.Click += returnbttneditcontract_Click;
            // 
            // deletecontractbttn
            // 
            deletecontractbttn.BackColor = Color.FromArgb(42, 75, 106);
            deletecontractbttn.ForeColor = Color.FromArgb(230, 228, 224);
            deletecontractbttn.Location = new Point(176, 490);
            deletecontractbttn.Name = "deletecontractbttn";
            deletecontractbttn.Size = new Size(102, 41);
            deletecontractbttn.TabIndex = 74;
            deletecontractbttn.Text = "Delete";
            deletecontractbttn.UseVisualStyleBackColor = false;
            deletecontractbttn.Click += deletecontractbttn_Click;
            // 
            // contractIDdeletetxt
            // 
            contractIDdeletetxt.Location = new Point(375, 105);
            contractIDdeletetxt.Name = "contractIDdeletetxt";
            contractIDdeletetxt.Size = new Size(77, 27);
            contractIDdeletetxt.TabIndex = 72;
            contractIDdeletetxt.TextAlign = HorizontalAlignment.Center;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(28, 160);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(629, 303);
            dataGridView1.TabIndex = 71;
            dataGridView1.RowHeaderMouseClick += dataGridView1_RowHeaderMouseClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(42, 75, 106);
            label1.Location = new Point(224, 101);
            label1.Name = "label1";
            label1.Size = new Size(125, 28);
            label1.TabIndex = 69;
            label1.Text = "Contract ID :";
            // 
            // deletecontract
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 228, 224);
            ClientSize = new Size(685, 547);
            Controls.Add(panel1);
            Controls.Add(returnbttneditcontract);
            Controls.Add(deletecontractbttn);
            Controls.Add(contractIDdeletetxt);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "deletecontract";
            Text = "deletecontract";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Label label9;
        private Button returnbttneditcontract;
        private Button deletecontractbttn;
        private TextBox contractIDdeletetxt;
        private DataGridView dataGridView1;
        private Label label1;
    }
}