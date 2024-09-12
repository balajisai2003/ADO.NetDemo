namespace AOD.NetDemo
{
    partial class Form2
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
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EmpPwd = new System.Windows.Forms.Label();
            this.textEmpId = new System.Windows.Forms.TextBox();
            this.textEmpEmail = new System.Windows.Forms.TextBox();
            this.textPwd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(37, 209);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(91, 23);
            this.btnRegister.TabIndex = 0;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(158, 209);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(91, 23);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "EmpId :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Email :";
            // 
            // EmpPwd
            // 
            this.EmpPwd.AutoSize = true;
            this.EmpPwd.Location = new System.Drawing.Point(12, 141);
            this.EmpPwd.Name = "EmpPwd";
            this.EmpPwd.Size = new System.Drawing.Size(59, 13);
            this.EmpPwd.TabIndex = 4;
            this.EmpPwd.Text = "Password :";
            // 
            // textEmpId
            // 
            this.textEmpId.Location = new System.Drawing.Point(87, 40);
            this.textEmpId.Name = "textEmpId";
            this.textEmpId.Size = new System.Drawing.Size(197, 20);
            this.textEmpId.TabIndex = 5;
            // 
            // textEmpEmail
            // 
            this.textEmpEmail.Location = new System.Drawing.Point(87, 90);
            this.textEmpEmail.Name = "textEmpEmail";
            this.textEmpEmail.Size = new System.Drawing.Size(197, 20);
            this.textEmpEmail.TabIndex = 6;
            // 
            // textPwd
            // 
            this.textPwd.Location = new System.Drawing.Point(87, 138);
            this.textPwd.Name = "textPwd";
            this.textPwd.Size = new System.Drawing.Size(197, 20);
            this.textPwd.TabIndex = 7;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 450);
            this.Controls.Add(this.textPwd);
            this.Controls.Add(this.textEmpEmail);
            this.Controls.Add(this.textEmpId);
            this.Controls.Add(this.EmpPwd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnRegister);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label EmpPwd;
        private System.Windows.Forms.TextBox textEmpId;
        private System.Windows.Forms.TextBox textEmpEmail;
        private System.Windows.Forms.TextBox textPwd;
    }
}