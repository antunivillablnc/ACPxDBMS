namespace tryconnect
{
    partial class deleteproperty
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
            propertyidtxtdelete = new TextBox();
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
            panel1.Location = new Point(176, -12);
            panel1.Name = "panel1";
            panel1.Size = new Size(424, 94);
            panel1.TabIndex = 28;
            // 
            // label9
            // 
            label9.BackColor = Color.FromArgb(42, 75, 106);
            label9.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ControlLightLight;
            label9.Location = new Point(38, 25);
            label9.Name = "label9";
            label9.Size = new Size(349, 56);
            label9.TabIndex = 18;
            label9.Text = "Delete a Property";
            label9.TextAlign = ContentAlignment.TopCenter;
            // 
            // returnpropertyedit
            // 
            returnpropertyedit.BackColor = Color.FromArgb(42, 75, 106);
            returnpropertyedit.ForeColor = Color.FromArgb(230, 228, 224);
            returnpropertyedit.Location = new Point(461, 480);
            returnpropertyedit.Name = "returnpropertyedit";
            returnpropertyedit.Size = new Size(102, 41);
            returnpropertyedit.TabIndex = 41;
            returnpropertyedit.Text = "Return";
            returnpropertyedit.UseVisualStyleBackColor = false;
            returnpropertyedit.Click += returnpropertyedit_Click;
            // 
            // deletebttnproperty
            // 
            deletebttnproperty.BackColor = Color.FromArgb(42, 75, 106);
            deletebttnproperty.ForeColor = Color.FromArgb(230, 228, 224);
            deletebttnproperty.Location = new Point(214, 480);
            deletebttnproperty.Name = "deletebttnproperty";
            deletebttnproperty.Size = new Size(102, 41);
            deletebttnproperty.TabIndex = 40;
            deletebttnproperty.Text = "Delete";
            deletebttnproperty.UseVisualStyleBackColor = false;
            deletebttnproperty.Click += deletebttnproperty_Click;
            // 
            // propertyidtxtdelete
            // 
            propertyidtxtdelete.Location = new Point(422, 134);
            propertyidtxtdelete.Name = "propertyidtxtdelete";
            propertyidtxtdelete.Size = new Size(66, 27);
            propertyidtxtdelete.TabIndex = 35;
            propertyidtxtdelete.TextAlign = HorizontalAlignment.Center;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(19, 194);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(761, 269);
            dataGridView1.TabIndex = 34;
            dataGridView1.RowHeaderMouseClick += dataGridView1_RowHeaderMouseClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(42, 75, 106);
            label1.Location = new Point(243, 130);
            label1.Name = "label1";
            label1.Size = new Size(128, 28);
            label1.TabIndex = 29;
            label1.Text = "Property ID :";
            // 
            // deleteproperty
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 228, 224);
            ClientSize = new Size(800, 548);
            Controls.Add(panel1);
            Controls.Add(returnpropertyedit);
            Controls.Add(deletebttnproperty);
            Controls.Add(propertyidtxtdelete);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "deleteproperty";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "deleteproperty";
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
        private TextBox propertyidtxtdelete;
        private DataGridView dataGridView1;
        private Label label1;
    }
}