namespace WorldSkillsRussia2020.settings.security
{
    partial class ChangePassword
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
            this.components = new System.ComponentModel.Container();
            this.oldPass = new System.Windows.Forms.TextBox();
            this.bg_input = new System.Windows.Forms.Panel();
            this.confPassImg = new System.Windows.Forms.PictureBox();
            this.confPass = new System.Windows.Forms.TextBox();
            this.changePassBtn = new System.Windows.Forms.Button();
            this.descAttempt = new System.Windows.Forms.Label();
            this.oldPassImg = new System.Windows.Forms.PictureBox();
            this.newPass = new System.Windows.Forms.TextBox();
            this.newPassImg = new System.Windows.Forms.PictureBox();
            this.bg_header = new System.Windows.Forms.Panel();
            this._collapse = new System.Windows.Forms.Label();
            this.xExit = new System.Windows.Forms.Label();
            this.header_text = new System.Windows.Forms.Label();
            this.oldPassToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.newPassToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.confPassToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.collToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.exitToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.bg_input.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.confPassImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oldPassImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPassImg)).BeginInit();
            this.bg_header.SuspendLayout();
            this.SuspendLayout();
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
            // bg_input
            // 
            this.bg_input.BackColor = System.Drawing.Color.Azure;
            this.bg_input.Controls.Add(this.confPassImg);
            this.bg_input.Controls.Add(this.confPass);
            this.bg_input.Controls.Add(this.changePassBtn);
            this.bg_input.Controls.Add(this.descAttempt);
            this.bg_input.Controls.Add(this.oldPassImg);
            this.bg_input.Controls.Add(this.newPass);
            this.bg_input.Controls.Add(this.newPassImg);
            this.bg_input.Controls.Add(this.oldPass);
            this.bg_input.Controls.Add(this.bg_header);
            this.bg_input.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.bg_input.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bg_input.Location = new System.Drawing.Point(0, 0);
            this.bg_input.Name = "bg_input";
            this.bg_input.Size = new System.Drawing.Size(600, 520);
            this.bg_input.TabIndex = 1;
            // 
            // confPassImg
            // 
            this.confPassImg.Image = global::WorldSkillsRussia2020.Properties.Resources.icons8_password_100__1_;
            this.confPassImg.Location = new System.Drawing.Point(36, 322);
            this.confPassImg.Name = "confPassImg";
            this.confPassImg.Size = new System.Drawing.Size(64, 64);
            this.confPassImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.confPassImg.TabIndex = 12;
            this.confPassImg.TabStop = false;
            // 
            // confPass
            // 
            this.confPass.Font = new System.Drawing.Font("Verdana", 14F);
            this.confPass.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.confPass.Location = new System.Drawing.Point(126, 322);
            this.confPass.Multiline = true;
            this.confPass.Name = "confPass";
            this.confPass.Size = new System.Drawing.Size(399, 64);
            this.confPass.TabIndex = 11;
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
            this.changePassBtn.Location = new System.Drawing.Point(219, 449);
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
            this.descAttempt.Location = new System.Drawing.Point(64, 403);
            this.descAttempt.Name = "descAttempt";
            this.descAttempt.Size = new System.Drawing.Size(0, 25);
            this.descAttempt.TabIndex = 10;
            // 
            // oldPassImg
            // 
            this.oldPassImg.Image = global::WorldSkillsRussia2020.Properties.Resources.icons8_password_100;
            this.oldPassImg.Location = new System.Drawing.Point(36, 127);
            this.oldPassImg.Name = "oldPassImg";
            this.oldPassImg.Size = new System.Drawing.Size(64, 64);
            this.oldPassImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.oldPassImg.TabIndex = 9;
            this.oldPassImg.TabStop = false;
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
            // newPassImg
            // 
            this.newPassImg.Image = global::WorldSkillsRussia2020.Properties.Resources.icons8_password_100__1_;
            this.newPassImg.Location = new System.Drawing.Point(35, 226);
            this.newPassImg.Name = "newPassImg";
            this.newPassImg.Size = new System.Drawing.Size(64, 64);
            this.newPassImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.newPassImg.TabIndex = 3;
            this.newPassImg.TabStop = false;
            // 
            // bg_header
            // 
            this.bg_header.AutoSize = true;
            this.bg_header.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.bg_header.Controls.Add(this._collapse);
            this.bg_header.Controls.Add(this.xExit);
            this.bg_header.Controls.Add(this.header_text);
            this.bg_header.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bg_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.bg_header.Location = new System.Drawing.Point(0, 0);
            this.bg_header.Name = "bg_header";
            this.bg_header.Size = new System.Drawing.Size(600, 60);
            this.bg_header.TabIndex = 0;
            // 
            // _collapse
            // 
            this._collapse.AutoSize = true;
            this._collapse.BackColor = System.Drawing.Color.MediumSeaGreen;
            this._collapse.Font = new System.Drawing.Font("Lucida Console", 16F);
            this._collapse.ForeColor = System.Drawing.Color.WhiteSmoke;
            this._collapse.Location = new System.Drawing.Point(526, 9);
            this._collapse.Name = "_collapse";
            this._collapse.Size = new System.Drawing.Size(28, 27);
            this._collapse.TabIndex = 2;
            this._collapse.Text = "-";
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
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 520);
            this.Controls.Add(this.bg_input);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePassword";
            this.bg_input.ResumeLayout(false);
            this.bg_input.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.confPassImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oldPassImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPassImg)).EndInit();
            this.bg_header.ResumeLayout(false);
            this.bg_header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox oldPass;
        private System.Windows.Forms.Panel bg_input;
        private System.Windows.Forms.Button changePassBtn;
        private System.Windows.Forms.Label descAttempt;
        private System.Windows.Forms.PictureBox oldPassImg;
        private System.Windows.Forms.TextBox newPass;
        private System.Windows.Forms.PictureBox newPassImg;
        private System.Windows.Forms.Panel bg_header;
        private System.Windows.Forms.Label _collapse;
        private System.Windows.Forms.Label xExit;
        private System.Windows.Forms.Label header_text;
        private System.Windows.Forms.TextBox confPass;
        private System.Windows.Forms.PictureBox confPassImg;
        private System.Windows.Forms.ToolTip oldPassToolTip;
        private System.Windows.Forms.ToolTip newPassToolTip;
        private System.Windows.Forms.ToolTip confPassToolTip;
        private System.Windows.Forms.ToolTip collToolTip;
        private System.Windows.Forms.ToolTip exitToolTip;
    }
}