using Microsoft.DotNet.Scaffolding.Shared.Messaging;
using NJInsurancePlatform.Models;
using System;

namespace NJInsurancePlatform.Interfaces
{
    public interface iMessageRepository : IDisposable
    {
        Task<IEnumerable<Transaction>>GetMessages();

        Task<Message>GetMessagesByID(Guid MessageMUID);

        void InsertMessage(Message message);

        void DeleteMessage(Guid message);

        void UpdateMessage(Message message);

        void Save();
    }
}
