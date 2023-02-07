﻿using System;
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
        [Required]
        public int Project { get; set; }
        [Required]
        public int Quizzes { get; set; }
        [Required]
        public int Midterm { get; set; }
        [Required]
        public int Final { get; set; }
        [Required]
        public int Intex { get; set; }
    }
}
