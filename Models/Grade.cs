using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lab9.Models
{
    public class Grade
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; } = "";
        public float Grade1 { get; set; }
        public float Grade2 { get; set; }
        public float Grade3 { get; set; }
        public string EnYear { get; set; } = "";
        public int Gpa { get; set; }

        public Grade()
        {
            this.StudentId = -1;
        }

        public void CalculateGPA()
        {
            float GradePoints = this.Grade1 + this.Grade2 + this.Grade3;
            this.Gpa = Convert.ToInt32(GradePoints / 3);
        }
    }
}