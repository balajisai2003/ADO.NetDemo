namespace AOD.NetDemo
{
    partial class Form4
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
            this.btnSyncExe = new System.Windows.Forms.Button();
            this.btnAsyncExe = new System.Windows.Forms.Button();
            this.btnAsyncWait = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSyncExe
            // 
            this.btnSyncExe.Location = new System.Drawing.Point(52, 52);
            this.btnSyncExe.Name = "btnSyncExe";
            this.btnSyncExe.Size = new System.Drawing.Size(111, 23);
            this.btnSyncExe.TabIndex = 0;
            this.btnSyncExe.Text = "Sync Exe";
            this.btnSyncExe.UseVisualStyleBackColor = true;
            this.btnSyncExe.Click += new System.EventHandler(this.btnSyncExe_Click);
            // 
            // btnAsyncExe
            // 
            this.btnAsyncExe.Location = new System.Drawing.Point(52, 110);
            this.btnAsyncExe.Name = "btnAsyncExe";
            this.btnAsyncExe.Size = new System.Drawing.Size(111, 23);
            this.btnAsyncExe.TabIndex = 1;
            this.btnAsyncExe.Text = "Async Exe";
            this.btnAsyncExe.UseVisualStyleBackColor = true;
            this.btnAsyncExe.Click += new System.EventHandler(this.btnAsyncExe_Click);
            // 
            // btnAsyncWait
            // 
            this.btnAsyncWait.Location = new System.Drawing.Point(52, 170);
            this.btnAsyncWait.Name = "btnAsyncWait";
            this.btnAsyncWait.Size = new System.Drawing.Size(111, 23);
            this.btnAsyncWait.TabIndex = 2;
            this.btnAsyncWait.Text = "Async Methods";
            this.btnAsyncWait.UseVisualStyleBackColor = true;
            this.btnAsyncWait.Click += new System.EventHandler(this.btnAsyncWait_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 248);
            this.Controls.Add(this.btnAsyncWait);
            this.Controls.Add(this.btnAsyncExe);
            this.Controls.Add(this.btnSyncExe);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSyncExe;
        private System.Windows.Forms.Button btnAsyncExe;
        private System.Windows.Forms.Button btnAsyncWait;
    }
}