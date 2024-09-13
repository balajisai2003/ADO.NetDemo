namespace AOD.NetDemo
{
    partial class Form3
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
            this.textTrnsc = new System.Windows.Forms.TextBox();
            this.btnTrnsc = new System.Windows.Forms.Button();
            this.btnDTCtrnsc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textTrnsc
            // 
            this.textTrnsc.Location = new System.Drawing.Point(116, 71);
            this.textTrnsc.Name = "textTrnsc";
            this.textTrnsc.Size = new System.Drawing.Size(100, 20);
            this.textTrnsc.TabIndex = 0;
            // 
            // btnTrnsc
            // 
            this.btnTrnsc.Location = new System.Drawing.Point(131, 111);
            this.btnTrnsc.Name = "btnTrnsc";
            this.btnTrnsc.Size = new System.Drawing.Size(75, 23);
            this.btnTrnsc.TabIndex = 1;
            this.btnTrnsc.Text = "Transfer";
            this.btnTrnsc.UseVisualStyleBackColor = true;
            this.btnTrnsc.Click += new System.EventHandler(this.btnTrnsc_Click);
            // 
            // btnDTCtrnsc
            // 
            this.btnDTCtrnsc.Location = new System.Drawing.Point(131, 164);
            this.btnDTCtrnsc.Name = "btnDTCtrnsc";
            this.btnDTCtrnsc.Size = new System.Drawing.Size(75, 23);
            this.btnDTCtrnsc.TabIndex = 2;
            this.btnDTCtrnsc.Text = "DTCTransfer";
            this.btnDTCtrnsc.UseVisualStyleBackColor = true;
            this.btnDTCtrnsc.Click += new System.EventHandler(this.btnDTCtrnsc_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 450);
            this.Controls.Add(this.btnDTCtrnsc);
            this.Controls.Add(this.btnTrnsc);
            this.Controls.Add(this.textTrnsc);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textTrnsc;
        private System.Windows.Forms.Button btnTrnsc;
        private System.Windows.Forms.Button btnDTCtrnsc;
    }
}