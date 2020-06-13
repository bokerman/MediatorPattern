using System;

namespace MediatorPattern.Structural
{
    public abstract class TeamMember
    {
        public string Name { get; }
        private ChatRoom _chatRoom;
        
        public TeamMember(string name)
        {
            Name = name;
        }

        internal void SetChatRoom(ChatRoom chatRoom)
        {
            _chatRoom = chatRoom ?? throw new ArgumentNullException(nameof(chatRoom));
        }

        public virtual void Receive(string from, string message)
        {
            Console.WriteLine($"message: \"{message}\" from: {from}");
        }

        public virtual void Send(string message)
        {
            _chatRoom.Send(Name, message);
        }

        public virtual void SendTo<T>(string message) where T : TeamMember
        {
            _chatRoom.SendTo<T>(Name, message);
        }
    }
}