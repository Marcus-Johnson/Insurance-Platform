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
        private bool disposed = false;
        
        public async Task<List<GroupRoomMessage>> GetMessages()
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

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _databaseContext.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
