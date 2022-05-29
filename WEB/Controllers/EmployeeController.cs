﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.DTOs;
using Services.Implementations;

namespace WEB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        EmployeeServices services = new EmployeeServices();
        [HttpGet]
        public List<EmployeeDTO> Get()
        {
            return services.Get();
        }
        [HttpGet("id")]
        public EmployeeDTO GetByID(int id)
        {
            return services.GetByID(id);
        }

        [HttpPost]
        public string Save(EmployeeDTO employeeDTO)
        {
            if (services.Save(employeeDTO))
            {
                return "Employee saved succesfully!";
            }
            else return "Employee was not saved!";
        }

        [HttpDelete]
        public string Delete(int id)
        {
            if (services.Delete(id))
            {
                return "Employee deleted succesfully!";
            }
            else return "Employee was not deleted!";
        }
    }
}
