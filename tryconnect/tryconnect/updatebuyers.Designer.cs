namespace tryconnect
{
    partial class editbuyers
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
            returnpropertyedit = new Button();
            editbuyersbttn = new Button();
            budgettxtedit = new TextBox();
            contactnumtxtedit = new TextBox();
            nametxtedit = new TextBox();
            addresstxtedit = new TextBox();
            buyertxtedit = new TextBox();
            dataGridView1 = new DataGridView();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(42, 75, 106);
            panel1.Controls.Add(label9);
            panel1.Location = new Point(285, -19);
            panel1.Name = "panel1";
            panel1.Size = new Size(536, 94);
            panel1.TabIndex = 56;
            // 
            // label9
            // 
            label9.BackColor = Color.FromArgb(42, 75, 106);
            label9.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(230, 228, 224);
            label9.Location = new Point(72, 25);
            label9.Name = "label9";
            label9.Size = new Size(405, 56);
            label9.TabIndex = 18;
            label9.Text = "Update a buyer\r\n";
            label9.TextAlign = ContentAlignment.TopCenter;
            // 
            // returnpropertyedit
            // 
            returnpropertyedit.BackColor = Color.FromArgb(42, 75, 106);
            returnpropertyedit.ForeColor = Color.FromArgb(230, 228, 224);
            returnpropertyedit.Location = new Point(969, 487);
            returnpropertyedit.Name = "returnpropertyedit";
            returnpropertyedit.Size = new Size(102, 41);
            returnpropertyedit.TabIndex = 69;
            returnpropertyedit.Text = "Return";
            returnpropertyedit.UseVisualStyleBackColor = false;
            returnpropertyedit.Click += returnpropertyedit_Click;
            // 
            // editbuyersbttn
            // 
            editbuyersbttn.BackColor = Color.FromArgb(42, 75, 106);
            editbuyersbttn.ForeColor = Color.FromArgb(230, 228, 224);
            editbuyersbttn.Location = new Point(861, 487);
            editbuyersbttn.Name = "editbuyersbttn";
            editbuyersbttn.Size = new Size(102, 41);
            editbuyersbttn.TabIndex = 68;
            editbuyersbttn.Text = "Edit";
            editbuyersbttn.UseVisualStyleBackColor = false;
            editbuyersbttn.Click += deletebttnproperty_Click;
            // 
            // budgettxtedit
            // 
            budgettxtedit.Location = new Point(14, 428);
            budgettxtedit.Name = "budgettxtedit";
            budgettxtedit.Size = new Size(322, 27);
            budgettxtedit.TabIndex = 67;
            // 
            // contactnumtxtedit
            // 
            contactnumtxtedit.Location = new Point(12, 358);
            contactnumtxtedit.Name = "contactnumtxtedit";
            contactnumtxtedit.Size = new Size(322, 27);
            contactnumtxtedit.TabIndex = 66;
            // 
            // nametxtedit
            // 
            nametxtedit.Location = new Point(12, 283);
            nametxtedit.Name = "nametxtedit";
            nametxtedit.Size = new Size(322, 27);
            nametxtedit.TabIndex = 65;
            // 
            // addresstxtedit
            // 
            addresstxtedit.Location = new Point(10, 215);
            addresstxtedit.Name = "addresstxtedit";
            addresstxtedit.Size = new Size(322, 27);
            addresstxtedit.TabIndex = 64;
            // 
            // buyertxtedit
            // 
            buyertxtedit.Location = new Point(10, 143);
            buyertxtedit.Name = "buyertxtedit";
            buyertxtedit.Size = new Size(322, 27);
            buyertxtedit.TabIndex = 63;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(362, 112);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(709, 353);
            dataGridView1.TabIndex = 62;
            dataGridView1.RowHeaderMouseClick += dataGridView1_RowHeaderMouseClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(42, 75, 106);
            label5.Location = new Point(14, 397);
            label5.Name = "label5";
            label5.Size = new Size(89, 28);
            label5.TabIndex = 61;
            label5.Text = "Budget :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(42, 75, 106);
            label4.Location = new Point(14, 327);
            label4.Name = "label4";
            label4.Size = new Size(170, 28);
            label4.TabIndex = 60;
            label4.Text = "Contact number :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(42, 75, 106);
            label3.Location = new Point(12, 252);
            label3.Name = "label3";
            label3.Size = new Size(77, 28);
            label3.TabIndex = 59;
            label3.Text = "Name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(42, 75, 106);
            label2.Location = new Point(12, 184);
            label2.Name = "label2";
            label2.Size = new Size(96, 28);
            label2.TabIndex = 58;
            label2.Text = "Address :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(42, 75, 106);
            label1.Location = new Point(10, 112);
            label1.Name = "label1";
            label1.Size = new Size(101, 28);
            label1.TabIndex = 57;
            label1.Text = "Buyer ID :";
            // 
            // editbuyers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 228, 224);
            ClientSize = new Size(1083, 540);
            Controls.Add(panel1);
            Controls.Add(returnpropertyedit);
            Controls.Add(editbuyersbttn);
            Controls.Add(budgettxtedit);
            Controls.Add(contactnumtxtedit);
            Controls.Add(nametxtedit);
            Controls.Add(addresstxtedit);
            Controls.Add(buyertxtedit);
            Controls.Add(dataGridView1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "editbuyers";
            Text = "editbuyers";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label9;
        private Button returnpropertyedit;
        private Button editbuyersbttn;
        private TextBox budgettxtedit;
        private TextBox contactnumtxtedit;
        private TextBox nametxtedit;
        private TextBox addresstxtedit;
        private TextBox buyertxtedit;
        private DataGridView dataGridView1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}