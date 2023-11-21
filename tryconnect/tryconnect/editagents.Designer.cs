namespace tryconnect
{
    partial class editagents
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
            usernametxtup = new TextBox();
            label6 = new Label();
            panel1 = new Panel();
            label9 = new Label();
            edittransaction = new Button();
            commratetxtup = new TextBox();
            contactinfotxtup = new TextBox();
            gendertxtup = new TextBox();
            nametxtup = new TextBox();
            returnpropertyedit = new Button();
            agentidtxtup = new TextBox();
            dataGridView1 = new DataGridView();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label7 = new Label();
            passwordtxtup = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // usernametxtup
            // 
            usernametxtup.Location = new Point(19, 465);
            usernametxtup.Name = "usernametxtup";
            usernametxtup.Size = new Size(322, 27);
            usernametxtup.TabIndex = 103;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(42, 75, 106);
            label6.Location = new Point(19, 438);
            label6.Name = "label6";
            label6.Size = new Size(115, 28);
            label6.TabIndex = 102;
            label6.Text = "Username :";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(42, 75, 106);
            panel1.Controls.Add(label9);
            panel1.Location = new Point(305, -14);
            panel1.Name = "panel1";
            panel1.Size = new Size(743, 94);
            panel1.TabIndex = 88;
            // 
            // label9
            // 
            label9.BackColor = Color.FromArgb(42, 75, 106);
            label9.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(230, 228, 224);
            label9.Location = new Point(176, 27);
            label9.Name = "label9";
            label9.Size = new Size(405, 56);
            label9.TabIndex = 18;
            label9.Text = "Update a Agent";
            label9.TextAlign = ContentAlignment.TopCenter;
            // 
            // edittransaction
            // 
            edittransaction.BackColor = Color.FromArgb(42, 75, 106);
            edittransaction.ForeColor = Color.FromArgb(230, 228, 224);
            edittransaction.Location = new Point(1033, 580);
            edittransaction.Name = "edittransaction";
            edittransaction.Size = new Size(102, 41);
            edittransaction.TabIndex = 100;
            edittransaction.Text = "Edit";
            edittransaction.UseVisualStyleBackColor = false;
            edittransaction.Click += edittransaction_Click;
            // 
            // commratetxtup
            // 
            commratetxtup.Location = new Point(19, 403);
            commratetxtup.Name = "commratetxtup";
            commratetxtup.Size = new Size(322, 27);
            commratetxtup.TabIndex = 99;
            // 
            // contactinfotxtup
            // 
            contactinfotxtup.Location = new Point(19, 340);
            contactinfotxtup.Name = "contactinfotxtup";
            contactinfotxtup.Size = new Size(322, 27);
            contactinfotxtup.TabIndex = 98;
            // 
            // gendertxtup
            // 
            gendertxtup.Location = new Point(19, 280);
            gendertxtup.Name = "gendertxtup";
            gendertxtup.Size = new Size(322, 27);
            gendertxtup.TabIndex = 97;
            // 
            // nametxtup
            // 
            nametxtup.Location = new Point(19, 219);
            nametxtup.Name = "nametxtup";
            nametxtup.Size = new Size(322, 27);
            nametxtup.TabIndex = 96;
            // 
            // returnpropertyedit
            // 
            returnpropertyedit.BackColor = Color.FromArgb(42, 75, 106);
            returnpropertyedit.ForeColor = Color.FromArgb(230, 228, 224);
            returnpropertyedit.Location = new Point(1166, 580);
            returnpropertyedit.Name = "returnpropertyedit";
            returnpropertyedit.Size = new Size(102, 41);
            returnpropertyedit.TabIndex = 101;
            returnpropertyedit.Text = "Return";
            returnpropertyedit.UseVisualStyleBackColor = false;
            returnpropertyedit.Click += returnpropertyedit_Click;
            // 
            // agentidtxtup
            // 
            agentidtxtup.Location = new Point(19, 158);
            agentidtxtup.Name = "agentidtxtup";
            agentidtxtup.Size = new Size(322, 27);
            agentidtxtup.TabIndex = 95;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(391, 122);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(855, 437);
            dataGridView1.TabIndex = 94;
            dataGridView1.RowHeaderMouseClick += dataGridView1_RowHeaderMouseClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(42, 75, 106);
            label5.Location = new Point(19, 374);
            label5.Name = "label5";
            label5.Size = new Size(172, 28);
            label5.TabIndex = 93;
            label5.Text = "Commision Rate :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(42, 75, 106);
            label4.Location = new Point(21, 314);
            label4.Name = "label4";
            label4.Size = new Size(206, 28);
            label4.TabIndex = 92;
            label4.Text = "Contact Information :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(42, 75, 106);
            label3.Location = new Point(19, 253);
            label3.Name = "label3";
            label3.Size = new Size(90, 28);
            label3.TabIndex = 91;
            label3.Text = "Gender :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(42, 75, 106);
            label2.Location = new Point(21, 193);
            label2.Name = "label2";
            label2.Size = new Size(77, 28);
            label2.TabIndex = 90;
            label2.Text = "Name :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(42, 75, 106);
            label1.Location = new Point(21, 122);
            label1.Name = "label1";
            label1.Size = new Size(104, 28);
            label1.TabIndex = 89;
            label1.Text = "Agent ID :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(42, 75, 106);
            label7.Location = new Point(19, 501);
            label7.Name = "label7";
            label7.Size = new Size(108, 28);
            label7.TabIndex = 104;
            label7.Text = "Password :";
            // 
            // passwordtxtup
            // 
            passwordtxtup.Location = new Point(21, 532);
            passwordtxtup.Name = "passwordtxtup";
            passwordtxtup.Size = new Size(322, 27);
            passwordtxtup.TabIndex = 105;
            // 
            // editagents
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 228, 224);
            ClientSize = new Size(1280, 633);
            Controls.Add(passwordtxtup);
            Controls.Add(label7);
            Controls.Add(usernametxtup);
            Controls.Add(label6);
            Controls.Add(panel1);
            Controls.Add(edittransaction);
            Controls.Add(commratetxtup);
            Controls.Add(contactinfotxtup);
            Controls.Add(gendertxtup);
            Controls.Add(nametxtup);
            Controls.Add(returnpropertyedit);
            Controls.Add(agentidtxtup);
            Controls.Add(dataGridView1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "editagents";
            Text = "editagents";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox usernametxtup;
        private Label label6;
        private Panel panel1;
        private Label label9;
        private Button edittransaction;
        private TextBox commratetxtup;
        private TextBox contactinfotxtup;
        private TextBox gendertxtup;
        private TextBox nametxtup;
        private Button returnpropertyedit;
        private TextBox agentidtxtup;
        private DataGridView dataGridView1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label7;
        private TextBox passwordtxtup;
    }
}