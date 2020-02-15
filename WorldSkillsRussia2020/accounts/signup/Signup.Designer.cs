namespace WorldSkillsRussia2020.Signup
{
    partial class signUp
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
            this.signUpBtn = new System.Windows.Forms.Button();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.loginField = new System.Windows.Forms.TextBox();
            this.bg_input = new System.Windows.Forms.Panel();
            this.bg_header = new System.Windows.Forms.Panel();
            this.regMsgLb = new System.Windows.Forms.Label();
            this.pass_img = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.signinLabel = new System.Windows.Forms.Label();
            this.signInWinState = new System.Windows.Forms.Label();
            this.xExit = new System.Windows.Forms.Label();
            this.header_text = new System.Windows.Forms.Label();
            this.bg_input.SuspendLayout();
            this.bg_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pass_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // signUpBtn
            // 
            this.signUpBtn.BackColor = System.Drawing.Color.LightGray;
            this.signUpBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signUpBtn.FlatAppearance.BorderColor = System.Drawing.Color.SandyBrown;
            this.signUpBtn.FlatAppearance.BorderSize = 0;
            this.signUpBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.signUpBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.signUpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.signUpBtn.Font = new System.Drawing.Font("Lucida Console", 12F);
            this.signUpBtn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.signUpBtn.Location = new System.Drawing.Point(172, 396);
            this.signUpBtn.Name = "signUpBtn";
            this.signUpBtn.Size = new System.Drawing.Size(272, 48);
            this.signUpBtn.TabIndex = 5;
            this.signUpBtn.Text = "Зарегистрироваться";
            this.signUpBtn.UseVisualStyleBackColor = false;
            // 
            // passwordField
            // 
            this.passwordField.Font = new System.Drawing.Font("Verdana", 14F);
            this.passwordField.Location = new System.Drawing.Point(127, 234);
            this.passwordField.Multiline = true;
            this.passwordField.Name = "passwordField";
            this.passwordField.PasswordChar = '•';
            this.passwordField.Size = new System.Drawing.Size(440, 64);
            this.passwordField.TabIndex = 4;
            // 
            // loginField
            // 
            this.loginField.Font = new System.Drawing.Font("Verdana", 14F);
            this.loginField.Location = new System.Drawing.Point(127, 129);
            this.loginField.Multiline = true;
            this.loginField.Name = "loginField";
            this.loginField.Size = new System.Drawing.Size(440, 64);
            this.loginField.TabIndex = 2;
            // 
            // bg_input
            // 
            this.bg_input.BackColor = System.Drawing.Color.SeaGreen;
            this.bg_input.Controls.Add(this.bg_header);
            this.bg_input.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.bg_input.Location = new System.Drawing.Point(0, 0);
            this.bg_input.MaximumSize = new System.Drawing.Size(600, 500);
            this.bg_input.MinimumSize = new System.Drawing.Size(600, 200);
            this.bg_input.Name = "bg_input";
            this.bg_input.Size = new System.Drawing.Size(600, 500);
            this.bg_input.TabIndex = 1;
            // 
            // bg_header
            // 
            this.bg_header.AutoSize = true;
            this.bg_header.BackColor = System.Drawing.Color.Azure;
            this.bg_header.Controls.Add(this.regMsgLb);
            this.bg_header.Controls.Add(this.pass_img);
            this.bg_header.Controls.Add(this.pictureBox2);
            this.bg_header.Controls.Add(this.signinLabel);
            this.bg_header.Controls.Add(this.signUpBtn);
            this.bg_header.Controls.Add(this.signInWinState);
            this.bg_header.Controls.Add(this.passwordField);
            this.bg_header.Controls.Add(this.xExit);
            this.bg_header.Controls.Add(this.header_text);
            this.bg_header.Controls.Add(this.loginField);
            this.bg_header.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.bg_header.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bg_header.Location = new System.Drawing.Point(0, 0);
            this.bg_header.Name = "bg_header";
            this.bg_header.Size = new System.Drawing.Size(600, 500);
            this.bg_header.TabIndex = 0;
            // 
            // regMsgLb
            // 
            this.regMsgLb.BackColor = System.Drawing.Color.Azure;
            this.regMsgLb.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.regMsgLb.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regMsgLb.ForeColor = System.Drawing.Color.MistyRose;
            this.regMsgLb.Location = new System.Drawing.Point(79, 317);
            this.regMsgLb.Name = "regMsgLb";
            this.regMsgLb.Size = new System.Drawing.Size(488, 63);
            this.regMsgLb.TabIndex = 12;
            // 
            // pass_img
            // 
            this.pass_img.BackColor = System.Drawing.Color.Azure;
            this.pass_img.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pass_img.Image = global::WorldSkillsRussia2020.Properties.Resources.iconfinder_lock_1814107;
            this.pass_img.Location = new System.Drawing.Point(33, 234);
            this.pass_img.Name = "pass_img";
            this.pass_img.Size = new System.Drawing.Size(64, 64);
            this.pass_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pass_img.TabIndex = 3;
            this.pass_img.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Azure;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox2.Image = global::WorldSkillsRussia2020.Properties.Resources.icons8_name_100__1_;
            this.pictureBox2.Location = new System.Drawing.Point(33, 129);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // signinLabel
            // 
            this.signinLabel.AutoSize = true;
            this.signinLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signinLabel.Font = new System.Drawing.Font("Lucida Console", 10F);
            this.signinLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.signinLabel.Location = new System.Drawing.Point(211, 456);
            this.signinLabel.Name = "signinLabel";
            this.signinLabel.Size = new System.Drawing.Size(178, 17);
            this.signinLabel.TabIndex = 10;
            this.signinLabel.Text = "Уже есть аккаунт?";
            this.signinLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // signInWinState
            // 
            this.signInWinState.AutoSize = true;
            this.signInWinState.BackColor = System.Drawing.Color.Blue;
            this.signInWinState.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signInWinState.Font = new System.Drawing.Font("Lucida Console", 16F);
            this.signInWinState.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.signInWinState.Location = new System.Drawing.Point(532, 9);
            this.signInWinState.Name = "signInWinState";
            this.signInWinState.Size = new System.Drawing.Size(28, 27);
            this.signInWinState.TabIndex = 11;
            this.signInWinState.Text = "-";
            // 
            // xExit
            // 
            this.xExit.AutoSize = true;
            this.xExit.BackColor = System.Drawing.Color.Blue;
            this.xExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.xExit.Font = new System.Drawing.Font("Lucida Console", 16F);
            this.xExit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.xExit.Location = new System.Drawing.Point(566, 9);
            this.xExit.Name = "xExit";
            this.xExit.Size = new System.Drawing.Size(28, 27);
            this.xExit.TabIndex = 2;
            this.xExit.Text = "x";
            // 
            // header_text
            // 
            this.header_text.BackColor = System.Drawing.Color.MidnightBlue;
            this.header_text.Cursor = System.Windows.Forms.Cursors.Hand;
            this.header_text.Dock = System.Windows.Forms.DockStyle.Top;
            this.header_text.Font = new System.Drawing.Font("Lucida Console", 14F);
            this.header_text.ForeColor = System.Drawing.Color.MistyRose;
            this.header_text.Location = new System.Drawing.Point(0, 0);
            this.header_text.MaximumSize = new System.Drawing.Size(600, 90);
            this.header_text.MinimumSize = new System.Drawing.Size(600, 90);
            this.header_text.Name = "header_text";
            this.header_text.Size = new System.Drawing.Size(600, 90);
            this.header_text.TabIndex = 0;
            this.header_text.Text = "Зарегистрироваться";
            this.header_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // signUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(600, 500);
            this.Controls.Add(this.bg_input);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "signUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Зарегистрироваться";
            this.bg_input.ResumeLayout(false);
            this.bg_input.PerformLayout();
            this.bg_header.ResumeLayout(false);
            this.bg_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pass_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button signUpBtn;
        private System.Windows.Forms.TextBox passwordField;
        private System.Windows.Forms.PictureBox pass_img;
        private System.Windows.Forms.TextBox loginField;
        private System.Windows.Forms.Panel bg_input;
        private System.Windows.Forms.Panel bg_header;
        private System.Windows.Forms.Label header_text;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label signinLabel;
        private System.Windows.Forms.Label xExit;
        private System.Windows.Forms.Label signInWinState;
        private System.Windows.Forms.Label regMsgLb;
    }
}