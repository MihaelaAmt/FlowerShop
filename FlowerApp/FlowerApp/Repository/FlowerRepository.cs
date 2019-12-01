﻿using FlowerApp.Models;
using FlowerApp.ViewModels;
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

        public IEnumerable<string> FlowersNames
        {
            get
            {
                return _appDbContext.Flowers.Select(x => x.Name).ToList();
            }
        }

        public IEnumerable<Flower> FlowerPresentation
        {
            get
            {
                return _appDbContext.Flowers.Include(c => c.Category).Where(p => p.IsFlowerPresentation);
            }
        }

        public Flower GetFlowerById(int flowerId)
        {
            return _appDbContext.Flowers.FirstOrDefault(f => f.FlowerId == flowerId);
        }

        public IEnumerable<FlowerViewModel> FlowersAsViewModel
        {
            get
            {
                List<FlowerViewModel> flowers = new List<FlowerViewModel>();

                foreach (var dbFlower in Flowers)
                {
                    flowers.Add(MapDbFlowerToFlowerViewModel(dbFlower));
                }

                return flowers;
            }
        }

        private FlowerViewModel MapDbFlowerToFlowerViewModel(Flower dbFlower)
        {
            return new FlowerViewModel()
            {
                FlowerId = dbFlower.FlowerId,
                Name = dbFlower.Name,
                Price = dbFlower.Price,
                ShortDescription = dbFlower.ShortDescription,
                ImageThumbnailUrl = dbFlower.ImageThumbnailUrl
            };
        }
    }
}
    

