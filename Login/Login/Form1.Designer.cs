namespace Login
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
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnShowHide = new System.Windows.Forms.Button();
            this.lblLowerCase = new System.Windows.Forms.Label();
            this.lblUpperCase = new System.Windows.Forms.Label();
            this.lblSpecChar = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.lbl8min = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEmail.Location = new System.Drawing.Point(13, 14);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(74, 29);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtEmail.Location = new System.Drawing.Point(18, 46);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(333, 32);
            this.txtEmail.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.AcceptsTab = true;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPassword.Location = new System.Drawing.Point(18, 136);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(333, 32);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPassword.Location = new System.Drawing.Point(13, 104);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(120, 29);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password";
            // 
            // btnShowHide
            // 
            this.btnShowHide.Location = new System.Drawing.Point(272, 109);
            this.btnShowHide.Name = "btnShowHide";
            this.btnShowHide.Size = new System.Drawing.Size(75, 23);
            this.btnShowHide.TabIndex = 4;
            this.btnShowHide.Text = "Show";
            this.btnShowHide.UseVisualStyleBackColor = true;
            this.btnShowHide.Click += new System.EventHandler(this.btnShowHide_Click);
            // 
            // lblLowerCase
            // 
            this.lblLowerCase.AutoSize = true;
            this.lblLowerCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLowerCase.Location = new System.Drawing.Point(18, 190);
            this.lblLowerCase.Name = "lblLowerCase";
            this.lblLowerCase.Size = new System.Drawing.Size(158, 17);
            this.lblLowerCase.TabIndex = 5;
            this.lblLowerCase.Text = "One lowercase letter";
            // 
            // lblUpperCase
            // 
            this.lblUpperCase.AutoSize = true;
            this.lblUpperCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUpperCase.Location = new System.Drawing.Point(18, 207);
            this.lblUpperCase.Name = "lblUpperCase";
            this.lblUpperCase.Size = new System.Drawing.Size(162, 17);
            this.lblUpperCase.TabIndex = 6;
            this.lblUpperCase.Text = "One uppercase letter";
            // 
            // lblSpecChar
            // 
            this.lblSpecChar.AutoSize = true;
            this.lblSpecChar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSpecChar.Location = new System.Drawing.Point(18, 224);
            this.lblSpecChar.Name = "lblSpecChar";
            this.lblSpecChar.Size = new System.Drawing.Size(168, 17);
            this.lblSpecChar.TabIndex = 7;
            this.lblSpecChar.Text = "One special character";
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNum.Location = new System.Drawing.Point(18, 241);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(97, 17);
            this.lblNum.TabIndex = 8;
            this.lblNum.Text = "One number";
            // 
            // lbl8min
            // 
            this.lbl8min.AutoSize = true;
            this.lbl8min.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl8min.Location = new System.Drawing.Point(18, 258);
            this.lbl8min.Name = "lbl8min";
            this.lbl8min.Size = new System.Drawing.Size(166, 17);
            this.lbl8min.TabIndex = 9;
            this.lbl8min.Text = "8 characters minimum";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 289);
            this.Controls.Add(this.lbl8min);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.lblSpecChar);
            this.Controls.Add(this.lblUpperCase);
            this.Controls.Add(this.lblLowerCase);
            this.Controls.Add(this.btnShowHide);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnShowHide;
        private System.Windows.Forms.Label lblLowerCase;
        private System.Windows.Forms.Label lblUpperCase;
        private System.Windows.Forms.Label lblSpecChar;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lbl8min;
    }
}

