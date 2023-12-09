namespace tryconnect
{
    partial class deletevisitorrecords
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
            returndeletevisitsbttn = new Button();
            deletebttnvisits = new Button();
            visitoriddeletetxt = new TextBox();
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
            panel1.Location = new Point(182, -39);
            panel1.Name = "panel1";
            panel1.Size = new Size(424, 94);
            panel1.TabIndex = 28;
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
            label9.Text = "Delete a Record";
            label9.TextAlign = ContentAlignment.TopCenter;
            // 
            // returndeletevisitsbttn
            // 
            returndeletevisitsbttn.BackColor = Color.FromArgb(42, 75, 106);
            returndeletevisitsbttn.ForeColor = Color.FromArgb(230, 228, 224);
            returndeletevisitsbttn.Location = new Point(471, 448);
            returndeletevisitsbttn.Name = "returndeletevisitsbttn";
            returndeletevisitsbttn.Size = new Size(102, 41);
            returndeletevisitsbttn.TabIndex = 41;
            returndeletevisitsbttn.Text = "Return";
            returndeletevisitsbttn.UseVisualStyleBackColor = false;
            returndeletevisitsbttn.Click += returndeletevisitsbttn_Click;
            // 
            // deletebttnvisits
            // 
            deletebttnvisits.BackColor = Color.FromArgb(42, 75, 106);
            deletebttnvisits.ForeColor = Color.FromArgb(230, 228, 224);
            deletebttnvisits.Location = new Point(224, 448);
            deletebttnvisits.Name = "deletebttnvisits";
            deletebttnvisits.Size = new Size(102, 41);
            deletebttnvisits.TabIndex = 40;
            deletebttnvisits.Text = "Delete";
            deletebttnvisits.UseVisualStyleBackColor = false;
            deletebttnvisits.Click += deletebttnvisits_Click;
            // 
            // visitoriddeletetxt
            // 
            visitoriddeletetxt.Location = new Point(399, 100);
            visitoriddeletetxt.Name = "visitoriddeletetxt";
            visitoriddeletetxt.Size = new Size(79, 27);
            visitoriddeletetxt.TabIndex = 35;
            visitoriddeletetxt.TextAlign = HorizontalAlignment.Center;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 157);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(770, 277);
            dataGridView1.TabIndex = 34;
            dataGridView1.RowHeaderMouseClick += dataGridView1_RowHeaderMouseClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(42, 75, 106);
            label1.Location = new Point(286, 96);
            label1.Name = "label1";
            label1.Size = new Size(107, 28);
            label1.TabIndex = 29;
            label1.Text = "Visitor ID :";
            // 
            // deletevisitorrecords
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 228, 224);
            ClientSize = new Size(800, 501);
            Controls.Add(panel1);
            Controls.Add(returndeletevisitsbttn);
            Controls.Add(deletebttnvisits);
            Controls.Add(visitoriddeletetxt);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "deletevisitorrecords";
            Text = "deletevisitorrecords";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label9;
        private Button returndeletevisitsbttn;
        private Button deletebttnvisits;
        private TextBox visitoriddeletetxt;
        private DataGridView dataGridView1;
        private Label label1;
    }
}