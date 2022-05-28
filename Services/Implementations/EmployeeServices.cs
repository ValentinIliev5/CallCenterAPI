using Data.Entities;
using Repository;
using Services.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Implementations
{
    public class EmployeeServices
    {
        public List<EmployeeDTO> Get()
        {
            List<EmployeeDTO> employeeDTOs = new List<EmployeeDTO>();

            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                foreach (var item in unitOfWork.EmployeesRepository.Get())
                {

                    employeeDTOs.Add(new EmployeeDTO
                    {
                        Id = item.Id,
                        Name = item.Name,
                        Age = item.Age,
                        PhoneNumber = item.PhoneNumber,
                        Salary = item.Salary,
                        Email = item.Email
                    });

                }
            }
            return employeeDTOs;
        }

        public EmployeeDTO GetByID()
        { 
            EmployeeDTO employeeDTO = new EmployeeDTO();

            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                Employee employee = unitOfWork.EmployeesRepository.GetByID(employeeDTO.Id);
                if (employee!=null)
                {
                    employeeDTO = new EmployeeDTO
                    {
                        Id = employee.Id,
                        Name = employee.Name,
                        Age = employee.Age,
                        PhoneNumber = employee.PhoneNumber,
                        Salary = employee.Salary,
                        Email = employee.Email
                    };
                }
            }
            return employeeDTO;
        }

        public bool Save(EmployeeDTO employeeDTO)
        {
            Employee employee = new Employee
            {
                Id = employeeDTO.Id,
                Name = employeeDTO.Name,
                Age = employeeDTO.Age,
                PhoneNumber = employeeDTO.PhoneNumber,
                Salary = employeeDTO.Salary,
                Email = employeeDTO.Email
            };

            try
            {
                using (UnitOfWork unitOfWork = new UnitOfWork())
                {
                    unitOfWork.EmployeesRepository.Insert(employee);
                    unitOfWork.Save();
                }
                return true;
            }
            catch (Exception)
            {
                return false;

            }
        }

        public bool Delete(int id)
        {
            try
            {
                using (UnitOfWork unitOfWork = new UnitOfWork())
                {
                    Employee employee = unitOfWork.EmployeesRepository.GetByID(id);
                    unitOfWork.EmployeesRepository.Delete(employee);
                    unitOfWork.Save();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            
        }
    }
}
