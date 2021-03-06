﻿namespace Bounced_Check_Manager
{
    namespace Bounced_Check_Manager_UI_Layer
    {
        partial class Supervisor
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.ModifyBankBtn = new System.Windows.Forms.Button();
            this.StoreBtn = new System.Windows.Forms.Button();
            this.ModifyUsersBtn = new System.Windows.Forms.Button();
            this.AddUserBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.ResetBtn, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.ModifyBankBtn, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.StoreBtn, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.ModifyUsersBtn, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.AddUserBtn, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(284, 262);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ResetBtn
            // 
            this.ResetBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ResetBtn.Location = new System.Drawing.Point(67, 223);
            this.ResetBtn.MinimumSize = new System.Drawing.Size(150, 0);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(150, 23);
            this.ResetBtn.TabIndex = 4;
            this.ResetBtn.Text = "RESET! NUKE DATABASE";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // ModifyBankBtn
            // 
            this.ModifyBankBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ModifyBankBtn.Location = new System.Drawing.Point(67, 170);
            this.ModifyBankBtn.MinimumSize = new System.Drawing.Size(150, 0);
            this.ModifyBankBtn.Name = "ModifyBankBtn";
            this.ModifyBankBtn.Size = new System.Drawing.Size(150, 23);
            this.ModifyBankBtn.TabIndex = 3;
            this.ModifyBankBtn.Text = "Modify Banks";
            this.ModifyBankBtn.UseVisualStyleBackColor = true;
            this.ModifyBankBtn.Click += new System.EventHandler(this.ModifyBankBtn_Click);
            // 
            // StoreBtn
            // 
            this.StoreBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StoreBtn.Location = new System.Drawing.Point(67, 118);
            this.StoreBtn.MinimumSize = new System.Drawing.Size(150, 0);
            this.StoreBtn.Name = "StoreBtn";
            this.StoreBtn.Size = new System.Drawing.Size(150, 23);
            this.StoreBtn.TabIndex = 2;
            this.StoreBtn.Text = "Modify Stores";
            this.StoreBtn.UseVisualStyleBackColor = true;
            this.StoreBtn.Click += new System.EventHandler(this.StoreBtn_Click);
            // 
            // ModifyUsersBtn
            // 
            this.ModifyUsersBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ModifyUsersBtn.Location = new System.Drawing.Point(67, 66);
            this.ModifyUsersBtn.MinimumSize = new System.Drawing.Size(150, 0);
            this.ModifyUsersBtn.Name = "ModifyUsersBtn";
            this.ModifyUsersBtn.Size = new System.Drawing.Size(150, 23);
            this.ModifyUsersBtn.TabIndex = 1;
            this.ModifyUsersBtn.Text = "Modify Users";
            this.ModifyUsersBtn.UseVisualStyleBackColor = true;
            this.ModifyUsersBtn.Click += new System.EventHandler(this.ModifyUsersBtn_Click);
            // 
            // AddUserBtn
            // 
            this.AddUserBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddUserBtn.Location = new System.Drawing.Point(67, 14);
            this.AddUserBtn.MinimumSize = new System.Drawing.Size(150, 0);
            this.AddUserBtn.Name = "AddUserBtn";
            this.AddUserBtn.Size = new System.Drawing.Size(150, 23);
            this.AddUserBtn.TabIndex = 0;
            this.AddUserBtn.Text = "Add User";
            this.AddUserBtn.UseVisualStyleBackColor = true;
            this.AddUserBtn.Click += new System.EventHandler(this.AddUserBtn_Click);
            // 
            // Supervisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Supervisor";
            this.Text = "Supervisor";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

            }

            #endregion

            private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
            private System.Windows.Forms.Button ResetBtn;
            private System.Windows.Forms.Button ModifyBankBtn;
            private System.Windows.Forms.Button StoreBtn;
            private System.Windows.Forms.Button ModifyUsersBtn;
            private System.Windows.Forms.Button AddUserBtn;
        }
    }
}