namespace tryconnect
{
    partial class edittransactions
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
            transactionamttxtedit = new TextBox();
            label6 = new Label();
            panel1 = new Panel();
            label9 = new Label();
            edittransaction = new Button();
            agentidtxtedit = new TextBox();
            buyeridtxtedit = new TextBox();
            propertyidtxtedit = new TextBox();
            returnpropertyedit = new Button();
            transactionsidtxtedit = new TextBox();
            dataGridView1 = new DataGridView();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // transactionamttxtedit
            // 
            transactionamttxtedit.Location = new Point(25, 435);
            transactionamttxtedit.Name = "transactionamttxtedit";
            transactionamttxtedit.Size = new Size(322, 27);
            transactionamttxtedit.TabIndex = 87;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(42, 75, 106);
            label6.Location = new Point(25, 404);
            label6.Name = "label6";
            label6.Size = new Size(205, 28);
            label6.TabIndex = 86;
            label6.Text = "Transaction Amount :";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(42, 75, 106);
            panel1.Controls.Add(label9);
            panel1.Location = new Point(300, -21);
            panel1.Name = "panel1";
            panel1.Size = new Size(676, 94);
            panel1.TabIndex = 72;
            // 
            // label9
            // 
            label9.BackColor = Color.FromArgb(42, 75, 106);
            label9.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(230, 228, 224);
            label9.Location = new Point(141, 32);
            label9.Name = "label9";
            label9.Size = new Size(405, 56);
            label9.TabIndex = 18;
            label9.Text = "Update Transactions";
            label9.TextAlign = ContentAlignment.TopCenter;
            // 
            // edittransaction
            // 
            edittransaction.BackColor = Color.FromArgb(42, 75, 106);
            edittransaction.ForeColor = Color.FromArgb(230, 228, 224);
            edittransaction.Location = new Point(1065, 486);
            edittransaction.Name = "edittransaction";
            edittransaction.Size = new Size(102, 41);
            edittransaction.TabIndex = 84;
            edittransaction.Text = "Edit";
            edittransaction.UseVisualStyleBackColor = false;
            edittransaction.Click += edittransaction_Click;
            // 
            // agentidtxtedit
            // 
            agentidtxtedit.Location = new Point(25, 364);
            agentidtxtedit.Name = "agentidtxtedit";
            agentidtxtedit.Size = new Size(322, 27);
            agentidtxtedit.TabIndex = 82;
            // 
            // buyeridtxtedit
            // 
            buyeridtxtedit.Location = new Point(25, 293);
            buyeridtxtedit.Name = "buyeridtxtedit";
            buyeridtxtedit.Size = new Size(322, 27);
            buyeridtxtedit.TabIndex = 81;
            // 
            // propertyidtxtedit
            // 
            propertyidtxtedit.Location = new Point(25, 222);
            propertyidtxtedit.Name = "propertyidtxtedit";
            propertyidtxtedit.Size = new Size(322, 27);
            propertyidtxtedit.TabIndex = 80;
            // 
            // returnpropertyedit
            // 
            returnpropertyedit.BackColor = Color.FromArgb(42, 75, 106);
            returnpropertyedit.ForeColor = Color.FromArgb(230, 228, 224);
            returnpropertyedit.Location = new Point(1173, 486);
            returnpropertyedit.Name = "returnpropertyedit";
            returnpropertyedit.Size = new Size(102, 41);
            returnpropertyedit.TabIndex = 85;
            returnpropertyedit.Text = "Return";
            returnpropertyedit.UseVisualStyleBackColor = false;
            returnpropertyedit.Click += returnpropertyedit_Click;
            // 
            // transactionsidtxtedit
            // 
            transactionsidtxtedit.Location = new Point(25, 151);
            transactionsidtxtedit.Name = "transactionsidtxtedit";
            transactionsidtxtedit.Size = new Size(322, 27);
            transactionsidtxtedit.TabIndex = 79;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(370, 120);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(905, 342);
            dataGridView1.TabIndex = 78;
            dataGridView1.RowHeaderMouseClick += dataGridView1_RowHeaderMouseClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(42, 75, 106);
            label4.Location = new Point(27, 333);
            label4.Name = "label4";
            label4.Size = new Size(104, 28);
            label4.TabIndex = 76;
            label4.Text = "Agent ID :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(42, 75, 106);
            label3.Location = new Point(25, 262);
            label3.Name = "label3";
            label3.Size = new Size(101, 28);
            label3.TabIndex = 75;
            label3.Text = "Buyer ID :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(42, 75, 106);
            label2.Location = new Point(27, 191);
            label2.Name = "label2";
            label2.Size = new Size(128, 28);
            label2.TabIndex = 74;
            label2.Text = "Property ID :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(42, 75, 106);
            label1.Location = new Point(25, 120);
            label1.Name = "label1";
            label1.Size = new Size(160, 28);
            label1.TabIndex = 73;
            label1.Text = "Transactions ID :";
            // 
            // edittransactions
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 228, 224);
            ClientSize = new Size(1287, 543);
            Controls.Add(transactionamttxtedit);
            Controls.Add(label6);
            Controls.Add(panel1);
            Controls.Add(edittransaction);
            Controls.Add(agentidtxtedit);
            Controls.Add(buyeridtxtedit);
            Controls.Add(propertyidtxtedit);
            Controls.Add(returnpropertyedit);
            Controls.Add(transactionsidtxtedit);
            Controls.Add(dataGridView1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "edittransactions";
            Text = "edittransactions";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox transactionamttxtedit;
        private Label label6;
        private Panel panel1;
        private Label label9;
        private Button edittransaction;
        private TextBox agentidtxtedit;
        private TextBox buyeridtxtedit;
        private TextBox propertyidtxtedit;
        private Button returnpropertyedit;
        private TextBox transactionsidtxtedit;
        private DataGridView dataGridView1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}