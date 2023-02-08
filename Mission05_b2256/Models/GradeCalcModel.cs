using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission05_b2256.Models
{
    public class GradeCalcModels
    {
        //Models for each of the variable values that can be used to calculate grades
        //They are required and must be between 0 and 100
        [Required]
        [Range(0, 100, ErrorMessage = "Group Assignment score must be between 0 and 100")]
        public int Assignment { get; set; }

        [Required]
        [Range(0, 100, ErrorMessage = "Project score must be between 0 and 100")]
        public int Project { get; set; }

        [Required]
        [Range(0, 100, ErrorMessage = "Quiz score must be between 0 and 100")]
        public int Quizzes { get; set; }

        [Required]
        [Range(0, 100, ErrorMessage = "Midterm score must be between 0 and 100")]
        public int Midterm { get; set; }

        [Required]
        [Range(0, 100, ErrorMessage = "Final score must be between 0 and 100")]
        public int Final { get; set; }

        [Required]
        [Range(0, 100, ErrorMessage = "Intex score must be between 0 and 100")]
        public int Intex { get; set; }

    }
}
