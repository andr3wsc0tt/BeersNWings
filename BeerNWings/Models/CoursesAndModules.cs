using System.ComponentModel.DataAnnotations;
namespace BeerNWings.Models {
    public class CoursesAndModules {
        [Key]
        public string CourseName { get; set; }
        // public string ModuleTitle { get; set; }
        // public int Sequence { get; set; }

        public CoursesAndModules () { }

        public CoursesAndModules (string courseName, string moduleTitle, int sequence) {
            this.CourseName = courseName;
            // this.ModuleTitle = moduleTitle;
            // this.Sequence = sequence;
        }
    }
}