using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;
using PTSLibrary;

namespace AdminApplication
{
    public partial class frmAdmin : Form
    {
        private PTSAdminFacade facade;
        private int adminId;
        private Customer[] customers;
        private Project[] projects;
        private Team[] teams;
        private Project selectedProject;
        private Task[] tasks;

        public frmAdmin()
        {
            InitializeComponent();
            HttpChannel channel = new HttpChannel();
            ChannelServices.RegisterChannel(channel, false);
            facade = (PTSAdminFacade)RemotingServices.Connect(typeof(PTSAdminFacade), "http://localhost:50000/PTSAdminFacade");
            adminId = 0;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                adminId = facade.Authenticate(this.txtUsername.Text, this.txtPassword.Text);
                if (adminId != 0)
                {
                    this.txtUsername.Text = "";
                    this.txtPassword.Text = "";
                    MessageBox.Show("Successfully logged in");
                    mainTabControl.SelectTab(1);
                    mainTabControl.Enabled = true;
                }
                else
                {
                    mainTabControl.SelectTab(0);
                    mainTabControl.Enabled = false;
                    MessageBox.Show("Wrong login details");
                }
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tasksTabPage_Click(object sender, EventArgs e)
        {

        }

        private void projectsTabPage_Click(object sender, EventArgs e)
        {

        }

        private void mainTabControl_Selected(object sender, TabControlEventArgs e)
        {
            if (mainTabControl.SelectedIndex == 1)
            {
                customers = facade.GetListOfCustomers();
                cbCustomer.DataSource = customers;
                cbCustomer.DisplayMember = "Name";
                cbCustomer.ValueMember = "id";
            }
        }

        private void btnAddProject_Click(object sender, EventArgs e)
        {
            DateTime startDate;
            DateTime endDate;

            if (txtProjectName.Text == "")
            {
                MessageBox.Show("You need to fiil in the name field");
                return;
            }

            try
            {
                startDate = DateTime.Parse(txtProjectStart.Text);
                endDate = DateTime.Parse(txtProjectEnd.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("The date(s) are in the wrong format");
                return;
            }
            facade.CreateProject(txtProjectName.Text, startDate, endDate, (int)cbCustomer.SelectedValue, adminId);
            txtProjectName.Text = "";
            txtProjectStart.Text = "";
            txtProjectEnd.Text = "";
            cbCustomer.SelectedIndex = 0;
            MessageBox.Show("Project successfully created");
            projectsTabControl.SelectTab(1);
        }

        private void projectsTabControl_Selected(object sender, TabControlEventArgs e)
        {
            if (projectsTabControl.SelectedIndex == 1)
            {
                projects = facade.GetListOfProjects(adminId);
                cbProjects.DataSource = projects;
                cbProjects.DisplayMember = "Name";
                cbProjects.ValueMember = "ProjectId";
                setProjectDetails();

                teams = facade.GetListOfTeams();
                cbTeams.DataSource = teams;
                cbTeams.DisplayMember = "Name";
                cbTeams.ValueMember = "TeamId";
            }
        }

        private void setProjectDetails()
        {
            selectedProject = projects[cbProjects.SelectedIndex];
            startDatelbl.Text = selectedProject.ExpectedStartDate.ToShortDateString();
            endDatelbl.Text = selectedProject.ExpectedEndDate.ToShortDateString();
            customerlbl.Text = ((Customer)selectedProject.TheCustomer).Name;
            UpdateTasks();
        }

        private void UpdateTasks()
        {
            tasks = facade.GetListOfTasks(selectedProject.ProjectId);
            lbTasks.DataSource = tasks;
            lbTasks.DisplayMember = "NameAndStatus";
            lbTasks.ValueMember = "TaskId";
        }

        private void cbProjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            setProjectDetails();
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            DateTime startDate;
            DateTime endDate;

            if (txtTaskName.Text == "")
            {
                MessageBox.Show("You need to fill in the name field");
                return;
            }

            try
            {
                startDate = DateTime.Parse(txtTaskStart.Text);
                endDate = DateTime.Parse(txtTaskEnd.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("The date(s) are in the wrong format");
                return;
            }
            facade.CreateTask(txtTaskName.Text, startDate, endDate, (int)cbTeams.SelectedValue, selectedProject.ProjectId);
            txtTaskName.Text = "";
            txtTaskStart.Text = "";
            txtTaskEnd.Text = "";
            cbTeams.SelectedIndex = 0;
            MessageBox.Show("Task successfully created");
            UpdateTasks();
        }
    }
}
