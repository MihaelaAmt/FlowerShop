using FlowerApp.Models;
using System.Collections.Generic;

namespace FlowerApp.Repository
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> Categories { get; }
    }
}
