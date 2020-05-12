using RentMotobike.BAL.Interface;
using RentMotobike.DAL.Interface;
using RentMotobike.Domain.Request.Rent;
using RentMotobike.Domain.Respone;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentMotobike.BAL
{
    public class RentService : IRentService
    {
        private readonly IRentRepository rentRepository;

        public RentService(IRentRepository _rentRepository)
        {
            rentRepository = _rentRepository;
        }

        public RentRes CreateRent(RentReq rentReq)
        {
            return rentRepository.CreateRent(rentReq);
        }

        public bool DeleteRent(int id)
        {
            return rentRepository.DeleteRent(id);
        }

        public RentReq GetRentById(int id)
        {
            return rentRepository.GetRentById(id);
        }

        public IList<RentReq> ListRent()
        {
            return rentRepository.ListRent();
        }

        public RentRes UpdateRent(int id, RentReq rentReq)
        {
            return rentRepository.UpdateRent(id, rentReq);
        }
    }
}
