using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.DTOs;
using Services.Implementations;

namespace WEB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CallsController : ControllerBase
    {
        CallServices services = new CallServices();
        [HttpGet]
        public List<CallDTO> Get()
        {
            return services.Get();
        }
        [HttpGet("id")]
        public CallDTO GetByID(int id)
        {
            return services.GetByID(id);
        }

        [HttpPost]
        public string Save(CallDTO callDTO)
        {
            if (services.Save(callDTO))
            {
                return "Call saved succesfully!";
            }
            else return "Call was not saved!";
        }

        [HttpDelete]
        public string Delete(int id)
        {
            if (services.Delete(id))
            {
                return "Call deleted succesfully!";
            }
            else return "Call was not found!";
        }
    }
}
