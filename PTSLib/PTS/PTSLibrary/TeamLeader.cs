using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTSLibrary
{
    [Serializable]
    public class TeamLeader : User
    {
        private int teamId;

        public int TeamId 
        { 
            get { return teamId; } 
            set { teamId = value; }
        }

        public TeamLeader() { }

        public TeamLeader(String name, int id, int teamId)
        {
            this.name = name; 
            this.id = id; 
            this.teamId = teamId;
        }
    }
}
