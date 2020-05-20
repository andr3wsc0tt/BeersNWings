using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BeerNWings.Models;
using BeerNWings.Services;
using Microsoft.AspNetCore.Mvc;

namespace BeerNWings.Controllers {
    public class CoursesController : Controller {

        private readonly ICoursesAndModulesService _coursesItemService;
        public CoursesController (ICoursesAndModulesService coursesItemService) {
            _coursesItemService = coursesItemService;
        }
        public async Task<IActionResult> Index () {
            var items = await _coursesItemService.GetCoursesAndModulesAsync ();
            var model = new CoursesAndModulesViewModel () {
                Courses = items
            };

            return View (model);
        }
    }
}