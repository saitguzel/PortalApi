using System;
using System.Linq;
using System.Reflection;
using AutoMapper;

namespace Portal.Application.System.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            ApplyMappingsFromAssembly(Assembly.GetExecutingAssembly());
        }

        private void ApplyMappingsFromAssembly(Assembly assembly)
        {
            var types = assembly.GetExportedTypes()
                        .Where(a => a.GetInterfaces().Any(x=>x.IsGenericType && x.GetGenericTypeDefinition()==typeof(IMapFrom<>)))
                        .ToList();
            foreach (var type in types)
            {
                var instance = Activator.CreateInstance(type);
                var methodInfo = type.GetMethod("Mapping");
                methodInfo?.Invoke(instance, new object[]{this});
            }
        }
    }
}
