using Microsoft.DotNet.Scaffolding.Shared.Messaging;
using Microsoft.EntityFrameworkCore;
using NJInsurancePlatform.Data;
using NJInsurancePlatform.Models;
using System;

namespace NJInsurancePlatform.Interfaces
{
    public class MessageRepository : iMessageRepository,IDisposable
    {
        private readonly InsuranceCorpDbContext _databaseContext;
        public async Task<IEnumerable<GroupRoomMessage>> GetMessages()
        {
            return _databaseContext.Messages.ToList();
        }

        public async Task<GroupRoomMessage> GetMessagesByID(Guid MessageMUID)
        {
            var message = await _databaseContext.Messages.FindAsync(MessageMUID);
            return message;
        }

        public async void InsertMessage(GroupRoomMessage message)
        {
            await _databaseContext.Messages.AddAsync(message);
        }

        public async void DeleteMessage(Guid MessageMUID)
        {
            var messageRemove = _databaseContext.Messages.FirstOrDefault(m => m.GroupRoomMessageMUID == MessageMUID);
            _databaseContext.Messages.Remove(messageRemove);
        }

        public async void UpdateMessage(GroupRoomMessage message)
        {
            try
            {
                _databaseContext.Update(message);
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
        }

        public async void Save()
        {
            await _databaseContext.SaveChangesAsync();
        }

        public async void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
