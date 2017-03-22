using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProfilerApp.Models
{
    [Table("students")]
    public class Student
    {
        [Key]
        [Column("EnrolId")]
        public int EnrolId { get; set; }

        public string StudentName { get; set; }

        public string Grade { get; set; }

        public string StudentDescription { get; set; }

        public DateTime JoiningDate { get; set; }
    }
}