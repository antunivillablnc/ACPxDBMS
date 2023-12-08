namespace tryconnect
{
    partial class addvisitor
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
            returnaddvisitorbttn = new Button();
            addbttnvisitor = new Button();
            visitorfeedbacktxt = new TextBox();
            agentidvisitortxt = new TextBox();
            visitornametxt = new TextBox();
            propertyidvisitortxt = new TextBox();
            visitoridtxt = new TextBox();
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
            panel1.Location = new Point(375, -33);
            panel1.Name = "panel1";
            panel1.Size = new Size(424, 94);
            panel1.TabIndex = 14;
            // 
            // label9
            // 
            label9.BackColor = Color.FromArgb(42, 75, 106);
            label9.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(230, 228, 224);
            label9.Location = new Point(40, 36);
            label9.Name = "label9";
            label9.Size = new Size(349, 56);
            label9.TabIndex = 18;
            label9.Text = "Add a Visitor";
            label9.TextAlign = ContentAlignment.TopCenter;
            // 
            // returnaddvisitorbttn
            // 
            returnaddvisitorbttn.BackColor = Color.FromArgb(42, 75, 106);
            returnaddvisitorbttn.ForeColor = Color.FromArgb(230, 228, 224);
            returnaddvisitorbttn.Location = new Point(1053, 508);
            returnaddvisitorbttn.Name = "returnaddvisitorbttn";
            returnaddvisitorbttn.Size = new Size(102, 41);
            returnaddvisitorbttn.TabIndex = 27;
            returnaddvisitorbttn.Text = "Return";
            returnaddvisitorbttn.UseVisualStyleBackColor = false;
            returnaddvisitorbttn.Click += returnaddvisitorbttn_Click;
            // 
            // addbttnvisitor
            // 
            addbttnvisitor.BackColor = Color.FromArgb(42, 75, 106);
            addbttnvisitor.ForeColor = Color.FromArgb(230, 228, 224);
            addbttnvisitor.Location = new Point(945, 508);
            addbttnvisitor.Name = "addbttnvisitor";
            addbttnvisitor.Size = new Size(102, 41);
            addbttnvisitor.TabIndex = 26;
            addbttnvisitor.Text = "Add";
            addbttnvisitor.UseVisualStyleBackColor = false;
            addbttnvisitor.Click += addbttnvisitor_Click;
            // 
            // visitorfeedbacktxt
            // 
            visitorfeedbacktxt.Location = new Point(20, 457);
            visitorfeedbacktxt.Name = "visitorfeedbacktxt";
            visitorfeedbacktxt.Size = new Size(322, 27);
            visitorfeedbacktxt.TabIndex = 25;
            // 
            // agentidvisitortxt
            // 
            agentidvisitortxt.Location = new Point(20, 378);
            agentidvisitortxt.Name = "agentidvisitortxt";
            agentidvisitortxt.Size = new Size(322, 27);
            agentidvisitortxt.TabIndex = 24;
            // 
            // visitornametxt
            // 
            visitornametxt.Location = new Point(23, 303);
            visitornametxt.Name = "visitornametxt";
            visitornametxt.Size = new Size(322, 27);
            visitornametxt.TabIndex = 23;
            // 
            // propertyidvisitortxt
            // 
            propertyidvisitortxt.Location = new Point(23, 223);
            propertyidvisitortxt.Name = "propertyidvisitortxt";
            propertyidvisitortxt.Size = new Size(322, 27);
            propertyidvisitortxt.TabIndex = 22;
            // 
            // visitoridtxt
            // 
            visitoridtxt.Location = new Point(23, 147);
            visitoridtxt.Name = "visitoridtxt";
            visitoridtxt.Size = new Size(322, 27);
            visitoridtxt.TabIndex = 21;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(397, 114);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(758, 370);
            dataGridView1.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(42, 75, 106);
            label5.Location = new Point(17, 426);
            label5.Name = "label5";
            label5.Size = new Size(109, 28);
            label5.TabIndex = 19;
            label5.Text = "Feedback :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(42, 75, 106);
            label4.Location = new Point(20, 347);
            label4.Name = "label4";
            label4.Size = new Size(104, 28);
            label4.TabIndex = 18;
            label4.Text = "Agent ID :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(42, 75, 106);
            label3.Location = new Point(20, 271);
            label3.Name = "label3";
            label3.Size = new Size(151, 28);
            label3.TabIndex = 17;
            label3.Text = "Visitor's name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(42, 75, 106);
            label2.Location = new Point(20, 192);
            label2.Name = "label2";
            label2.Size = new Size(128, 28);
            label2.TabIndex = 16;
            label2.Text = "Property ID :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(42, 75, 106);
            label1.Location = new Point(20, 114);
            label1.Name = "label1";
            label1.Size = new Size(107, 28);
            label1.TabIndex = 15;
            label1.Text = "Visitor ID :";
            // 
            // addvisitor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 228, 224);
            ClientSize = new Size(1180, 564);
            Controls.Add(panel1);
            Controls.Add(returnaddvisitorbttn);
            Controls.Add(addbttnvisitor);
            Controls.Add(visitorfeedbacktxt);
            Controls.Add(agentidvisitortxt);
            Controls.Add(visitornametxt);
            Controls.Add(propertyidvisitortxt);
            Controls.Add(visitoridtxt);
            Controls.Add(dataGridView1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "addvisitor";
            Text = "addvisitor";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label9;
        private Button returnaddvisitorbttn;
        private Button addbttnvisitor;
        private TextBox visitorfeedbacktxt;
        private TextBox agentidvisitortxt;
        private TextBox visitornametxt;
        private TextBox propertyidvisitortxt;
        private TextBox visitoridtxt;
        private DataGridView dataGridView1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}