using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThanhNguyen.Model.Models
{
    [Table("SupportOnline")]
    public class SupportOnline
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        public string Name { set; get; }

        [Required]
        public string Department { set; get; }

        public string Skype { set; get; }

        [Required]
        public string Mobile { set; get; }
        [Required]
        public string Email { set; get; }

        public string Facebook { set; get; }

        [Required]
        public bool Status { set; get; }
    }
}
