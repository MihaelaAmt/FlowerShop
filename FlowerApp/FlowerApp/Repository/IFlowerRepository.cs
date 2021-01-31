using FlowerApp.Models;
using FlowerApp.ViewModels;
using System.Collections.Generic;

namespace FlowerApp.Repository
{
    //create interface for Flower
    public interface IFlowerRepository
    {
        //iteration for flower
        IEnumerable<Flower> Flowers { get; }

        //iteration for flower presentation
        IEnumerable<Flower> FlowerPresentation { get; }

        IEnumerable<FlowerViewModel> FlowersAsViewModel
        {
            get;
        }

        //iteration for Flowers name
        IEnumerable<string> FlowersNames
        {
            get;
        }

        Flower GetFlowerById(int flowerId);

        //add flower
        bool AddFlower(Flower flower);

        //delete flower
        bool DeleteFlower(Flower flower);

        //update flower
        bool UpdateFlower(Flower flower);
    }
}
