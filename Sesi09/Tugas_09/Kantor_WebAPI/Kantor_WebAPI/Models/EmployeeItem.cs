using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kantor_WebAPI.Models
{
    public class EmployeeItem
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string nama { get; set; }
        [Required]
        public string jenisKelamin { get; set; }
        [Required]
        public string alamat { get; set; }
    }
}
