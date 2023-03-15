using Microsoft.DotNet.Scaffolding.Shared.Messaging;
using Microsoft.EntityFrameworkCore;
using NJInsurancePlatform.Data;
using NJInsurancePlatform.InterfaceImplementation;
using NJInsurancePlatform.Models;
using System;

namespace NJInsurancePlatform.Interfaces
{
    public class GroupRoomMessageRepository : iGroupRoomMessageRepository, IDisposable
    {
        private readonly InsuranceCorpDbContext _databaseContext;
        private bool disposed;

        public GroupRoomMessageRepository(InsuranceCorpDbContext databaseContext)
        {
            _databaseContext = databaseContext ?? throw new ArgumentNullException(nameof(databaseContext));
        }

        public async Task<List<GroupRoomMessage>> GetMessages()
            => await _databaseContext.GroupRoomMessages.ToListAsync();

        public async Task<GroupRoomMessage> GetMessagesByID(Guid GroupRoomMessageMUID)
            => await _databaseContext.GroupRoomMessages.FindAsync(GroupRoomMessageMUID);

        public async Task InsertMessage(GroupRoomMessage groupRoomMessages)
            => await _databaseContext.GroupRoomMessages.AddAsync(groupRoomMessages ?? throw new ArgumentNullException(nameof(groupRoomMessages)));

        public async Task DeleteMessage(Guid MessageMUID)
        {
            var messageRemove = await _databaseContext.GroupRoomMessages.FirstOrDefaultAsync(m => m.GroupRoomMessageMUID == MessageMUID);
            _databaseContext.GroupRoomMessages.Remove(messageRemove != null ? messageRemove : throw new ArgumentNullException(nameof(messageRemove)));
        }

        public async Task UpdateMessage(GroupRoomMessage groupRoomMessages)
            => _databaseContext.Update(groupRoomMessages ?? throw new ArgumentNullException(nameof(groupRoomMessages)));

        public async Task Save()
            => await _databaseContext.SaveChangesAsync();

        protected virtual void Dispose(bool disposing)
        {
            if (disposed) return;
            if (disposing) _databaseContext.Dispose();
            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
