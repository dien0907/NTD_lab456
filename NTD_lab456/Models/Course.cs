

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NTD_lab456.Models
{
    public class Course
    {
        public int Id { get; set; }

        public ApplicationUser Lecturer { get; set; }
        [Required]
        public string LecturerId { get; set; }
        [Required]
        [StringLength(255)]
        public string Place { get; set; }
        public DateTime DataTime { get; set; }

        private Category category;

        public Category GetCategory()
        {
            return category;
        }

        public void SetCategory(Category value)
        {
            category = value;
        }

        [Required]
        public byte CategoryId { get; set; }
    }
}