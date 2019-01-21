using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DBATool.Data.Models
{
    public class Database
    {

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int Size { get; set; }

        [Display(Name = "Database Owner")]
        public Employee DatabaseOwner { get; set; }

        [Display(Name = "Primary DBA Support")]
        public Employee PrimaryDBA { get; set; }

        [Display(Name = "Backup DBA Support")]
        public Employee BackupDBA { get; set; }

        public int NumberOfUsers { get; set; }



    }
}
