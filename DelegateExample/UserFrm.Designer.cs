namespace DelegateExample
{
    partial class UserFrm
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
            this.txtUser = new System.Windows.Forms.TextBox();
            this.btnValidate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "User :";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(26, 67);
            this.txtUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(366, 40);
            this.txtUser.TabIndex = 1;
            this.txtUser.TextChanged += new System.EventHandler(this.txtUser_TextChanged);
            // 
            // btnValidate
            // 
            this.btnValidate.Location = new System.Drawing.Point(254, 115);
            this.btnValidate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(138, 55);
            this.btnValidate.TabIndex = 2;
            this.btnValidate.Text = "Valider";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // UserFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(392, 165);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UserFrm";
            this.Text = "UserFrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Button btnValidate;
    }
}