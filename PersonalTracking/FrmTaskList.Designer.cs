namespace PersonalTracking
{
    partial class FrmTaskList
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmbTaskState = new System.Windows.Forms.ComboBox();
            this.lblTaskState = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoDeliveryDate = new System.Windows.Forms.RadioButton();
            this.rbtnStartDate = new System.Windows.Forms.RadioButton();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblFinishDate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblTaskDate = new System.Windows.Forms.Label();
            this.pnelForAdmin = new System.Windows.Forms.Panel();
            this.cmbPosition = new System.Windows.Forms.ComboBox();
            this.llbSurname = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDepartment = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtUserNo = new System.Windows.Forms.TextBox();
            this.cmpDepartment = new System.Windows.Forms.ComboBox();
            this.lblUsrNo = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnApprove = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnelForAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.pnelForAdmin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 232);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnClear);
            this.panel3.Controls.Add(this.btnSearch);
            this.panel3.Controls.Add(this.cmbTaskState);
            this.panel3.Controls.Add(this.lblTaskState);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.dateTimePicker2);
            this.panel3.Controls.Add(this.dateTimePicker1);
            this.panel3.Controls.Add(this.lblFinishDate);
            this.panel3.Controls.Add(this.lblStartDate);
            this.panel3.Controls.Add(this.lblTaskDate);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(409, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(575, 232);
            this.panel3.TabIndex = 1;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel3_Paint);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(148, 183);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(111, 43);
            this.btnClear.TabIndex = 27;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(15, 183);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(111, 43);
            this.btnSearch.TabIndex = 26;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // cmbTaskState
            // 
            this.cmbTaskState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTaskState.FormattingEnabled = true;
            this.cmbTaskState.Location = new System.Drawing.Point(123, 129);
            this.cmbTaskState.Name = "cmbTaskState";
            this.cmbTaskState.Size = new System.Drawing.Size(173, 28);
            this.cmbTaskState.TabIndex = 25;
            // 
            // lblTaskState
            // 
            this.lblTaskState.AutoSize = true;
            this.lblTaskState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskState.Location = new System.Drawing.Point(11, 132);
            this.lblTaskState.Name = "lblTaskState";
            this.lblTaskState.Size = new System.Drawing.Size(96, 20);
            this.lblTaskState.TabIndex = 24;
            this.lblTaskState.Text = "Task State";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoDeliveryDate);
            this.groupBox1.Controls.Add(this.rbtnStartDate);
            this.groupBox1.Location = new System.Drawing.Point(368, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // rdoDeliveryDate
            // 
            this.rdoDeliveryDate.AutoSize = true;
            this.rdoDeliveryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoDeliveryDate.Location = new System.Drawing.Point(24, 44);
            this.rdoDeliveryDate.Name = "rdoDeliveryDate";
            this.rdoDeliveryDate.Size = new System.Drawing.Size(124, 21);
            this.rdoDeliveryDate.TabIndex = 1;
            this.rdoDeliveryDate.TabStop = true;
            this.rdoDeliveryDate.Text = "Delivery Date";
            this.rdoDeliveryDate.UseVisualStyleBackColor = true;
            // 
            // rbtnStartDate
            // 
            this.rbtnStartDate.AutoSize = true;
            this.rbtnStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnStartDate.Location = new System.Drawing.Point(24, 19);
            this.rbtnStartDate.Name = "rbtnStartDate";
            this.rbtnStartDate.Size = new System.Drawing.Size(100, 21);
            this.rbtnStartDate.TabIndex = 0;
            this.rbtnStartDate.TabStop = true;
            this.rbtnStartDate.Text = "Start Date";
            this.rbtnStartDate.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(96, 84);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(174, 20);
            this.dateTimePicker2.TabIndex = 13;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(96, 39);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(174, 20);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // lblFinishDate
            // 
            this.lblFinishDate.AutoSize = true;
            this.lblFinishDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinishDate.Location = new System.Drawing.Point(11, 85);
            this.lblFinishDate.Name = "lblFinishDate";
            this.lblFinishDate.Size = new System.Drawing.Size(62, 20);
            this.lblFinishDate.TabIndex = 11;
            this.lblFinishDate.Text = "Finish ";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(11, 40);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(49, 20);
            this.lblStartDate.TabIndex = 10;
            this.lblStartDate.Text = "Start";
            // 
            // lblTaskDate
            // 
            this.lblTaskDate.AutoSize = true;
            this.lblTaskDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskDate.Location = new System.Drawing.Point(3, 9);
            this.lblTaskDate.Name = "lblTaskDate";
            this.lblTaskDate.Size = new System.Drawing.Size(91, 20);
            this.lblTaskDate.TabIndex = 9;
            this.lblTaskDate.Text = "Task Date";
            // 
            // pnelForAdmin
            // 
            this.pnelForAdmin.Controls.Add(this.cmbPosition);
            this.pnelForAdmin.Controls.Add(this.llbSurname);
            this.pnelForAdmin.Controls.Add(this.lblPosition);
            this.pnelForAdmin.Controls.Add(this.txtSurname);
            this.pnelForAdmin.Controls.Add(this.txtName);
            this.pnelForAdmin.Controls.Add(this.txtDepartment);
            this.pnelForAdmin.Controls.Add(this.lblName);
            this.pnelForAdmin.Controls.Add(this.txtUserNo);
            this.pnelForAdmin.Controls.Add(this.cmpDepartment);
            this.pnelForAdmin.Controls.Add(this.lblUsrNo);
            this.pnelForAdmin.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnelForAdmin.Location = new System.Drawing.Point(0, 0);
            this.pnelForAdmin.Name = "pnelForAdmin";
            this.pnelForAdmin.Size = new System.Drawing.Size(409, 232);
            this.pnelForAdmin.TabIndex = 0;
            this.pnelForAdmin.Paint += new System.Windows.Forms.PaintEventHandler(this.PnelForAdmin_Paint);
            // 
            // cmbPosition
            // 
            this.cmbPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPosition.FormattingEnabled = true;
            this.cmbPosition.Location = new System.Drawing.Point(128, 150);
            this.cmbPosition.Name = "cmbPosition";
            this.cmbPosition.Size = new System.Drawing.Size(215, 28);
            this.cmbPosition.TabIndex = 23;
            // 
            // llbSurname
            // 
            this.llbSurname.AutoSize = true;
            this.llbSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbSurname.Location = new System.Drawing.Point(8, 82);
            this.llbSurname.Name = "llbSurname";
            this.llbSurname.Size = new System.Drawing.Size(81, 20);
            this.llbSurname.TabIndex = 13;
            this.llbSurname.Text = "Surname";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.Location = new System.Drawing.Point(8, 150);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(73, 20);
            this.lblPosition.TabIndex = 22;
            this.lblPosition.Text = "Position";
            // 
            // txtSurname
            // 
            this.txtSurname.CausesValidation = false;
            this.txtSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurname.Location = new System.Drawing.Point(128, 79);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(215, 26);
            this.txtSurname.TabIndex = 12;
            // 
            // txtName
            // 
            this.txtName.CausesValidation = false;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(128, 50);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(215, 26);
            this.txtName.TabIndex = 11;
            // 
            // txtDepartment
            // 
            this.txtDepartment.AutoSize = true;
            this.txtDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartment.Location = new System.Drawing.Point(3, 116);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(104, 20);
            this.txtDepartment.TabIndex = 20;
            this.txtDepartment.Text = "Department";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(8, 49);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 20);
            this.lblName.TabIndex = 10;
            this.lblName.Text = "Name";
            // 
            // txtUserNo
            // 
            this.txtUserNo.CausesValidation = false;
            this.txtUserNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserNo.Location = new System.Drawing.Point(128, 17);
            this.txtUserNo.Name = "txtUserNo";
            this.txtUserNo.Size = new System.Drawing.Size(215, 26);
            this.txtUserNo.TabIndex = 9;
            this.txtUserNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtUserNo_KeyPress);
            // 
            // cmpDepartment
            // 
            this.cmpDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmpDepartment.FormattingEnabled = true;
            this.cmpDepartment.Location = new System.Drawing.Point(128, 114);
            this.cmpDepartment.Name = "cmpDepartment";
            this.cmpDepartment.Size = new System.Drawing.Size(215, 28);
            this.cmpDepartment.TabIndex = 21;
            // 
            // lblUsrNo
            // 
            this.lblUsrNo.AutoSize = true;
            this.lblUsrNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsrNo.Location = new System.Drawing.Point(8, 17);
            this.lblUsrNo.Name = "lblUsrNo";
            this.lblUsrNo.Size = new System.Drawing.Size(69, 20);
            this.lblUsrNo.TabIndex = 8;
            this.lblUsrNo.Text = "UserNo";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 232);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(984, 257);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnApprove);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.btnNew);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 489);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(984, 209);
            this.panel2.TabIndex = 2;
            // 
            // btnApprove
            // 
            this.btnApprove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApprove.Location = new System.Drawing.Point(12, 24);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(111, 43);
            this.btnApprove.TabIndex = 16;
            this.btnApprove.Text = "Approve";
            this.btnApprove.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(448, 24);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 43);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(346, 24);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(83, 43);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(245, 24);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(80, 43);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(128, 24);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(111, 43);
            this.btnNew.TabIndex = 12;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // FrmTaskList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 570);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmTaskList";
            this.Text = "Task List";
            this.Load += new System.EventHandler(this.FrmTaskList_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnelForAdmin.ResumeLayout(false);
            this.pnelForAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnelForAdmin;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label llbSurname;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtUserNo;
        private System.Windows.Forms.Label lblUsrNo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoDeliveryDate;
        private System.Windows.Forms.RadioButton rbtnStartDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblFinishDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblTaskDate;
        private System.Windows.Forms.Label txtDepartment;
        private System.Windows.Forms.ComboBox cmpDepartment;
        private System.Windows.Forms.ComboBox cmbPosition;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.ComboBox cmbTaskState;
        private System.Windows.Forms.Label lblTaskState;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
    }
}