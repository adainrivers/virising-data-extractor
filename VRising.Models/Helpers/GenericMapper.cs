using AutoMapper;
using VRising.Models.Data;
using VRising.Models.Internal;

namespace VRising.Models.Helpers
{
    public static class GenericMapper
    {
        private static readonly Mapper Mapper;

        static GenericMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<RisingDb_UnitStats, UnitStats>();
                cfg.CreateMap<RisingDb_ResistanceData, ResistanceData>();
            });

            Mapper = new Mapper(config);
        }

        public static TOutput Map<TInput, TOutput>(TInput input)
        {
            return Mapper.Map<TInput, TOutput>(input);
        }
    }
}