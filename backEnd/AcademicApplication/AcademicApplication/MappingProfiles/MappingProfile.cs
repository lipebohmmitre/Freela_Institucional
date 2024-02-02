using AcademicApplication.Data.Entities;
using AcademicApplication.DTOs;
using AutoMapper;

namespace AcademicApplication.MappingProfiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Categoria, CategoriaDTO>().ReverseMap();
        }
    }
}
