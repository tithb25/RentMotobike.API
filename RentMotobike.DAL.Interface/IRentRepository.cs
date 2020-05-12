using RentMotobike.Domain.Request.Rent;
using RentMotobike.Domain.Respone;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentMotobike.DAL.Interface
{
    public interface IRentRepository
    {
        IList<RentReq> ListRent();
        RentReq GetRentById(int id);
        RentRes CreateRent(RentReq rentReq);
        RentRes UpdateRent(int id, RentReq rentReq);
        bool DeleteRent(int id);
    }
}
