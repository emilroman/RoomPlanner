using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DbAccess.Abstractions;
using Services.Abstractions;

namespace Services.Types
{
    public class RoomService : IRoomService
    {
        private readonly IRoomRepository _roomRepository;
        private readonly IMapper _mapper;

        public RoomService(IRoomRepository roomRepository, IMapper mapper)
        {
            _roomRepository = roomRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<Room>> GetRooms()
        {
            var roomEntities = await _roomRepository.GetRooms();

            var rooms = _mapper.Map<IEnumerable<Room>>(roomEntities);
            return rooms;
        }

        public async Task<Room> GetRoom(int roomId)
        {
            var roomEntity = await _roomRepository.GetRoom(roomId);

            var room = _mapper.Map<Room>(roomEntity);
            return room;
        }

        public void SetStatus(int roomId, Status status)
        {
            var statusEntity = _mapper.Map<StatusEntity>(status);
            _roomRepository.SetStatus(roomId, statusEntity);
        }
    }
}
