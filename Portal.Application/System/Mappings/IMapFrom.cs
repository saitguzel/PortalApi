using System;
using AutoMapper;

namespace Portal.Application.System.Mappings
{
    public interface IMapFrom<T>
    {
        /// <summary>
        /// Aynı tipteki dllleri bulup register edecek.
        /// DTO ları register edecek.
        /// </summary>
        /// <param name="profile"></param>
        void Mapping(Profile profile)=>profile.CreateMap(typeof(T),GetType());
    }
}
