using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using StudentSystem_WebApiDB.Data;
using StudentSystem_WebApiDB.Data.DTO.StudentDTO;
using StudentSystem_WebApiDB.Data.Models;
using StudentSystem_WebApiDB.Interface;

namespace StudentSystem_WebApiDB.Services
{
    public class StudentService : IStudentService
    {
        //(CRUD(Create, Read, Update, Delete)
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;

        public StudentService(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        //GetAll = Read
        public async Task<ICollection<Student>> GetAll()
        {

            var students = await _db.student.ToListAsync();
            if (students is null)
            {
                return null;
            }
            return students;
        }
        public async Task<List<List<Student>>> GroupByLectorId()
        {
            var students = await _db.student
                    .GroupBy(student => student.LectorID)
                    .Select(group => group.ToList())
                    .ToListAsync();

            return students;
        }
        //GetByID
        public async Task<Student> GetStudentByID(int id)
        {
            try
            {
                //EagerLoading
                var student = await _db.student.Include(x => x.Lectors).FirstOrDefaultAsync(s => s.StudentID == id);

                if (student is null)
                {
                    return null;
                }
                return student;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        //Create
        public async Task<bool> CreateStudent(StudentCreateDTO studentDTO)
        {
            try
            {
                var student = _mapper.Map<Student>(studentDTO);
                await _db.student.AddAsync(student);

                await _db.SaveChangesAsync();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        //Update
        public async Task<bool> UpdateStudent(StudentUpdateDTO studentDTO)
        {
            try
            {
                var studentToUpdate = await _db.student.FirstOrDefaultAsync(x => x.StudentID == studentDTO.StudentID);

                if (studentToUpdate is null)
                    return false;

                _mapper.Map(studentDTO, studentToUpdate);

                _db.student.Update(studentToUpdate);
                await _db.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        //Delete
        public async Task<bool> DeleteStudent(int id)
        {
            try
            {
                var studentToDelete = await _db.student.FirstOrDefaultAsync(x => x.StudentID == id);

                if (studentToDelete is null)
                    return false;
                studentToDelete = _mapper.Map<Student>(studentToDelete);

                _db.student.Remove(studentToDelete);
                await _db.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        //AggregationFunctions (Average Age, Average Grade)
        public async Task<string> GetAverageAge()
        {
            try
            {
                var avgAge = "Average Student Age is " + _db.student.Average(x => DateTime.Now.Year - x.DateOfBirth.Year);
                return avgAge;
            }
            catch (Exception ex)
            {
                return $"Error occured! + {ex}";
            }
        }
        public async Task<string> GetGradeMinMaxAvg()
        {
            try
            {
                var maxGrade = "Max Grade = " + _db.student.Max(x => x.Grade);
                var minGrade = "Min Grade = " + _db.student.Min(x => x.Grade);
                var avgGrade = "Average Grade = " + _db.student.Average(x => x.Grade);
                return $"{maxGrade}\n{minGrade}\n{avgGrade}";
            }
            catch (Exception ex)
            {
                return $"Error occured! + {ex}";
            }
        }
    }
}
