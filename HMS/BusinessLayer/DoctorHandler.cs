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
    public class DoctorHandler
    {
        Controller ct = new Controller();
        Repository<Doctor> docRepo = new Repository<Doctor>();
        public List<Doctor> GetAll()
        {
            return docRepo.List();
        }
        public int addDoctor(Doctor c, TextBox mail, TextBox age, TextBox phone, TextBox tc)
        {
            if (c.doctorName.Length <= 3) //Name must be longer
            {
                MessageBox.Show("Doctor Name Must be Longer Than 3 Letters");
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
            return docRepo.Insert(c);  //Inserts value into table

        }
        public int delDoctor(int p)
        {
            if (p != 0)
            {
                Doctor doc = docRepo.Find(x => x.doctorID == p);        //Gets the whole row to delete
                return docRepo.Delete(doc);                            //Deletes whole row
            }
            else
            {
                return -1;
            }
        }
        public int updDoctor(Doctor p, TextBox mail, TextBox age, TextBox phone, TextBox tc)
        {
            if (p.doctorAge.ToString() == "" || p.password == "" || p.doctorGender == "" || p.doctorMail == "" || p.doctorName.Length <= 3)
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
            Doctor doc = docRepo.Find(x => x.doctorID == p.doctorID);
            doc.doctorMail = p.doctorMail;
            doc.doctorAge = p.doctorAge;
            doc.password = p.password;
            doc.doctorGender = p.doctorGender;
            doc.doctorName = p.doctorName;
            doc.doctorPhone = p.doctorPhone;
            doc.doctorTCNO = p.doctorTCNO;
            MessageBox.Show("Succesfully Updated");
            return docRepo.Update(doc);

        }
        public List<Doctor> GetByClinic(string p)
        {
            return docRepo.List(x => x.clinic == p);
        }
    }
}

