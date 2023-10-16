using DataAccessLayer;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessLayer
{
    public class AppointmentHandler
    {
        Repository<Appointment> appoRepo = new Repository<Appointment>();
        public List<Appointment> GetAll()
        {
            return appoRepo.List();
        }
        public int addAppo(Appointment c)
        {
            return appoRepo.Insert(c);
        }
        public DataTable getAbstract()
        {
            string sql = "select appoID, doctorID, patientID, date from dbo.Appointments";
            DataTable appo = DataAccess.GetDataTable(sql);
            return appo;
        }
        public int delAppo(int p)
        {
            if (p != 0)
            {
                Appointment app = appoRepo.Find(x => x.appoID == p);        //Gets the whole row to delete
                return appoRepo.Delete(app);                            //Deletes whole row instead of just id
            }
            else
            {               
                return -1;
            }
        }
        public int updAppo(Appointment p)
        {
            Appointment app = appoRepo.Find(x => x.appoID == p.appoID);
            app.doctorID = p.doctorID;
            app.patientID = p.patientID;
            app.date = p.date;
            MessageBox.Show("Succesfully Updated");
            return appoRepo.Update(app);
        }
        public int endAppo(Appointment p)
        {
            Appointment app = appoRepo.Find(x => x.doctorID == p.doctorID);
            app.dialog = p.dialog;
            app.notes = p.notes;
            app.analysisReport = p.analysisReport;
            app.diagnosis = p.diagnosis;
            app.medicines = p.medicines;
            MessageBox.Show("Succesfully Updated");
            return appoRepo.Update(app);
        }
        public List<Appointment> GetByDoctorID(int p)
        {
            return appoRepo.List(x => x.doctorID == p);
        }
    }
}
