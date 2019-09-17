using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ThanhNguyen.Model.Abstract;

namespace ThanhNguyen.Model.Models
{
    [Table("Products")]
    public class Product : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        [MaxLength(256)]
        public string Name { set; get; }

        [Required]
        [MaxLength(256)]
        public string Alias { set; get; }

        [Required]
        public int CategoryID { set; get; }

        [MaxLength(256)]
        public string Image { set; get; }

        [Column(TypeName ="xml")]
        public XElement MoreImage { set; get; }


        public decimal Price { set; get; }
        public decimal? Promotion { set; get; }
        public int? Warranty { set; get; }

        [MaxLength(256)]
        public string Description { set; get; }
        public string Content { set; get; }

        public bool? HomeFlag { set; get; }
        public bool? HostFlag { set; get; }
        public int? ViewCount { set; get; }

        //Thiếu Tags, Quantity, OriginalPrice 

        //Khóa ngoại trỏ đến ProdectCatogory
        [ForeignKey("CategoryID")]
        public virtual ProductCategory ProductCategory { set; get; }


        //ProductTags đã trỏ đến Products
        public virtual IEnumerable<ProductTag> ProductTags { set; get; }
    }
}
