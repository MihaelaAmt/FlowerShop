﻿using FlowerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlowerApp.Repository
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> Categories { get; }
    }
}