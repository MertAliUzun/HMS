using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Secretary
    {
        [Key]
        public int secID { get; set; }
        
        [StringLength(20)]
        public string secName { get; set; }
        public string secGender { get; set; }
        public int secAge { get; set; }
        [StringLength(11)]
        public string secPhone { get; set; }
        [StringLength(11)]
        public string secTCNO { get; set; }
        [StringLength(4)]
        public string password { get; set; }
    }
}
