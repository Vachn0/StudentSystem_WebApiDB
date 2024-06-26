﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentSystem_WebApiDB.Data.DTO.StudentDTO;
using StudentSystem_WebApiDB.Data.Models;
using StudentSystem_WebApiDB.Interface;
using StudentSystem_WebApiDB.Services;

namespace StudentSystem_WebApiDB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet]
        public async Task<ICollection<Student>> GetAll()
        {
            var result = await _studentService.GetAll();
            return result;
        }
        [HttpGet("Group Students By Lector ID")]
        public async Task<List<List<Student>>> GroupByLectorId()
        {
            var result = await _studentService.GroupByLectorId();
            return result;
        }
        [HttpGet("{id}")]
        public async Task<Student> GetStudentByID(int id)
        {
            var result = await _studentService.GetStudentByID(id);
            return result;
        }
        [HttpPost]
        public async Task<bool> CreateStudent(StudentCreateDTO model)
        {
            var result = await _studentService.CreateStudent(model);
            return true;
        }
        [HttpPut]
        public async Task<bool> UpdateStudent(StudentUpdateDTO model)
        {
            var result = await _studentService.UpdateStudent(model);
            return true;
        }
        [HttpDelete]
        public async Task<bool> DeleteStudent(int id)
        {
            var result = await _studentService.DeleteStudent(id);
            return result;
        }
        [HttpGet("Average Age")]
        public async Task<string> GetAverageAge()
        {
            var result = await _studentService.GetAverageAge();
            return $"Average Age\n{result}";
        }
        [HttpGet("MinMaxAvg Grade")]
        public async Task<string> GetGradeMinMaxAvg()
        {
            var result = await _studentService.GetGradeMinMaxAvg();
            return $"MinMaxAvg Grade\n{result}";
        }
    }
}
