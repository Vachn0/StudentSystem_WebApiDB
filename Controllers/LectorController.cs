using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentSystem_WebApiDB.Data.DTO.LectorDTO;
using StudentSystem_WebApiDB.Data.DTO.StudentDTO;
using StudentSystem_WebApiDB.Data.Models;
using StudentSystem_WebApiDB.Interface;
using StudentSystem_WebApiDB.Services;

namespace StudentSystem_WebApiDB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LectorController : ControllerBase
    {
        private readonly ILectorService _lectorService;

        public LectorController(ILectorService lectorService)
        {
            _lectorService = lectorService;
        }
        [HttpGet]
        public async Task<ICollection<Lector>> GetAll()
        {
            var result = await _lectorService.GetAll();
            return result;
        }
        [HttpGet("{id}")]
        public async Task<Lector> GetLectorByID(int id)
        {
            var result = await _lectorService.GetLectorByID(id);
            return result;
        }

        [HttpPost]
        public async Task<bool> CreateLector(LectorCreateDTO model)
        {
            var result = await _lectorService.CreateLector(model);
            return true;
        }
        [HttpPut]
        public async Task<bool> UpdateStudent(LectorUpdateDTO model)
        {
            var result = await _lectorService.UpdateLector(model);
            return true;
        }
        [HttpDelete]
        public async Task<bool> DeleteStudent(int id)
        {
            var result = await _lectorService.DeleteLector(id);
            return result;
        }
    }
}
