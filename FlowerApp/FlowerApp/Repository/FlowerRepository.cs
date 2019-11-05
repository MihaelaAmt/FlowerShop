using FlowerApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlowerApp.Repository
{
    public class FlowerRepository : IFlowerRepository
    {
        private readonly AppDbContext _appDbContext;

        public FlowerRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Flower> Flowers
        {
            get
            {
                return _appDbContext.Flowers.Include(c => c.Category);
            }
        }


        public Flower GetFlowerById(int flowerId)
        {
            return _appDbContext.Flowers.FirstOrDefault(f => f.FlowerId == flowerId);
        }
    }
}
    

