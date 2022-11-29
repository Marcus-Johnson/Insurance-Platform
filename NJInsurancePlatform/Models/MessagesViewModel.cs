namespace NJInsurancePlatform.Models
{
    public class MessagesViewModel
    {
        public List<GroupRoom>? groupRooms { get; set; }
        public List<GroupRoomMessage>? groupRoomMessages { get; set; }

        public MessagesViewModel()
        {
            this.groupRooms = new List<GroupRoom>();
            this.groupRoomMessages = new List<GroupRoomMessage>();
        }
     }
}
