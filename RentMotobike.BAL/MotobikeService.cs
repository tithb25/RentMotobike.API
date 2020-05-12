using RentMotobike.BAL.Interface;
using RentMotobike.DAL.Interface;
using RentMotobike.Domain.Request.Motobike;
using RentMotobike.Domain.Respone.Motobike;
using System;
using System.Collections.Generic;

namespace RentMotobike.BAL
{
    public class MotobikeService : IMotobikeService
    {
        private readonly IMotobikeRepository motobikeRepository;

        public MotobikeService(IMotobikeRepository _motobikeRepository)
        {
            motobikeRepository = _motobikeRepository;
        }

        public MotobikeRes CreateMotobike(MotobikeReq motobikeReq)
        {
            return motobikeRepository.CreateMotobike(motobikeReq);
        }

        public bool DeleteMotobike(int id)
        {
            return motobikeRepository.DeleteMotobike(id);
        }

        public MotobikeReq GetMotobikeById(int id)
        {
            return motobikeRepository.GetMotobikeById(id);
        }

        public IList<MotobikeReq> ListMotobike()
        {
            return motobikeRepository.ListMotobike();
        }

        public MotobikeRes UpdateMotobike(int id, MotobikeReq motobikeReq)
        {
            return motobikeRepository.UpdateMotobike(id, motobikeReq);
        }
    }
}
