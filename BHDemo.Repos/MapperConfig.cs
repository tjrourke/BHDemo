using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BHDemo.Data;
using BHDemo.Common.Dto;

namespace BHDemo.Repos
{
    /// <summary>
    /// Sets up mapping for the repositories in the system.
    /// </summary>
    public static class MapperConfig
    {
        public static IMapper SetUpMapper()
        {
            if (Mapper != null)
            {
                return Mapper;
            }

            var configuration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Reason, ReasonDto>();
            });

#if DEBUG || TEST
            // Validate mappings during coding
            //configuration.AssertConfigurationIsValid();
#endif

            Mapper = configuration.CreateMapper();
            return Mapper;
        }

        public static IMapper Mapper { get; private set; }
    }
}
