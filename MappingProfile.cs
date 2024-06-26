﻿using AutoMapper;
using StudentSystem_WebApiDB.Data.DTO.LectorDTO;
using StudentSystem_WebApiDB.Data.DTO.StudentDTO;
using StudentSystem_WebApiDB.Data.Models;

namespace StudentSystem_WebApiDB
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Student, StudentCreateDTO>().ReverseMap();
            CreateMap<Student, StudentUpdateDTO>().ReverseMap();
            CreateMap<Lector, LectorCreateDTO>().ReverseMap();
            CreateMap<Lector, LectorUpdateDTO>().ReverseMap();
        }
    }
}
