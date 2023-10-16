using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessLayer
{
    public class Controller  //Used for checking textbox restrictions for data entry
    {
        int mailchar, maildot;
        public bool CheckAge(TextBox age)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(age.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                return false;
            }
            return true;
        }

        public bool CheckPhone(TextBox phone)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(phone.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                phone.Text = phone.Text.Remove(phone.Text.Length - 1);
            }
            else
            {
                try
                {
                    if (phone.Text.Length != 11)  //Check for the length requirement
                    {
                        MessageBox.Show("Invalid Phone Number!");
                        phone.Text = "";
                        return false;
                    }
                }
                catch
                {
                    phone.Text = "Enter Phone Number";
                    return false;
                }
            }
            return true;

        }
        public bool CheckTC(TextBox tc)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tc.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                tc.Text = tc.Text.Remove(tc.Text.Length - 1);
            }
            else
            {
                try
                {
                    if (tc.Text.Length != 11)  //Check for the length requirement
                    {
                        MessageBox.Show("Invalid TC No!");
                        tc.Text = "";
                        return false;
                    }
                }
                catch
                {
                    tc.Text = "Enter TC No";
                    return false;
                }
            }
            return true;
        }
        public bool CheckMail(TextBox tBox)
        {

            try
            {
                mailchar = tBox.Text.IndexOf("@", 1);
                if (mailchar > 0)   // If there is @ check for dot
                {
                    maildot = tBox.Text.IndexOf(".", mailchar + 1);
                }
                if (mailchar < 0 || maildot < 0)  //Check If the Mail is correct
                {
                    tBox.Text = "";
                    return false;
                }
                return true;
            }
            catch
            {
                tBox.Text = "Enter Mail !";
                return false;
            }

        }
    }
}
