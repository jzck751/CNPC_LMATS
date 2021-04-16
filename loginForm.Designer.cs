
namespace CNPC_LMATS
{
    partial class loginForm
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
            this.user_name = new System.Windows.Forms.Label();
            this.user_pwd = new System.Windows.Forms.Label();
            this.user_name_textBox = new System.Windows.Forms.TextBox();
            this.user_pwd_textBox = new System.Windows.Forms.TextBox();
            this.login_button = new System.Windows.Forms.Button();
            this.reset_button = new System.Windows.Forms.Button();
            this.sign_in_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // user_name
            // 
            this.user_name.AutoSize = true;
            this.user_name.Location = new System.Drawing.Point(238, 108);
            this.user_name.Name = "user_name";
            this.user_name.Size = new System.Drawing.Size(60, 15);
            this.user_name.TabIndex = 0;
            this.user_name.Text = "用户名:";
            // 
            // user_pwd
            // 
            this.user_pwd.AutoSize = true;
            this.user_pwd.Location = new System.Drawing.Point(238, 200);
            this.user_pwd.Name = "user_pwd";
            this.user_pwd.Size = new System.Drawing.Size(45, 15);
            this.user_pwd.TabIndex = 1;
            this.user_pwd.Text = "密码:";
            // 
            // user_name_textBox
            // 
            this.user_name_textBox.Location = new System.Drawing.Point(326, 105);
            this.user_name_textBox.Name = "user_name_textBox";
            this.user_name_textBox.Size = new System.Drawing.Size(240, 25);
            this.user_name_textBox.TabIndex = 2;
            // 
            // user_pwd_textBox
            // 
            this.user_pwd_textBox.Location = new System.Drawing.Point(326, 190);
            this.user_pwd_textBox.Name = "user_pwd_textBox";
            this.user_pwd_textBox.PasswordChar = '*';
            this.user_pwd_textBox.Size = new System.Drawing.Size(240, 25);
            this.user_pwd_textBox.TabIndex = 3;
            // 
            // login_button
            // 
            this.login_button.Location = new System.Drawing.Point(241, 280);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(75, 23);
            this.login_button.TabIndex = 4;
            this.login_button.Text = "登录";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // reset_button
            // 
            this.reset_button.Location = new System.Drawing.Point(373, 280);
            this.reset_button.Name = "reset_button";
            this.reset_button.Size = new System.Drawing.Size(75, 23);
            this.reset_button.TabIndex = 5;
            this.reset_button.Text = "重置";
            this.reset_button.UseVisualStyleBackColor = true;
            // 
            // sign_in_button
            // 
            this.sign_in_button.Location = new System.Drawing.Point(491, 280);
            this.sign_in_button.Name = "sign_in_button";
            this.sign_in_button.Size = new System.Drawing.Size(75, 23);
            this.sign_in_button.TabIndex = 6;
            this.sign_in_button.Text = "注册";
            this.sign_in_button.UseVisualStyleBackColor = true;
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sign_in_button);
            this.Controls.Add(this.reset_button);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.user_pwd_textBox);
            this.Controls.Add(this.user_name_textBox);
            this.Controls.Add(this.user_pwd);
            this.Controls.Add(this.user_name);
            this.Name = "loginForm";
            this.Text = "loginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label user_name;
        private System.Windows.Forms.Label user_pwd;
        private System.Windows.Forms.TextBox user_name_textBox;
        private System.Windows.Forms.TextBox user_pwd_textBox;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Button reset_button;
        private System.Windows.Forms.Button sign_in_button;
    }
}