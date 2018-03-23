using System.Collections.Generic;
using DbAccess.Abstractions;

namespace DbAccess
{
    public static class NotFakeDatabse
    {
        public static List<RoomEntity> Rooms = new List<RoomEntity>()
        {
            new RoomEntity{ Id = 1, Name = "Room1", Status = StatusEntity.Liber },
            new RoomEntity{ Id = 2, Name = "Room2", Status = StatusEntity.Liber },
            new RoomEntity{ Id = 3, Name = "Room3", Status = StatusEntity.Liber }
        };
    }
}