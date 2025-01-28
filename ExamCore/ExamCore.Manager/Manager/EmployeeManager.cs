using ExamCore.Manager.Base;
using ExamCore.Manager.Contracts;
using ExamCore.Model.Models;
using ExamCore.Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamCore.Manager.Manager
{
    public class EmployeeManager:BaseManager<Employee>, IEmployeeManager
    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeManager(IEmployeeRepository employeeRepository) : base(employeeRepository) => _employeeRepository = employeeRepository;
        public override async Task<ICollection<Employee>> GetAllAsync()
        {
            return await _employeeRepository.GetAllAsync();
        }
    }
}
