using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekBrains.Lesson8.Data
{
    public interface IRepository
    {
        Task<List<ListOfStudentDTO>> GetStudents();
    }
    /// <summary>
    /// 
    /// </summary>
    public class Repository : IRepository
    {
        public async Task<List<ListOfStudentDTO>> GetStudents()
        {
            var db = new StudentsContext();
            var Result = await db.ListOfStudent.ToListAsync();
            var ResultMapped = Mapping.Mapper.Map<List<ListOfStudentDTO>>(Result);
            return ResultMapped;
        }
    }
}
