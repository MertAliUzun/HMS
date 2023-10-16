using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Doctor
    {
        [Key]
        public int doctorID { get; set; }

        [StringLength(20)]
        public string doctorName { get; set; }
        public string doctorMail { get; set; }
        public string clinic { get; set; }
        public string doctorGender { get; set; }
        public int doctorAge { get; set; }
        [StringLength(11)]
        public string doctorPhone { get; set; }
        [StringLength(11)]
        public string doctorTCNO { get; set; }
        [StringLength(4)]
        public string password { get; set; }


        public ICollection<Appointment> Appointments { get; set; }

    }
}
