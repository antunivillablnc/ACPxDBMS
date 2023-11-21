namespace tryconnect
{
    partial class deletebuyer
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
            deletebttnproperty = new Button();
            budgettxtdelete = new TextBox();
            contactinfotxtdelete = new TextBox();
            nametxtdelete = new TextBox();
            addresstxtdelete = new TextBox();
            buyeridtxtdelete = new TextBox();
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
            panel1.Location = new Point(176, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(424, 94);
            panel1.TabIndex = 42;
            // 
            // label9
            // 
            label9.BackColor = Color.FromArgb(42, 75, 106);
            label9.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(230, 228, 224);
            label9.Location = new Point(38, 25);
            label9.Name = "label9";
            label9.Size = new Size(349, 56);
            label9.TabIndex = 18;
            label9.Text = "Delete a Buyer";
            label9.TextAlign = ContentAlignment.TopCenter;
            // 
            // returnpropertyedit
            // 
            returnpropertyedit.BackColor = Color.FromArgb(42, 75, 106);
            returnpropertyedit.ForeColor = Color.FromArgb(230, 228, 224);
            returnpropertyedit.Location = new Point(678, 406);
            returnpropertyedit.Name = "returnpropertyedit";
            returnpropertyedit.Size = new Size(102, 41);
            returnpropertyedit.TabIndex = 55;
            returnpropertyedit.Text = "Return";
            returnpropertyedit.UseVisualStyleBackColor = false;
            returnpropertyedit.Click += returnpropertyedit_Click;
            // 
            // deletebttnproperty
            // 
            deletebttnproperty.BackColor = Color.FromArgb(42, 75, 106);
            deletebttnproperty.ForeColor = Color.FromArgb(230, 228, 224);
            deletebttnproperty.Location = new Point(397, 406);
            deletebttnproperty.Name = "deletebttnproperty";
            deletebttnproperty.Size = new Size(102, 41);
            deletebttnproperty.TabIndex = 54;
            deletebttnproperty.Text = "Delete";
            deletebttnproperty.UseVisualStyleBackColor = false;
            deletebttnproperty.Click += deletebttnproperty_Click;
            // 
            // budgettxtdelete
            // 
            budgettxtdelete.Location = new Point(23, 406);
            budgettxtdelete.Name = "budgettxtdelete";
            budgettxtdelete.Size = new Size(322, 27);
            budgettxtdelete.TabIndex = 53;
            // 
            // contactinfotxtdelete
            // 
            contactinfotxtdelete.Location = new Point(20, 352);
            contactinfotxtdelete.Name = "contactinfotxtdelete";
            contactinfotxtdelete.Size = new Size(322, 27);
            contactinfotxtdelete.TabIndex = 52;
            // 
            // nametxtdelete
            // 
            nametxtdelete.Location = new Point(23, 291);
            nametxtdelete.Name = "nametxtdelete";
            nametxtdelete.Size = new Size(322, 27);
            nametxtdelete.TabIndex = 51;
            // 
            // addresstxtdelete
            // 
            addresstxtdelete.Location = new Point(23, 230);
            addresstxtdelete.Name = "addresstxtdelete";
            addresstxtdelete.Size = new Size(322, 27);
            addresstxtdelete.TabIndex = 50;
            // 
            // buyeridtxtdelete
            // 
            buyeridtxtdelete.Location = new Point(23, 169);
            buyeridtxtdelete.Name = "buyeridtxtdelete";
            buyeridtxtdelete.Size = new Size(322, 27);
            buyeridtxtdelete.TabIndex = 49;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(397, 126);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(383, 269);
            dataGridView1.TabIndex = 48;
            dataGridView1.RowHeaderMouseClick += dataGridView1_RowHeaderMouseClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(42, 75, 106);
            label5.Location = new Point(20, 375);
            label5.Name = "label5";
            label5.Size = new Size(89, 28);
            label5.TabIndex = 47;
            label5.Text = "Budget :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(42, 75, 106);
            label4.Location = new Point(20, 321);
            label4.Name = "label4";
            label4.Size = new Size(206, 28);
            label4.TabIndex = 46;
            label4.Text = "Contact Information :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(42, 75, 106);
            label3.Location = new Point(20, 259);
            label3.Name = "label3";
            label3.Size = new Size(77, 28);
            label3.TabIndex = 45;
            label3.Text = "Name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(42, 75, 106);
            label2.Location = new Point(20, 199);
            label2.Name = "label2";
            label2.Size = new Size(96, 28);
            label2.TabIndex = 44;
            label2.Text = "Address :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(42, 75, 106);
            label1.Location = new Point(20, 136);
            label1.Name = "label1";
            label1.Size = new Size(101, 28);
            label1.TabIndex = 43;
            label1.Text = "Buyer ID :";
            // 
            // deletebuyer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(returnpropertyedit);
            Controls.Add(deletebttnproperty);
            Controls.Add(budgettxtdelete);
            Controls.Add(contactinfotxtdelete);
            Controls.Add(nametxtdelete);
            Controls.Add(addresstxtdelete);
            Controls.Add(buyeridtxtdelete);
            Controls.Add(dataGridView1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "deletebuyer";
            Text = "deletebuyer";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label9;
        private Button returnpropertyedit;
        private Button deletebttnproperty;
        private TextBox budgettxtdelete;
        private TextBox contactinfotxtdelete;
        private TextBox nametxtdelete;
        private TextBox addresstxtdelete;
        private TextBox buyeridtxtdelete;
        private DataGridView dataGridView1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}