﻿namespace tryconnect
{
    partial class updatecontract
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
            transactionIDeditcontracttxt = new TextBox();
            label5 = new Label();
            panel1 = new Panel();
            label9 = new Label();
            returnbttneditcontract = new Button();
            saveeditcontractbttn = new Button();
            tandcedittxt = new TextBox();
            contractIDedittxt = new TextBox();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // transactionIDeditcontracttxt
            // 
            transactionIDeditcontracttxt.Location = new Point(20, 264);
            transactionIDeditcontracttxt.Name = "transactionIDeditcontracttxt";
            transactionIDeditcontracttxt.Size = new Size(322, 27);
            transactionIDeditcontracttxt.TabIndex = 67;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(42, 75, 106);
            label5.Location = new Point(20, 233);
            label5.Name = "label5";
            label5.Size = new Size(145, 28);
            label5.TabIndex = 66;
            label5.Text = "Transaction ID:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(42, 75, 106);
            panel1.Controls.Add(label9);
            panel1.Location = new Point(224, -23);
            panel1.Name = "panel1";
            panel1.Size = new Size(424, 94);
            panel1.TabIndex = 58;
            // 
            // label9
            // 
            label9.BackColor = Color.FromArgb(42, 75, 106);
            label9.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(230, 228, 224);
            label9.Location = new Point(41, 28);
            label9.Name = "label9";
            label9.Size = new Size(349, 56);
            label9.TabIndex = 18;
            label9.Text = "Edit Contract";
            label9.TextAlign = ContentAlignment.TopCenter;
            // 
            // returnbttneditcontract
            // 
            returnbttneditcontract.BackColor = Color.FromArgb(42, 75, 106);
            returnbttneditcontract.ForeColor = Color.FromArgb(230, 228, 224);
            returnbttneditcontract.Location = new Point(759, 447);
            returnbttneditcontract.Name = "returnbttneditcontract";
            returnbttneditcontract.Size = new Size(102, 41);
            returnbttneditcontract.TabIndex = 65;
            returnbttneditcontract.Text = "Return";
            returnbttneditcontract.UseVisualStyleBackColor = false;
            returnbttneditcontract.Click += returnbttneditcontract_Click;
            // 
            // saveeditcontractbttn
            // 
            saveeditcontractbttn.BackColor = Color.FromArgb(42, 75, 106);
            saveeditcontractbttn.ForeColor = Color.FromArgb(230, 228, 224);
            saveeditcontractbttn.Location = new Point(639, 447);
            saveeditcontractbttn.Name = "saveeditcontractbttn";
            saveeditcontractbttn.Size = new Size(102, 41);
            saveeditcontractbttn.TabIndex = 64;
            saveeditcontractbttn.Text = "Save";
            saveeditcontractbttn.UseVisualStyleBackColor = false;
            saveeditcontractbttn.Click += saveeditcontractbttn_Click;
            // 
            // tandcedittxt
            // 
            tandcedittxt.Location = new Point(20, 390);
            tandcedittxt.Name = "tandcedittxt";
            tandcedittxt.Size = new Size(322, 27);
            tandcedittxt.TabIndex = 63;
            // 
            // contractIDedittxt
            // 
            contractIDedittxt.Location = new Point(20, 151);
            contractIDedittxt.Name = "contractIDedittxt";
            contractIDedittxt.Size = new Size(322, 27);
            contractIDedittxt.TabIndex = 62;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(380, 120);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(481, 309);
            dataGridView1.TabIndex = 61;
            dataGridView1.RowHeaderMouseClick += dataGridView1_RowHeaderMouseClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(42, 75, 106);
            label2.Location = new Point(20, 359);
            label2.Name = "label2";
            label2.Size = new Size(221, 28);
            label2.TabIndex = 60;
            label2.Text = "Terms and Conditions :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(42, 75, 106);
            label1.Location = new Point(17, 120);
            label1.Name = "label1";
            label1.Size = new Size(125, 28);
            label1.TabIndex = 59;
            label1.Text = "Contract ID :";
            // 
            // updatecontract
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 228, 224);
            ClientSize = new Size(893, 501);
            Controls.Add(transactionIDeditcontracttxt);
            Controls.Add(label5);
            Controls.Add(panel1);
            Controls.Add(returnbttneditcontract);
            Controls.Add(saveeditcontractbttn);
            Controls.Add(tandcedittxt);
            Controls.Add(contractIDedittxt);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "updatecontract";
            Text = "updatecontract";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox transactionIDeditcontracttxt;
        private Label label5;
        private Panel panel1;
        private Label label9;
        private Button returnbttneditcontract;
        private Button saveeditcontractbttn;
        private TextBox tandcedittxt;
        private TextBox contractIDedittxt;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label1;
    }
}