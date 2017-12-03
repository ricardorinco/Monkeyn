using AutoMapper;

namespace SC.Sunset.Application.AutoMapper
{
    public class AutoMapperConfiguration
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize(x => { x.AddProfile<MappingProfile>(); });
        }
    }
}
