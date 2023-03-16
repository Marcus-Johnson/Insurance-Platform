using Microsoft.EntityFrameworkCore;
using NJInsurancePlatform.Data;
using NJInsurancePlatform.InterfaceImplementation;
using NJInsurancePlatform.Models;
using System;

namespace NJInsurancePlatform.Interfaces
{
    public class RoomRepository : iRoomRepository, IDisposable
    {
        private readonly InsuranceCorpDbContext _databaseContext;
        private bool disposed = false;

        public RoomRepository(InsuranceCorpDbContext databaseContext)
        {
            _databaseContext = databaseContext;
        }
        
        public async Task<List<GroupRoom>> GetGroupRooms() 
            => await _databaseContext.GroupRooms.ToListAsync();
        
        public async Task<GroupRoom> GetGroupRoomsByID(Guid GroupMUID) 
            => await _databaseContext.GroupRooms.FindAsync(GroupMUID);
        
        public async void InsertGroupRoom(GroupRoom groupRoom) 
            => await _databaseContext.GroupRooms.AddAsync(groupRoom);
        
        public async void DeleteGroupRoom(Guid GroupMUID)
        {
            var groupRoom = await _databaseContext.GroupRooms.FindAsync(GroupMUID);
            _databaseContext.GroupRooms.Remove(groupRoom);
        }
        
        public async void UpdateGroupRoom(GroupRoom groupRoom)
        {
            try
            {
                 _databaseContext.Update(groupRoom);
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
        }
        
        public async void Save() => await _databaseContext.SaveChangesAsync();

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
