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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(deletetransaction));
            transactionamttxtdelete = new TextBox();
            label6 = new Label();
            panel1 = new Panel();
            label9 = new Label();
            deletetr = new Button();
            agentidtxtdelete = new TextBox();
            buyeridtxtdelete = new TextBox();
            propertyidtxtdelete = new TextBox();
            returnpropertyedit = new Button();
            transactionsidtxtdelete = new TextBox();
            dataGridView1 = new DataGridView();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // transactionamttxtdelete
            // 
            transactionamttxtdelete.Location = new Point(15, 380);
            transactionamttxtdelete.Name = "transactionamttxtdelete";
            transactionamttxtdelete.Size = new Size(322, 27);
            transactionamttxtdelete.TabIndex = 103;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(42, 75, 106);
            label6.Location = new Point(15, 349);
            label6.Name = "label6";
            label6.Size = new Size(205, 28);
            label6.TabIndex = 102;
            label6.Text = "Transaction Amount :";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(42, 75, 106);
            panel1.Controls.Add(label9);
            panel1.Location = new Point(181, -19);
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
            deletetr.Location = new Point(402, 406);
            deletetr.Name = "deletetr";
            deletetr.Size = new Size(102, 41);
            deletetr.TabIndex = 100;
            deletetr.Text = "delete";
            deletetr.UseVisualStyleBackColor = false;
            deletetr.Click += deletetr_Click;
            // 
            // agentidtxtdelete
            // 
            agentidtxtdelete.Location = new Point(15, 300);
            agentidtxtdelete.Name = "agentidtxtdelete";
            agentidtxtdelete.Size = new Size(322, 27);
            agentidtxtdelete.TabIndex = 98;
            // 
            // buyeridtxtdelete
            // 
            buyeridtxtdelete.Location = new Point(15, 239);
            buyeridtxtdelete.Name = "buyeridtxtdelete";
            buyeridtxtdelete.Size = new Size(322, 27);
            buyeridtxtdelete.TabIndex = 97;
            // 
            // propertyidtxtdelete
            // 
            propertyidtxtdelete.Location = new Point(15, 178);
            propertyidtxtdelete.Name = "propertyidtxtdelete";
            propertyidtxtdelete.Size = new Size(322, 27);
            propertyidtxtdelete.TabIndex = 96;
            // 
            // returnpropertyedit
            // 
            returnpropertyedit.BackColor = Color.FromArgb(42, 75, 106);
            returnpropertyedit.ForeColor = Color.FromArgb(230, 228, 224);
            returnpropertyedit.Location = new Point(683, 406);
            returnpropertyedit.Name = "returnpropertyedit";
            returnpropertyedit.Size = new Size(102, 41);
            returnpropertyedit.TabIndex = 101;
            returnpropertyedit.Text = "Return";
            returnpropertyedit.UseVisualStyleBackColor = false;
            returnpropertyedit.Click += returnpropertyedit_Click;
            // 
            // transactionsidtxtdelete
            // 
            transactionsidtxtdelete.Location = new Point(15, 117);
            transactionsidtxtdelete.Name = "transactionsidtxtdelete";
            transactionsidtxtdelete.Size = new Size(322, 27);
            transactionsidtxtdelete.TabIndex = 95;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(402, 126);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(383, 269);
            dataGridView1.TabIndex = 94;
            dataGridView1.RowHeaderMouseClick += dataGridView1_RowHeaderMouseClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(42, 75, 106);
            label4.Location = new Point(17, 269);
            label4.Name = "label4";
            label4.Size = new Size(104, 28);
            label4.TabIndex = 92;
            label4.Text = "Agent ID :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(42, 75, 106);
            label3.Location = new Point(15, 208);
            label3.Name = "label3";
            label3.Size = new Size(101, 28);
            label3.TabIndex = 91;
            label3.Text = "Buyer ID :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(42, 75, 106);
            label2.Location = new Point(17, 147);
            label2.Name = "label2";
            label2.Size = new Size(128, 28);
            label2.TabIndex = 90;
            label2.Text = "Property ID :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(42, 75, 106);
            label1.Location = new Point(15, 86);
            label1.Name = "label1";
            label1.Size = new Size(160, 28);
            label1.TabIndex = 89;
            label1.Text = "Transactions ID :";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(640, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(145, 114);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 104;
            pictureBox1.TabStop = false;
            // 
            // deletetransaction
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 228, 224);
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(transactionamttxtdelete);
            Controls.Add(label6);
            Controls.Add(panel1);
            Controls.Add(deletetr);
            Controls.Add(agentidtxtdelete);
            Controls.Add(buyeridtxtdelete);
            Controls.Add(propertyidtxtdelete);
            Controls.Add(returnpropertyedit);
            Controls.Add(transactionsidtxtdelete);
            Controls.Add(dataGridView1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "deletetransaction";
            Text = "deletetransaction";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox transactionamttxtdelete;
        private Label label6;
        private Panel panel1;
        private Label label9;
        private Button deletetr;
        private TextBox agentidtxtdelete;
        private TextBox buyeridtxtdelete;
        private TextBox propertyidtxtdelete;
        private Button returnpropertyedit;
        private TextBox transactionsidtxtdelete;
        private DataGridView dataGridView1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
    }
}