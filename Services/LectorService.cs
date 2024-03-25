using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StudentSystem_WebApiDB.Data;
using StudentSystem_WebApiDB.Data.DTO.LectorDTO;
using StudentSystem_WebApiDB.Data.Models;
using StudentSystem_WebApiDB.Interface;

namespace StudentSystem_WebApiDB.Services
{
    public class LectorService : ILectorService
    {
        //(CRUD(Create, Read, Update, Delete)
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;

        public LectorService(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<ICollection<Lector>> GetAll()
        {
            var lectors = await _db.lector.ToListAsync();
            if (lectors is null)
                return null;

            return lectors;
        }
        public async Task<Lector> GetLectorByID(int id)
        {
            var lectors = await _db.lector.FirstOrDefaultAsync(s => s.LectorID == id);
            if (lectors is null)
                return null;

            return lectors;
        }
        public async Task<bool> CreateLector(LectorCreateDTO LectorDTO)
        {
            try
            {
                var lectors = _mapper.Map<Lector>(LectorDTO);
                await _db.lector.AddAsync(lectors);
                await _db.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public async Task<bool> UpdateLector(LectorUpdateDTO LectorDTO)
        {
            try
            {
                var lectorToUpdate = await _db.lector.FirstOrDefaultAsync(x => x.LectorID == LectorDTO.LectorID);

                if (lectorToUpdate is null)
                    return false;

                _mapper.Map(LectorDTO, lectorToUpdate);

                _db.lector.Update(lectorToUpdate);
                await _db.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public async Task<bool> DeleteLector(int id)
        {
            try
            {
                var lectorToDelete = await _db.lector.FirstOrDefaultAsync(x => x.LectorID == id);

                if (lectorToDelete is null)
                    return false;
                lectorToDelete = _mapper.Map<Lector>(lectorToDelete);

                _db.lector.Remove(lectorToDelete);
                await _db.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
