using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RepositoryUnitOfWork.AutoMapper
{
    public class MapperHelper
    {
        private IMapper mapper;

        public MapperHelper(TSource, TDestination)
        {
            var configuration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Source, Destination>();
                cfg.CreateMap<Source, DestinationClass>();
            });
            mapper = configuration.CreateMapper();
        }

        private static MapperHelper Mapper()
        {
        }

        public static T MapFrom<T>(object entity)
        {
            return Mapper().Map<T>(entity);
        }
    }
}