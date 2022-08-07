using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTSLibrary
{
    public class PTSAdminFacade : PTSSuperFacade
    {
        private DAO.AdminDAO dao;
        public PTSAdminFacade() : base(new DAO.AdminDAO())
        {
            dao = (DAO.AdminDAO)base.dao;
        }
        public int Authenticate(string username, string password)
        {
            if (username == "" || password == "")
            {
                throw new Exception("Missing Data");
            }
            return dao.Authenticate(username, password);
        }
        public void CreateProject(string name, DateTime startDate, DateTime endDate, int
       customerId, int administratorId)
        {
            if (name == null || name == "" || startDate == null || endDate == null)
            {
                throw new Exception("Missing Data");
            }
            dao.CreateProject(name, startDate, endDate, customerId, administratorId);
        }
        public Customer[] GetListOfCustomers()
        {
            return (dao.GetListOfCustomers()).ToArray();
        }
        public Project[] GetListOfProjects(int adminId)
        {
            return (dao.GetListOfProjects(adminId)).ToArray();
        }
        public Team[] GetListOfTeams()
        {
            return (dao.GetListOfTeams()).ToArray();
        }
        public void CreateTask(string name, DateTime startDate, DateTime endDate, int teamId,
       Guid projectId)
        {
            if (name == null || name == "" || startDate == null || endDate == null)
            {
                throw new Exception("Missing Data");
            }
            dao.CreateTask(name, startDate, endDate, teamId, projectId);
        }
    }
}
