using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Appointment
    {
        [Key]
        public int appoID { get; set; }
        public int doctorID { get; set; }
        public virtual Doctor Doctor { get; set; }
        public int patientID { get; set; }
        public virtual Pati Patient { get; set; }
        [Index(IsUnique =true)]
        public DateTime date { get; set; }
        public string dialog { get; set; }  
        public string notes { get; set; }
        public string analysisReport { get; set; }
        public string diagnosis { get; set; }
        public string medicines { get; set; }
    }
}
