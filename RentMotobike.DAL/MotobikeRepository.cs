using Dapper;
using RentMotobike.DAL.Interface;
using RentMotobike.Domain.Request.Motobike;
using RentMotobike.Domain.Respone.Motobike;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace RentMotobike.DAL
{
    public class MotobikeRepository : BaseRepository, IMotobikeRepository
    {
        public MotobikeRes CreateMotobike(MotobikeReq motobikeReq)
        {
            var result = new MotobikeRes()
            {
                Result = 0,
                Message = $"Lỗi , Hãy thử lại !"
            };
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@MotobikeId", motobikeReq.MotobikeId);
                parameters.Add("@MotobikeName", motobikeReq.MotobikeName);
                parameters.Add("@LicensePlates", motobikeReq.LicensePlates);
                parameters.Add("@Price", motobikeReq.Price);
                parameters.Add("@Status", motobikeReq.Status);
                parameters.Add("@Image", motobikeReq.Image);
                var respone = SqlMapper.ExecuteScalar<int>(con, "proc_CreateMotobike",
                                                                param: parameters,
                                                                commandType: CommandType.StoredProcedure);
                result.Result = motobikeReq.MotobikeId;
                result.Message = $"Tạo mới thành công!";

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool DeleteMotobike(int id)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("MotobikeId", id);
                var delMotobike = SqlMapper.ExecuteScalar<bool>(con, "proc_DeleteMotobike", param: parameters, commandType: CommandType.StoredProcedure);
                return delMotobike;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public MotobikeReq GetMotobikeById(int id)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("MotobikeId", id);
            MotobikeReq motobikeReq = SqlMapper.Query<MotobikeReq>(con, "proc_GetMotobikeById", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
            return motobikeReq;
        }

        public IList<MotobikeReq> ListMotobike()
        {
            IList<MotobikeReq> listMotobike = SqlMapper.Query<MotobikeReq>(con, "proc_GetMotobike", commandType: CommandType.StoredProcedure).ToList();
            return listMotobike;
        }

        public MotobikeRes UpdateMotobike(int id, MotobikeReq motobikeReq)
        {
            var result = new MotobikeRes()
            {
                Result = 0,
                Message = $"Lỗi , Hãy thử lại !"
            };
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@MotobikeId", id);
                parameters.Add("@MotobikeName", motobikeReq.MotobikeName);
                parameters.Add("@LicensePlates", motobikeReq.LicensePlates);
                parameters.Add("@Price", motobikeReq.Price);
                parameters.Add("@Status", motobikeReq.Status);
                parameters.Add("@Image", motobikeReq.Image);
                var respone = SqlMapper.ExecuteScalar<int>(con, "proc_UpdateMotobike",
                                                                param: parameters,
                                                                commandType: CommandType.StoredProcedure);
                result.Result = motobikeReq.MotobikeId;
                result.Message = motobikeReq.MotobikeId != id ? $"Not Found!" : $"Cập nhật thành công!";

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
