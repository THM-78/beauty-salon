namespace beauty_salon_project
{
    partial class login
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
            this.userNameTxtBx = new System.Windows.Forms.TextBox();
            this.userNameLb = new System.Windows.Forms.Label();
            this.exitPic = new System.Windows.Forms.PictureBox();
            this.passwordTxtBx = new System.Windows.Forms.TextBox();
            this.passLb = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.exitPic)).BeginInit();
            this.SuspendLayout();
            // 
            // userNameTxtBx
            // 
            this.userNameTxtBx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(177)))), ((int)(((byte)(215)))));
            this.userNameTxtBx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userNameTxtBx.ForeColor = System.Drawing.Color.White;
            this.userNameTxtBx.Location = new System.Drawing.Point(569, 147);
            this.userNameTxtBx.Multiline = true;
            this.userNameTxtBx.Name = "userNameTxtBx";
            this.userNameTxtBx.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.userNameTxtBx.Size = new System.Drawing.Size(100, 17);
            this.userNameTxtBx.TabIndex = 6;
            this.userNameTxtBx.Visible = false;
            this.userNameTxtBx.KeyDown += new System.Windows.Forms.KeyEventHandler(this.userNameTxtBx_KeyDown);
            this.userNameTxtBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.userNameTxtBx_KeyPress);
            // 
            // userNameLb
            // 
            this.userNameLb.BackColor = System.Drawing.Color.Transparent;
            this.userNameLb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userNameLb.Location = new System.Drawing.Point(489, 137);
            this.userNameLb.Name = "userNameLb";
            this.userNameLb.Size = new System.Drawing.Size(212, 34);
            this.userNameLb.TabIndex = 7;
            this.userNameLb.Click += new System.EventHandler(this.userNameLb_Click);
            // 
            // exitPic
            // 
            this.exitPic.AccessibleDescription = "خروج";
            this.exitPic.BackgroundImage = global::beauty_salon_project.Properties.Resources.cancel_ico;
            this.exitPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitPic.Location = new System.Drawing.Point(12, 365);
            this.exitPic.Name = "exitPic";
            this.exitPic.Size = new System.Drawing.Size(50, 50);
            this.exitPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exitPic.TabIndex = 8;
            this.exitPic.TabStop = false;
            this.exitPic.Click += new System.EventHandler(this.exitPic_Click);
            this.exitPic.MouseLeave += new System.EventHandler(this.exitPic_MouseLeave);
            this.exitPic.MouseHover += new System.EventHandler(this.exitPic_MouseHover);
            // 
            // passwordTxtBx
            // 
            this.passwordTxtBx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(177)))), ((int)(((byte)(215)))));
            this.passwordTxtBx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTxtBx.ForeColor = System.Drawing.Color.White;
            this.passwordTxtBx.Location = new System.Drawing.Point(569, 194);
            this.passwordTxtBx.Name = "passwordTxtBx";
            this.passwordTxtBx.PasswordChar = '*';
            this.passwordTxtBx.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.passwordTxtBx.Size = new System.Drawing.Size(100, 13);
            this.passwordTxtBx.TabIndex = 9;
            this.passwordTxtBx.Visible = false;
            // 
            // passLb
            // 
            this.passLb.BackColor = System.Drawing.Color.Transparent;
            this.passLb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passLb.Location = new System.Drawing.Point(489, 183);
            this.passLb.Name = "passLb";
            this.passLb.Size = new System.Drawing.Size(212, 34);
            this.passLb.TabIndex = 10;
            this.passLb.Click += new System.EventHandler(this.passLb_Click);
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.Transparent;
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBtn.Location = new System.Drawing.Point(485, 238);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(221, 42);
            this.loginBtn.TabIndex = 11;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::beauty_salon_project.Properties.Resources.loginBg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(741, 427);
            this.ControlBox = false;
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.passwordTxtBx);
            this.Controls.Add(this.passLb);
            this.Controls.Add(this.exitPic);
            this.Controls.Add(this.userNameTxtBx);
            this.Controls.Add(this.userNameLb);
            this.Name = "login";
            this.Text = "فرم ورود";
            this.Load += new System.EventHandler(this.login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.exitPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userNameTxtBx;
        private System.Windows.Forms.Label userNameLb;
        private System.Windows.Forms.PictureBox exitPic;
        private System.Windows.Forms.TextBox passwordTxtBx;
        private System.Windows.Forms.Label passLb;
        private System.Windows.Forms.Label loginBtn;
    }
}