using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.DTOs;
using Services.Implementations;

namespace WEB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        ClientServices services = new ClientServices();
        [HttpGet]
        public List<ClientDTO> Get()
        {
            return services.Get();
        }
        [HttpGet("GetById/{id}")]
        public ClientDTO GetByID(int id)
        {
            return services.GetByID(id);
        }
        [HttpGet()]
        [Route("GetByName/{name}")]
        public List<ClientDTO> GetByName(string name)
        {
            return services.GetByName(name);
        }
        [HttpPost]
        public string Save(ClientDTO clientDTO)
        {
            if (services.Save(clientDTO))
            {
                return "Client saved succesfully!";
            }
            else return "Client was not saved!";
        }

        [HttpDelete]
        public string Delete(int id)
        {
            if (services.Delete(id))
            {
                return "Client deleted succesfully!";
            }
            else return "Client was not found!";
        }
    }
}
