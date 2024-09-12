namespace AOD.NetDemo
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
            this.DBConn = new System.Windows.Forms.Button();
            this.ArrConn = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.textEmpName = new System.Windows.Forms.TextBox();
            this.textEmpSalary = new System.Windows.Forms.TextBox();
            this.labelEmpName = new System.Windows.Forms.Label();
            this.labelEmpSalary = new System.Windows.Forms.Label();
            this.labelEmpId = new System.Windows.Forms.Label();
            this.textEmpID = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnGetEmployees = new System.Windows.Forms.Button();
            this.getEmpSalary = new System.Windows.Forms.Button();
            this.DeptID = new System.Windows.Forms.Label();
            this.textDeptId = new System.Windows.Forms.TextBox();
            this.btnEmpDept = new System.Windows.Forms.Button();
            this.btnInsrtPrms = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnInsertImg = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGetImg = new System.Windows.Forms.Button();
            this.btnGetSalViaProce = new System.Windows.Forms.Button();
            this.btnInsertStoredProc = new System.Windows.Forms.Button();
            this.btnGetEmpProce = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DBConn
            // 
            this.DBConn.Location = new System.Drawing.Point(124, 174);
            this.DBConn.Name = "DBConn";
            this.DBConn.Size = new System.Drawing.Size(100, 23);
            this.DBConn.TabIndex = 0;
            this.DBConn.Text = "DBConn";
            this.DBConn.UseVisualStyleBackColor = true;
            this.DBConn.Click += new System.EventHandler(this.DBConn_Click);
            // 
            // ArrConn
            // 
            this.ArrConn.Location = new System.Drawing.Point(230, 174);
            this.ArrConn.Name = "ArrConn";
            this.ArrConn.Size = new System.Drawing.Size(100, 23);
            this.ArrConn.TabIndex = 1;
            this.ArrConn.Text = "ArrConn";
            this.ArrConn.UseVisualStyleBackColor = true;
            this.ArrConn.Click += new System.EventHandler(this.ArrConn_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(18, 98);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(100, 23);
            this.btnInsert.TabIndex = 2;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // textEmpName
            // 
            this.textEmpName.Location = new System.Drawing.Point(78, 38);
            this.textEmpName.Name = "textEmpName";
            this.textEmpName.Size = new System.Drawing.Size(100, 20);
            this.textEmpName.TabIndex = 3;
            // 
            // textEmpSalary
            // 
            this.textEmpSalary.Location = new System.Drawing.Point(78, 63);
            this.textEmpSalary.Name = "textEmpSalary";
            this.textEmpSalary.Size = new System.Drawing.Size(100, 20);
            this.textEmpSalary.TabIndex = 4;
            // 
            // labelEmpName
            // 
            this.labelEmpName.AutoSize = true;
            this.labelEmpName.Location = new System.Drawing.Point(10, 41);
            this.labelEmpName.Name = "labelEmpName";
            this.labelEmpName.Size = new System.Drawing.Size(62, 13);
            this.labelEmpName.TabIndex = 5;
            this.labelEmpName.Text = "Emp Name:";
            // 
            // labelEmpSalary
            // 
            this.labelEmpSalary.AutoSize = true;
            this.labelEmpSalary.Location = new System.Drawing.Point(12, 66);
            this.labelEmpSalary.Name = "labelEmpSalary";
            this.labelEmpSalary.Size = new System.Drawing.Size(60, 13);
            this.labelEmpSalary.TabIndex = 6;
            this.labelEmpSalary.Text = "Emp Salary";
            // 
            // labelEmpId
            // 
            this.labelEmpId.AutoSize = true;
            this.labelEmpId.Location = new System.Drawing.Point(185, 41);
            this.labelEmpId.Name = "labelEmpId";
            this.labelEmpId.Size = new System.Drawing.Size(45, 13);
            this.labelEmpId.TabIndex = 8;
            this.labelEmpId.Text = "Emp ID:";
            // 
            // textEmpID
            // 
            this.textEmpID.Location = new System.Drawing.Point(236, 38);
            this.textEmpID.Name = "textEmpID";
            this.textEmpID.Size = new System.Drawing.Size(100, 20);
            this.textEmpID.TabIndex = 7;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(124, 98);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 23);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(230, 98);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnDelete.Size = new System.Drawing.Size(100, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnGetEmployees
            // 
            this.btnGetEmployees.Location = new System.Drawing.Point(18, 136);
            this.btnGetEmployees.Name = "btnGetEmployees";
            this.btnGetEmployees.Size = new System.Drawing.Size(100, 23);
            this.btnGetEmployees.TabIndex = 11;
            this.btnGetEmployees.Text = "Get Employees";
            this.btnGetEmployees.UseVisualStyleBackColor = true;
            this.btnGetEmployees.Click += new System.EventHandler(this.btnGetEmployees_Click);
            // 
            // getEmpSalary
            // 
            this.getEmpSalary.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.getEmpSalary.Location = new System.Drawing.Point(124, 136);
            this.getEmpSalary.Name = "getEmpSalary";
            this.getEmpSalary.Size = new System.Drawing.Size(100, 23);
            this.getEmpSalary.TabIndex = 12;
            this.getEmpSalary.Text = "Get Emp Salary";
            this.getEmpSalary.UseVisualStyleBackColor = true;
            this.getEmpSalary.Click += new System.EventHandler(this.getEmpSalary_Click);
            // 
            // DeptID
            // 
            this.DeptID.AutoSize = true;
            this.DeptID.Location = new System.Drawing.Point(185, 65);
            this.DeptID.Name = "DeptID";
            this.DeptID.Size = new System.Drawing.Size(50, 13);
            this.DeptID.TabIndex = 13;
            this.DeptID.Text = "Dept ID :";
            // 
            // textDeptId
            // 
            this.textDeptId.Location = new System.Drawing.Point(236, 65);
            this.textDeptId.Name = "textDeptId";
            this.textDeptId.Size = new System.Drawing.Size(100, 20);
            this.textDeptId.TabIndex = 14;
            // 
            // btnEmpDept
            // 
            this.btnEmpDept.Location = new System.Drawing.Point(230, 136);
            this.btnEmpDept.Name = "btnEmpDept";
            this.btnEmpDept.Size = new System.Drawing.Size(100, 23);
            this.btnEmpDept.TabIndex = 15;
            this.btnEmpDept.Text = "EmpDept";
            this.btnEmpDept.UseVisualStyleBackColor = true;
            this.btnEmpDept.Click += new System.EventHandler(this.btnEmpDept_Click);
            // 
            // btnInsrtPrms
            // 
            this.btnInsrtPrms.Location = new System.Drawing.Point(18, 174);
            this.btnInsrtPrms.Name = "btnInsrtPrms";
            this.btnInsrtPrms.Size = new System.Drawing.Size(100, 23);
            this.btnInsrtPrms.TabIndex = 16;
            this.btnInsrtPrms.Text = "Insert(Prms)";
            this.btnInsrtPrms.UseVisualStyleBackColor = true;
            this.btnInsrtPrms.Click += new System.EventHandler(this.btnInsrtPrms_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(18, 365);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(100, 23);
            this.btnBrowse.TabIndex = 17;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnInsertImg
            // 
            this.btnInsertImg.Location = new System.Drawing.Point(230, 365);
            this.btnInsertImg.Name = "btnInsertImg";
            this.btnInsertImg.Size = new System.Drawing.Size(100, 23);
            this.btnInsertImg.TabIndex = 18;
            this.btnInsertImg.Text = "Insert Img";
            this.btnInsertImg.UseVisualStyleBackColor = true;
            this.btnInsertImg.Click += new System.EventHandler(this.btnInsertImg_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(18, 203);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(312, 156);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // btnGetImg
            // 
            this.btnGetImg.Location = new System.Drawing.Point(124, 365);
            this.btnGetImg.Name = "btnGetImg";
            this.btnGetImg.Size = new System.Drawing.Size(100, 23);
            this.btnGetImg.TabIndex = 20;
            this.btnGetImg.Text = "Get Emp Img";
            this.btnGetImg.UseVisualStyleBackColor = true;
            this.btnGetImg.Click += new System.EventHandler(this.btnGetImg_Click);
            // 
            // btnGetSalViaProce
            // 
            this.btnGetSalViaProce.Location = new System.Drawing.Point(18, 394);
            this.btnGetSalViaProce.Name = "btnGetSalViaProce";
            this.btnGetSalViaProce.Size = new System.Drawing.Size(100, 23);
            this.btnGetSalViaProce.TabIndex = 21;
            this.btnGetSalViaProce.Text = "GetSalViaProce";
            this.btnGetSalViaProce.UseVisualStyleBackColor = true;
            this.btnGetSalViaProce.Click += new System.EventHandler(this.btnGetSalViaProce_Click);
            // 
            // btnInsertStoredProc
            // 
            this.btnInsertStoredProc.Location = new System.Drawing.Point(124, 394);
            this.btnInsertStoredProc.Name = "btnInsertStoredProc";
            this.btnInsertStoredProc.Size = new System.Drawing.Size(100, 23);
            this.btnInsertStoredProc.TabIndex = 22;
            this.btnInsertStoredProc.Text = "InsertStoredProc";
            this.btnInsertStoredProc.UseVisualStyleBackColor = true;
            this.btnInsertStoredProc.Click += new System.EventHandler(this.btnInsertStoredProc_Click);
            // 
            // btnGetEmpProce
            // 
            this.btnGetEmpProce.Location = new System.Drawing.Point(230, 393);
            this.btnGetEmpProce.Name = "btnGetEmpProce";
            this.btnGetEmpProce.Size = new System.Drawing.Size(100, 23);
            this.btnGetEmpProce.TabIndex = 23;
            this.btnGetEmpProce.Text = "GetEmpProce";
            this.btnGetEmpProce.UseVisualStyleBackColor = true;
            this.btnGetEmpProce.Click += new System.EventHandler(this.btnGetEmpProce_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 428);
            this.Controls.Add(this.btnGetEmpProce);
            this.Controls.Add(this.btnInsertStoredProc);
            this.Controls.Add(this.btnGetSalViaProce);
            this.Controls.Add(this.btnGetImg);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnInsertImg);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.btnInsrtPrms);
            this.Controls.Add(this.btnEmpDept);
            this.Controls.Add(this.textDeptId);
            this.Controls.Add(this.DeptID);
            this.Controls.Add(this.getEmpSalary);
            this.Controls.Add(this.btnGetEmployees);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.labelEmpId);
            this.Controls.Add(this.textEmpID);
            this.Controls.Add(this.labelEmpSalary);
            this.Controls.Add(this.labelEmpName);
            this.Controls.Add(this.textEmpSalary);
            this.Controls.Add(this.textEmpName);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.ArrConn);
            this.Controls.Add(this.DBConn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DBConn;
        private System.Windows.Forms.Button ArrConn;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox textEmpName;
        private System.Windows.Forms.TextBox textEmpSalary;
        private System.Windows.Forms.Label labelEmpName;
        private System.Windows.Forms.Label labelEmpSalary;
        private System.Windows.Forms.Label labelEmpId;
        private System.Windows.Forms.TextBox textEmpID;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnGetEmployees;
        private System.Windows.Forms.Button getEmpSalary;
        private System.Windows.Forms.Label DeptID;
        private System.Windows.Forms.TextBox textDeptId;
        private System.Windows.Forms.Button btnEmpDept;
        private System.Windows.Forms.Button btnInsrtPrms;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnInsertImg;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnGetImg;
        private System.Windows.Forms.Button btnGetSalViaProce;
        private System.Windows.Forms.Button btnInsertStoredProc;
        private System.Windows.Forms.Button btnGetEmpProce;
    }
}

