using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithASPNETUdemy.Model
{
    [Table("books")]
    public class Books
    {
        [Column("id")]
        public long Id { get; set; }

        [Column("author")]
        public string FirstName { get; set; }

        [Column("launch_date")]
        public string LastName { get; set; }

        [Column("price")]
        public string Address { get; set; }
        [Column("title")]
        public string Gender { get; set; }
    }
}
