namespace QuanLyBanHang
{
    partial class frmDangNhap
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btExit_Click = new System.Windows.Forms.Button();
            this.btLogin_Click = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(135, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐĂNG NHẬP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(114, 88);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(278, 22);
            this.txtUsername.TabIndex = 3;
            // 
            // btExit_Click
            // 
            this.btExit_Click.Location = new System.Drawing.Point(287, 202);
            this.btExit_Click.Name = "btExit_Click";
            this.btExit_Click.Size = new System.Drawing.Size(105, 42);
            this.btExit_Click.TabIndex = 6;
            this.btExit_Click.Text = "Thoát";
            this.btExit_Click.UseVisualStyleBackColor = true;
            this.btExit_Click.Click += new System.EventHandler(this.btExit_Click_Click);
            // 
            // btLogin_Click
            // 
            this.btLogin_Click.Location = new System.Drawing.Point(117, 202);
            this.btLogin_Click.Name = "btLogin_Click";
            this.btLogin_Click.Size = new System.Drawing.Size(105, 42);
            this.btLogin_Click.TabIndex = 7;
            this.btLogin_Click.Text = "Đăng nhập";
            this.btLogin_Click.UseVisualStyleBackColor = true;
            this.btLogin_Click.Click += new System.EventHandler(this.btLogin_Click_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(114, 151);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(278, 22);
            this.txtPassword.TabIndex = 8;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(462, 275);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btLogin_Click);
            this.Controls.Add(this.btExit_Click);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmDangNhap";
            this.Text = "Đăng Nhập";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsername;
       
        private System.Windows.Forms.Button btExit_Click;
        private System.Windows.Forms.Button btLogin_Click;
        private System.Windows.Forms.TextBox txtPassword;
    }
}