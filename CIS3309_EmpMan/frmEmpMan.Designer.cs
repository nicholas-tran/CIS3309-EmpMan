namespace CIS3309_EmpMan
{
    partial class frmEmpMan
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCreateDesc = new System.Windows.Forms.Label();
            this.btnCreateWorker = new System.Windows.Forms.Button();
            this.btnCreateManager = new System.Windows.Forms.Button();
            this.btnCreateClient = new System.Windows.Forms.Button();
            this.lblControlsDesc = new System.Windows.Forms.Label();
            this.btnClearEntryForm = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtControlWorkerHourlyPay = new System.Windows.Forms.TextBox();
            this.lblControlWorkerHourlyPay = new System.Windows.Forms.Label();
            this.lblControlWorker = new System.Windows.Forms.Label();
            this.txtControlManagerBonus = new System.Windows.Forms.TextBox();
            this.lblControlManagerBonus = new System.Windows.Forms.Label();
            this.txtControlManagerSalary = new System.Windows.Forms.TextBox();
            this.lblControlManagerSalary = new System.Windows.Forms.Label();
            this.lblControlManager = new System.Windows.Forms.Label();
            this.txtControlEmployeeJobTitle = new System.Windows.Forms.TextBox();
            this.lblControlEmployeeJobTitle = new System.Windows.Forms.Label();
            this.lblControlEmployee = new System.Windows.Forms.Label();
            this.txtControlClientType = new System.Windows.Forms.TextBox();
            this.lblControlClientType = new System.Windows.Forms.Label();
            this.lblControlClient = new System.Windows.Forms.Label();
            this.txtControlPersonBirthDate = new System.Windows.Forms.TextBox();
            this.lblControlPersonBirthDate = new System.Windows.Forms.Label();
            this.txtControlPersonName = new System.Windows.Forms.TextBox();
            this.lblControlPersonName = new System.Windows.Forms.Label();
            this.txtControlPersonID = new System.Windows.Forms.TextBox();
            this.lblControlPersonID = new System.Windows.Forms.Label();
            this.lblControlPerson = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEditUpdate = new System.Windows.Forms.Button();
            this.btnFindDisplay = new System.Windows.Forms.Button();
            this.grpCreate = new System.Windows.Forms.GroupBox();
            this.grpControl = new System.Windows.Forms.GroupBox();
            this.grpOptions = new System.Windows.Forms.GroupBox();
            this.txtControlSearchID = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.grpCreate.SuspendLayout();
            this.grpControl.SuspendLayout();
            this.grpOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(267, 11);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(303, 17);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Data Entry and Display for SamLia Corporation";
            // 
            // lblCreateDesc
            // 
            this.lblCreateDesc.AutoSize = true;
            this.lblCreateDesc.Location = new System.Drawing.Point(16, 52);
            this.lblCreateDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCreateDesc.Name = "lblCreateDesc";
            this.lblCreateDesc.Size = new System.Drawing.Size(297, 34);
            this.lblCreateDesc.TabIndex = 1;
            this.lblCreateDesc.Text = "To CREATE a new client, manager or worker, \r\nalways press the button below before" +
    " typing.";
            // 
            // btnCreateWorker
            // 
            this.btnCreateWorker.Location = new System.Drawing.Point(302, 123);
            this.btnCreateWorker.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateWorker.Name = "btnCreateWorker";
            this.btnCreateWorker.Size = new System.Drawing.Size(133, 28);
            this.btnCreateWorker.TabIndex = 2;
            this.btnCreateWorker.Text = "Create Worker";
            this.btnCreateWorker.UseVisualStyleBackColor = true;
            this.btnCreateWorker.Click += new System.EventHandler(this.btnCreateWorker_Click);
            // 
            // btnCreateManager
            // 
            this.btnCreateManager.Location = new System.Drawing.Point(149, 28);
            this.btnCreateManager.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateManager.Name = "btnCreateManager";
            this.btnCreateManager.Size = new System.Drawing.Size(133, 28);
            this.btnCreateManager.TabIndex = 1;
            this.btnCreateManager.Text = "Create Manager";
            this.btnCreateManager.UseVisualStyleBackColor = true;
            this.btnCreateManager.Click += new System.EventHandler(this.btnCreateManager_Click);
            // 
            // btnCreateClient
            // 
            this.btnCreateClient.Location = new System.Drawing.Point(8, 28);
            this.btnCreateClient.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateClient.Name = "btnCreateClient";
            this.btnCreateClient.Size = new System.Drawing.Size(133, 28);
            this.btnCreateClient.TabIndex = 0;
            this.btnCreateClient.Text = "Create Client";
            this.btnCreateClient.UseVisualStyleBackColor = true;
            this.btnCreateClient.Click += new System.EventHandler(this.btnCreateClient_Click);
            // 
            // lblControlsDesc
            // 
            this.lblControlsDesc.AutoSize = true;
            this.lblControlsDesc.Location = new System.Drawing.Point(479, 44);
            this.lblControlsDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblControlsDesc.Name = "lblControlsDesc";
            this.lblControlsDesc.Size = new System.Drawing.Size(356, 34);
            this.lblControlsDesc.TabIndex = 4;
            this.lblControlsDesc.Text = "To Find/SEARCH, Edit/UPDATE or DELETE, \r\nenter person ID and Select appropiate co" +
    "ntrol at below.";
            // 
            // btnClearEntryForm
            // 
            this.btnClearEntryForm.Location = new System.Drawing.Point(696, 222);
            this.btnClearEntryForm.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearEntryForm.Name = "btnClearEntryForm";
            this.btnClearEntryForm.Size = new System.Drawing.Size(100, 43);
            this.btnClearEntryForm.TabIndex = 5;
            this.btnClearEntryForm.Text = "Clear Form Entries";
            this.btnClearEntryForm.UseVisualStyleBackColor = true;
            this.btnClearEntryForm.Click += new System.EventHandler(this.btnClearEntryForm_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(696, 479);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 43);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtControlWorkerHourlyPay
            // 
            this.txtControlWorkerHourlyPay.Location = new System.Drawing.Point(413, 297);
            this.txtControlWorkerHourlyPay.Margin = new System.Windows.Forms.Padding(4);
            this.txtControlWorkerHourlyPay.MaxLength = 15;
            this.txtControlWorkerHourlyPay.Name = "txtControlWorkerHourlyPay";
            this.txtControlWorkerHourlyPay.Size = new System.Drawing.Size(140, 22);
            this.txtControlWorkerHourlyPay.TabIndex = 20;
            // 
            // lblControlWorkerHourlyPay
            // 
            this.lblControlWorkerHourlyPay.AutoSize = true;
            this.lblControlWorkerHourlyPay.Location = new System.Drawing.Point(328, 300);
            this.lblControlWorkerHourlyPay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblControlWorkerHourlyPay.Name = "lblControlWorkerHourlyPay";
            this.lblControlWorkerHourlyPay.Size = new System.Drawing.Size(77, 17);
            this.lblControlWorkerHourlyPay.TabIndex = 19;
            this.lblControlWorkerHourlyPay.Text = "Hourly Pay";
            // 
            // lblControlWorker
            // 
            this.lblControlWorker.AutoSize = true;
            this.lblControlWorker.Location = new System.Drawing.Point(309, 266);
            this.lblControlWorker.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblControlWorker.Name = "lblControlWorker";
            this.lblControlWorker.Size = new System.Drawing.Size(54, 17);
            this.lblControlWorker.TabIndex = 18;
            this.lblControlWorker.Text = "Worker";
            // 
            // txtControlManagerBonus
            // 
            this.txtControlManagerBonus.Location = new System.Drawing.Point(109, 329);
            this.txtControlManagerBonus.Margin = new System.Windows.Forms.Padding(4);
            this.txtControlManagerBonus.MaxLength = 15;
            this.txtControlManagerBonus.Name = "txtControlManagerBonus";
            this.txtControlManagerBonus.Size = new System.Drawing.Size(140, 22);
            this.txtControlManagerBonus.TabIndex = 17;
            // 
            // lblControlManagerBonus
            // 
            this.lblControlManagerBonus.AutoSize = true;
            this.lblControlManagerBonus.Location = new System.Drawing.Point(31, 332);
            this.lblControlManagerBonus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblControlManagerBonus.Name = "lblControlManagerBonus";
            this.lblControlManagerBonus.Size = new System.Drawing.Size(48, 17);
            this.lblControlManagerBonus.TabIndex = 16;
            this.lblControlManagerBonus.Text = "Bonus";
            // 
            // txtControlManagerSalary
            // 
            this.txtControlManagerSalary.Location = new System.Drawing.Point(109, 297);
            this.txtControlManagerSalary.Margin = new System.Windows.Forms.Padding(4);
            this.txtControlManagerSalary.MaxLength = 15;
            this.txtControlManagerSalary.Name = "txtControlManagerSalary";
            this.txtControlManagerSalary.Size = new System.Drawing.Size(140, 22);
            this.txtControlManagerSalary.TabIndex = 15;
            // 
            // lblControlManagerSalary
            // 
            this.lblControlManagerSalary.AutoSize = true;
            this.lblControlManagerSalary.Location = new System.Drawing.Point(31, 300);
            this.lblControlManagerSalary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblControlManagerSalary.Name = "lblControlManagerSalary";
            this.lblControlManagerSalary.Size = new System.Drawing.Size(48, 17);
            this.lblControlManagerSalary.TabIndex = 14;
            this.lblControlManagerSalary.Text = "Salary";
            // 
            // lblControlManager
            // 
            this.lblControlManager.AutoSize = true;
            this.lblControlManager.Location = new System.Drawing.Point(20, 266);
            this.lblControlManager.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblControlManager.Name = "lblControlManager";
            this.lblControlManager.Size = new System.Drawing.Size(64, 17);
            this.lblControlManager.TabIndex = 13;
            this.lblControlManager.Text = "Manager";
            // 
            // txtControlEmployeeJobTitle
            // 
            this.txtControlEmployeeJobTitle.Location = new System.Drawing.Point(109, 209);
            this.txtControlEmployeeJobTitle.Margin = new System.Windows.Forms.Padding(4);
            this.txtControlEmployeeJobTitle.MaxLength = 50;
            this.txtControlEmployeeJobTitle.Name = "txtControlEmployeeJobTitle";
            this.txtControlEmployeeJobTitle.Size = new System.Drawing.Size(281, 22);
            this.txtControlEmployeeJobTitle.TabIndex = 12;
            // 
            // lblControlEmployeeJobTitle
            // 
            this.lblControlEmployeeJobTitle.AutoSize = true;
            this.lblControlEmployeeJobTitle.Location = new System.Drawing.Point(31, 213);
            this.lblControlEmployeeJobTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblControlEmployeeJobTitle.Name = "lblControlEmployeeJobTitle";
            this.lblControlEmployeeJobTitle.Size = new System.Drawing.Size(62, 17);
            this.lblControlEmployeeJobTitle.TabIndex = 11;
            this.lblControlEmployeeJobTitle.Text = "Job Title";
            // 
            // lblControlEmployee
            // 
            this.lblControlEmployee.AutoSize = true;
            this.lblControlEmployee.Location = new System.Drawing.Point(20, 178);
            this.lblControlEmployee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblControlEmployee.Name = "lblControlEmployee";
            this.lblControlEmployee.Size = new System.Drawing.Size(70, 17);
            this.lblControlEmployee.TabIndex = 10;
            this.lblControlEmployee.Text = "Employee";
            // 
            // txtControlClientType
            // 
            this.txtControlClientType.Location = new System.Drawing.Point(104, 130);
            this.txtControlClientType.Margin = new System.Windows.Forms.Padding(4);
            this.txtControlClientType.MaxLength = 30;
            this.txtControlClientType.Name = "txtControlClientType";
            this.txtControlClientType.Size = new System.Drawing.Size(132, 22);
            this.txtControlClientType.TabIndex = 9;
            // 
            // lblControlClientType
            // 
            this.lblControlClientType.AutoSize = true;
            this.lblControlClientType.Location = new System.Drawing.Point(31, 134);
            this.lblControlClientType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblControlClientType.Name = "lblControlClientType";
            this.lblControlClientType.Size = new System.Drawing.Size(40, 17);
            this.lblControlClientType.TabIndex = 8;
            this.lblControlClientType.Text = "Type";
            // 
            // lblControlClient
            // 
            this.lblControlClient.AutoSize = true;
            this.lblControlClient.Location = new System.Drawing.Point(20, 100);
            this.lblControlClient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblControlClient.Name = "lblControlClient";
            this.lblControlClient.Size = new System.Drawing.Size(43, 17);
            this.lblControlClient.TabIndex = 7;
            this.lblControlClient.Text = "Client";
            // 
            // txtControlPersonBirthDate
            // 
            this.txtControlPersonBirthDate.Location = new System.Drawing.Point(509, 58);
            this.txtControlPersonBirthDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtControlPersonBirthDate.MaxLength = 10;
            this.txtControlPersonBirthDate.Name = "txtControlPersonBirthDate";
            this.txtControlPersonBirthDate.Size = new System.Drawing.Size(132, 22);
            this.txtControlPersonBirthDate.TabIndex = 6;
            // 
            // lblControlPersonBirthDate
            // 
            this.lblControlPersonBirthDate.AutoSize = true;
            this.lblControlPersonBirthDate.Location = new System.Drawing.Point(429, 62);
            this.lblControlPersonBirthDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblControlPersonBirthDate.Name = "lblControlPersonBirthDate";
            this.lblControlPersonBirthDate.Size = new System.Drawing.Size(71, 17);
            this.lblControlPersonBirthDate.TabIndex = 5;
            this.lblControlPersonBirthDate.Text = "Birth Date";
            // 
            // txtControlPersonName
            // 
            this.txtControlPersonName.Location = new System.Drawing.Point(295, 58);
            this.txtControlPersonName.Margin = new System.Windows.Forms.Padding(4);
            this.txtControlPersonName.MaxLength = 30;
            this.txtControlPersonName.Name = "txtControlPersonName";
            this.txtControlPersonName.Size = new System.Drawing.Size(132, 22);
            this.txtControlPersonName.TabIndex = 4;
            // 
            // lblControlPersonName
            // 
            this.lblControlPersonName.AutoSize = true;
            this.lblControlPersonName.Location = new System.Drawing.Point(240, 62);
            this.lblControlPersonName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblControlPersonName.Name = "lblControlPersonName";
            this.lblControlPersonName.Size = new System.Drawing.Size(45, 17);
            this.lblControlPersonName.TabIndex = 3;
            this.lblControlPersonName.Text = "Name";
            // 
            // txtControlPersonID
            // 
            this.txtControlPersonID.Location = new System.Drawing.Point(104, 58);
            this.txtControlPersonID.Margin = new System.Windows.Forms.Padding(4);
            this.txtControlPersonID.MaxLength = 5;
            this.txtControlPersonID.Name = "txtControlPersonID";
            this.txtControlPersonID.Size = new System.Drawing.Size(132, 22);
            this.txtControlPersonID.TabIndex = 2;
            // 
            // lblControlPersonID
            // 
            this.lblControlPersonID.AutoSize = true;
            this.lblControlPersonID.Location = new System.Drawing.Point(31, 62);
            this.lblControlPersonID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblControlPersonID.Name = "lblControlPersonID";
            this.lblControlPersonID.Size = new System.Drawing.Size(21, 17);
            this.lblControlPersonID.TabIndex = 1;
            this.lblControlPersonID.Text = "ID";
            // 
            // lblControlPerson
            // 
            this.lblControlPerson.AutoSize = true;
            this.lblControlPerson.Location = new System.Drawing.Point(16, 28);
            this.lblControlPerson.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblControlPerson.Name = "lblControlPerson";
            this.lblControlPerson.Size = new System.Drawing.Size(53, 17);
            this.lblControlPerson.TabIndex = 0;
            this.lblControlPerson.Text = "Person";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(232, 37);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 28);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEditUpdate
            // 
            this.btnEditUpdate.Location = new System.Drawing.Point(124, 37);
            this.btnEditUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditUpdate.Name = "btnEditUpdate";
            this.btnEditUpdate.Size = new System.Drawing.Size(100, 28);
            this.btnEditUpdate.TabIndex = 1;
            this.btnEditUpdate.Text = "Edit/Update";
            this.btnEditUpdate.UseVisualStyleBackColor = true;
            this.btnEditUpdate.Click += new System.EventHandler(this.btnEditUpdate_Click);
            // 
            // btnFindDisplay
            // 
            this.btnFindDisplay.Location = new System.Drawing.Point(16, 37);
            this.btnFindDisplay.Margin = new System.Windows.Forms.Padding(4);
            this.btnFindDisplay.Name = "btnFindDisplay";
            this.btnFindDisplay.Size = new System.Drawing.Size(100, 28);
            this.btnFindDisplay.TabIndex = 0;
            this.btnFindDisplay.Text = "Find/Display";
            this.btnFindDisplay.UseVisualStyleBackColor = true;
            this.btnFindDisplay.Click += new System.EventHandler(this.btnFindDisplay_Click);
            // 
            // grpCreate
            // 
            this.grpCreate.Controls.Add(this.btnCreateClient);
            this.grpCreate.Controls.Add(this.btnCreateManager);
            this.grpCreate.Location = new System.Drawing.Point(12, 95);
            this.grpCreate.Margin = new System.Windows.Forms.Padding(4);
            this.grpCreate.Name = "grpCreate";
            this.grpCreate.Padding = new System.Windows.Forms.Padding(4);
            this.grpCreate.Size = new System.Drawing.Size(431, 64);
            this.grpCreate.TabIndex = 9;
            this.grpCreate.TabStop = false;
            this.grpCreate.Text = "Controls for Creating a New Entry";
            // 
            // grpControl
            // 
            this.grpControl.Controls.Add(this.txtControlWorkerHourlyPay);
            this.grpControl.Controls.Add(this.lblControlPersonBirthDate);
            this.grpControl.Controls.Add(this.txtControlPersonName);
            this.grpControl.Controls.Add(this.lblControlWorkerHourlyPay);
            this.grpControl.Controls.Add(this.lblControlPersonName);
            this.grpControl.Controls.Add(this.lblControlClient);
            this.grpControl.Controls.Add(this.lblControlWorker);
            this.grpControl.Controls.Add(this.txtControlPersonID);
            this.grpControl.Controls.Add(this.lblControlClientType);
            this.grpControl.Controls.Add(this.txtControlManagerBonus);
            this.grpControl.Controls.Add(this.lblControlPersonID);
            this.grpControl.Controls.Add(this.lblControlManagerBonus);
            this.grpControl.Controls.Add(this.txtControlClientType);
            this.grpControl.Controls.Add(this.lblControlPerson);
            this.grpControl.Controls.Add(this.txtControlManagerSalary);
            this.grpControl.Controls.Add(this.lblControlEmployee);
            this.grpControl.Controls.Add(this.txtControlPersonBirthDate);
            this.grpControl.Controls.Add(this.lblControlManagerSalary);
            this.grpControl.Controls.Add(this.lblControlEmployeeJobTitle);
            this.grpControl.Controls.Add(this.txtControlEmployeeJobTitle);
            this.grpControl.Controls.Add(this.lblControlManager);
            this.grpControl.Location = new System.Drawing.Point(12, 160);
            this.grpControl.Margin = new System.Windows.Forms.Padding(4);
            this.grpControl.Name = "grpControl";
            this.grpControl.Padding = new System.Windows.Forms.Padding(4);
            this.grpControl.Size = new System.Drawing.Size(676, 366);
            this.grpControl.TabIndex = 21;
            this.grpControl.TabStop = false;
            // 
            // grpOptions
            // 
            this.grpOptions.Controls.Add(this.txtControlSearchID);
            this.grpOptions.Controls.Add(this.btnDelete);
            this.grpOptions.Controls.Add(this.btnFindDisplay);
            this.grpOptions.Controls.Add(this.btnEditUpdate);
            this.grpOptions.Location = new System.Drawing.Point(467, 82);
            this.grpOptions.Margin = new System.Windows.Forms.Padding(4);
            this.grpOptions.Name = "grpOptions";
            this.grpOptions.Padding = new System.Windows.Forms.Padding(4);
            this.grpOptions.Size = new System.Drawing.Size(349, 77);
            this.grpOptions.TabIndex = 22;
            this.grpOptions.TabStop = false;
            this.grpOptions.Text = "Form Control for Data Processing";
            // 
            // txtControlSearchID
            // 
            this.txtControlSearchID.Location = new System.Drawing.Point(232, 4);
            this.txtControlSearchID.MaxLength = 5;
            this.txtControlSearchID.Name = "txtControlSearchID";
            this.txtControlSearchID.Size = new System.Drawing.Size(100, 22);
            this.txtControlSearchID.TabIndex = 3;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(696, 166);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(100, 43);
            this.btnOk.TabIndex = 23;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // frmEmpMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 537);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCreateWorker);
            this.Controls.Add(this.grpOptions);
            this.Controls.Add(this.grpControl);
            this.Controls.Add(this.grpCreate);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClearEntryForm);
            this.Controls.Add(this.lblControlsDesc);
            this.Controls.Add(this.lblCreateDesc);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmEmpMan";
            this.Text = "frmEmpMan";
            this.Load += new System.EventHandler(this.frmEmpMan_Load);
            this.grpCreate.ResumeLayout(false);
            this.grpControl.ResumeLayout(false);
            this.grpControl.PerformLayout();
            this.grpOptions.ResumeLayout(false);
            this.grpOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.Label lblCreateDesc;
        public System.Windows.Forms.Label lblControlsDesc;
        public System.Windows.Forms.Button btnClearEntryForm;
        public System.Windows.Forms.Button btnExit;
        public System.Windows.Forms.Button btnCreateWorker;
        public System.Windows.Forms.Button btnCreateManager;
        public System.Windows.Forms.Button btnCreateClient;
        public System.Windows.Forms.TextBox txtControlEmployeeJobTitle;
        public System.Windows.Forms.Label lblControlEmployeeJobTitle;
        public System.Windows.Forms.Label lblControlEmployee;
        public System.Windows.Forms.TextBox txtControlClientType;
        public System.Windows.Forms.Label lblControlClientType;
        public System.Windows.Forms.Label lblControlClient;
        public System.Windows.Forms.TextBox txtControlPersonBirthDate;
        public System.Windows.Forms.Label lblControlPersonBirthDate;
        public System.Windows.Forms.TextBox txtControlPersonName;
        public System.Windows.Forms.Label lblControlPersonName;
        public System.Windows.Forms.TextBox txtControlPersonID;
        public System.Windows.Forms.Label lblControlPersonID;
        public System.Windows.Forms.Label lblControlPerson;
        public System.Windows.Forms.TextBox txtControlWorkerHourlyPay;
        public System.Windows.Forms.Label lblControlWorkerHourlyPay;
        public System.Windows.Forms.Label lblControlWorker;
        public System.Windows.Forms.TextBox txtControlManagerBonus;
        public System.Windows.Forms.Label lblControlManagerBonus;
        public System.Windows.Forms.TextBox txtControlManagerSalary;
        public System.Windows.Forms.Label lblControlManagerSalary;
        public System.Windows.Forms.Label lblControlManager;
        public System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.Button btnEditUpdate;
        public System.Windows.Forms.Button btnFindDisplay;
        public System.Windows.Forms.GroupBox grpCreate;
        public System.Windows.Forms.GroupBox grpControl;
        public System.Windows.Forms.GroupBox grpOptions;
        private System.Windows.Forms.Button btnOk;
        public System.Windows.Forms.TextBox txtControlSearchID;
    }
}

