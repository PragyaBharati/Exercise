using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebAppExGit.Models
{
    [Table("Emp")]
    public class Emp
    {
        [Key]
        public int Eid { get; set; }
        public string Ename { get; set; }
        public string EDesing { get; set; }
        public DateTime EDOJ { get; set; }
    }
}