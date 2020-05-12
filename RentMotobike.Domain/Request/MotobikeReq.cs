using System;
using System.Collections.Generic;
using System.Text;

namespace RentMotobike.Domain.Request.Motobike
{
    public class MotobikeReq
    {
        public int MotobikeId { get; set; }
        public string MotobikeName { get; set; }
        public string LicensePlates { get; set; }
        public int Price { get; set; }
        public bool Status { get; set; }
        public string Image { get; set; }
    }
}
