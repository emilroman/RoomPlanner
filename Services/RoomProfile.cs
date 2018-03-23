using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using DbAccess.Abstractions;
using Services.Abstractions;

namespace Services
{
    public class ServicesProfile : Profile
    {
        public ServicesProfile()
        {
            CreateMap<RoomEntity, Room>();
        }
    }
}