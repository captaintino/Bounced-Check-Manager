namespace Bounced_Check_Manager
{
    namespace Bounced_Check_Manager_UI_Layer
    {
        partial class mainMenu
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.GenerateLettersBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.CreateCheckBtn = new System.Windows.Forms.Button();
            this.PayCheckBtn = new System.Windows.Forms.Button();
            this.createBtn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.accountIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountLastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountPhoneNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bankIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountRoutingNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.teamPenguinDataSet = new Bounced_Check_Manager.TeamPenguinDataSet();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updatePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supervisorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.accountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountTableAdapter = new Bounced_Check_Manager.TeamPenguinDataSetTableAdapters.AccountTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamPenguinDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(781, 491);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.GenerateLettersBtn, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.updateBtn, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.button5, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.CreateCheckBtn, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.PayCheckBtn, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.createBtn, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.refreshBtn, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(244, 485);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // GenerateLettersBtn
            // 
            this.GenerateLettersBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GenerateLettersBtn.Location = new System.Drawing.Point(22, 23);
            this.GenerateLettersBtn.Name = "GenerateLettersBtn";
            this.GenerateLettersBtn.Size = new System.Drawing.Size(200, 23);
            this.GenerateLettersBtn.TabIndex = 7;
            this.GenerateLettersBtn.Text = "Generate Letters";
            this.GenerateLettersBtn.UseVisualStyleBackColor = true;
            this.GenerateLettersBtn.Click += new System.EventHandler(this.GenerateLettersBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.updateBtn.Location = new System.Drawing.Point(22, 230);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(200, 23);
            this.updateBtn.TabIndex = 3;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button5.Location = new System.Drawing.Point(22, 438);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(200, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "Exit";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // CreateCheckBtn
            // 
            this.CreateCheckBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CreateCheckBtn.Location = new System.Drawing.Point(22, 299);
            this.CreateCheckBtn.Name = "CreateCheckBtn";
            this.CreateCheckBtn.Size = new System.Drawing.Size(200, 23);
            this.CreateCheckBtn.TabIndex = 5;
            this.CreateCheckBtn.Text = "Input Check";
            this.CreateCheckBtn.UseVisualStyleBackColor = true;
            this.CreateCheckBtn.Click += new System.EventHandler(this.CreateCheckBtn_Click);
            // 
            // PayCheckBtn
            // 
            this.PayCheckBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PayCheckBtn.Location = new System.Drawing.Point(22, 368);
            this.PayCheckBtn.Name = "PayCheckBtn";
            this.PayCheckBtn.Size = new System.Drawing.Size(200, 23);
            this.PayCheckBtn.TabIndex = 6;
            this.PayCheckBtn.Text = "Pay Check";
            this.PayCheckBtn.UseVisualStyleBackColor = true;
            this.PayCheckBtn.Click += new System.EventHandler(this.PayCheckBtn_Click);
            // 
            // createBtn
            // 
            this.createBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.createBtn.Location = new System.Drawing.Point(22, 161);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(200, 23);
            this.createBtn.TabIndex = 1;
            this.createBtn.Text = "Create";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.refreshBtn.Location = new System.Drawing.Point(22, 92);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(200, 23);
            this.refreshBtn.TabIndex = 0;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.accountIDDataGridViewTextBoxColumn,
            this.accountLastNameDataGridViewTextBoxColumn,
            this.accountPhoneNumDataGridViewTextBoxColumn,
            this.accountAddressDataGridViewTextBoxColumn,
            this.accountNumDataGridViewTextBoxColumn,
            this.bankIDDataGridViewTextBoxColumn,
            this.accountRoutingNumDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.accountBindingSource2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(253, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(525, 485);
            this.dataGridView1.TabIndex = 1;
            // 
            // accountIDDataGridViewTextBoxColumn
            // 
            this.accountIDDataGridViewTextBoxColumn.DataPropertyName = "AccountID";
            this.accountIDDataGridViewTextBoxColumn.HeaderText = "AccountID";
            this.accountIDDataGridViewTextBoxColumn.Name = "accountIDDataGridViewTextBoxColumn";
            this.accountIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // accountLastNameDataGridViewTextBoxColumn
            // 
            this.accountLastNameDataGridViewTextBoxColumn.DataPropertyName = "AccountLastName";
            this.accountLastNameDataGridViewTextBoxColumn.HeaderText = "AccountLastName";
            this.accountLastNameDataGridViewTextBoxColumn.Name = "accountLastNameDataGridViewTextBoxColumn";
            this.accountLastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // accountPhoneNumDataGridViewTextBoxColumn
            // 
            this.accountPhoneNumDataGridViewTextBoxColumn.DataPropertyName = "AccountPhoneNum";
            this.accountPhoneNumDataGridViewTextBoxColumn.HeaderText = "AccountPhoneNum";
            this.accountPhoneNumDataGridViewTextBoxColumn.Name = "accountPhoneNumDataGridViewTextBoxColumn";
            this.accountPhoneNumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // accountAddressDataGridViewTextBoxColumn
            // 
            this.accountAddressDataGridViewTextBoxColumn.DataPropertyName = "AccountAddress";
            this.accountAddressDataGridViewTextBoxColumn.HeaderText = "AccountAddress";
            this.accountAddressDataGridViewTextBoxColumn.Name = "accountAddressDataGridViewTextBoxColumn";
            this.accountAddressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // accountNumDataGridViewTextBoxColumn
            // 
            this.accountNumDataGridViewTextBoxColumn.DataPropertyName = "AccountNum";
            this.accountNumDataGridViewTextBoxColumn.HeaderText = "AccountNum";
            this.accountNumDataGridViewTextBoxColumn.Name = "accountNumDataGridViewTextBoxColumn";
            this.accountNumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bankIDDataGridViewTextBoxColumn
            // 
            this.bankIDDataGridViewTextBoxColumn.DataPropertyName = "BankID";
            this.bankIDDataGridViewTextBoxColumn.HeaderText = "BankID";
            this.bankIDDataGridViewTextBoxColumn.Name = "bankIDDataGridViewTextBoxColumn";
            this.bankIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // accountRoutingNumDataGridViewTextBoxColumn
            // 
            this.accountRoutingNumDataGridViewTextBoxColumn.DataPropertyName = "AccountRoutingNum";
            this.accountRoutingNumDataGridViewTextBoxColumn.HeaderText = "AccountRoutingNum";
            this.accountRoutingNumDataGridViewTextBoxColumn.Name = "accountRoutingNumDataGridViewTextBoxColumn";
            this.accountRoutingNumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // accountBindingSource2
            // 
            this.accountBindingSource2.DataMember = "Account";
            this.accountBindingSource2.DataSource = this.teamPenguinDataSet;
            // 
            // teamPenguinDataSet
            // 
            this.teamPenguinDataSet.DataSetName = "TeamPenguinDataSet";
            this.teamPenguinDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(781, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updatePasswordToolStripMenuItem,
            this.supervisorToolStripMenuItem,
            this.updateToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // updatePasswordToolStripMenuItem
            // 
            this.updatePasswordToolStripMenuItem.Name = "updatePasswordToolStripMenuItem";
            this.updatePasswordToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.updatePasswordToolStripMenuItem.Text = "Update Password";
            this.updatePasswordToolStripMenuItem.Click += new System.EventHandler(this.updatePasswordToolStripMenuItem_Click);
            // 
            // supervisorToolStripMenuItem
            // 
            this.supervisorToolStripMenuItem.Name = "supervisorToolStripMenuItem";
            this.supervisorToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.supervisorToolStripMenuItem.Text = "Supervisor";
            this.supervisorToolStripMenuItem.Click += new System.EventHandler(this.supervisorToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.updateToolStripMenuItem.Text = "Update";
            // 
            // accountBindingSource1
            // 
            this.accountBindingSource1.DataMember = "Account";
            this.accountBindingSource1.DataSource = this.teamPenguinDataSet;
            // 
            // accountBindingSource
            // 
            this.accountBindingSource.DataMember = "Account";
            this.accountBindingSource.DataSource = this.teamPenguinDataSet;
            // 
            // accountTableAdapter
            // 
            this.accountTableAdapter.ClearBeforeFill = true;
            // 
            // mainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 515);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainMenu";
            this.Text = "s";
            this.Load += new System.EventHandler(this.mainMenu_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamPenguinDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

            #endregion

            private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
            private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
            private System.Windows.Forms.Button button5;
            private System.Windows.Forms.Button updateBtn;
            private System.Windows.Forms.Button createBtn;
            private System.Windows.Forms.Button refreshBtn;
            private System.Windows.Forms.DataGridView dataGridView1;
            private System.Windows.Forms.Button PayCheckBtn;
            private System.Windows.Forms.Button CreateCheckBtn;
            private System.Windows.Forms.Button GenerateLettersBtn;
            private TeamPenguinDataSet teamPenguinDataSet;
            private System.Windows.Forms.BindingSource accountBindingSource;
            private TeamPenguinDataSetTableAdapters.AccountTableAdapter accountTableAdapter;
            private System.Windows.Forms.BindingSource accountBindingSource1;
            private System.Windows.Forms.DataGridViewTextBoxColumn accountIDDataGridViewTextBoxColumn;
            private System.Windows.Forms.DataGridViewTextBoxColumn accountLastNameDataGridViewTextBoxColumn;
            private System.Windows.Forms.DataGridViewTextBoxColumn accountPhoneNumDataGridViewTextBoxColumn;
            private System.Windows.Forms.DataGridViewTextBoxColumn accountAddressDataGridViewTextBoxColumn;
            private System.Windows.Forms.DataGridViewTextBoxColumn accountNumDataGridViewTextBoxColumn;
            private System.Windows.Forms.DataGridViewTextBoxColumn bankIDDataGridViewTextBoxColumn;
            private System.Windows.Forms.DataGridViewTextBoxColumn accountRoutingNumDataGridViewTextBoxColumn;
            private System.Windows.Forms.MenuStrip menuStrip1;
            private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
            private System.Windows.Forms.ToolStripMenuItem updatePasswordToolStripMenuItem;
            private System.Windows.Forms.ToolStripMenuItem supervisorToolStripMenuItem;
            private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
            private System.Windows.Forms.BindingSource accountBindingSource2;
        }
    }

}