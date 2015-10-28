﻿namespace Bounced_Check_Manager
{
    partial class PayCheck
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
            this.components = new System.ComponentModel.Container();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.LNameTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.FNameTxtBox = new System.Windows.Forms.TextBox();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label13 = new System.Windows.Forms.Label();
            this.AddressTxtBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.AccNumberTxtBox = new System.Windows.Forms.TextBox();
            this.RoutingNumberTxtBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.PayBtn = new System.Windows.Forms.Button();
            this.checksGridView = new System.Windows.Forms.DataGridView();
            this.checkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teamPenguinDataSet = new Bounced_Check_Manager.TeamPenguinDataSet();
            this.checkTableAdapter = new Bounced_Check_Manager.TeamPenguinDataSetTableAdapters.CheckTableAdapter();
            this.checkBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.CheckNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BankName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BankAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateIssued = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CashierId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountOwed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checksGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamPenguinDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tableLayoutPanel2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(618, 157);
            this.splitContainer2.SplitterDistance = 58;
            this.splitContainer2.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.LNameTextBox, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label10, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.FNameTxtBox, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(618, 58);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // LNameTextBox
            // 
            this.LNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LNameTextBox.Location = new System.Drawing.Point(465, 19);
            this.LNameTextBox.Name = "LNameTextBox";
            this.LNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.LNameTextBox.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(94, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "First Name";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(401, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Last Name";
            // 
            // FNameTxtBox
            // 
            this.FNameTxtBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.FNameTxtBox.Location = new System.Drawing.Point(157, 19);
            this.FNameTxtBox.Name = "FNameTxtBox";
            this.FNameTxtBox.Size = new System.Drawing.Size(100, 20);
            this.FNameTxtBox.TabIndex = 12;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.tableLayoutPanel4);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.tableLayoutPanel3);
            this.splitContainer3.Size = new System.Drawing.Size(618, 95);
            this.splitContainer3.SplitterDistance = 51;
            this.splitContainer3.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.label13, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.AddressTxtBox, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(618, 51);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(52, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = "Address";
            // 
            // AddressTxtBox
            // 
            this.AddressTxtBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddressTxtBox.Location = new System.Drawing.Point(103, 3);
            this.AddressTxtBox.Multiline = true;
            this.AddressTxtBox.Name = "AddressTxtBox";
            this.AddressTxtBox.Size = new System.Drawing.Size(512, 45);
            this.AddressTxtBox.TabIndex = 12;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Controls.Add(this.SearchBtn, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.AccNumberTxtBox, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.RoutingNumberTxtBox, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label11, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label12, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(618, 40);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SearchBtn.Location = new System.Drawing.Point(517, 8);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(75, 23);
            this.SearchBtn.TabIndex = 23;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // AccNumberTxtBox
            // 
            this.AccNumberTxtBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AccNumberTxtBox.Location = new System.Drawing.Point(372, 10);
            this.AccNumberTxtBox.Name = "AccNumberTxtBox";
            this.AccNumberTxtBox.Size = new System.Drawing.Size(88, 20);
            this.AccNumberTxtBox.TabIndex = 22;
            // 
            // RoutingNumberTxtBox
            // 
            this.RoutingNumberTxtBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.RoutingNumberTxtBox.Location = new System.Drawing.Point(126, 10);
            this.RoutingNumberTxtBox.Name = "RoutingNumberTxtBox";
            this.RoutingNumberTxtBox.Size = new System.Drawing.Size(88, 20);
            this.RoutingNumberTxtBox.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(36, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Routing Number";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(279, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Account Number";
            // 
            // PayBtn
            // 
            this.PayBtn.Location = new System.Drawing.Point(282, 354);
            this.PayBtn.Name = "PayBtn";
            this.PayBtn.Size = new System.Drawing.Size(75, 23);
            this.PayBtn.TabIndex = 3;
            this.PayBtn.Text = "Pay";
            this.PayBtn.UseVisualStyleBackColor = true;
            this.PayBtn.Click += new System.EventHandler(this.PayBtn_Click);
            // 
            // checksGridView
            // 
            this.checksGridView.AllowUserToAddRows = false;
            this.checksGridView.AllowUserToDeleteRows = false;
            this.checksGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.checksGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheckNumber,
            this.BankName,
            this.BankAddress,
            this.DateIssued,
            this.Amount,
            this.CashierId,
            this.AmountOwed});
            this.checksGridView.Location = new System.Drawing.Point(0, 163);
            this.checksGridView.Name = "checksGridView";
            this.checksGridView.ReadOnly = true;
            this.checksGridView.RowTemplate.ReadOnly = true;
            this.checksGridView.Size = new System.Drawing.Size(615, 150);
            this.checksGridView.TabIndex = 4;
            // 
            // checkBindingSource
            // 
            this.checkBindingSource.DataMember = "Check";
            this.checkBindingSource.DataSource = this.teamPenguinDataSet;
            // 
            // teamPenguinDataSet
            // 
            this.teamPenguinDataSet.DataSetName = "TeamPenguinDataSet";
            this.teamPenguinDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // checkTableAdapter
            // 
            this.checkTableAdapter.ClearBeforeFill = true;
            // 
            // checkBindingSource1
            // 
            this.checkBindingSource1.DataMember = "Check";
            this.checkBindingSource1.DataSource = this.teamPenguinDataSet;
            // 
            // CheckNumber
            // 
            this.CheckNumber.Frozen = true;
            this.CheckNumber.HeaderText = "Check Number";
            this.CheckNumber.Name = "CheckNumber";
            this.CheckNumber.ReadOnly = true;
            this.CheckNumber.Width = 60;
            // 
            // BankName
            // 
            this.BankName.Frozen = true;
            this.BankName.HeaderText = "Bank Name";
            this.BankName.Name = "BankName";
            this.BankName.ReadOnly = true;
            this.BankName.Width = 80;
            // 
            // BankAddress
            // 
            this.BankAddress.Frozen = true;
            this.BankAddress.HeaderText = "Bank Address";
            this.BankAddress.Name = "BankAddress";
            this.BankAddress.ReadOnly = true;
            // 
            // DateIssued
            // 
            this.DateIssued.Frozen = true;
            this.DateIssued.HeaderText = "Date Issued";
            this.DateIssued.Name = "DateIssued";
            this.DateIssued.ReadOnly = true;
            this.DateIssued.Width = 70;
            // 
            // Amount
            // 
            this.Amount.Frozen = true;
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            this.Amount.Width = 60;
            // 
            // CashierId
            // 
            this.CashierId.Frozen = true;
            this.CashierId.HeaderText = "Cashier Id";
            this.CashierId.Name = "CashierId";
            this.CashierId.ReadOnly = true;
            this.CashierId.Width = 60;
            // 
            // AmountOwed
            // 
            this.AmountOwed.Frozen = true;
            this.AmountOwed.HeaderText = "Amount Owed";
            this.AmountOwed.Name = "AmountOwed";
            this.AmountOwed.ReadOnly = true;
            this.AmountOwed.Width = 60;
            // 
            // PayCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 495);
            this.Controls.Add(this.checksGridView);
            this.Controls.Add(this.PayBtn);
            this.Controls.Add(this.splitContainer2);
            this.Name = "PayCheck";
            this.Text = "PayCheck";
            this.Load += new System.EventHandler(this.PayCheck_Load);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checksGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamPenguinDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox LNameTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox FNameTxtBox;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox AddressTxtBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.TextBox AccNumberTxtBox;
        private System.Windows.Forms.TextBox RoutingNumberTxtBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button PayBtn;
        private System.Windows.Forms.DataGridView checksGridView;
        private TeamPenguinDataSet teamPenguinDataSet;
        private System.Windows.Forms.BindingSource checkBindingSource;
        private TeamPenguinDataSetTableAdapters.CheckTableAdapter checkTableAdapter;
        private System.Windows.Forms.BindingSource checkBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn BankName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BankAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateIssued;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn CashierId;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountOwed;
    }
}