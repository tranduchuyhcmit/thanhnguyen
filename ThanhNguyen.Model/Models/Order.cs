using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ThanhNguyen.Model.Abstract;

namespace ThanhNguyen.Model.Models
{
    [Table("Orders")]
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        [MaxLength(256)]
        public string CustomerName { set; get; }
        [Required]
        [MaxLength(256)]
        public string CustomerAddress { set; get; }
        [Required]
        [MaxLength(256)]
        public string CustomerEmail { set; get; }
        [Required]
        [MaxLength(256)]
        public string CustomerMobile { set; get; }

        [MaxLength(256)]
        public string CustomerMessage { set; get; }

        public DateTime? CreatedDate { set; get; }
        public string CreatedBy { set; get; }

        [MaxLength(256)]
        public string PaymentMethod { set; get; }
        [Required]
        public string PaymentStatus { set; get; }

        public bool Status { set; get; }




        //-----------------------------------
        //OrderDetails đã trỏ đến Orders
        public virtual IEnumerable<OrderDetail> OrderDetails { set; get; }
    }
}
