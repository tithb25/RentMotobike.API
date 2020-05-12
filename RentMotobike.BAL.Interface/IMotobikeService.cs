using RentMotobike.Domain.Request.Motobike;
using RentMotobike.Domain.Respone.Motobike;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentMotobike.BAL.Interface
{
    public interface IMotobikeService
    {
        IList<MotobikeReq> ListMotobike();
        MotobikeReq GetMotobikeById(int id);
        MotobikeRes CreateMotobike(MotobikeReq motobikeReq);
        MotobikeRes UpdateMotobike(int id, MotobikeReq motobikeReq);
        bool DeleteMotobike(int id);
    }
}
