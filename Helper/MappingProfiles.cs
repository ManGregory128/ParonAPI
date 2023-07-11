using AutoMapper;
using ParonAPI.Dto;
using ParonAPI.Models;

namespace ParonAPI.Helper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<School, SchoolDto>();
        }
    }
}
