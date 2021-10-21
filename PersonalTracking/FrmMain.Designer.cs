namespace PersonalTracking
{
    partial class FrmMain
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
            this.txtEmployee = new System.Windows.Forms.Button();
            this.btnTask = new System.Windows.Forms.Button();
            this.btnSalary = new System.Windows.Forms.Button();
            this.btnPermission = new System.Windows.Forms.Button();
            this.btnDepartment = new System.Windows.Forms.Button();
            this.btnPosition = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEmployee
            // 
            this.txtEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployee.Image = global::PersonalTracking.Properties.Resources.management;
            this.txtEmployee.Location = new System.Drawing.Point(1, 27);
            this.txtEmployee.Name = "txtEmployee";
            this.txtEmployee.Size = new System.Drawing.Size(195, 101);
            this.txtEmployee.TabIndex = 0;
            this.txtEmployee.Text = "Employee";
            this.txtEmployee.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.txtEmployee.UseVisualStyleBackColor = false;
            this.txtEmployee.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnTask
            // 
            this.btnTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTask.Image = global::PersonalTracking.Properties.Resources.workspace;
            this.btnTask.Location = new System.Drawing.Point(221, 27);
            this.btnTask.Name = "btnTask";
            this.btnTask.Size = new System.Drawing.Size(169, 101);
            this.btnTask.TabIndex = 1;
            this.btnTask.Text = "Tasks";
            this.btnTask.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTask.UseVisualStyleBackColor = false;
            this.btnTask.Click += new System.EventHandler(this.BtnTask_Click);
            // 
            // btnSalary
            // 
            this.btnSalary.BackColor = System.Drawing.Color.Lime;
            this.btnSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalary.Image = global::PersonalTracking.Properties.Resources.give_money;
            this.btnSalary.Location = new System.Drawing.Point(413, 27);
            this.btnSalary.Name = "btnSalary";
            this.btnSalary.Size = new System.Drawing.Size(169, 101);
            this.btnSalary.TabIndex = 2;
            this.btnSalary.Text = "Salary";
            this.btnSalary.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalary.UseVisualStyleBackColor = false;
            this.btnSalary.Click += new System.EventHandler(this.BtnSalary_Click);
            // 
            // btnPermission
            // 
            this.btnPermission.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnPermission.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPermission.Image = global::PersonalTracking.Properties.Resources.management;
            this.btnPermission.Location = new System.Drawing.Point(12, 157);
            this.btnPermission.Name = "btnPermission";
            this.btnPermission.Size = new System.Drawing.Size(169, 101);
            this.btnPermission.TabIndex = 3;
            this.btnPermission.Text = "Permission";
            this.btnPermission.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPermission.UseVisualStyleBackColor = false;
            this.btnPermission.Click += new System.EventHandler(this.BtnPermission_Click);
            // 
            // btnDepartment
            // 
            this.btnDepartment.BackColor = System.Drawing.Color.Yellow;
            this.btnDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepartment.Image = global::PersonalTracking.Properties.Resources.organization;
            this.btnDepartment.Location = new System.Drawing.Point(221, 157);
            this.btnDepartment.Name = "btnDepartment";
            this.btnDepartment.Size = new System.Drawing.Size(169, 101);
            this.btnDepartment.TabIndex = 4;
            this.btnDepartment.Text = "Department";
            this.btnDepartment.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDepartment.UseVisualStyleBackColor = false;
            this.btnDepartment.Click += new System.EventHandler(this.BtnDepartment_Click);
            // 
            // btnPosition
            // 
            this.btnPosition.BackColor = System.Drawing.Color.Yellow;
            this.btnPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPosition.Image = global::PersonalTracking.Properties.Resources.medal;
            this.btnPosition.Location = new System.Drawing.Point(413, 157);
            this.btnPosition.Name = "btnPosition";
            this.btnPosition.Size = new System.Drawing.Size(169, 101);
            this.btnPosition.TabIndex = 5;
            this.btnPosition.Text = "Position";
            this.btnPosition.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPosition.UseVisualStyleBackColor = false;
            this.btnPosition.Click += new System.EventHandler(this.BtnPosition_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Yellow;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Image = global::PersonalTracking.Properties.Resources.logout;
            this.btnLogout.Location = new System.Drawing.Point(12, 296);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(169, 101);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "LogOut";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Image = global::PersonalTracking.Properties.Resources.exit;
            this.btnExit.Location = new System.Drawing.Point(221, 296);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(169, 101);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnPosition);
            this.Controls.Add(this.btnDepartment);
            this.Controls.Add(this.btnPermission);
            this.Controls.Add(this.btnSalary);
            this.Controls.Add(this.btnTask);
            this.Controls.Add(this.txtEmployee);
            this.Name = "FrmMain";
            this.Text = "Employee Tracking";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button txtEmployee;
        private System.Windows.Forms.Button btnTask;
        private System.Windows.Forms.Button btnSalary;
        private System.Windows.Forms.Button btnPermission;
        private System.Windows.Forms.Button btnDepartment;
        private System.Windows.Forms.Button btnPosition;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnExit;
    }
}