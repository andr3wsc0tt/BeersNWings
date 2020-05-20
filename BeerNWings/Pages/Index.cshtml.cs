using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BeerNWings.Controllers;
using BeerNWings.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BeerNWings.Pages {
    public class CoursesAndModulesModel : PageModel {
        DataAccessController dac = new DataAccessController ();

        public List<CoursesAndModules> CoursesAndModules;

        public void OnGet () {
            CoursesAndModules = dac.GetAllCoursesAndModules ().ToList ();
        }
    }
}