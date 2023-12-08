namespace tryconnect
{
    partial class addtransactions
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
            transactionamttxtadd = new TextBox();
            label6 = new Label();
            panel1 = new Panel();
            label9 = new Label();
            addtransaction = new Button();
            returnpropertyedit = new Button();
            transactionsidtxtadd = new TextBox();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            propertyIDtxttransactions = new TextBox();
            label2 = new Label();
            buyerIDtransactionstxt = new TextBox();
            label3 = new Label();
            label4 = new Label();
            agentIDtransactionstxt = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // transactionamttxtadd
            // 
            transactionamttxtadd.Location = new Point(21, 413);
            transactionamttxtadd.Name = "transactionamttxtadd";
            transactionamttxtadd.Size = new Size(322, 27);
            transactionamttxtadd.TabIndex = 103;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(42, 75, 106);
            label6.Location = new Point(21, 382);
            label6.Name = "label6";
            label6.Size = new Size(205, 28);
            label6.TabIndex = 102;
            label6.Text = "Transaction Amount :";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(42, 75, 106);
            panel1.Controls.Add(label9);
            panel1.Location = new Point(277, -22);
            panel1.Name = "panel1";
            panel1.Size = new Size(611, 94);
            panel1.TabIndex = 88;
            // 
            // label9
            // 
            label9.BackColor = Color.FromArgb(42, 75, 106);
            label9.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(230, 228, 224);
            label9.Location = new Point(103, 29);
            label9.Name = "label9";
            label9.Size = new Size(405, 56);
            label9.TabIndex = 18;
            label9.Text = "Add a Transactions";
            label9.TextAlign = ContentAlignment.TopCenter;
            // 
            // addtransaction
            // 
            addtransaction.BackColor = Color.FromArgb(42, 75, 106);
            addtransaction.ForeColor = Color.FromArgb(230, 228, 224);
            addtransaction.Location = new Point(918, 458);
            addtransaction.Name = "addtransaction";
            addtransaction.Size = new Size(102, 41);
            addtransaction.TabIndex = 100;
            addtransaction.Text = "Add";
            addtransaction.UseVisualStyleBackColor = false;
            addtransaction.Click += addtransaction_Click;
            // 
            // returnpropertyedit
            // 
            returnpropertyedit.BackColor = Color.FromArgb(42, 75, 106);
            returnpropertyedit.ForeColor = Color.FromArgb(230, 228, 224);
            returnpropertyedit.Location = new Point(1036, 458);
            returnpropertyedit.Name = "returnpropertyedit";
            returnpropertyedit.Size = new Size(102, 41);
            returnpropertyedit.TabIndex = 101;
            returnpropertyedit.Text = "Return";
            returnpropertyedit.UseVisualStyleBackColor = false;
            returnpropertyedit.Click += returnpropertyedit_Click;
            // 
            // transactionsidtxtadd
            // 
            transactionsidtxtadd.Location = new Point(21, 145);
            transactionsidtxtadd.Name = "transactionsidtxtadd";
            transactionsidtxtadd.Size = new Size(322, 27);
            transactionsidtxtadd.TabIndex = 95;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(364, 114);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(774, 326);
            dataGridView1.TabIndex = 94;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(42, 75, 106);
            label1.Location = new Point(21, 247);
            label1.Name = "label1";
            label1.Size = new Size(101, 28);
            label1.TabIndex = 89;
            label1.Text = "Buyer ID :";
            // 
            // propertyIDtxttransactions
            // 
            propertyIDtxttransactions.Location = new Point(21, 211);
            propertyIDtxttransactions.Name = "propertyIDtxttransactions";
            propertyIDtxttransactions.Size = new Size(322, 27);
            propertyIDtxttransactions.TabIndex = 106;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(42, 75, 106);
            label2.Location = new Point(21, 180);
            label2.Name = "label2";
            label2.Size = new Size(128, 28);
            label2.TabIndex = 105;
            label2.Text = "Property ID :";
            // 
            // buyerIDtransactionstxt
            // 
            buyerIDtransactionstxt.Location = new Point(21, 278);
            buyerIDtransactionstxt.Name = "buyerIDtransactionstxt";
            buyerIDtransactionstxt.Size = new Size(322, 27);
            buyerIDtransactionstxt.TabIndex = 108;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(42, 75, 106);
            label3.Location = new Point(21, 114);
            label3.Name = "label3";
            label3.Size = new Size(160, 28);
            label3.TabIndex = 107;
            label3.Text = "Transactions ID :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(42, 75, 106);
            label4.Location = new Point(21, 314);
            label4.Name = "label4";
            label4.Size = new Size(104, 28);
            label4.TabIndex = 110;
            label4.Text = "Agent ID :";
            // 
            // agentIDtransactionstxt
            // 
            agentIDtransactionstxt.Location = new Point(21, 347);
            agentIDtransactionstxt.Name = "agentIDtransactionstxt";
            agentIDtransactionstxt.Size = new Size(322, 27);
            agentIDtransactionstxt.TabIndex = 109;
            // 
            // addtransactions
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 228, 224);
            ClientSize = new Size(1150, 511);
            Controls.Add(label4);
            Controls.Add(agentIDtransactionstxt);
            Controls.Add(buyerIDtransactionstxt);
            Controls.Add(label3);
            Controls.Add(propertyIDtxttransactions);
            Controls.Add(label2);
            Controls.Add(transactionamttxtadd);
            Controls.Add(label6);
            Controls.Add(panel1);
            Controls.Add(addtransaction);
            Controls.Add(returnpropertyedit);
            Controls.Add(transactionsidtxtadd);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "addtransactions";
            Text = "addtransactions";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox transactionamttxtadd;
        private Label label6;
        private Panel panel1;
        private Label label9;
        private Button addtransaction;
        private Button returnpropertyedit;
        private TextBox transactionsidtxtadd;
        private DataGridView dataGridView1;
        private Label label1;
        private TextBox propertyIDtxttransactions;
        private Label label2;
        private TextBox buyerIDtransactionstxt;
        private Label label3;
        private Label label4;
        private TextBox agentIDtransactionstxt;
    }
}