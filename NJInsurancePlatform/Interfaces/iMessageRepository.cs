using Microsoft.DotNet.Scaffolding.Shared.Messaging;
using NJInsurancePlatform.Models;
using System;

namespace NJInsurancePlatform.Interfaces
{
    public interface iMessageRepository : IDisposable
    {
        Task<IEnumerable<GroupRoomMessage>>GetMessages();

        Task<GroupRoomMessage> GetMessagesByID(Guid MessageMUID);

        void InsertMessage(GroupRoomMessage message);

        void DeleteMessage(Guid MessageMUID);

        void UpdateMessage(GroupRoomMessage message);

        void Save();
    }
}
