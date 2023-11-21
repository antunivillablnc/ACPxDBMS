namespace tryconnect
{
    partial class editproperty
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
            editbttnproperty = new Button();
            pricetxtedit = new TextBox();
            sizetxtedit = new TextBox();
            typeofproptxtedit = new TextBox();
            addresstxtedit = new TextBox();
            propertyidtxtedit = new TextBox();
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
            panel1.Location = new Point(202, -16);
            panel1.Name = "panel1";
            panel1.Size = new Size(642, 94);
            panel1.TabIndex = 14;
            // 
            // label9
            // 
            label9.BackColor = Color.FromArgb(42, 75, 106);
            label9.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ControlLightLight;
            label9.Location = new Point(148, 25);
            label9.Name = "label9";
            label9.Size = new Size(349, 56);
            label9.TabIndex = 18;
            label9.Text = "Edit a Property";
            label9.TextAlign = ContentAlignment.TopCenter;
            // 
            // returnpropertyedit
            // 
            returnpropertyedit.BackColor = Color.FromArgb(42, 75, 106);
            returnpropertyedit.ForeColor = Color.FromArgb(230, 228, 224);
            returnpropertyedit.Location = new Point(939, 473);
            returnpropertyedit.Name = "returnpropertyedit";
            returnpropertyedit.Size = new Size(102, 41);
            returnpropertyedit.TabIndex = 27;
            returnpropertyedit.Text = "Return";
            returnpropertyedit.UseVisualStyleBackColor = false;
            returnpropertyedit.Click += returnpropertyedit_Click;
            // 
            // editbttnproperty
            // 
            editbttnproperty.BackColor = Color.FromArgb(42, 75, 106);
            editbttnproperty.ForeColor = Color.FromArgb(230, 228, 224);
            editbttnproperty.Location = new Point(775, 473);
            editbttnproperty.Name = "editbttnproperty";
            editbttnproperty.Size = new Size(102, 41);
            editbttnproperty.TabIndex = 26;
            editbttnproperty.Text = "Edit";
            editbttnproperty.UseVisualStyleBackColor = false;
            editbttnproperty.Click += editbttnproperty_Click;
            // 
            // pricetxtedit
            // 
            pricetxtedit.Location = new Point(23, 425);
            pricetxtedit.Name = "pricetxtedit";
            pricetxtedit.Size = new Size(322, 27);
            pricetxtedit.TabIndex = 25;
            // 
            // sizetxtedit
            // 
            sizetxtedit.Location = new Point(20, 357);
            sizetxtedit.Name = "sizetxtedit";
            sizetxtedit.Size = new Size(322, 27);
            sizetxtedit.TabIndex = 24;
            // 
            // typeofproptxtedit
            // 
            typeofproptxtedit.Location = new Point(23, 290);
            typeofproptxtedit.Name = "typeofproptxtedit";
            typeofproptxtedit.Size = new Size(322, 27);
            typeofproptxtedit.TabIndex = 23;
            // 
            // addresstxtedit
            // 
            addresstxtedit.Location = new Point(23, 216);
            addresstxtedit.Name = "addresstxtedit";
            addresstxtedit.Size = new Size(322, 27);
            addresstxtedit.TabIndex = 22;
            // 
            // propertyidtxtedit
            // 
            propertyidtxtedit.Location = new Point(23, 149);
            propertyidtxtedit.Name = "propertyidtxtedit";
            propertyidtxtedit.Size = new Size(322, 27);
            propertyidtxtedit.TabIndex = 21;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(365, 116);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(676, 336);
            dataGridView1.TabIndex = 20;
            dataGridView1.RowHeaderMouseClick += dataGridView1_RowHeaderMouseClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(42, 75, 106);
            label5.Location = new Point(20, 394);
            label5.Name = "label5";
            label5.Size = new Size(67, 28);
            label5.TabIndex = 19;
            label5.Text = "Price :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(42, 75, 106);
            label4.Location = new Point(20, 326);
            label4.Name = "label4";
            label4.Size = new Size(59, 28);
            label4.TabIndex = 18;
            label4.Text = "Size :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(42, 75, 106);
            label3.Location = new Point(20, 258);
            label3.Name = "label3";
            label3.Size = new Size(176, 28);
            label3.TabIndex = 17;
            label3.Text = "Type of Property :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(42, 75, 106);
            label2.Location = new Point(20, 185);
            label2.Name = "label2";
            label2.Size = new Size(96, 28);
            label2.TabIndex = 16;
            label2.Text = "Address :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(42, 75, 106);
            label1.Location = new Point(20, 116);
            label1.Name = "label1";
            label1.Size = new Size(128, 28);
            label1.TabIndex = 15;
            label1.Text = "Property ID :";
            // 
            // editproperty
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 228, 224);
            ClientSize = new Size(1057, 526);
            Controls.Add(panel1);
            Controls.Add(returnpropertyedit);
            Controls.Add(editbttnproperty);
            Controls.Add(pricetxtedit);
            Controls.Add(sizetxtedit);
            Controls.Add(typeofproptxtedit);
            Controls.Add(addresstxtedit);
            Controls.Add(propertyidtxtedit);
            Controls.Add(dataGridView1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "editproperty";
            Text = "editproperty";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label9;
        private Button returnpropertyedit;
        private Button editbttnproperty;
        private TextBox pricetxtedit;
        private TextBox sizetxtedit;
        private TextBox typeofproptxtedit;
        private TextBox addresstxtedit;
        private TextBox propertyidtxtedit;
        private DataGridView dataGridView1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}