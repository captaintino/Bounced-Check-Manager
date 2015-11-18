namespace Bounced_Check_Manager
{
    namespace Bounced_Check_Manager_UI_Layer
    {
        partial class SelectAccount
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
            this.SelectBtn = new System.Windows.Forms.Button();
            this.SelectAccountCmb = new System.Windows.Forms.ComboBox();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SelectBtn
            // 
            this.SelectBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SelectBtn.Location = new System.Drawing.Point(264, 67);
            this.SelectBtn.Name = "SelectBtn";
            this.SelectBtn.Size = new System.Drawing.Size(102, 23);
            this.SelectBtn.TabIndex = 8;
            this.SelectBtn.Text = "Select";
            this.SelectBtn.UseVisualStyleBackColor = true;
            this.SelectBtn.Click += new System.EventHandler(this.SelectBtn_Click);
            // 
            // SelectAccountCmb
            // 
            this.SelectAccountCmb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SelectAccountCmb.DisplayMember = "StoreNum";
            this.SelectAccountCmb.DropDownWidth = 350;
            this.SelectAccountCmb.FormattingEnabled = true;
            this.SelectAccountCmb.Location = new System.Drawing.Point(12, 12);
            this.SelectAccountCmb.Name = "SelectAccountCmb";
            this.SelectAccountCmb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SelectAccountCmb.Size = new System.Drawing.Size(399, 21);
            this.SelectAccountCmb.TabIndex = 23;
            // 
            // CancelBtn
            // 
            this.CancelBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CancelBtn.Location = new System.Drawing.Point(56, 67);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(102, 23);
            this.CancelBtn.TabIndex = 24;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // SelectAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 116);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.SelectAccountCmb);
            this.Controls.Add(this.SelectBtn);
            this.MinimumSize = new System.Drawing.Size(250, 154);
            this.Name = "SelectAccount";
            this.Text = "SelectAccount";
            this.ResumeLayout(false);

            }

            #endregion

            private System.Windows.Forms.Button SelectBtn;
            private System.Windows.Forms.ComboBox SelectAccountCmb;
            private System.Windows.Forms.Button CancelBtn;
        }
    }
}