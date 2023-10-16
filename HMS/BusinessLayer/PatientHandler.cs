using DataAccessLayer;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessLayer
{
    public class PatientHandler
    {
        Controller ct = new Controller();
        Repository<Pati> patRepo = new Repository<Pati>();
        public List<Pati> GetAll()
        {
            return patRepo.List();
        }
        public int addPatient(Pati c, TextBox mail, TextBox age, TextBox phone, TextBox tc) 
        {
            if (c.patientName.Length <= 3) //Name must be longer
            {
                MessageBox.Show("Patient Name Must be Longer Than 3 Letters");
                return -1;
            }
            else if (!ct.CheckMail(mail))  //Email requirmenets
            {
                MessageBox.Show("Enter Correct E-Mail");
                return -1;
            }
            else if (!ct.CheckAge(age)) //Age must be numbers only
            {
                MessageBox.Show("Enter Correct Age");
                return -1;
            }
            else if (!ct.CheckPhone(phone)) //Phone must be 11 in length
            {
                MessageBox.Show("Enter Correct Phone");
                return -1;
            }
            else if (!ct.CheckTC(tc)) //TC no must be 11 in length
            {
                MessageBox.Show("Enter Correct TC No");
                return -1;
            }
            MessageBox.Show("Succesfully Added");
            return patRepo.Insert(c);  //Inserts value into table

        }
        public int delPatient(int p)
        {
            if (p != 0)
            {
                Pati pat = patRepo.Find(x => x.patientID == p);        //Gets the whole row to delete
                return patRepo.Delete(pat);                            //Deletes whole row instead of just id
            }
            else
            {
                return -1;
            }
        }
        public int updPatient(Pati p,TextBox mail,TextBox age, TextBox phone, TextBox tc)
        {
            if(p.patientAge.ToString() == ""||p.patientBlood==""||p.patientGender==""||p.patientMail==""||p.patientName.Length <=3)
            {
                MessageBox.Show("You Must Enter All Information");
                return -1;
            }
            else if (!ct.CheckMail(mail))  //Email requirmenets
            {
                MessageBox.Show("Enter Correct E-Mail");
                return -1;
            }
            else if (!ct.CheckAge(age)) //Age must be numbers only
            {
                MessageBox.Show("Enter Correct Age");
                return -1;
            }
            else if (!ct.CheckPhone(phone)) //Phone must be 11 in length
            {
                MessageBox.Show("Enter Correct Phone");
                return -1;
            }
            else if (!ct.CheckTC(tc)) //TC no must be 11 in length
            {
                MessageBox.Show("Enter Correct TC No");
                return -1;
            }
            Pati pat = patRepo.Find(x => x.patientID == p.patientID);
            pat.patientMail = p.patientMail;
            pat.patientAge = p.patientAge;
            pat.patientBlood = p.patientBlood;
            pat.patientGender = p.patientGender;
            pat.patientName = p.patientName;
            pat.patientPhone = p.patientPhone;
            pat.patientTCNO = p.patientTCNO;
            MessageBox.Show("Succesfully Updated");
            return patRepo.Update(pat);

        }
        public List<Pati> GetByAppoID(int p)
        {
            return patRepo.List(x => x.patientID == p);
        }
        public List<Pati> GetOne(int p)
        {
            return patRepo.List(x => x.patientID == p);
        }

    }
}
