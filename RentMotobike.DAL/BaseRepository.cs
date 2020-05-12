using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace RentMotobike.DAL
{
    public class BaseRepository
    {
        protected IDbConnection con;
        public BaseRepository()
        {
            string connectString = @"Server=ADMIN;Database=RentMotobike;Trusted_Connection=True;MultipleActiveResultSets=true;";
            con = new SqlConnection(connectString);
        }
    }
}
