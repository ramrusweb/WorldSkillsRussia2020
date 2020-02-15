namespace WorldSkillsRussia2020.handlers
{
    partial class ChangePass
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
            this.bg_input = new System.Windows.Forms.Panel();
            this.confPass = new System.Windows.Forms.TextBox();
            this.changePassBtn = new System.Windows.Forms.Button();
            this.descAttempt = new System.Windows.Forms.Label();
            this.newPass = new System.Windows.Forms.TextBox();
            this.oldPass = new System.Windows.Forms.TextBox();
            this.bg_header = new System.Windows.Forms.Panel();
            this.signInWinState = new System.Windows.Forms.Label();
            this.xExit = new System.Windows.Forms.Label();
            this.header_text = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pass_img = new System.Windows.Forms.PictureBox();
            this.bg_input.SuspendLayout();
            this.bg_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pass_img)).BeginInit();
            this.SuspendLayout();
            // 
            // bg_input
            // 
            this.bg_input.BackColor = System.Drawing.Color.Azure;
            this.bg_input.Controls.Add(this.pictureBox1);
            this.bg_input.Controls.Add(this.confPass);
            this.bg_input.Controls.Add(this.changePassBtn);
            this.bg_input.Controls.Add(this.descAttempt);
            this.bg_input.Controls.Add(this.pictureBox2);
            this.bg_input.Controls.Add(this.newPass);
            this.bg_input.Controls.Add(this.pass_img);
            this.bg_input.Controls.Add(this.oldPass);
            this.bg_input.Controls.Add(this.bg_header);
            this.bg_input.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.bg_input.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bg_input.Location = new System.Drawing.Point(0, 0);
            this.bg_input.Name = "bg_input";
            this.bg_input.Size = new System.Drawing.Size(600, 500);
            this.bg_input.TabIndex = 1;
            // 
            // confPass
            // 
            this.confPass.Font = new System.Drawing.Font("Verdana", 14F);
            this.confPass.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.confPass.Location = new System.Drawing.Point(126, 318);
            this.confPass.Multiline = true;
            this.confPass.Name = "confPass";
            this.confPass.Size = new System.Drawing.Size(399, 64);
            this.confPass.TabIndex = 13;
            this.confPass.UseSystemPasswordChar = true;
            // 
            // changePassBtn
            // 
            this.changePassBtn.BackColor = System.Drawing.Color.LightGray;
            this.changePassBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changePassBtn.FlatAppearance.BorderColor = System.Drawing.Color.SandyBrown;
            this.changePassBtn.FlatAppearance.BorderSize = 0;
            this.changePassBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.changePassBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.changePassBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.changePassBtn.Font = new System.Drawing.Font("Lucida Console", 12F);
            this.changePassBtn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.changePassBtn.Location = new System.Drawing.Point(221, 440);
            this.changePassBtn.Name = "changePassBtn";
            this.changePassBtn.Size = new System.Drawing.Size(159, 48);
            this.changePassBtn.TabIndex = 5;
            this.changePassBtn.Text = "Изменить";
            this.changePassBtn.UseVisualStyleBackColor = false;
            // 
            // descAttempt
            // 
            this.descAttempt.AutoSize = true;
            this.descAttempt.BackColor = System.Drawing.Color.SeaGreen;
            this.descAttempt.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descAttempt.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.descAttempt.Location = new System.Drawing.Point(38, 392);
            this.descAttempt.Name = "descAttempt";
            this.descAttempt.Size = new System.Drawing.Size(0, 25);
            this.descAttempt.TabIndex = 10;
            // 
            // newPass
            // 
            this.newPass.Font = new System.Drawing.Font("Verdana", 14F);
            this.newPass.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.newPass.Location = new System.Drawing.Point(126, 226);
            this.newPass.Multiline = true;
            this.newPass.Name = "newPass";
            this.newPass.Size = new System.Drawing.Size(399, 64);
            this.newPass.TabIndex = 4;
            this.newPass.UseSystemPasswordChar = true;
            // 
            // oldPass
            // 
            this.oldPass.Font = new System.Drawing.Font("Verdana", 14F);
            this.oldPass.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.oldPass.Location = new System.Drawing.Point(126, 127);
            this.oldPass.Multiline = true;
            this.oldPass.Name = "oldPass";
            this.oldPass.Size = new System.Drawing.Size(399, 64);
            this.oldPass.TabIndex = 2;
            // 
            // bg_header
            // 
            this.bg_header.AutoSize = true;
            this.bg_header.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.bg_header.Controls.Add(this.signInWinState);
            this.bg_header.Controls.Add(this.xExit);
            this.bg_header.Controls.Add(this.header_text);
            this.bg_header.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bg_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.bg_header.Location = new System.Drawing.Point(0, 0);
            this.bg_header.Name = "bg_header";
            this.bg_header.Size = new System.Drawing.Size(600, 60);
            this.bg_header.TabIndex = 0;
            // 
            // signInWinState
            // 
            this.signInWinState.AutoSize = true;
            this.signInWinState.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.signInWinState.Font = new System.Drawing.Font("Lucida Console", 16F);
            this.signInWinState.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.signInWinState.Location = new System.Drawing.Point(526, 9);
            this.signInWinState.Name = "signInWinState";
            this.signInWinState.Size = new System.Drawing.Size(28, 27);
            this.signInWinState.TabIndex = 2;
            this.signInWinState.Text = "-";
            // 
            // xExit
            // 
            this.xExit.AutoSize = true;
            this.xExit.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.xExit.Font = new System.Drawing.Font("Lucida Console", 16F);
            this.xExit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.xExit.Location = new System.Drawing.Point(560, 9);
            this.xExit.Name = "xExit";
            this.xExit.Size = new System.Drawing.Size(28, 27);
            this.xExit.TabIndex = 1;
            this.xExit.Text = "x";
            // 
            // header_text
            // 
            this.header_text.BackColor = System.Drawing.Color.SeaGreen;
            this.header_text.Dock = System.Windows.Forms.DockStyle.Top;
            this.header_text.Font = new System.Drawing.Font("Lucida Console", 14F);
            this.header_text.ForeColor = System.Drawing.Color.MistyRose;
            this.header_text.Location = new System.Drawing.Point(0, 0);
            this.header_text.Name = "header_text";
            this.header_text.Size = new System.Drawing.Size(600, 60);
            this.header_text.TabIndex = 0;
            this.header_text.Text = "Изменить пароль";
            this.header_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WorldSkillsRussia2020.Properties.Resources.icons8_password_100__1_;
            this.pictureBox1.Location = new System.Drawing.Point(36, 318);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WorldSkillsRussia2020.Properties.Resources.icons8_password_100;
            this.pictureBox2.Location = new System.Drawing.Point(36, 127);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pass_img
            // 
            this.pass_img.Image = global::WorldSkillsRussia2020.Properties.Resources.icons8_password_100__1_;
            this.pass_img.Location = new System.Drawing.Point(35, 226);
            this.pass_img.Name = "pass_img";
            this.pass_img.Size = new System.Drawing.Size(64, 64);
            this.pass_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pass_img.TabIndex = 3;
            this.pass_img.TabStop = false;
            // 
            // ChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 500);
            this.Controls.Add(this.bg_input);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(600, 500);
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "ChangePass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePass";
            this.bg_input.ResumeLayout(false);
            this.bg_input.PerformLayout();
            this.bg_header.ResumeLayout(false);
            this.bg_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pass_img)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bg_input;
        private System.Windows.Forms.Button changePassBtn;
        private System.Windows.Forms.Label descAttempt;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox newPass;
        private System.Windows.Forms.PictureBox pass_img;
        private System.Windows.Forms.TextBox oldPass;
        private System.Windows.Forms.Panel bg_header;
        private System.Windows.Forms.Label signInWinState;
        private System.Windows.Forms.Label xExit;
        private System.Windows.Forms.Label header_text;
        private System.Windows.Forms.TextBox confPass;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}