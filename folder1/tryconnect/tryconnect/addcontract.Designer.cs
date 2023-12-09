namespace tryconnect
{
    partial class addcontract
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
            transactionIDaddcontracttxt = new TextBox();
            label5 = new Label();
            panel1 = new Panel();
            label9 = new Label();
            returnbttnaddcontract = new Button();
            addbttncontract = new Button();
            tandctxt = new TextBox();
            contractIDaddtxt = new TextBox();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // transactionIDaddcontracttxt
            // 
            transactionIDaddcontracttxt.Location = new Point(20, 273);
            transactionIDaddcontracttxt.Name = "transactionIDaddcontracttxt";
            transactionIDaddcontracttxt.Size = new Size(322, 27);
            transactionIDaddcontracttxt.TabIndex = 57;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(42, 75, 106);
            label5.Location = new Point(20, 242);
            label5.Name = "label5";
            label5.Size = new Size(145, 28);
            label5.TabIndex = 56;
            label5.Text = "Transaction ID:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(42, 75, 106);
            panel1.Controls.Add(label9);
            panel1.Location = new Point(262, -23);
            panel1.Name = "panel1";
            panel1.Size = new Size(424, 94);
            panel1.TabIndex = 44;
            // 
            // label9
            // 
            label9.BackColor = Color.FromArgb(42, 75, 106);
            label9.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(230, 228, 224);
            label9.Location = new Point(38, 28);
            label9.Name = "label9";
            label9.Size = new Size(349, 56);
            label9.TabIndex = 18;
            label9.Text = "Add Contract";
            label9.TextAlign = ContentAlignment.TopCenter;
            // 
            // returnbttnaddcontract
            // 
            returnbttnaddcontract.BackColor = Color.FromArgb(42, 75, 106);
            returnbttnaddcontract.ForeColor = Color.FromArgb(230, 228, 224);
            returnbttnaddcontract.Location = new Point(830, 439);
            returnbttnaddcontract.Name = "returnbttnaddcontract";
            returnbttnaddcontract.Size = new Size(102, 41);
            returnbttnaddcontract.TabIndex = 55;
            returnbttnaddcontract.Text = "Return";
            returnbttnaddcontract.UseVisualStyleBackColor = false;
            returnbttnaddcontract.Click += returnbttnaddcontract_Click;
            // 
            // addbttncontract
            // 
            addbttncontract.BackColor = Color.FromArgb(42, 75, 106);
            addbttncontract.ForeColor = Color.FromArgb(230, 228, 224);
            addbttncontract.Location = new Point(722, 439);
            addbttncontract.Name = "addbttncontract";
            addbttncontract.Size = new Size(102, 41);
            addbttncontract.TabIndex = 54;
            addbttncontract.Text = "Add";
            addbttncontract.UseVisualStyleBackColor = false;
            addbttncontract.Click += addbttncontract_Click;
            // 
            // tandctxt
            // 
            tandctxt.Location = new Point(20, 396);
            tandctxt.Name = "tandctxt";
            tandctxt.Size = new Size(322, 27);
            tandctxt.TabIndex = 51;
            // 
            // contractIDaddtxt
            // 
            contractIDaddtxt.Location = new Point(20, 152);
            contractIDaddtxt.Name = "contractIDaddtxt";
            contractIDaddtxt.Size = new Size(322, 27);
            contractIDaddtxt.TabIndex = 50;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(371, 115);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(561, 308);
            dataGridView1.TabIndex = 49;
            dataGridView1.RowHeaderMouseClick += dataGridView1_RowHeaderMouseClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(42, 75, 106);
            label2.Location = new Point(20, 365);
            label2.Name = "label2";
            label2.Size = new Size(221, 28);
            label2.TabIndex = 46;
            label2.Text = "Terms and Conditions :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(42, 75, 106);
            label1.Location = new Point(17, 121);
            label1.Name = "label1";
            label1.Size = new Size(125, 28);
            label1.TabIndex = 45;
            label1.Text = "Contract ID :";
            // 
            // addcontract
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 228, 224);
            ClientSize = new Size(944, 492);
            Controls.Add(transactionIDaddcontracttxt);
            Controls.Add(label5);
            Controls.Add(panel1);
            Controls.Add(returnbttnaddcontract);
            Controls.Add(addbttncontract);
            Controls.Add(tandctxt);
            Controls.Add(contractIDaddtxt);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "addcontract";
            Text = "addcontract";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox transactionIDaddcontracttxt;
        private Label label5;
        private Panel panel1;
        private Label label9;
        private Button returnbttnaddcontract;
        private Button addbttncontract;
        private TextBox tandctxt;
        private TextBox contractIDaddtxt;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label1;
    }
}