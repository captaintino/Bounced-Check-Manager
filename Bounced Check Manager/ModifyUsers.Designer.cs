namespace Bounced_Check_Manager
{
    namespace Bounced_Check_Manager_UI_Layer
    {
        partial class ModifyUsers
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
                this.splitContainer1 = new System.Windows.Forms.SplitContainer();
                this.UsersDataGridView = new System.Windows.Forms.DataGridView();
                this.uid = new System.Windows.Forms.DataGridViewTextBoxColumn();
                this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
                this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
                this.createdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
                this.updatedate = new System.Windows.Forms.DataGridViewTextBoxColumn();
                this.accdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
                this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
                this.ChangePasswordBtn = new System.Windows.Forms.Button();
                this.DeleteBtn = new System.Windows.Forms.Button();
                this.button3 = new System.Windows.Forms.Button();
                this.button4 = new System.Windows.Forms.Button();
                ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
                this.splitContainer1.Panel1.SuspendLayout();
                this.splitContainer1.Panel2.SuspendLayout();
                this.splitContainer1.SuspendLayout();
                ((System.ComponentModel.ISupportInitialize)(this.UsersDataGridView)).BeginInit();
                this.tableLayoutPanel1.SuspendLayout();
                this.SuspendLayout();
                // 
                // splitContainer1
                // 
                this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
                this.splitContainer1.Location = new System.Drawing.Point(0, 0);
                this.splitContainer1.Name = "splitContainer1";
                this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
                // 
                // splitContainer1.Panel1
                // 
                this.splitContainer1.Panel1.Controls.Add(this.UsersDataGridView);
                // 
                // splitContainer1.Panel2
                // 
                this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
                this.splitContainer1.Size = new System.Drawing.Size(670, 496);
                this.splitContainer1.SplitterDistance = 288;
                this.splitContainer1.TabIndex = 0;
                // 
                // UsersDataGridView
                // 
                this.UsersDataGridView.AllowUserToAddRows = false;
                this.UsersDataGridView.AllowUserToDeleteRows = false;
                this.UsersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                this.UsersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uid,
            this.status,
            this.name,
            this.createdate,
            this.updatedate,
            this.accdate});
                this.UsersDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
                this.UsersDataGridView.Location = new System.Drawing.Point(0, 0);
                this.UsersDataGridView.MultiSelect = false;
                this.UsersDataGridView.Name = "UsersDataGridView";
                this.UsersDataGridView.ReadOnly = true;
                this.UsersDataGridView.Size = new System.Drawing.Size(670, 288);
                this.UsersDataGridView.TabIndex = 1;
                // 
                // uid
                // 
                this.uid.HeaderText = "uid";
                this.uid.Name = "uid";
                this.uid.ReadOnly = true;
                // 
                // status
                // 
                this.status.HeaderText = "status";
                this.status.Name = "status";
                this.status.ReadOnly = true;
                // 
                // name
                // 
                this.name.HeaderText = "name";
                this.name.Name = "name";
                this.name.ReadOnly = true;
                // 
                // createdate
                // 
                this.createdate.HeaderText = "createdate";
                this.createdate.Name = "createdate";
                this.createdate.ReadOnly = true;
                this.createdate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
                this.createdate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
                // 
                // updatedate
                // 
                this.updatedate.HeaderText = "updatedate";
                this.updatedate.Name = "updatedate";
                this.updatedate.ReadOnly = true;
                this.updatedate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
                this.updatedate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
                // 
                // accdate
                // 
                this.accdate.HeaderText = "accdate";
                this.accdate.Name = "accdate";
                this.accdate.ReadOnly = true;
                // 
                // tableLayoutPanel1
                // 
                this.tableLayoutPanel1.ColumnCount = 2;
                this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
                this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
                this.tableLayoutPanel1.Controls.Add(this.button4, 1, 1);
                this.tableLayoutPanel1.Controls.Add(this.button3, 0, 1);
                this.tableLayoutPanel1.Controls.Add(this.DeleteBtn, 1, 0);
                this.tableLayoutPanel1.Controls.Add(this.ChangePasswordBtn, 0, 0);
                this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
                this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
                this.tableLayoutPanel1.Name = "tableLayoutPanel1";
                this.tableLayoutPanel1.RowCount = 2;
                this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
                this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
                this.tableLayoutPanel1.Size = new System.Drawing.Size(670, 204);
                this.tableLayoutPanel1.TabIndex = 0;
                // 
                // ChangePasswordBtn
                // 
                this.ChangePasswordBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
                this.ChangePasswordBtn.Location = new System.Drawing.Point(107, 39);
                this.ChangePasswordBtn.Name = "ChangePasswordBtn";
                this.ChangePasswordBtn.Size = new System.Drawing.Size(120, 23);
                this.ChangePasswordBtn.TabIndex = 0;
                this.ChangePasswordBtn.Text = "Change Password";
                this.ChangePasswordBtn.UseVisualStyleBackColor = true;
                // 
                // DeleteBtn
                // 
                this.DeleteBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
                this.DeleteBtn.Location = new System.Drawing.Point(465, 39);
                this.DeleteBtn.Name = "DeleteBtn";
                this.DeleteBtn.Size = new System.Drawing.Size(75, 23);
                this.DeleteBtn.TabIndex = 1;
                this.DeleteBtn.Text = "Delete";
                this.DeleteBtn.UseVisualStyleBackColor = true;
                this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
                // 
                // button3
                // 
                this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
                this.button3.Location = new System.Drawing.Point(130, 141);
                this.button3.Name = "button3";
                this.button3.Size = new System.Drawing.Size(75, 23);
                this.button3.TabIndex = 2;
                this.button3.Text = "button3";
                this.button3.UseVisualStyleBackColor = true;
                // 
                // button4
                // 
                this.button4.Anchor = System.Windows.Forms.AnchorStyles.None;
                this.button4.Location = new System.Drawing.Point(465, 141);
                this.button4.Name = "button4";
                this.button4.Size = new System.Drawing.Size(75, 23);
                this.button4.TabIndex = 3;
                this.button4.Text = "button4";
                this.button4.UseVisualStyleBackColor = true;
                // 
                // ModifyUsers
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.ClientSize = new System.Drawing.Size(670, 496);
                this.Controls.Add(this.splitContainer1);
                this.Name = "ModifyUsers";
                this.Text = "ModifyUsers";
                this.splitContainer1.Panel1.ResumeLayout(false);
                this.splitContainer1.Panel2.ResumeLayout(false);
                ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
                this.splitContainer1.ResumeLayout(false);
                ((System.ComponentModel.ISupportInitialize)(this.UsersDataGridView)).EndInit();
                this.tableLayoutPanel1.ResumeLayout(false);
                this.ResumeLayout(false);

            }

            #endregion

            private System.Windows.Forms.SplitContainer splitContainer1;
            private System.Windows.Forms.DataGridView UsersDataGridView;
            private System.Windows.Forms.DataGridViewTextBoxColumn uid;
            private System.Windows.Forms.DataGridViewTextBoxColumn status;
            private System.Windows.Forms.DataGridViewTextBoxColumn name;
            private System.Windows.Forms.DataGridViewTextBoxColumn createdate;
            private System.Windows.Forms.DataGridViewTextBoxColumn updatedate;
            private System.Windows.Forms.DataGridViewTextBoxColumn accdate;
            private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
            private System.Windows.Forms.Button button4;
            private System.Windows.Forms.Button button3;
            private System.Windows.Forms.Button DeleteBtn;
            private System.Windows.Forms.Button ChangePasswordBtn;

        }
    }
}