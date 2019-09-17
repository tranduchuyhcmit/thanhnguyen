using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThanhNguyen.Model.Abstract;

namespace ThanhNguyen.Model.Models
{
    [Table("Pages")]
    public class Page : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }
        
        [Required]
        [MaxLength(256)]
        public string Name { set; get; }

        public string Content { set; get; }
        
    }
}
