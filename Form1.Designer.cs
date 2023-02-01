namespace Email_Sender
{
    partial class Form1
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
            this.btnSendVerifyCode = new System.Windows.Forms.Button();
            this.txtUserEmail = new System.Windows.Forms.TextBox();
            this.pnlEnterEmail = new System.Windows.Forms.Panel();
            this.pnlEnterCode = new System.Windows.Forms.Panel();
            this.btnSendAnotherCode = new System.Windows.Forms.Button();
            this.btnCheckCode = new System.Windows.Forms.Button();
            this.txtEnteredCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlCreateNewPassword = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.btnAppendPassword = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlEnterEmail.SuspendLayout();
            this.pnlEnterCode.SuspendLayout();
            this.pnlCreateNewPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSendVerifyCode
            // 
            this.btnSendVerifyCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendVerifyCode.Location = new System.Drawing.Point(47, 29);
            this.btnSendVerifyCode.Name = "btnSendVerifyCode";
            this.btnSendVerifyCode.Size = new System.Drawing.Size(134, 49);
            this.btnSendVerifyCode.TabIndex = 0;
            this.btnSendVerifyCode.Text = "Forgot Password?";
            this.btnSendVerifyCode.UseVisualStyleBackColor = true;
            this.btnSendVerifyCode.Click += new System.EventHandler(this.btnSendVerifyCode_Click);
            // 
            // txtUserEmail
            // 
            this.txtUserEmail.Location = new System.Drawing.Point(3, 3);
            this.txtUserEmail.Name = "txtUserEmail";
            this.txtUserEmail.Size = new System.Drawing.Size(220, 20);
            this.txtUserEmail.TabIndex = 1;
            // 
            // pnlEnterEmail
            // 
            this.pnlEnterEmail.Controls.Add(this.txtUserEmail);
            this.pnlEnterEmail.Controls.Add(this.btnSendVerifyCode);
            this.pnlEnterEmail.Location = new System.Drawing.Point(2, 114);
            this.pnlEnterEmail.Name = "pnlEnterEmail";
            this.pnlEnterEmail.Size = new System.Drawing.Size(229, 85);
            this.pnlEnterEmail.TabIndex = 3;
            // 
            // pnlEnterCode
            // 
            this.pnlEnterCode.Controls.Add(this.btnSendAnotherCode);
            this.pnlEnterCode.Controls.Add(this.btnCheckCode);
            this.pnlEnterCode.Controls.Add(this.txtEnteredCode);
            this.pnlEnterCode.Controls.Add(this.label1);
            this.pnlEnterCode.Location = new System.Drawing.Point(266, 114);
            this.pnlEnterCode.Name = "pnlEnterCode";
            this.pnlEnterCode.Size = new System.Drawing.Size(190, 95);
            this.pnlEnterCode.TabIndex = 4;
            // 
            // btnSendAnotherCode
            // 
            this.btnSendAnotherCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendAnotherCode.Location = new System.Drawing.Point(95, 44);
            this.btnSendAnotherCode.Name = "btnSendAnotherCode";
            this.btnSendAnotherCode.Size = new System.Drawing.Size(92, 48);
            this.btnSendAnotherCode.TabIndex = 3;
            this.btnSendAnotherCode.Text = "Send Another Code";
            this.btnSendAnotherCode.UseVisualStyleBackColor = true;
            this.btnSendAnotherCode.Click += new System.EventHandler(this.btnSendAnotherCode_Click);
            // 
            // btnCheckCode
            // 
            this.btnCheckCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckCode.Location = new System.Drawing.Point(3, 44);
            this.btnCheckCode.Name = "btnCheckCode";
            this.btnCheckCode.Size = new System.Drawing.Size(86, 48);
            this.btnCheckCode.TabIndex = 2;
            this.btnCheckCode.Text = "Reset Password";
            this.btnCheckCode.UseVisualStyleBackColor = true;
            this.btnCheckCode.Click += new System.EventHandler(this.btnCheckCode_Click);
            // 
            // txtEnteredCode
            // 
            this.txtEnteredCode.Location = new System.Drawing.Point(70, 18);
            this.txtEnteredCode.Name = "txtEnteredCode";
            this.txtEnteredCode.Size = new System.Drawing.Size(96, 20);
            this.txtEnteredCode.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please enter your verification code here:";
            // 
            // pnlCreateNewPassword
            // 
            this.pnlCreateNewPassword.Controls.Add(this.btnAppendPassword);
            this.pnlCreateNewPassword.Controls.Add(this.pictureBox1);
            this.pnlCreateNewPassword.Controls.Add(this.txtNewPassword);
            this.pnlCreateNewPassword.Controls.Add(this.label2);
            this.pnlCreateNewPassword.Location = new System.Drawing.Point(5, 8);
            this.pnlCreateNewPassword.Name = "pnlCreateNewPassword";
            this.pnlCreateNewPassword.Size = new System.Drawing.Size(269, 100);
            this.pnlCreateNewPassword.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Enter a new password below:";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(4, 24);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '*';
            this.txtNewPassword.Size = new System.Drawing.Size(216, 20);
            this.txtNewPassword.TabIndex = 1;
            // 
            // btnAppendPassword
            // 
            this.btnAppendPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppendPassword.Location = new System.Drawing.Point(4, 50);
            this.btnAppendPassword.Name = "btnAppendPassword";
            this.btnAppendPassword.Size = new System.Drawing.Size(216, 46);
            this.btnAppendPassword.TabIndex = 3;
            this.btnAppendPassword.Text = "Set as new password";
            this.btnAppendPassword.UseVisualStyleBackColor = true;
            this.btnAppendPassword.Click += new System.EventHandler(this.btnAppendPassword_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Email_Sender.Properties.Resources.eye_closed;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(226, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 239);
            this.Controls.Add(this.pnlCreateNewPassword);
            this.Controls.Add(this.pnlEnterCode);
            this.Controls.Add(this.pnlEnterEmail);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlEnterEmail.ResumeLayout(false);
            this.pnlEnterEmail.PerformLayout();
            this.pnlEnterCode.ResumeLayout(false);
            this.pnlEnterCode.PerformLayout();
            this.pnlCreateNewPassword.ResumeLayout(false);
            this.pnlCreateNewPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSendVerifyCode;
        private System.Windows.Forms.TextBox txtUserEmail;
        private System.Windows.Forms.Panel pnlEnterEmail;
        private System.Windows.Forms.Panel pnlEnterCode;
        private System.Windows.Forms.Button btnCheckCode;
        private System.Windows.Forms.TextBox txtEnteredCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSendAnotherCode;
        private System.Windows.Forms.Panel pnlCreateNewPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAppendPassword;
    }
}

