namespace Bounced_Check_Manager
{
    namespace Bounced_Check_Manager_UI_Layer
    {
        partial class CreateUser
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
                this.label1 = new System.Windows.Forms.Label();
                this.label2 = new System.Windows.Forms.Label();
                this.label3 = new System.Windows.Forms.Label();
                this.CancelBtn = new System.Windows.Forms.Button();
                this.SubmitBtn = new System.Windows.Forms.Button();
                this.UsernameTxtBox = new System.Windows.Forms.TextBox();
                this.PasswordTxtBox = new System.Windows.Forms.TextBox();
                this.RoleComboBox = new System.Windows.Forms.ComboBox();
                this.tableLayoutPanel1.SuspendLayout();
                this.SuspendLayout();
                // 
                // tableLayoutPanel1
                // 
                this.tableLayoutPanel1.ColumnCount = 2;
                this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
                this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
                this.tableLayoutPanel1.Controls.Add(this.PasswordTxtBox, 1, 1);
                this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
                this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
                this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
                this.tableLayoutPanel1.Controls.Add(this.CancelBtn, 0, 3);
                this.tableLayoutPanel1.Controls.Add(this.SubmitBtn, 1, 3);
                this.tableLayoutPanel1.Controls.Add(this.UsernameTxtBox, 1, 0);
                this.tableLayoutPanel1.Controls.Add(this.RoleComboBox, 1, 2);
                this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
                this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
                this.tableLayoutPanel1.Name = "tableLayoutPanel1";
                this.tableLayoutPanel1.RowCount = 4;
                this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
                this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
                this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
                this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
                this.tableLayoutPanel1.Size = new System.Drawing.Size(333, 270);
                this.tableLayoutPanel1.TabIndex = 0;
                // 
                // label1
                // 
                this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
                this.label1.AutoSize = true;
                this.label1.Location = new System.Drawing.Point(108, 27);
                this.label1.Name = "label1";
                this.label1.Size = new System.Drawing.Size(55, 13);
                this.label1.TabIndex = 0;
                this.label1.Text = "Username";
                // 
                // label2
                // 
                this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
                this.label2.AutoSize = true;
                this.label2.Location = new System.Drawing.Point(110, 94);
                this.label2.Name = "label2";
                this.label2.Size = new System.Drawing.Size(53, 13);
                this.label2.TabIndex = 1;
                this.label2.Text = "Password";
                // 
                // label3
                // 
                this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
                this.label3.AutoSize = true;
                this.label3.Location = new System.Drawing.Point(93, 161);
                this.label3.Name = "label3";
                this.label3.Size = new System.Drawing.Size(70, 13);
                this.label3.TabIndex = 2;
                this.label3.Text = "Prvilige Level";
                // 
                // CancelBtn
                // 
                this.CancelBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
                this.CancelBtn.Location = new System.Drawing.Point(45, 224);
                this.CancelBtn.Name = "CancelBtn";
                this.CancelBtn.Size = new System.Drawing.Size(75, 23);
                this.CancelBtn.TabIndex = 3;
                this.CancelBtn.Text = "Cancel";
                this.CancelBtn.UseVisualStyleBackColor = true;
                this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
                // 
                // SubmitBtn
                // 
                this.SubmitBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
                this.SubmitBtn.Location = new System.Drawing.Point(212, 224);
                this.SubmitBtn.Name = "SubmitBtn";
                this.SubmitBtn.Size = new System.Drawing.Size(75, 23);
                this.SubmitBtn.TabIndex = 4;
                this.SubmitBtn.Text = "Submit";
                this.SubmitBtn.UseVisualStyleBackColor = true;
                this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
                // 
                // UsernameTxtBox
                // 
                this.UsernameTxtBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
                this.UsernameTxtBox.Location = new System.Drawing.Point(169, 23);
                this.UsernameTxtBox.Name = "UsernameTxtBox";
                this.UsernameTxtBox.Size = new System.Drawing.Size(100, 20);
                this.UsernameTxtBox.TabIndex = 5;
                // 
                // PasswordTxtBox
                // 
                this.PasswordTxtBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
                this.PasswordTxtBox.Location = new System.Drawing.Point(169, 90);
                this.PasswordTxtBox.Name = "PasswordTxtBox";
                this.PasswordTxtBox.Size = new System.Drawing.Size(100, 20);
                this.PasswordTxtBox.TabIndex = 6;
                // 
                // RoleComboBox
                // 
                this.RoleComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
                this.RoleComboBox.FormattingEnabled = true;
                this.RoleComboBox.Items.AddRange(new object[] {
            "Clerk",
            "Supervisor"});
                this.RoleComboBox.Location = new System.Drawing.Point(169, 157);
                this.RoleComboBox.Name = "RoleComboBox";
                this.RoleComboBox.Size = new System.Drawing.Size(121, 21);
                this.RoleComboBox.TabIndex = 7;
                // 
                // CreateUser
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.ClientSize = new System.Drawing.Size(333, 270);
                this.Controls.Add(this.tableLayoutPanel1);
                this.Name = "CreateUser";
                this.Text = "CreateUser";
                this.tableLayoutPanel1.ResumeLayout(false);
                this.tableLayoutPanel1.PerformLayout();
                this.ResumeLayout(false);

            }

            #endregion

            private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
            private System.Windows.Forms.TextBox PasswordTxtBox;
            private System.Windows.Forms.Label label1;
            private System.Windows.Forms.Label label2;
            private System.Windows.Forms.Label label3;
            private System.Windows.Forms.Button CancelBtn;
            private System.Windows.Forms.Button SubmitBtn;
            private System.Windows.Forms.TextBox UsernameTxtBox;
            private System.Windows.Forms.ComboBox RoleComboBox;
        }
    }
}