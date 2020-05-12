using Dapper;
using RentMotobike.DAL.Interface;
using RentMotobike.Domain.Request.Rent;
using RentMotobike.Domain.Respone;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace RentMotobike.DAL
{
    public class RentRepository : BaseRepository, IRentRepository
    {
        public RentRes CreateRent(RentReq rentReq)
        {
            var result = new RentRes()
            {
                Result = 0,
                Message = $"Lỗi , Hãy thử lại !"
            };
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@RentId", rentReq.RentId);
                parameters.Add("@MotobikeId", rentReq.MotobikeId);
                parameters.Add("@CustomerId", rentReq.CustomerId);
                parameters.Add("@FisrtDay", rentReq.FisrtDay);
                parameters.Add("@LastDay", rentReq.LastDay);
                parameters.Add("@Price", rentReq.Price);
                var respone = SqlMapper.ExecuteScalar<int>(con, "proc_CreateRent",
                                                                param: parameters,
                                                                commandType: CommandType.StoredProcedure);
                result.Result = rentReq.RentId;
                result.Message = $"Tạo mới thành công!";

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool DeleteRent(int id)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("RentId", id);
                var delRent = SqlMapper.ExecuteScalar<bool>(con, "proc_DeleteRent", commandType: CommandType.StoredProcedure);
                return delRent;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public RentReq GetRentById(int id)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("RentId", id);
            RentReq rentReq = SqlMapper.Query<RentReq>(con, "proc_GetRentById", commandType: CommandType.StoredProcedure).FirstOrDefault();
            return rentReq;
        }

        public IList<RentReq> ListRent()
        {
            IList<RentReq> listRent = SqlMapper.Query<RentReq>(con, "proc_GetRent", commandType: CommandType.StoredProcedure).ToList();
            return listRent;
        }

        public RentRes UpdateRent(int id, RentReq rentReq)
        {
            var result = new RentRes()
            {
                Result = 0,
                Message = $"Lỗi , Hãy thử lại !"
            };
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@RentId", id);
                parameters.Add("@MotobikeId", rentReq.MotobikeId);
                parameters.Add("@CustomerId", rentReq.CustomerId);
                parameters.Add("@FisrtDay", rentReq.FisrtDay);
                parameters.Add("@LastDay", rentReq.LastDay);
                parameters.Add("@Price", rentReq.Price);
                var respone = SqlMapper.ExecuteScalar<int>(con, "proc_UpdateRent",
                                                                param: parameters,
                                                                commandType: CommandType.StoredProcedure);
                result.Result = rentReq.RentId;
                result.Message = rentReq.RentId != id ? $"Not Found!" : $"Cập nhật thành công!";

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
