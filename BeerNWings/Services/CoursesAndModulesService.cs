using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BeerNWings.Data;
using BeerNWings.Models;
using Microsoft.EntityFrameworkCore;

namespace BeerNWings.Services {
    public class CoursesAndModulesService : ICoursesAndModulesService {
        private readonly ApplicationDbContext _context;
        public CoursesAndModulesService (ApplicationDbContext context) {
            _context = context;
        }
        public async Task<CoursesAndModules[]> GetCoursesAndModulesAsync () {
            return await _context.Courses
                .ToArrayAsync ();
        }
    }
}