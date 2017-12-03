using AutoMapper;
using Monkeyn.Application.ViewModels;
using Monkeyn.Domain.Models;

namespace SC.Sunset.Application.AutoMapper
{
    public class MappingProfile : Profile
    {
        protected override void Configure()
        {
            CreateMap<Data, DataViewModel>().ReverseMap();
            CreateMap<Hanoi, HanoiViewModel>().ReverseMap();
            CreateMap<Move, MoveViewModel>().ReverseMap();
        }
    }
}
