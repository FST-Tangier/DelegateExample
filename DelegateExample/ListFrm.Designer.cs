namespace DelegateExample
{
    partial class ListFrm
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
            this.label1 = new System.Windows.Forms.Label();
            this.lstUsers = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.currentUser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Liste des users";
            // 
            // lstUsers
            // 
            this.lstUsers.FormattingEnabled = true;
            this.lstUsers.ItemHeight = 33;
            this.lstUsers.Location = new System.Drawing.Point(13, 45);
            this.lstUsers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstUsers.Name = "lstUsers";
            this.lstUsers.Size = new System.Drawing.Size(321, 235);
            this.lstUsers.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 283);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "En cours ...";
            // 
            // currentUser
            // 
            this.currentUser.AutoSize = true;
            this.currentUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.currentUser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.currentUser.Location = new System.Drawing.Point(23, 324);
            this.currentUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.currentUser.Name = "currentUser";
            this.currentUser.Size = new System.Drawing.Size(0, 33);
            this.currentUser.TabIndex = 0;
            // 
            // ListFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(359, 361);
            this.Controls.Add(this.lstUsers);
            this.Controls.Add(this.currentUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ListFrm";
            this.Text = "ListFrm";
            this.Load += new System.EventHandler(this.ListFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstUsers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label currentUser;
    }
}