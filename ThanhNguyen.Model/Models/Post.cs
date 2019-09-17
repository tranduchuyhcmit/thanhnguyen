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
    [Table("Posts")]

    public class Post : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        [MaxLength(256)]
        public string Name { set; get; }

        [Required]
        [MaxLength(256)]
        [Column(TypeName ="varchar")]
        public string Alias { set; get; }

        [Required]
        public int CategoryID { set; get; }

        [MaxLength(256)]
        public string Image { set; get; }

        [MaxLength(500)]
        public string Description { set; get; }
        public string Content { set; get; }

        public bool? HomeFlag { set; get; }
        public bool? HostFlag { set; get; }
        public int? ViewCount { set; get; }

        //Khóa ngoại trỏ đến PostCategories
        [ForeignKey("CategoryID")]
        public virtual PostCategory PostCategory { set; get; }

        //PostTags đã trỏ đến Post
        public virtual IEnumerable<PostTag> PostTags { set; get; }

    }
}
