using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThanhNguyen.Model.Models
{
    [Table("OrderDetails")]
    public class OrderDetail
    {
        [Key]
        [Column(Order =1)]
        public int OrderID { set; get; }

        [Key]
        [Column(Order = 2)]
        public int ProductID { set; get; }

        public int Quantity { set; get; }



        //-----------------------------------
        //Khóa ngoại trỏ đến bảng Orders
        [ForeignKey("OrderID")]
        public virtual Order Order { set; get; }

        //Khóa ngoại trỏ đến Products
        [ForeignKey("ProductID")]
        public virtual Product Product { set; get; }
    }
}
