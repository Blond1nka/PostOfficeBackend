using AutoMapper;
using HorseRaceBackend.Dtos;
using HorseRaceBackend.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseRaceBackend.Profiles
{
    public class MainProfile : Profile
    {
        public MainProfile()
        {
            CreateMap<HorseAddDto, Horse>();
            CreateMap<BettorAddDto, Bettor>();
            CreateMap<BettorUpdateDto, Bettor>().ReverseMap();
        }
    }
}
