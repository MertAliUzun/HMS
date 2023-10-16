using DataAccessLayer;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessLayer
{
    public class LoginHandler
    {
        public static bool isDoctor;
        public static bool  VerifyLogin(string username, string password, Doctor c)
        {
            try
            {
                string sql = @"select * from dbo.Doctors where doctorName = '" + username + "' and password = '" + password + "'";
                DataSet ds = DataAccess.GetDataSet(sql);
                bool succesfulLogin = DataAccess.HasValue(sql);
                if (succesfulLogin)
                {                   
                    c.doctorID = Convert.ToInt32(ds.Tables[0].Rows[0]["doctorID"]);                   
                    isDoctor = true;
                    return true;
                }
                sql = @"select * from dbo.Secretaries where secName = '" + username + "' and password = '" + password + "'";
                ds = DataAccess.GetDataSet(sql);
                succesfulLogin = DataAccess.HasValue(sql);
                if (succesfulLogin)
                {
                    isDoctor = false;
                    return true;
                }
                else
                {
                    return false;
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
