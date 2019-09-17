using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThanhNguyen.Model.Models
{
    [Table("ProductTags")]
    public class ProductTag
    {
        [Key]
        [Column(Order =1)]
        public int ProductID { set; get; }

        [Key]
        [Column(TypeName ="varchar", Order =2)]
        [MaxLength(50)]
        public string TagID { set; get; }

        //Khóa ngoại trỏ đến Products
        [ForeignKey("ProductID")]
        public virtual Product Product { set; get; }

        //Khóa ngoại trỏ đến Tags
        [ForeignKey("TagID")]
        public virtual Tag Tag { set; get; }
    }
}
