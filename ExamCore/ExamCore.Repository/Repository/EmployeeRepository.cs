using ExamCore.Model.Models;
using ExamCore.Repository.Base;
using ExamCore.Repository.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamCore.Repository.Repository
{
    public class EmployeeRepository:BaseRepository<Employee>, IEmployeeRepository
    {
        public override async Task<ICollection<Employee>> GetAllAsync()
        {
            var employees = await dbContext.Employees.Where(e => !e.IsDeleted).ToListAsync();
            return employees;
        }
    }
}
