using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using DbAccess.Abstractions;

namespace DbAccess.Types
{
    public class RoomRepository : IRoomRepository
    {
        public async Task<IEnumerable<RoomEntity>> GetRooms()
        {
            await AccessDatabase();

            return NotFakeDatabse.Rooms;
        }

        public async Task<RoomEntity> GetRoom(int roomId)
        {
            await AccessDatabase();
            var room = NotFakeDatabse.Rooms.First(r => r.Id == roomId);

            return room;
        }

        public async Task SetStatus(int roomId, StatusEntity status)
        {
            await AccessDatabase();
            
            var room = NotFakeDatabse.Rooms.First(r => r.Id == roomId);
            room.Status = status;
        }

        /// <summary>
        /// Because databases
        /// </summary>
        private Task AccessDatabase()
        {
            return Task.Delay(500);
        }
    }
}