using FlowerApp.Models;
using System.Collections.Generic;

namespace FlowerApp.Repository
{
    //create the interface
    //interface for Category
    public interface ICategoryRepository
    {
        //iteration for categories
        IEnumerable<Category> Categories { get; }
    }
}
