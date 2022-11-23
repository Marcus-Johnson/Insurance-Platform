namespace NJInsurancePlatform.Models
{
    public class MessagesViewModel
    {
        public IEnumerable<GroupRoom> groupRooms { get; set; }
        public IEnumerable<GroupRoomMessage> groupRoomMessages { get; set; }
     }
}
