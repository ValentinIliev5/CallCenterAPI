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
    public class CallServices
    {
        public List<CallDTO> Get()
        {
            List<CallDTO> callDTOs = new List<CallDTO>();

            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                foreach (var item in unitOfWork.CallsRepository.Get())
                {

                    callDTOs.Add(new CallDTO
                    {
                        Id = item.Id,
                        DateOfCall = item.DateOfCall,
                        StartOfCall = item.StartOfCall,
                        EndOfCall = item.EndOfCall,
                        EmployeeId = item.EmployeeId,
                        ClientId = item.ClientId,
                        
                    });

                }
            }
            return callDTOs;
        }

        public CallDTO GetByID(int id)
        {
            CallDTO callDTO = new CallDTO();

            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                Call call = unitOfWork.CallsRepository.GetByID(id);
                if (call != null)
                {
                    callDTO = new CallDTO
                    {
                        Id = call.Id,
                        DateOfCall = call.DateOfCall,
                        StartOfCall = call.StartOfCall,
                        EndOfCall = call.EndOfCall,
                        EmployeeId = call.EmployeeId,
                        ClientId = call.ClientId
                    };
                }
            }
            return callDTO;
        }

        public bool Save(CallDTO callDTO)
        {
            Call call = new Call
            {
                Id = callDTO.Id,
                DateOfCall = callDTO.DateOfCall,
                StartOfCall = callDTO.StartOfCall,
                EndOfCall = callDTO.EndOfCall,
                EmployeeId = callDTO.EmployeeId,
                ClientId = callDTO.ClientId
            };

            try
            {
                using (UnitOfWork unitOfWork = new UnitOfWork())
                {
                    unitOfWork.CallsRepository.Insert(call);
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
                    Call call = unitOfWork.CallsRepository.GetByID(id);
                    unitOfWork.CallsRepository.Delete(call);
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
