using Microsoft.DotNet.Scaffolding.Shared.Messaging;
using Microsoft.EntityFrameworkCore;
using NJInsurancePlatform.Data;
using NJInsurancePlatform.Models;
using System;

namespace NJInsurancePlatform.Interfaces
{
    public class GroupRoomMessageRepository : iGroupRoomMessageRepository,IDisposable
    {
        private readonly InsuranceCorpDbContext _databaseContext;
        public async Task<IEnumerable<GroupRoomMessage>> GetMessages()
        {
            return _databaseContext.GroupRoomMessages.ToList();
        }

        public async Task<GroupRoomMessage> GetMessagesByID(Guid GroupRoomMessageMUID)
        {
            var message = await _databaseContext.GroupRoomMessages.FindAsync(GroupRoomMessageMUID);
            return message;
        }

        public async void InsertMessage(GroupRoomMessage groupRoomMessages)
        {
            await _databaseContext.GroupRoomMessages.AddAsync(groupRoomMessages);
        }

        public async void DeleteMessage(Guid MessageMUID)
        {
            var messageRemove = _databaseContext.GroupRoomMessages.FirstOrDefault(m => m.GroupRoomMessageMUID == MessageMUID);
            _databaseContext.GroupRoomMessages.Remove(messageRemove);
        }

        public async void UpdateMessage(GroupRoomMessage groupRoomMessages)
        {
            try
            {
                _databaseContext.Update(groupRoomMessages);
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
