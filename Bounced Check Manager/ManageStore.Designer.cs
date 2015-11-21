namespace Bounced_Check_Manager
{
    partial class ManageStore
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
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.ModifyStoreBtn = new System.Windows.Forms.Button();
            this.CreateStoreBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.storeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storeNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storeAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storeServiceChargeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teamPenguinDataSet = new Bounced_Check_Manager.TeamPenguinDataSet();
            this.storeTableAdapter = new Bounced_Check_Manager.TeamPenguinDataSetTableAdapters.StoreTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamPenguinDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(690, 270);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.RefreshBtn, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.ModifyStoreBtn, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.CreateStoreBtn, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(124, 264);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RefreshBtn.Location = new System.Drawing.Point(24, 32);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(75, 23);
            this.RefreshBtn.TabIndex = 3;
            this.RefreshBtn.Text = "Refresh";
            this.RefreshBtn.UseVisualStyleBackColor = true;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // ModifyStoreBtn
            // 
            this.ModifyStoreBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ModifyStoreBtn.Location = new System.Drawing.Point(24, 208);
            this.ModifyStoreBtn.Name = "ModifyStoreBtn";
            this.ModifyStoreBtn.Size = new System.Drawing.Size(75, 23);
            this.ModifyStoreBtn.TabIndex = 1;
            this.ModifyStoreBtn.Text = "Modify Store";
            this.ModifyStoreBtn.UseVisualStyleBackColor = true;
            this.ModifyStoreBtn.Click += new System.EventHandler(this.ModifyStoreBtn_Click);
            // 
            // CreateStoreBtn
            // 
            this.CreateStoreBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CreateStoreBtn.Location = new System.Drawing.Point(24, 120);
            this.CreateStoreBtn.Name = "CreateStoreBtn";
            this.CreateStoreBtn.Size = new System.Drawing.Size(75, 23);
            this.CreateStoreBtn.TabIndex = 0;
            this.CreateStoreBtn.Text = "Create Store";
            this.CreateStoreBtn.UseVisualStyleBackColor = true;
            this.CreateStoreBtn.Click += new System.EventHandler(this.CreateStoreBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.storeIDDataGridViewTextBoxColumn,
            this.storeNumDataGridViewTextBoxColumn,
            this.storeNameDataGridViewTextBoxColumn,
            this.storeAddressDataGridViewTextBoxColumn,
            this.storeServiceChargeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.storeBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(133, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(554, 264);
            this.dataGridView1.TabIndex = 1;
            // 
            // storeIDDataGridViewTextBoxColumn
            // 
            this.storeIDDataGridViewTextBoxColumn.DataPropertyName = "StoreID";
            this.storeIDDataGridViewTextBoxColumn.HeaderText = "StoreID";
            this.storeIDDataGridViewTextBoxColumn.Name = "storeIDDataGridViewTextBoxColumn";
            this.storeIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // storeNumDataGridViewTextBoxColumn
            // 
            this.storeNumDataGridViewTextBoxColumn.DataPropertyName = "StoreNum";
            this.storeNumDataGridViewTextBoxColumn.HeaderText = "StoreNum";
            this.storeNumDataGridViewTextBoxColumn.Name = "storeNumDataGridViewTextBoxColumn";
            this.storeNumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // storeNameDataGridViewTextBoxColumn
            // 
            this.storeNameDataGridViewTextBoxColumn.DataPropertyName = "StoreName";
            this.storeNameDataGridViewTextBoxColumn.HeaderText = "StoreName";
            this.storeNameDataGridViewTextBoxColumn.Name = "storeNameDataGridViewTextBoxColumn";
            this.storeNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // storeAddressDataGridViewTextBoxColumn
            // 
            this.storeAddressDataGridViewTextBoxColumn.DataPropertyName = "StoreAddress";
            this.storeAddressDataGridViewTextBoxColumn.HeaderText = "StoreAddress";
            this.storeAddressDataGridViewTextBoxColumn.Name = "storeAddressDataGridViewTextBoxColumn";
            this.storeAddressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // storeServiceChargeDataGridViewTextBoxColumn
            // 
            this.storeServiceChargeDataGridViewTextBoxColumn.DataPropertyName = "StoreServiceCharge";
            this.storeServiceChargeDataGridViewTextBoxColumn.HeaderText = "StoreServiceCharge";
            this.storeServiceChargeDataGridViewTextBoxColumn.Name = "storeServiceChargeDataGridViewTextBoxColumn";
            this.storeServiceChargeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // storeBindingSource
            // 
            this.storeBindingSource.DataMember = "Store";
            this.storeBindingSource.DataSource = this.teamPenguinDataSet;
            // 
            // teamPenguinDataSet
            // 
            this.teamPenguinDataSet.DataSetName = "TeamPenguinDataSet";
            this.teamPenguinDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // storeTableAdapter
            // 
            this.storeTableAdapter.ClearBeforeFill = true;
            // 
            // ManageStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 270);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ManageStore";
            this.Text = "ManageStore";
            this.Load += new System.EventHandler(this.ManageStore_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamPenguinDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button ModifyStoreBtn;
        private System.Windows.Forms.Button CreateStoreBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private TeamPenguinDataSet teamPenguinDataSet;
        private System.Windows.Forms.BindingSource storeBindingSource;
        private TeamPenguinDataSetTableAdapters.StoreTableAdapter storeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn storeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn storeNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn storeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn storeAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn storeServiceChargeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button RefreshBtn;
    }
}