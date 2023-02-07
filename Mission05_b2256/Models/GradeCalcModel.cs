using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission05_b2256.Models
{
    public class GradeCalcModels
    {
        [Required]
        public string Assignment { get; set; }

        //setter

        public int Project { get; set; }
        public int Quizzes { get; set; }
        public int Midterm { get; set; }

        public int Final { get; set; }
        public int Intex { get; set; }
    }
}
