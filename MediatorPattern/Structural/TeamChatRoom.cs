using System.Collections.Generic;
using System.Linq;

namespace MediatorPattern.Structural
{
    public class TeamChatRoom : ChatRoom
    {
        private readonly List<TeamMember> _teamMembers = new List<TeamMember>();
        public override void RegisterTeamMember(TeamMember teamMember)
        {
            teamMember.SetChatRoom(this);
            _teamMembers.Add(teamMember);
        }

        public void RegisterTeamMembers(params TeamMember[] teamMembers)
        {
            foreach (var teamMember in teamMembers)
            {
                RegisterTeamMember(teamMember);
            }
        }

        public override void Send(string @from, string message)
        {
            _teamMembers.Where(x => x.Name != from).ToList().ForEach(x => x.Receive(from, message));
        }

        public override void SendTo<T>(string @from, string message)
        {
            _teamMembers.Where(x => x.Name != from).OfType<T>().ToList().ForEach(x => x.Receive(from, message));    
        }
    }
}