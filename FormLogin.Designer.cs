namespace LatihanGithub
{
    partial class FormLogin
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
            this.lbluser = new System.Windows.Forms.Label();
            this.lblpass = new System.Windows.Forms.Label();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.Location = new System.Drawing.Point(113, 140);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(110, 25);
            this.lbluser.TabIndex = 0;
            this.lbluser.Text = "Username";
            this.lbluser.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.Location = new System.Drawing.Point(113, 221);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(106, 25);
            this.lblpass.TabIndex = 1;
            this.lblpass.Text = "Password";
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(282, 140);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(401, 31);
            this.txtuser.TabIndex = 2;
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(282, 215);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(401, 31);
            this.txtpass.TabIndex = 3;
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(282, 298);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(142, 53);
            this.btnlogin.TabIndex = 4;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = true;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 693);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.lblpass);
            this.Controls.Add(this.lbluser);
            this.Name = "FormLogin";
            this.Text = "FormLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.Label lblpass;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Button btnlogin;
    }
}

