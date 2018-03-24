using System.Collections.Generic;
using System.Threading.Tasks;

namespace DbAccess.Abstractions
{
    public interface IRoomRepository
    {
        Task<IEnumerable<RoomEntity>> GetRooms();
        Task<RoomEntity> GetRoom(int roomId);
        Task SetStatus(int roomId, StatusEntity status);
    }
}