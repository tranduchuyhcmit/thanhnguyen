using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThanhNguyen.Model.Models
{
    [Table("PostTags")]
    public class PostTag
    {
        [Key]
        [Column(Order =1)]
        public int PostID { set; get; }

        [Key]
        [Column(TypeName ="varchar", Order = 2)]
        [MaxLength(50)]
        public string TagID { set; get; }

        //Khóa ngoại trỏ đến Posts
        [ForeignKey("PostID")]
        public virtual Post Post { set; get; }

        //Khóa ngoại trỏ đến Tags
        [ForeignKey("TagID")]
        public virtual Tag Tag { set; get; }

    }
}
