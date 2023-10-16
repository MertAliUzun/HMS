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
    public class SecretaryHandler
    {
        Controller ct = new Controller();
        Repository<Secretary> secRepo = new Repository<Secretary>();
        public List<Secretary> GetAll()
        {
            return secRepo.List();
        }
        public int addSecretary(Secretary c, TextBox age, TextBox phone, TextBox tc)
        {
            if (c.secName.Length <= 3) //Name must be longer
            {
                MessageBox.Show("Secretary Name Must be Longer Than 3 Letters");
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
            return secRepo.Insert(c);  //Inserts value into table

        }
        public int delSecretary(int p)
        {
            if (p != 0)
            {
                Secretary sec = secRepo.Find(x => x.secID == p);        //Gets the whole row to delete
                return secRepo.Delete(sec);                            //Deletes whole row instead of just id
            }
            else
            {
                return -1;
            }
        }
        public int updSecretary(Secretary p, TextBox age, TextBox phone, TextBox tc)
        {
            if (p.secAge.ToString() == "" || p.password == "" || p.secGender == "" || p.secName.Length <= 3)
            {
                MessageBox.Show("You Must Enter All Information");
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
            Secretary sec = secRepo.Find(x => x.secID == p.secID);
            sec.secAge = p.secAge;
            sec.password = p.password;
            sec.secGender = p.secGender;
            sec.secName = p.secName;
            sec.secPhone = p.secPhone;
            sec.secTCNO = p.secTCNO;
            MessageBox.Show("Succesfully Updated");
            return secRepo.Update(sec);

        }
    }
}
