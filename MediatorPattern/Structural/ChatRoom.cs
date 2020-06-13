using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.Structural
{
    public abstract class ChatRoom
    {
        public abstract void RegisterTeamMember(TeamMember teamMember);
        public abstract void Send(string from, string message);
        public abstract void SendTo<T>(string from, string message) where T : TeamMember;   
    }
}
