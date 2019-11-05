using FlowerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlowerApp.Repository
{
    public interface IFlowerRepository
    {
        IEnumerable<Flower> Flowers { get; }

        IEnumerable<Flower> FlowerPresentation { get; }

        Flower GetFlowerById(int flowerId);

    }
}
