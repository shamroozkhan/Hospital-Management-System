using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System
{
    public class bill_details
    {
        public int PatientName { get; set; }
        public int DoctorName { get; set; }
        public int ID { get; set; }
        public int DocFees { get; set; }
        public DateTime DateofAppointment { get; set; }
        public DateTime TimeofAppointment { get; set; }
    }
}
