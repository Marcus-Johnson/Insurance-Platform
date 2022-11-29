namespace NJInsurancePlatform.Models
{
    public class MessagesViewModel
    {
        public IEnumerable<GroupRoom> groupRooms { get; set; }
        public IEnumerable<GroupRoomMessage> groupRoomMessages { get; set; }

        public MessagesViewModel()
        {
            this.groupRooms = new List<GroupRoom>();
            this.groupRoomMessages = new List<GroupRoomMessage>();
        }
     }
}
