using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services.Abstractions
{
    public interface IRoomService
    {
        Task<IEnumerable<Room>> GetRooms();
        Task<Room> GetRoom(int roomId);
        void SetStatus(int roomId, Status status);
    }
}
