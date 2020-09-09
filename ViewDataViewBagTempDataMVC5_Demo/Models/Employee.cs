﻿using System;
using System.ComponentModel.DataAnnotations;

namespace ViewDataViewBagTempDataMVC5_Demo.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(100)]
        public string Position { get; set; }

        [Required]
        [StringLength(100)]
        public string Office { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public int Salary { get; set; }
    }
}