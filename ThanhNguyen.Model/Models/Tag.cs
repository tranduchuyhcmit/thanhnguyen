﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThanhNguyen.Model.Models
{
    [Table("Tags")]
    public class Tag
    {
        [Key]
        public string ID { set; get; }
        [Required]
        public string Name { set; get; }
        [Required]
        public string Type { set; get; }
    }
}
