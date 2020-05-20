using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BeerNWings.Models;

namespace BeerNWings.Services {
    public interface ICoursesAndModulesService {
        Task<CoursesAndModules[]> GetCoursesAndModulesAsync ();
    }
}