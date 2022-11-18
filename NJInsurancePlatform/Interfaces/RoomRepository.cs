﻿using Microsoft.EntityFrameworkCore;
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
        
        public async Task<IEnumerable<GroupRoom>> GetGroupRooms()
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
                    context.Dispose();
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