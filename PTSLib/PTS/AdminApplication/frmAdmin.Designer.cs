namespace AdminApplication
{
    partial class frmAdmin
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
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.welcomeTabPage = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.projectsTabPage = new System.Windows.Forms.TabPage();
            this.projectsTabControl = new System.Windows.Forms.TabControl();
            this.newTabPage = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddProject = new System.Windows.Forms.Button();
            this.cbCustomer = new System.Windows.Forms.ComboBox();
            this.txtProjectEnd = new System.Windows.Forms.TextBox();
            this.txtProjectStart = new System.Windows.Forms.TextBox();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.custLabel = new System.Windows.Forms.Label();
            this.expendLabel = new System.Windows.Forms.Label();
            this.expStrtLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.tasksTabPage = new System.Windows.Forms.TabPage();
            this.exstProjGroupBox = new System.Windows.Forms.GroupBox();
            this.customerlbl = new System.Windows.Forms.Label();
            this.endDatelbl = new System.Windows.Forms.Label();
            this.startDatelbl = new System.Windows.Forms.Label();
            this.customerLabel = new System.Windows.Forms.Label();
            this.expEndLabel2 = new System.Windows.Forms.Label();
            this.expStartLabel = new System.Windows.Forms.Label();
            this.cbProjects = new System.Windows.Forms.ComboBox();
            this.slctprojLabel = new System.Windows.Forms.Label();
            this.tasksGroupBox = new System.Windows.Forms.GroupBox();
            this.lbTasks = new System.Windows.Forms.ListBox();
            this.addTaskGroupBox = new System.Windows.Forms.GroupBox();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.cbTeams = new System.Windows.Forms.ComboBox();
            this.txtTaskEnd = new System.Windows.Forms.TextBox();
            this.txtTaskStart = new System.Windows.Forms.TextBox();
            this.txtTaskName = new System.Windows.Forms.TextBox();
            this.teamlbl = new System.Windows.Forms.Label();
            this.expEndlbl = new System.Windows.Forms.Label();
            this.expStrtlbl = new System.Windows.Forms.Label();
            this.namelbl = new System.Windows.Forms.Label();
            this.mainTabControl.SuspendLayout();
            this.welcomeTabPage.SuspendLayout();
            this.projectsTabPage.SuspendLayout();
            this.projectsTabControl.SuspendLayout();
            this.newTabPage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tasksTabPage.SuspendLayout();
            this.exstProjGroupBox.SuspendLayout();
            this.tasksGroupBox.SuspendLayout();
            this.addTaskGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(109, 30);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 20);
            this.txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(314, 33);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(45, 33);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(58, 13);
            this.usernameLabel.TabIndex = 2;
            this.usernameLabel.Text = "Username:";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(252, 35);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(56, 13);
            this.PasswordLabel.TabIndex = 3;
            this.PasswordLabel.Text = "Password:";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(466, 33);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.welcomeTabPage);
            this.mainTabControl.Controls.Add(this.projectsTabPage);
            this.mainTabControl.Enabled = false;
            this.mainTabControl.Location = new System.Drawing.Point(12, 77);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(690, 430);
            this.mainTabControl.TabIndex = 5;
            this.mainTabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.mainTabControl_Selected);
            // 
            // welcomeTabPage
            // 
            this.welcomeTabPage.Controls.Add(this.label2);
            this.welcomeTabPage.Controls.Add(this.label1);
            this.welcomeTabPage.Location = new System.Drawing.Point(4, 22);
            this.welcomeTabPage.Name = "welcomeTabPage";
            this.welcomeTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.welcomeTabPage.Size = new System.Drawing.Size(682, 404);
            this.welcomeTabPage.TabIndex = 0;
            this.welcomeTabPage.Text = "Welcome";
            this.welcomeTabPage.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(89, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(483, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "In order to start using the tool, you must login using the fields above";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(162, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to the Administrator Tool";
            // 
            // projectsTabPage
            // 
            this.projectsTabPage.Controls.Add(this.projectsTabControl);
            this.projectsTabPage.Location = new System.Drawing.Point(4, 22);
            this.projectsTabPage.Name = "projectsTabPage";
            this.projectsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.projectsTabPage.Size = new System.Drawing.Size(682, 404);
            this.projectsTabPage.TabIndex = 1;
            this.projectsTabPage.Text = "Projects";
            this.projectsTabPage.UseVisualStyleBackColor = true;
            this.projectsTabPage.Click += new System.EventHandler(this.projectsTabPage_Click);
            // 
            // projectsTabControl
            // 
            this.projectsTabControl.Controls.Add(this.newTabPage);
            this.projectsTabControl.Controls.Add(this.tasksTabPage);
            this.projectsTabControl.Location = new System.Drawing.Point(20, 22);
            this.projectsTabControl.Name = "projectsTabControl";
            this.projectsTabControl.SelectedIndex = 0;
            this.projectsTabControl.Size = new System.Drawing.Size(643, 352);
            this.projectsTabControl.TabIndex = 0;
            this.projectsTabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.projectsTabControl_Selected);
            // 
            // newTabPage
            // 
            this.newTabPage.Controls.Add(this.groupBox1);
            this.newTabPage.Location = new System.Drawing.Point(4, 22);
            this.newTabPage.Name = "newTabPage";
            this.newTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.newTabPage.Size = new System.Drawing.Size(635, 326);
            this.newTabPage.TabIndex = 0;
            this.newTabPage.Text = "New";
            this.newTabPage.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddProject);
            this.groupBox1.Controls.Add(this.cbCustomer);
            this.groupBox1.Controls.Add(this.txtProjectEnd);
            this.groupBox1.Controls.Add(this.txtProjectStart);
            this.groupBox1.Controls.Add(this.txtProjectName);
            this.groupBox1.Controls.Add(this.custLabel);
            this.groupBox1.Controls.Add(this.expendLabel);
            this.groupBox1.Controls.Add(this.expStrtLabel);
            this.groupBox1.Controls.Add(this.nameLabel);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 191);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Project";
            // 
            // btnAddProject
            // 
            this.btnAddProject.Location = new System.Drawing.Point(96, 150);
            this.btnAddProject.Name = "btnAddProject";
            this.btnAddProject.Size = new System.Drawing.Size(75, 23);
            this.btnAddProject.TabIndex = 8;
            this.btnAddProject.Text = "Add";
            this.btnAddProject.UseVisualStyleBackColor = true;
            this.btnAddProject.Click += new System.EventHandler(this.btnAddProject_Click);
            // 
            // cbCustomer
            // 
            this.cbCustomer.FormattingEnabled = true;
            this.cbCustomer.Location = new System.Drawing.Point(96, 110);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(121, 21);
            this.cbCustomer.TabIndex = 7;
            // 
            // txtProjectEnd
            // 
            this.txtProjectEnd.Location = new System.Drawing.Point(96, 83);
            this.txtProjectEnd.Name = "txtProjectEnd";
            this.txtProjectEnd.Size = new System.Drawing.Size(100, 20);
            this.txtProjectEnd.TabIndex = 6;
            // 
            // txtProjectStart
            // 
            this.txtProjectStart.Location = new System.Drawing.Point(96, 56);
            this.txtProjectStart.Name = "txtProjectStart";
            this.txtProjectStart.Size = new System.Drawing.Size(100, 20);
            this.txtProjectStart.TabIndex = 5;
            // 
            // txtProjectName
            // 
            this.txtProjectName.Location = new System.Drawing.Point(96, 29);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(100, 20);
            this.txtProjectName.TabIndex = 4;
            // 
            // custLabel
            // 
            this.custLabel.AutoSize = true;
            this.custLabel.Location = new System.Drawing.Point(35, 113);
            this.custLabel.Name = "custLabel";
            this.custLabel.Size = new System.Drawing.Size(54, 13);
            this.custLabel.TabIndex = 3;
            this.custLabel.Text = "Customer:";
            // 
            // expendLabel
            // 
            this.expendLabel.AutoSize = true;
            this.expendLabel.Location = new System.Drawing.Point(12, 86);
            this.expendLabel.Name = "expendLabel";
            this.expendLabel.Size = new System.Drawing.Size(77, 13);
            this.expendLabel.TabIndex = 2;
            this.expendLabel.Text = "Expected End:";
            // 
            // expStrtLabel
            // 
            this.expStrtLabel.AutoSize = true;
            this.expStrtLabel.Location = new System.Drawing.Point(9, 59);
            this.expStrtLabel.Name = "expStrtLabel";
            this.expStrtLabel.Size = new System.Drawing.Size(80, 13);
            this.expStrtLabel.TabIndex = 1;
            this.expStrtLabel.Text = "Expected Start:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(51, 32);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name:";
            // 
            // tasksTabPage
            // 
            this.tasksTabPage.Controls.Add(this.exstProjGroupBox);
            this.tasksTabPage.Location = new System.Drawing.Point(4, 22);
            this.tasksTabPage.Name = "tasksTabPage";
            this.tasksTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.tasksTabPage.Size = new System.Drawing.Size(635, 326);
            this.tasksTabPage.TabIndex = 1;
            this.tasksTabPage.Text = "Tasks";
            this.tasksTabPage.UseVisualStyleBackColor = true;
            this.tasksTabPage.Click += new System.EventHandler(this.tasksTabPage_Click);
            // 
            // exstProjGroupBox
            // 
            this.exstProjGroupBox.Controls.Add(this.customerlbl);
            this.exstProjGroupBox.Controls.Add(this.endDatelbl);
            this.exstProjGroupBox.Controls.Add(this.startDatelbl);
            this.exstProjGroupBox.Controls.Add(this.customerLabel);
            this.exstProjGroupBox.Controls.Add(this.expEndLabel2);
            this.exstProjGroupBox.Controls.Add(this.expStartLabel);
            this.exstProjGroupBox.Controls.Add(this.cbProjects);
            this.exstProjGroupBox.Controls.Add(this.slctprojLabel);
            this.exstProjGroupBox.Controls.Add(this.tasksGroupBox);
            this.exstProjGroupBox.Controls.Add(this.addTaskGroupBox);
            this.exstProjGroupBox.Location = new System.Drawing.Point(23, 21);
            this.exstProjGroupBox.Name = "exstProjGroupBox";
            this.exstProjGroupBox.Size = new System.Drawing.Size(589, 286);
            this.exstProjGroupBox.TabIndex = 0;
            this.exstProjGroupBox.TabStop = false;
            this.exstProjGroupBox.Text = "Existing Projects";
            // 
            // customerlbl
            // 
            this.customerlbl.AutoSize = true;
            this.customerlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerlbl.Location = new System.Drawing.Point(322, 68);
            this.customerlbl.Name = "customerlbl";
            this.customerlbl.Size = new System.Drawing.Size(72, 13);
            this.customerlbl.TabIndex = 9;
            this.customerlbl.Text = "lblCustomer";
            // 
            // endDatelbl
            // 
            this.endDatelbl.AutoSize = true;
            this.endDatelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDatelbl.Location = new System.Drawing.Point(514, 34);
            this.endDatelbl.Name = "endDatelbl";
            this.endDatelbl.Size = new System.Drawing.Size(69, 13);
            this.endDatelbl.TabIndex = 8;
            this.endDatelbl.Text = "lblEndDate";
            // 
            // startDatelbl
            // 
            this.startDatelbl.AutoSize = true;
            this.startDatelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDatelbl.Location = new System.Drawing.Point(348, 34);
            this.startDatelbl.Name = "startDatelbl";
            this.startDatelbl.Size = new System.Drawing.Size(74, 13);
            this.startDatelbl.TabIndex = 7;
            this.startDatelbl.Text = "lblStartDate";
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Location = new System.Drawing.Point(262, 68);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(54, 13);
            this.customerLabel.TabIndex = 6;
            this.customerLabel.Text = "Customer:";
            // 
            // expEndLabel2
            // 
            this.expEndLabel2.AutoSize = true;
            this.expEndLabel2.Location = new System.Drawing.Point(431, 34);
            this.expEndLabel2.Name = "expEndLabel2";
            this.expEndLabel2.Size = new System.Drawing.Size(77, 13);
            this.expEndLabel2.TabIndex = 5;
            this.expEndLabel2.Text = "Expected End:";
            // 
            // expStartLabel
            // 
            this.expStartLabel.AutoSize = true;
            this.expStartLabel.Location = new System.Drawing.Point(262, 34);
            this.expStartLabel.Name = "expStartLabel";
            this.expStartLabel.Size = new System.Drawing.Size(80, 13);
            this.expStartLabel.TabIndex = 4;
            this.expStartLabel.Text = "Expected Start:";
            // 
            // cbProjects
            // 
            this.cbProjects.FormattingEnabled = true;
            this.cbProjects.Location = new System.Drawing.Point(111, 34);
            this.cbProjects.Name = "cbProjects";
            this.cbProjects.Size = new System.Drawing.Size(121, 21);
            this.cbProjects.TabIndex = 3;
            this.cbProjects.SelectedIndexChanged += new System.EventHandler(this.cbProjects_SelectedIndexChanged);
            // 
            // slctprojLabel
            // 
            this.slctprojLabel.AutoSize = true;
            this.slctprojLabel.Location = new System.Drawing.Point(29, 37);
            this.slctprojLabel.Name = "slctprojLabel";
            this.slctprojLabel.Size = new System.Drawing.Size(76, 13);
            this.slctprojLabel.TabIndex = 2;
            this.slctprojLabel.Text = "Select Project:";
            // 
            // tasksGroupBox
            // 
            this.tasksGroupBox.Controls.Add(this.lbTasks);
            this.tasksGroupBox.Location = new System.Drawing.Point(305, 111);
            this.tasksGroupBox.Name = "tasksGroupBox";
            this.tasksGroupBox.Size = new System.Drawing.Size(250, 169);
            this.tasksGroupBox.TabIndex = 1;
            this.tasksGroupBox.TabStop = false;
            this.tasksGroupBox.Text = "Tasks";
            // 
            // lbTasks
            // 
            this.lbTasks.FormattingEnabled = true;
            this.lbTasks.Location = new System.Drawing.Point(30, 33);
            this.lbTasks.Name = "lbTasks";
            this.lbTasks.Size = new System.Drawing.Size(192, 108);
            this.lbTasks.TabIndex = 0;
            // 
            // addTaskGroupBox
            // 
            this.addTaskGroupBox.Controls.Add(this.btnAddTask);
            this.addTaskGroupBox.Controls.Add(this.cbTeams);
            this.addTaskGroupBox.Controls.Add(this.txtTaskEnd);
            this.addTaskGroupBox.Controls.Add(this.txtTaskStart);
            this.addTaskGroupBox.Controls.Add(this.txtTaskName);
            this.addTaskGroupBox.Controls.Add(this.teamlbl);
            this.addTaskGroupBox.Controls.Add(this.expEndlbl);
            this.addTaskGroupBox.Controls.Add(this.expStrtlbl);
            this.addTaskGroupBox.Controls.Add(this.namelbl);
            this.addTaskGroupBox.Location = new System.Drawing.Point(27, 111);
            this.addTaskGroupBox.Name = "addTaskGroupBox";
            this.addTaskGroupBox.Size = new System.Drawing.Size(240, 169);
            this.addTaskGroupBox.TabIndex = 0;
            this.addTaskGroupBox.TabStop = false;
            this.addTaskGroupBox.Text = "Add Task";
            // 
            // btnAddTask
            // 
            this.btnAddTask.Location = new System.Drawing.Point(116, 131);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(75, 23);
            this.btnAddTask.TabIndex = 8;
            this.btnAddTask.Text = "Add";
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // cbTeams
            // 
            this.cbTeams.FormattingEnabled = true;
            this.cbTeams.Location = new System.Drawing.Point(91, 104);
            this.cbTeams.Name = "cbTeams";
            this.cbTeams.Size = new System.Drawing.Size(121, 21);
            this.cbTeams.TabIndex = 7;
            // 
            // txtTaskEnd
            // 
            this.txtTaskEnd.Location = new System.Drawing.Point(91, 74);
            this.txtTaskEnd.Name = "txtTaskEnd";
            this.txtTaskEnd.Size = new System.Drawing.Size(100, 20);
            this.txtTaskEnd.TabIndex = 6;
            // 
            // txtTaskStart
            // 
            this.txtTaskStart.Location = new System.Drawing.Point(91, 46);
            this.txtTaskStart.Name = "txtTaskStart";
            this.txtTaskStart.Size = new System.Drawing.Size(100, 20);
            this.txtTaskStart.TabIndex = 5;
            // 
            // txtTaskName
            // 
            this.txtTaskName.Location = new System.Drawing.Point(91, 16);
            this.txtTaskName.Name = "txtTaskName";
            this.txtTaskName.Size = new System.Drawing.Size(100, 20);
            this.txtTaskName.TabIndex = 4;
            // 
            // teamlbl
            // 
            this.teamlbl.AutoSize = true;
            this.teamlbl.Location = new System.Drawing.Point(48, 107);
            this.teamlbl.Name = "teamlbl";
            this.teamlbl.Size = new System.Drawing.Size(37, 13);
            this.teamlbl.TabIndex = 3;
            this.teamlbl.Text = "Team:";
            // 
            // expEndlbl
            // 
            this.expEndlbl.AutoSize = true;
            this.expEndlbl.Location = new System.Drawing.Point(8, 77);
            this.expEndlbl.Name = "expEndlbl";
            this.expEndlbl.Size = new System.Drawing.Size(77, 13);
            this.expEndlbl.TabIndex = 2;
            this.expEndlbl.Text = "Expected End:";
            // 
            // expStrtlbl
            // 
            this.expStrtlbl.AutoSize = true;
            this.expStrtlbl.Location = new System.Drawing.Point(5, 49);
            this.expStrtlbl.Name = "expStrtlbl";
            this.expStrtlbl.Size = new System.Drawing.Size(80, 13);
            this.expStrtlbl.TabIndex = 1;
            this.expStrtlbl.Text = "Expected Start:";
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.Location = new System.Drawing.Point(47, 19);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(38, 13);
            this.namelbl.TabIndex = 0;
            this.namelbl.Text = "Name:";
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 518);
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Name = "frmAdmin";
            this.Text = "Administrator Tool";
            this.mainTabControl.ResumeLayout(false);
            this.welcomeTabPage.ResumeLayout(false);
            this.welcomeTabPage.PerformLayout();
            this.projectsTabPage.ResumeLayout(false);
            this.projectsTabControl.ResumeLayout(false);
            this.newTabPage.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tasksTabPage.ResumeLayout(false);
            this.exstProjGroupBox.ResumeLayout(false);
            this.exstProjGroupBox.PerformLayout();
            this.tasksGroupBox.ResumeLayout(false);
            this.addTaskGroupBox.ResumeLayout(false);
            this.addTaskGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage welcomeTabPage;
        private System.Windows.Forms.TabPage projectsTabPage;
        private System.Windows.Forms.TabControl projectsTabControl;
        private System.Windows.Forms.TabPage newTabPage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddProject;
        private System.Windows.Forms.ComboBox cbCustomer;
        private System.Windows.Forms.TextBox txtProjectEnd;
        private System.Windows.Forms.TextBox txtProjectStart;
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.Label custLabel;
        private System.Windows.Forms.Label expendLabel;
        private System.Windows.Forms.Label expStrtLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TabPage tasksTabPage;
        private System.Windows.Forms.GroupBox exstProjGroupBox;
        private System.Windows.Forms.Label customerlbl;
        private System.Windows.Forms.Label endDatelbl;
        private System.Windows.Forms.Label startDatelbl;
        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.Label expEndLabel2;
        private System.Windows.Forms.Label expStartLabel;
        private System.Windows.Forms.ComboBox cbProjects;
        private System.Windows.Forms.Label slctprojLabel;
        private System.Windows.Forms.GroupBox tasksGroupBox;
        private System.Windows.Forms.GroupBox addTaskGroupBox;
        private System.Windows.Forms.ComboBox cbTeams;
        private System.Windows.Forms.TextBox txtTaskEnd;
        private System.Windows.Forms.TextBox txtTaskStart;
        private System.Windows.Forms.TextBox txtTaskName;
        private System.Windows.Forms.Label teamlbl;
        private System.Windows.Forms.Label expEndlbl;
        private System.Windows.Forms.Label expStrtlbl;
        private System.Windows.Forms.Label namelbl;
        private System.Windows.Forms.ListBox lbTasks;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

