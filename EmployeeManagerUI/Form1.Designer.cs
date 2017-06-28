namespace EmployeeManagerUI
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblempname = new System.Windows.Forms.Label();
            this.txtempname = new System.Windows.Forms.TextBox();
            this.btnempname = new System.Windows.Forms.Button();
            this.dgvshow = new System.Windows.Forms.DataGridView();
            this.EmpID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deptName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpBirthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empphone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpshow = new System.Windows.Forms.GroupBox();
            this.lblEmpID = new System.Windows.Forms.Label();
            this.txtEmpID = new System.Windows.Forms.TextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lbldeptName = new System.Windows.Forms.Label();
            this.cmbdeptName = new System.Windows.Forms.ComboBox();
            this.lblEmpBirthday = new System.Windows.Forms.Label();
            this.txtEmpBirthday = new System.Windows.Forms.TextBox();
            this.lblEmpphone = new System.Windows.Forms.Label();
            this.txtEmpphone = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnxg = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnno = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvshow)).BeginInit();
            this.grpshow.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblempname
            // 
            this.lblempname.AutoSize = true;
            this.lblempname.Location = new System.Drawing.Point(23, 25);
            this.lblempname.Name = "lblempname";
            this.lblempname.Size = new System.Drawing.Size(65, 12);
            this.lblempname.TabIndex = 0;
            this.lblempname.Text = "员工姓名：";
            // 
            // txtempname
            // 
            this.txtempname.Location = new System.Drawing.Point(94, 16);
            this.txtempname.Name = "txtempname";
            this.txtempname.Size = new System.Drawing.Size(100, 21);
            this.txtempname.TabIndex = 1;
            // 
            // btnempname
            // 
            this.btnempname.Location = new System.Drawing.Point(216, 13);
            this.btnempname.Name = "btnempname";
            this.btnempname.Size = new System.Drawing.Size(75, 23);
            this.btnempname.TabIndex = 2;
            this.btnempname.Text = "查询";
            this.btnempname.UseVisualStyleBackColor = true;
            this.btnempname.Click += new System.EventHandler(this.btnempname_Click);
            // 
            // dgvshow
            // 
            this.dgvshow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvshow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmpID,
            this.EmpName,
            this.deptName,
            this.EmpBirthday,
            this.Empphone});
            this.dgvshow.Location = new System.Drawing.Point(44, 53);
            this.dgvshow.Name = "dgvshow";
            this.dgvshow.RowTemplate.Height = 23;
            this.dgvshow.Size = new System.Drawing.Size(544, 150);
            this.dgvshow.TabIndex = 3;
            // 
            // EmpID
            // 
            this.EmpID.DataPropertyName = "EmpID";
            this.EmpID.HeaderText = "编号";
            this.EmpID.Name = "EmpID";
            // 
            // EmpName
            // 
            this.EmpName.DataPropertyName = "EmpName";
            this.EmpName.HeaderText = "姓名";
            this.EmpName.Name = "EmpName";
            // 
            // deptName
            // 
            this.deptName.DataPropertyName = "deptName";
            this.deptName.HeaderText = "部门";
            this.deptName.Name = "deptName";
            // 
            // EmpBirthday
            // 
            this.EmpBirthday.DataPropertyName = "EmpBirthday";
            this.EmpBirthday.HeaderText = "出生年月";
            this.EmpBirthday.Name = "EmpBirthday";
            // 
            // Empphone
            // 
            this.Empphone.DataPropertyName = "Empphone";
            this.Empphone.HeaderText = "手机";
            this.Empphone.Name = "Empphone";
            // 
            // grpshow
            // 
            this.grpshow.Controls.Add(this.txtEmpphone);
            this.grpshow.Controls.Add(this.lblEmpphone);
            this.grpshow.Controls.Add(this.txtEmpBirthday);
            this.grpshow.Controls.Add(this.lblEmpBirthday);
            this.grpshow.Controls.Add(this.cmbdeptName);
            this.grpshow.Controls.Add(this.lbldeptName);
            this.grpshow.Controls.Add(this.txtname);
            this.grpshow.Controls.Add(this.lblname);
            this.grpshow.Controls.Add(this.txtEmpID);
            this.grpshow.Controls.Add(this.lblEmpID);
            this.grpshow.Location = new System.Drawing.Point(25, 209);
            this.grpshow.Name = "grpshow";
            this.grpshow.Size = new System.Drawing.Size(591, 100);
            this.grpshow.TabIndex = 4;
            this.grpshow.TabStop = false;
            this.grpshow.Text = "员工管理";
            // 
            // lblEmpID
            // 
            this.lblEmpID.AutoSize = true;
            this.lblEmpID.Location = new System.Drawing.Point(6, 28);
            this.lblEmpID.Name = "lblEmpID";
            this.lblEmpID.Size = new System.Drawing.Size(59, 12);
            this.lblEmpID.TabIndex = 0;
            this.lblEmpID.Text = "员工编号:";
            // 
            // txtEmpID
            // 
            this.txtEmpID.Location = new System.Drawing.Point(72, 18);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.ReadOnly = true;
            this.txtEmpID.Size = new System.Drawing.Size(100, 21);
            this.txtEmpID.TabIndex = 1;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(189, 27);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(59, 12);
            this.lblname.TabIndex = 2;
            this.lblname.Text = "员工姓名:";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(254, 20);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 21);
            this.txtname.TabIndex = 3;
            // 
            // lbldeptName
            // 
            this.lbldeptName.AutoSize = true;
            this.lbldeptName.Location = new System.Drawing.Point(374, 27);
            this.lbldeptName.Name = "lbldeptName";
            this.lbldeptName.Size = new System.Drawing.Size(59, 12);
            this.lbldeptName.TabIndex = 4;
            this.lbldeptName.Text = "部门名称:";
            // 
            // cmbdeptName
            // 
            this.cmbdeptName.FormattingEnabled = true;
            this.cmbdeptName.Items.AddRange(new object[] {
            "财务部",
            "销售部",
            "技术部"});
            this.cmbdeptName.Location = new System.Drawing.Point(440, 20);
            this.cmbdeptName.Name = "cmbdeptName";
            this.cmbdeptName.Size = new System.Drawing.Size(121, 20);
            this.cmbdeptName.TabIndex = 5;
            // 
            // lblEmpBirthday
            // 
            this.lblEmpBirthday.AutoSize = true;
            this.lblEmpBirthday.Location = new System.Drawing.Point(8, 60);
            this.lblEmpBirthday.Name = "lblEmpBirthday";
            this.lblEmpBirthday.Size = new System.Drawing.Size(59, 12);
            this.lblEmpBirthday.TabIndex = 6;
            this.lblEmpBirthday.Text = "出生年月:";
            // 
            // txtEmpBirthday
            // 
            this.txtEmpBirthday.Location = new System.Drawing.Point(72, 50);
            this.txtEmpBirthday.Name = "txtEmpBirthday";
            this.txtEmpBirthday.Size = new System.Drawing.Size(100, 21);
            this.txtEmpBirthday.TabIndex = 7;
            // 
            // lblEmpphone
            // 
            this.lblEmpphone.AutoSize = true;
            this.lblEmpphone.Location = new System.Drawing.Point(191, 58);
            this.lblEmpphone.Name = "lblEmpphone";
            this.lblEmpphone.Size = new System.Drawing.Size(47, 12);
            this.lblEmpphone.TabIndex = 8;
            this.lblEmpphone.Text = "手机号:";
            // 
            // txtEmpphone
            // 
            this.txtEmpphone.Location = new System.Drawing.Point(254, 51);
            this.txtEmpphone.Name = "txtEmpphone";
            this.txtEmpphone.Size = new System.Drawing.Size(100, 21);
            this.txtEmpphone.TabIndex = 9;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(78, 331);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 5;
            this.btnadd.Text = "添加";
            this.btnadd.UseVisualStyleBackColor = true;
            // 
            // btnxg
            // 
            this.btnxg.Location = new System.Drawing.Point(218, 330);
            this.btnxg.Name = "btnxg";
            this.btnxg.Size = new System.Drawing.Size(75, 23);
            this.btnxg.TabIndex = 6;
            this.btnxg.Text = "修改";
            this.btnxg.UseVisualStyleBackColor = true;
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(369, 330);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 7;
            this.btndelete.Text = "删除";
            this.btndelete.UseVisualStyleBackColor = true;
            // 
            // btnno
            // 
            this.btnno.Location = new System.Drawing.Point(511, 330);
            this.btnno.Name = "btnno";
            this.btnno.Size = new System.Drawing.Size(75, 23);
            this.btnno.TabIndex = 8;
            this.btnno.Text = "退出";
            this.btnno.UseVisualStyleBackColor = true;
            this.btnno.Click += new System.EventHandler(this.btnno_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 366);
            this.Controls.Add(this.btnno);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnxg);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.grpshow);
            this.Controls.Add(this.dgvshow);
            this.Controls.Add(this.btnempname);
            this.Controls.Add(this.txtempname);
            this.Controls.Add(this.lblempname);
            this.Name = "Form1";
            this.Text = "员工信息管理";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvshow)).EndInit();
            this.grpshow.ResumeLayout(false);
            this.grpshow.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblempname;
        private System.Windows.Forms.TextBox txtempname;
        private System.Windows.Forms.Button btnempname;
        private System.Windows.Forms.DataGridView dgvshow;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn deptName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpBirthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empphone;
        private System.Windows.Forms.GroupBox grpshow;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.TextBox txtEmpID;
        private System.Windows.Forms.Label lblEmpID;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lbldeptName;
        private System.Windows.Forms.ComboBox cmbdeptName;
        private System.Windows.Forms.Label lblEmpBirthday;
        private System.Windows.Forms.TextBox txtEmpBirthday;
        private System.Windows.Forms.Label lblEmpphone;
        private System.Windows.Forms.TextBox txtEmpphone;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnxg;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnno;
    }
}

