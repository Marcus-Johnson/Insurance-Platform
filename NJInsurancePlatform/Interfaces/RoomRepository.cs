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
        {
            return _databaseContext.GroupRooms.ToList();
        }
        
        public async Task<GroupRoom> GetGroupRoomsByID(Guid GroupMUID)
        {
            var groupRoom = await _databaseContext.GroupRooms.FindAsync(GroupMUID);
            return groupRoom;
        }
        
        public async void InsertGroupRoom(GroupRoom groupRoom)
        {
            await _databaseContext.GroupRooms.AddAsync(groupRoom);
        }
        
        public async void DeleteGroupRoom(Guid GroupMUID)
        {
            var groupRoomRemove = _databaseContext.GroupRooms.FirstOrDefault(p => p.GroupMUID == GroupMUID);
            _databaseContext.GroupRooms.Remove(groupRoomRemove);
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
        
        public  void Save()
        {
             _databaseContext.SaveChanges();
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
