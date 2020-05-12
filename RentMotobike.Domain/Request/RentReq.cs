using System;
using System.Collections.Generic;
using System.Text;

namespace RentMotobike.Domain.Request.Rent
{
    public class RentReq
    {
        public int RentId { get; set; }
        public int MotobikeId { get; set; }
        public int CustomerId { get; set; }
        public DateTime FisrtDay { get; set; }
        public DateTime LastDay { get; set; }
        public int Price { get; set; }
    }
}
