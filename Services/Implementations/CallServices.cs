using Data.Entities;
using Repository;
using Services.DTOs;
using System;
using System.Collections.Generic;
using System.Globalization;
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
                        DateOfCall = item.DateOfCall.Date.ToString("dd-MM-yyyy"),
                        StartOfCall = item.StartOfCall.TimeOfDay.ToString(),
                        EndOfCall = item.EndOfCall.TimeOfDay.ToString(),
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
                        DateOfCall = call.DateOfCall.Date.ToString("dd-MM-yyyy"),
                        StartOfCall = call.StartOfCall.TimeOfDay.ToString(),
                        EndOfCall = call.EndOfCall.TimeOfDay.ToString(),
                        EmployeeId = call.EmployeeId,
                        ClientId = call.ClientId
                    };
                }
            }
            return callDTO;
        }

        public bool Save(CallDTO callDTO)
        {
            var getStart = (callDTO.DateOfCall + " " + callDTO.StartOfCall).Split(' ', '-',':','.').Select(w => int.Parse(w)).ToList();
            var getEnd = (callDTO.DateOfCall + " " + callDTO.EndOfCall).Split(' ', '-', ':', '.').Select(w=>int.Parse(w)).ToList();

            Call call = new Call
            {

                Id = callDTO.Id,
                DateOfCall = new DateTime(getStart[2],getStart[1],getStart[0]),
                StartOfCall = new DateTime(getStart[2], getStart[1], getStart[0], getStart[3], getStart[4], getStart[5]),
                EndOfCall = new DateTime(getEnd[2], getEnd[1], getEnd[0], getEnd[3], getEnd[4], getEnd[5]),
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