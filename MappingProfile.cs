using AutoMapper;
using StudentSystem_WebApiDB.Data.DTO;
using StudentSystem_WebApiDB.Data.Models;

namespace StudentSystem_WebApiDB
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Student, StudentCreateDTO>().ReverseMap();
            CreateMap<Student, StudentUpdateDTO>().ReverseMap();
        }
    }
}
