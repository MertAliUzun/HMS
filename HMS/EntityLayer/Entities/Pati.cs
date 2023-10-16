using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Pati
    {
        [Key]
        public int patientID { get; set; }
        [StringLength(20)]
        public string patientName { get; set; }
        [StringLength(30)]
        public string patientMail { get; set; }
        public string clinic { get; set; }
        [StringLength(8)]
        public string patientGender { get; set; }
        [StringLength(4)]
        public string patientBlood { get; set; }
        public int patientAge { get; set; }
        public string patientPhone { get; set; }
        public string patientTCNO { get; set; }

        public ICollection<Appointment> Appointments { get; set; }

    }
}
