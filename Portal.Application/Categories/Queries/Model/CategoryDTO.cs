using System;
using AutoMapper;
using Portal.Application.System.Mappings;
using Portal.Domain.Entities;

namespace Portal.Application.Categories.Queries.Model
{
    public class CategoryDTO : IMapFrom<Category>
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Category,CategoryDTO>()
                   .ForMember(c => c.Id ,opt => opt.MapFrom(d => d.Id))
                   .ForMember(c => c.Name ,opt => opt.MapFrom(d => d.Name));
        }
    }
}
