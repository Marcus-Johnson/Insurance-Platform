using NJInsurancePlatform.Models;
using System;

namespace NJInsurancePlatform.InterfaceImplementation
{
    public interface iRoomRepository
    {
        Task<IEnumerable<GroupRoom>> GetGroupRooms();

        Task<GroupRoom> GetGroupRoomsByID(Guid GroupMUID);

        void InsertGroupRoom(GroupRoom groupRoom);

        void DeleteGroupRoom(Guid GroupMUID);

        void UpdateGroupRoom(GroupRoom groupRoom);

        void Save();
    }
}
