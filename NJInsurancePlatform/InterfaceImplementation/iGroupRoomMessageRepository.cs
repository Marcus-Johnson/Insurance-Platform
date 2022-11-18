using Microsoft.DotNet.Scaffolding.Shared.Messaging;
using NJInsurancePlatform.Models;
using System;

namespace NJInsurancePlatform.InterfaceImplementation
{
    public interface iGroupRoomMessageRepository 
    {
        Task<IEnumerable<GroupRoomMessage>> GetMessages();

        Task<GroupRoomMessage> GetMessagesByID(Guid GroupRoomMessageMUID);

        void InsertMessage(GroupRoomMessage groupRoomMessage);

        void DeleteMessage(Guid GroupRoomMessageMUID);

        void UpdateMessage(GroupRoomMessage groupRoomMessage);

        void Save();
    }
}
