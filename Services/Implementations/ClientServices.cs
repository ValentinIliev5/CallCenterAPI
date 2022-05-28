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
    public class ClientServices
    {
        public List<ClientDTO> Get()
        {
            List<ClientDTO> clientDTOs = new List<ClientDTO>();

            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                foreach (var item in unitOfWork.ClientsRepository.Get())
                {

                    clientDTOs.Add(new ClientDTO
                    {
                        Id = item.Id,
                        Name = item.Name,
                        Age = item.Age,
                        PhoneNumber = item.PhoneNumber,
                        CallsMade = item.CallsMade
                    });

                }
            }
            return clientDTOs;
        }

        public ClientDTO GetByID(int id)
        {
            ClientDTO clientDTO = new ClientDTO();

            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                Client client = unitOfWork.ClientsRepository.GetByID(id);
                if (client != null)
                {
                    clientDTO = new ClientDTO
                    {
                        Id = client.Id,
                        Name = client.Name,
                        Age = client.Age,
                        PhoneNumber = client.PhoneNumber,
                        CallsMade= client.CallsMade
                    };
                }
            }
            return clientDTO;
        }

        public bool Save(ClientDTO clientDTO)
        {
            Client client = new Client
            {
                Id = clientDTO.Id,
                Name = clientDTO.Name,
                Age = clientDTO.Age,
                PhoneNumber = clientDTO.PhoneNumber
            };

            try
            {
                using (UnitOfWork unitOfWork = new UnitOfWork())
                {
                    unitOfWork.ClientsRepository.Insert(client);
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
                    Client client = unitOfWork.ClientsRepository.GetByID(id);
                    unitOfWork.ClientsRepository.Delete(client);
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
