using System.ComponentModel.DataAnnotations;

namespace NJInsurancePlatform.Models
{
    public class MessagesViewModel
    {

        public List<GroupRoom>? groupRooms { get; set; }
        public GroupRoom? groupRoom { get; set; }
        public List<GroupRoomMessage>? groupRoomMessages { get; set; }
        public ApplicationUser? applicationUser { get; set; }

        public MessagesViewModel()
        {
            this.groupRooms = new List<GroupRoom>();
            this.groupRoom = new GroupRoom();
            this.groupRoomMessages = new List<GroupRoomMessage>();
            this.applicationUser = new ApplicationUser();
        }
     }
}
