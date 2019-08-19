namespace LinqToSQLDemo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEcode = new System.Windows.Forms.TextBox();
            this.txtEname = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtDeptid = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.sumofsalary = new System.Windows.Forms.Button();
            this.txtsum = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ecode :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ename";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Salary";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(162, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Deptid";
            // 
            // txtEcode
            // 
            this.txtEcode.Location = new System.Drawing.Point(281, 48);
            this.txtEcode.Name = "txtEcode";
            this.txtEcode.Size = new System.Drawing.Size(100, 20);
            this.txtEcode.TabIndex = 4;
            // 
            // txtEname
            // 
            this.txtEname.Location = new System.Drawing.Point(281, 114);
            this.txtEname.Name = "txtEname";
            this.txtEname.Size = new System.Drawing.Size(100, 20);
            this.txtEname.TabIndex = 5;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(281, 201);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(100, 20);
            this.txtSalary.TabIndex = 6;
            // 
            // txtDeptid
            // 
            this.txtDeptid.Location = new System.Drawing.Point(281, 283);
            this.txtDeptid.Name = "txtDeptid";
            this.txtDeptid.Size = new System.Drawing.Size(100, 20);
            this.txtDeptid.TabIndex = 7;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(121, 360);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 8;
            this.btnInsert.Text = "INSERT";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(281, 360);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(450, 360);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dgv
            // 
            this.dgv.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(522, 48);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(340, 261);
            this.dgv.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(629, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "FindById";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sumofsalary
            // 
            this.sumofsalary.Location = new System.Drawing.Point(121, 426);
            this.sumofsalary.Name = "sumofsalary";
            this.sumofsalary.Size = new System.Drawing.Size(75, 23);
            this.sumofsalary.TabIndex = 13;
            this.sumofsalary.Text = "Totalsalary";
            this.sumofsalary.UseVisualStyleBackColor = true;
            this.sumofsalary.Click += new System.EventHandler(this.sumofsalary_Click);
            // 
            // txtsum
            // 
            this.txtsum.Location = new System.Drawing.Point(281, 428);
            this.txtsum.Name = "txtsum";
            this.txtsum.Size = new System.Drawing.Size(100, 20);
            this.txtsum.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 601);
            this.Controls.Add(this.txtsum);
            this.Controls.Add(this.sumofsalary);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txtDeptid);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtEname);
            this.Controls.Add(this.txtEcode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEcode;
        private System.Windows.Forms.TextBox txtEname;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtDeptid;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button sumofsalary;
        private System.Windows.Forms.TextBox txtsum;
    }
}

