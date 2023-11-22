using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreCodeFirstTogether_START.Data
{
    public class Person
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Range(15, 100)]
        public int Age { get; set; }

        public List<Invoice> Invoices { get; set; } = new List<Invoice>();

        [Range(1, 60)]
        public int ShoeSize { get; set; }

        public County County { get; set; }
    }
}
