using FlowerApp.Models;
using FlowerApp.ViewModels;
using System.Collections.Generic;

namespace FlowerApp.Repository
{
    public interface IFlowerRepository
    {
        IEnumerable<Flower> Flowers { get; }

        IEnumerable<Flower> FlowerPresentation { get; }

        IEnumerable<FlowerViewModel> FlowersAsViewModel
        {
            get;
        }

        IEnumerable<string> FlowersNames
        {
            get;
        }

        Flower GetFlowerById(int flowerId);

        bool AddFlower(Flower flower);

        bool DeleteFlower(Flower flower);

        bool UpdateFlower(Flower flower);
    }
}
