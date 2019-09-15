using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThanhNguyen.Model.Abstract
{
    public abstract class Auditable : IAuditable
    {
       //Nhóm 4
       public DateTime? CreatedDate { set; get; }

        [MaxLength(256)]
       public string CreatedBy { set; get; }

       public DateTime? UpdatedDate { set; get; }

       [MaxLength(256)]
       public string UpdatedBy { set; get; }


        //Nhóm 2
       [MaxLength(256)]
       public string MetaKeyword { set; get; }
       [MaxLength(256)]
       public string MataDescription { set; get; }
       
        //Riêng lẻ
       public bool Status { set; get; }
    }
}
